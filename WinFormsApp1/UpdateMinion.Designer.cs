namespace WinFormsApp
{
    partial class UpdateMinion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateButton = new Button();
            textBoxName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDownHeight = new NumericUpDown();
            label1 = new Label();
            radioButtonOneEye = new RadioButton();
            radioButtonTwoEyes = new RadioButton();
            panel1 = new Panel();
            pictureBoxBody = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).BeginInit();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.FlatStyle = FlatStyle.System;
            UpdateButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateButton.Location = new Point(145, 633);
            UpdateButton.Margin = new Padding(4, 3, 4, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(153, 52);
            UpdateButton.TabIndex = 20;
            UpdateButton.Text = "Изменить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(158, 215);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 31);
            textBoxName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(44, 322);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 17;
            label4.Text = "Количество глаз:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(44, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 16;
            label3.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(44, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 15;
            label2.Text = "Рост:";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownHeight.Location = new Point(158, 269);
            numericUpDownHeight.Margin = new Padding(4, 3, 4, 3);
            numericUpDownHeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(250, 29);
            numericUpDownHeight.TabIndex = 14;
            numericUpDownHeight.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 39);
            label1.TabIndex = 13;
            label1.Text = "Изменить миньона";
            // 
            // radioButtonOneEye
            // 
            radioButtonOneEye.AutoSize = true;
            radioButtonOneEye.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonOneEye.Location = new Point(22, 17);
            radioButtonOneEye.Margin = new Padding(4, 3, 4, 3);
            radioButtonOneEye.Name = "radioButtonOneEye";
            radioButtonOneEye.Size = new Size(82, 29);
            radioButtonOneEye.TabIndex = 7;
            radioButtonOneEye.TabStop = true;
            radioButtonOneEye.Text = "Один";
            radioButtonOneEye.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwoEyes
            // 
            radioButtonTwoEyes.AutoSize = true;
            radioButtonTwoEyes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonTwoEyes.Location = new Point(125, 17);
            radioButtonTwoEyes.Margin = new Padding(4, 3, 4, 3);
            radioButtonTwoEyes.Name = "radioButtonTwoEyes";
            radioButtonTwoEyes.Size = new Size(69, 29);
            radioButtonTwoEyes.TabIndex = 6;
            radioButtonTwoEyes.TabStop = true;
            radioButtonTwoEyes.Text = "Два";
            radioButtonTwoEyes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonOneEye);
            panel1.Controls.Add(radioButtonTwoEyes);
            panel1.Location = new Point(192, 354);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 66);
            panel1.TabIndex = 18;
            // 
            // pictureBoxBody
            // 
            pictureBoxBody.BackColor = Color.Transparent;
            pictureBoxBody.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxBody.Location = new Point(436, 67);
            pictureBoxBody.Margin = new Padding(4, 3, 4, 3);
            pictureBoxBody.Name = "pictureBoxBody";
            pictureBoxBody.Size = new Size(444, 545);
            pictureBoxBody.TabIndex = 12;
            pictureBoxBody.TabStop = false;
            // 
            // UpdateMinion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 752);
            Controls.Add(UpdateButton);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownHeight);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxBody);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(926, 791);
            MinimumSize = new Size(926, 791);
            Name = "UpdateMinion";
            Text = "UpdateMinion";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonOneEye;
        private System.Windows.Forms.RadioButton radioButtonTwoEyes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBody;
    }
}