using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLogic;
using Model;
using WinFormsApp1;

namespace WinFormsApp
{
    public partial class UpdateMinion : Form
    {
        private readonly Logic _logic;
        private readonly Minion _minion;
        private readonly ImageRender _imageRender;
        public UpdateMinion(Logic logic, int id, ImageRender imageRender)
        {
            InitializeComponent();
            _logic = logic;
            _imageRender = imageRender;
            _minion = _logic.GetMinionByID(id);
            numericUpDownHeight.ValueChanged += (s, e) => UpdateImage();
            radioButtonTwoEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEye.CheckedChanged += (s, e) => UpdateImage();
            textBoxName.Text = _minion.Name;
            numericUpDownHeight.Value = _minion.Height;
            numericUpDownHeight.Maximum = HeightCategories.MaxHeight;
            numericUpDownHeight.Minimum = HeightCategories.MinHeight;
            if (_minion.HasTwoEyes)
            {
                radioButtonTwoEyes.Checked = true;
            }
            else
            {
                radioButtonOneEye.Checked = true;
            }
                this.Shown += (s, e) => UpdateImage();

        }
        /// <summary>
        /// Обновляет изображение на форме
        /// </summary>
        private void UpdateImage()
        {
            var size = pictureBoxBody.Size;
            var image = _imageRender.Render(size, (int)numericUpDownHeight.Value, !radioButtonOneEye.Checked);
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = image;
            old?.Dispose();
        }
        /// <summary>
        /// Изменяет параметры миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка изменить</param>
        /// <param name="e">аргументы события</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool twoeyes = !radioButtonOneEye.Checked;
                _logic.UpdateMinion(_minion.ID, textBoxName.Text.Trim(), (int)numericUpDownHeight.Value, twoeyes);
                MessageBox.Show("Миньон изменен!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка при изменении миньона: {ex.Message}"); }
        }

    }


}

