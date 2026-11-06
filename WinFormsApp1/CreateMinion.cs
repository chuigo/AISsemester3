    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BuisnessLogic;
using WinFormsApp1;


namespace WinFormsApp
{
    public partial class CreateMinion : Form
    {
        private readonly ILogic _logic;
        private readonly ImageRender _imageRender;
        public CreateMinion(ILogic logic, ImageRender imageRender)
        {
            InitializeComponent();
            _logic = logic;
            _imageRender = imageRender;
            numericUpDownHeight.ValueChanged += (s, e) => UpdateImage();
            radionButtonTwoEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEyes.Checked = true;
            numericUpDownHeight.Maximum = HeightCategories.MaxHeight;
            numericUpDownHeight.Minimum = HeightCategories.MinHeight;
            this.Shown += (s, e) => UpdateImage();
            _imageRender = imageRender;
        }

        /// <summary>
        /// Обновляет изображение на форме
        /// </summary>
        private void UpdateImage()
        {
            var size = pictureBoxBody.Size;
            var image = _imageRender.Render(size, (int)numericUpDownHeight.Value, !radioButtonOneEyes.Checked);
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = image;
            old?.Dispose();
        }

        /// <summary>
        /// Создает миньона
        /// </summary>
        /// <param name="sender">источник события: кнопка создать</param>
        /// <param name="e">аргументы события</param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool twoeyes = !radioButtonOneEyes.Checked;
                _logic.AddMinion(textBoxName.Text.Trim(),(int)numericUpDownHeight.Value, twoeyes);
                MessageBox.Show("Миньон добавлен!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка при добавлении миньона: {ex.Message}"); }
        }
    }
}
