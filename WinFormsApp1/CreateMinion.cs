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

namespace WinFormsApp
{
    public partial class CreateMinion : Form
    {
        private readonly Logic _logic;
        public CreateMinion(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
            numericUpDownHeight.ValueChanged += (s, e) => UpdateImage();
            radionButtonTwoEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEyes.Checked = true;
            numericUpDownHeight.Maximum = Logic.MaxHeight;
            numericUpDownHeight.Minimum = Logic.MinHeight;
            this.Shown += (s, e) => UpdateImage();

        }

        /// <summary>
        /// Обновляет изображение на форме
        /// </summary>
        private void UpdateImage()
        {
            var bmp = new Bitmap(pictureBoxBody.Width, pictureBoxBody.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                int number = (int)numericUpDownHeight.Value;
                Image body = number < 120 ? WinFormsApp1.Properties.Resources.Short
                             : number < 170 ? WinFormsApp1.Properties.Resources.Medium
                             : WinFormsApp1.Properties.Resources.High;
                Image eyes = radioButtonOneEyes.Checked ? WinFormsApp1.Properties.Resources.OneEye : WinFormsApp1.Properties.Resources.TwoEyes;
                g.DrawImage(body, 0, 0, bmp.Width, bmp.Height);
                g.DrawImage(eyes, 0, 0, bmp.Width, bmp.Height);
            }
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = bmp;
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
