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
    public partial class UpdateMinion : Form
    {
        private readonly Logic _logic;
        private readonly Minion _minion;
        public UpdateMinion(Logic logic, Minion minion)
        {
            InitializeComponent();
            _logic = logic;
            _minion = minion;
            numericUpDownHeight.ValueChanged += (s, e) => UpdateImage();
            radioButtonTwoEyes.CheckedChanged += (s, e) => UpdateImage();
            radioButtonOneEye.CheckedChanged += (s, e) => UpdateImage();
            textBoxName.Text = minion.Name;
            numericUpDownHeight.Value = minion.Height;
            numericUpDownHeight.Maximum = Logic.MaxHeight;
            numericUpDownHeight.Minimum = Logic.MinHeight;
            if (minion.HasTwoEyes)
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
            var bmp = new Bitmap(pictureBoxBody.Width, pictureBoxBody.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                int number = (int)numericUpDownHeight.Value;
                Image body = number < Logic.MiddleHeight ? WinFormsApp1.Properties.Resources.Short
                             : number < Logic.HighHeight ? WinFormsApp1.Properties.Resources.Medium
                             : WinFormsApp1.Properties.Resources.High;
                Image eyes = radioButtonOneEye.Checked ? WinFormsApp1.Properties.Resources.OneEye : WinFormsApp1.Properties.Resources.TwoEyes;
                g.DrawImage(body, 0, 0, bmp.Width, bmp.Height);
                g.DrawImage(eyes, 0, 0, bmp.Width, bmp.Height);
            }
            var old = pictureBoxBody.Image;
            pictureBoxBody.Image = bmp;
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

