using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Model;
using BuisnessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WinFormsApp1;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly ILogic _logic;
        private GameSession _gameSession;
        private readonly ImageRender _imageRender;
        private readonly Random _random = new Random();
        public MainForm(ILogic logic)
        {
            _logic = logic;
            var selector = new ImageSelector();
            _imageRender = new ImageRender(selector);
            InitializeComponent();
            InitializeListViewMinions();
            RefreshMinionsList(_logic.GetALlMinions());
            radioButtonHigh.CheckedChanged += CheckedChangedGrouping;
            radioButtonMedium.CheckedChanged += CheckedChangedGrouping;
            radioButtonShort.CheckedChanged += CheckedChangedGrouping;
            radioButtonReset.CheckedChanged += CheckedChangedGrouping;
            radioButtonReset.Checked = true;
            GruText.Text = "Привет! Можешь помочь с учетом всех моих миньонов?\nА то я уже со счету сбился, их так много!" +
                "\nЕсли готов, нажми кнопку <НАЧАТЬ>";
            ButtonCreate.Visible = false;
            ButtonUpdate.Visible = false;
            ButtonDelete.Visible = false;
            buttonSend.Visible = false;
            this.FormClosed += MainForm_FormClosed;
        }
        /// <summary>
        /// Обновляет ui в зависимости от текущего состояния игры 
        /// </summary>
        private void UpdateUITask()
        {
            GruText.Text = _gameSession.GruText;
            if (_gameSession.CurrentTask == GameTasks.Send)
            {
                buttonSend.Visible = true;
            }
        }

        /// <summary>
        /// Изменяет вывведенный список в зависимости от выбранной кнопки
        /// </summary>
        /// <param name="sender">источник события: radiobutton</param>
        /// <param name="e">аргументы события</param>
        private void CheckedChangedGrouping(object sender, EventArgs e)
        {
            if (sender == radioButtonShort)
            {
                RefreshMinionsList(_logic.GroupByHeight().TryGetValue("Низкий", out var list) ? list.ToList() : new List<Minion>());
            }
            else if (sender == radioButtonMedium)
            {
                RefreshMinionsList(_logic.GroupByHeight().TryGetValue("Средний", out var list) ? list.ToList() : new List<Minion>());
            }
            else if (sender == radioButtonHigh)
            {
                RefreshMinionsList(_logic.GroupByHeight().TryGetValue("Высокий", out var list) ? list.ToList() : new List<Minion>());
            }
            else
            {
                RefreshMinionsList(_logic.GetALlMinions());
            }
        }

        /// <summary>
        /// Открывает форму с созданием миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка создать</param>
        /// <param name="e">аргументы события</param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (_gameSession.ImposterExist())
            {
                MessageBox.Show("Сначала удалите предателя");
                return;
            }
            var createMinion = new CreateMinion(_logic, _imageRender);
            createMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBoxName.Text = "";
            radioButtonReset.Checked = true;
            _gameSession.CompleteCreate();
        }

        /// <summary>
        /// Открывает форму с обновлением данных миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка изменить</param>
        /// <param name="e">аргументы события</param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (_gameSession.ImposterExist())
            {
                MessageBox.Show("Сначала удалите предателя");
                return;
            }
            if (listViewMinions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите миньона из списка");
                return;
            }
            int id = (int)listViewMinions.SelectedItems[0].Tag;
            var updateMinion = new UpdateMinion(_logic, id, _imageRender);
            updateMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBoxName.Text = "";
            radioButtonReset.Checked = true;
            _gameSession.CompleteUpdate(id);
        }

        /// <summary>
        /// Удаляет выбранного миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка удалить</param>
        /// <param name="e">агрументы события</param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewMinions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите миньона из списка");
                return;
            }
            int id = (int)listViewMinions.SelectedItems[0].Tag;
            if (!_gameSession.CanDelete(id))
            {
                MessageBox.Show("Выбранного миньона пока нельзя удалить");
                return;
            }
            _logic.RemoveMinion(id);
            MessageBox.Show("Миньон удален!");
            if (_logic.GetALlMinions().Count == 0)
            {
                ClearPictureBox();
            }
            RefreshMinionsList(_logic.GetALlMinions());
            radioButtonReset.Checked = true;
            _gameSession.CompleteImposter(id);
        }

        /// <summary>
        /// Удаляет изображение на форме
        /// </summary>
        private void ClearPictureBox()
        {
            var picture = pictureBoxBody.Image;
            pictureBoxBody.Image = null;
            picture?.Dispose();
            labelName.Text = "";
        }

        /// <summary>
        /// Создает отображение списка на форме
        /// </summary>
        private void InitializeListViewMinions()
        {
            listViewMinions.MultiSelect = false;
            listViewMinions.View = View.Details;
            listViewMinions.FullRowSelect = true;
            listViewMinions.GridLines = true;
            listViewMinions.Columns.Clear();
            listViewMinions.Columns.Add("ID", 60);
            listViewMinions.Columns.Add("Имя", 90);
            listViewMinions.Columns.Add("Рост", 60);
            listViewMinions.Columns.Add("Количество глаз", 150);
        }

        /// <summary>
        /// Обновляет список на форме
        /// </summary>
        /// <param name="minions">список миньнов</param>
        private void RefreshMinionsList(List<Minion> minions)
        {
            listViewMinions.Items.Clear();
            foreach (var minion in minions)
            {
                var item = new ListViewItem(minion.ID.ToString())
                {
                    Tag = minion.ID
                };
                item.SubItems.Add(minion.Name);
                item.SubItems.Add(minion.Height.ToString());
                int eyes = minion.HasTwoEyes ? 2 : 1;
                item.SubItems.Add(eyes.ToString());
                listViewMinions.Items.Add(item);
            }
            ClearPictureBox();
        }

        /// <summary>
        /// Изменяет изображение в зависимости от выбранного элемента списка
        /// </summary>
        /// <param name="sender">источник события listview</param>
        /// <param name="e">аргументы события</param>
        private void ListViewMinions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMinions.SelectedItems.Count == 0)
            {
                ClearPictureBox();
                return;
            }
            var minion = _logic.GetMinionByID((int)listViewMinions.SelectedItems[0].Tag);
            var size = pictureBoxBody.Size;
            var image = _imageRender.Render(size, minion.Height, minion.HasTwoEyes, _gameSession.ImposterID == minion.ID);
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = image;
            old?.Dispose();
            labelName.Text = minion.Name;
        }

        /// <summary>
        /// Очищает поле поиска по имени
        /// </summary>
        /// <param name="sender">источник события кнопка сброса</param>
        /// <param name="e">аргументы события</param>
        private void ButtonResetSearch_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            RefreshMinionsList(_logic.GetALlMinions());
        }

        /// <summary>
        /// Обновляет список при изменении значения в поиске
        /// </summary>
        /// <param name="sender">источник события textbox</param>
        /// <param name="e">аргументы события</param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshMinionsList(_logic.SearchByName(textBoxName.Text));
        }

        /// <summary>
        /// Создает задание и начинает игру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            ButtonCreate.Visible = true;
            ButtonDelete.Visible = true;
            ButtonUpdate.Visible = true;
            _gameSession = new GameSession(_logic);
            _gameSession.TaskChanged += UpdateUITask;
            UpdateUITask();
        }


        /// <summary>
        /// Отправляет миньона на задание и удаляет его из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (listViewMinions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите миньона из списка");
                return;
            }

            string selectedCategory = null;
            if (radioButtonHigh.Checked) selectedCategory = "Высокий";
            else if (radioButtonMedium.Checked) selectedCategory = "Средний";
            else if (radioButtonShort.Checked) selectedCategory = "Низкий";
            if (selectedCategory == null  || !_gameSession.CanSend(selectedCategory))
            {
                MessageBox.Show("Не выбрана нужная группировка");
                return;
            }
            try
            {
                int id = (int)listViewMinions.SelectedItems[0].Tag;
                _logic.RemoveMinion(id);
                _gameSession.CompleteSend();
                buttonSend.Visible = false;
                RefreshMinionsList(_logic.GetALlMinions());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_gameSession != null)
            {
                _gameSession.TaskChanged -= UpdateUITask;
            }
        }
    }
}
