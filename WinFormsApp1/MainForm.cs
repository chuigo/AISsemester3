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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp
{
    public enum GameTasks { FindImposter, Send, UpdateMinion, CreateNew }
    public partial class MainForm : Form
    {
        private readonly Logic _logic = new Logic();
        private GameTasks _gameTasks;
        private readonly Random _random = new Random();

        private int? _countMinions;
        private int? _imposterid;
        private string? _keyHeight;
        private int? _updateid;

        public MainForm()
        {
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
            if (_imposterid != null)
            {
                MessageBox.Show("Сначала удалите предателя");
                return;
            }
            var createMinion = new CreateMinion(_logic);
            createMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBoxName.Text = "";
            radioButtonReset.Checked = true;
            if (_countMinions.HasValue && _countMinions.Value <= _logic.GetALlMinions().Count)
            {
                _countMinions = null;
                Tasks();
            }
        }

        /// <summary>
        /// Открывает форму с обновлением данных миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка изменить</param>
        /// <param name="e">аргументы события</param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (_imposterid != null)
            {
                MessageBox.Show("Сначала удалите предателя");
                return;
            }
            if (listViewMinions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите миньона из списка");
                return;
            }
            int updateMinionId = (int)listViewMinions.SelectedItems[0].Tag;
            var minion = _logic.GetMinionByID(updateMinionId);
            var updateMinion = new UpdateMinion(_logic, minion);
            updateMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBoxName.Text = "";
            radioButtonReset.Checked = true;
            if (_updateid!= null && _updateid == updateMinionId)
            {
                _updateid = null;
                Tasks();
            }
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
            if ((int)listViewMinions.SelectedItems[0].Tag == _updateid)
            {
                MessageBox.Show("Выбранного миньона пока нельзя удалить");
                return;
            }
            _logic.RemoveMinion((int)listViewMinions.SelectedItems[0].Tag);
            MessageBox.Show("Миньон удален!");
            if (_logic.GetALlMinions().Count == 0)
            {
                ClearPictureBox();
            }
            RefreshMinionsList(_logic.GetALlMinions());
            radioButtonReset.Checked = true;
            if (_imposterid != null)
            {
                bool exists;
                try
                {
                    exists = _logic.GetMinionByID(_imposterid.Value) != null;
                }
                catch (ArgumentException)
                {
                    exists = false;
                }

                if (!exists)
                {
                    _imposterid = null;
                    Tasks();
                }
            }
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
            var bmp = new Bitmap(pictureBoxBody.Width, pictureBoxBody.Height);
            if (_imposterid != null && minion == _logic.GetMinionByID(_imposterid.Value))
            {
                using (var g = Graphics.FromImage(bmp))
                {
                    Image imposter = WinFormsApp1.Properties.Resources.imposter;
                    g.DrawImage(imposter, 0, 0, bmp.Width, bmp.Height);
                }

                pictureBoxBody.Image = bmp;
                labelName.Text = minion.Name;
                return;
            }
            using (var g = Graphics.FromImage(bmp))
            {
                Image body = minion.Height < Logic.MiddleHeight ? WinFormsApp1.Properties.Resources.Short
                             : minion.Height < Logic.HighHeight ? WinFormsApp1.Properties.Resources.Medium
                             : WinFormsApp1.Properties.Resources.High;
                Image eyes = minion.HasTwoEyes ? WinFormsApp1.Properties.Resources.TwoEyes : WinFormsApp1.Properties.Resources.OneEye;
                g.DrawImage(body, 0, 0, bmp.Width, bmp.Height);
                g.DrawImage(eyes, 0, 0, bmp.Width, bmp.Height);
            }
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = bmp;
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
            _gameTasks = GameTasks.CreateNew;
            CreateTask();
        }

        /// <summary>
        /// Случайно вызывает задание
        /// </summary>
        private void Tasks()
        {
            var tasks = new[] { GameTasks.CreateNew, GameTasks.UpdateMinion, GameTasks.FindImposter, GameTasks.Send };
            _gameTasks = tasks[_random.Next(tasks.Length)];
            switch (_gameTasks)
            {
                case GameTasks.CreateNew: CreateTask(); break;
                case GameTasks.Send: SendTask(); break;
                case GameTasks.FindImposter: FindImposterTask(); break;
                case GameTasks.UpdateMinion: UpdateTask(); break;
            }
        }
        /// <summary>
        /// Выводит информацию о задании по созданию миньона
        /// </summary>
        private void CreateTask()
        {
            int needToCreate = _random.Next(1, 5);
            GruText.Text = $"Для учета требуется добавить {needToCreate} миньонов";
            _countMinions = _logic.GetALlMinions().Count + needToCreate;
        }
        /// <summary>
        /// Выводит информацию о задании по отправлению миньона с выбранным ростом
        /// </summary>
        private void SendTask()
        {
            buttonSend.Visible = true;
            List<string> height = _logic.GroupByHeight().Keys.ToList();
            _keyHeight = height.ElementAt(_random.Next(height.Count));
            GruText.Text = $"Мне тут нужен {_keyHeight} миньон\nВоспользуйся группировкой по росту и найди мне такого\nНу или для начала создай его";
        }
        /// <summary>
        /// Выводит информацию о задании по нахождению предателя
        /// </summary>
        private void FindImposterTask()
        {
            if (_logic.GetALlMinions().Count != 0 )
            {
                var imposter = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                _imposterid = imposter.ID;
                GruText.Text = $"Я тут узнал, что среди миньонов есть один предатель.\nЭто {imposter}\nСрочно удали его!";
                return;
            }
            Tasks();
        }
        /// <summary>
        /// Выводит информацию о задании по изменению миньона
        /// </summary>
        private void UpdateTask()
        {
            if (_logic.GetALlMinions().Count != 0)
            {
                var updateminion = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                _updateid = updateminion.ID;
                GruText.Text = $"Слушай, {updateminion}\nявно неправильно занесен в список.Попробуй изменить его данные";
                return;
            }
            Tasks();
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
            if ((_keyHeight == radioButtonHigh.Text && radioButtonHigh.Checked) || (_keyHeight == radioButtonMedium.Text && radioButtonMedium.Checked) || (_keyHeight == radioButtonShort.Text && radioButtonShort.Checked))
            {
                _logic.RemoveMinion((int)listViewMinions.SelectedItems[0].Tag);
                buttonSend.Visible = false;
                Tasks();
                RefreshMinionsList(_logic.GetALlMinions());

            }
            else
            {
                MessageBox.Show("Не выбрана нужная группировка");
            }
        }
    }
}
