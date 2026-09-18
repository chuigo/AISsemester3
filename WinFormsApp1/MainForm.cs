using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private readonly Logic _logic = new Logic();

        public MainForm()
        {
            InitializeComponent();
            InitializeListViewMinions();
            _logic.CreateStarterMinions();
            RefreshMinionsList(_logic.GetALlMinions());
            radioButtonHigh.CheckedChanged += CheckedChangedGrouping;
            radioButtonMedium.CheckedChanged += CheckedChangedGrouping;
            radioButtonShort.CheckedChanged += CheckedChangedGrouping;
            radioButtonReset.CheckedChanged += CheckedChangedGrouping;
            ButtonCreate.Visible = false;
            ButtonDelete.Visible = false;
            GruText.Text = "Привет, слушай, мне тут нужна помощь в учете миньонов.\nДавай посмотрим, годишься ли ты на эту работу.\n" +
                "Я тут уже заполнил информацию о нескольких, но совсем\n позабыл, что Джеймс то у нас одноглазый.\n" +
                "Попробуй изменить миньона.";
        }

        private void TaskTwo()
        {

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
                RefreshMinionsList(_logic.GroupByHeight().TryGetValue("Низкий", out var list) ? list.ToList():new List<Minion>());
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

            var createMinion = new CreateMinion(_logic);
            createMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBox1.Text = "";
        }

        /// <summary>
        /// Открывает форму с обновлением данных миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка изменить</param>
        /// <param name="e">аргументы события</param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewMinions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите миньона из списка");
                return;
            }
            var minion = _logic.GetMinionByID((int)listViewMinions.SelectedItems[0].Tag);
            var updateMinion = new UpdateMinion(_logic, minion);
            updateMinion.ShowDialog();
            RefreshMinionsList(_logic.GetALlMinions());
            textBox1.Text = "";
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
            _logic.RemoveMinion((int)listViewMinions.SelectedItems[0].Tag);
            MessageBox.Show("Миньон удален!");
            if (_logic.GetALlMinions().Count == 0)
            {
                ClearPictureBox();
            }
            RefreshMinionsList(_logic.GetALlMinions());
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
            using (var g = Graphics.FromImage(bmp))
            {
                Image body = minion.Height < 120 ? Properties.Resources.Short
                             : minion.Height < 170 ? Properties.Resources.Medium
                             : Properties.Resources.High;
                Image eyes = minion.HasTwoEyes ? Properties.Resources.TwoEyes : Properties.Resources.OneEye;
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
            textBox1.Text = "";
            RefreshMinionsList(_logic.GetALlMinions());
        }

        /// <summary>
        /// Обновляет список при изменении значения в поиске
        /// </summary>
        /// <param name="sender">источник события textbox</param>
        /// <param name="e">аргументы события</param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshMinionsList(_logic.SearchByName(textBox1.Text));
        }
    }
}
