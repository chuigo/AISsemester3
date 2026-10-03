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
            labelCountEyes = new Label();
            labelName = new Label();
            labelHeight = new Label();
            numericUpDownHeight = new NumericUpDown();
            labelChangeMinion = new Label();
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
            // labelSearch
            // 
            labelCountEyes.AutoSize = true;
            labelCountEyes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountEyes.Location = new Point(44, 322);
            labelCountEyes.Margin = new Padding(4, 0, 4, 0);
            labelCountEyes.Name = "labelSearch";
            labelCountEyes.Size = new Size(184, 25);
            labelCountEyes.TabIndex = 17;
            labelCountEyes.Text = "Количество глаз:";
            // 
            // labelGroup
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(44, 222);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelGroup";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 16;
            labelName.Text = "Имя:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHeight.Location = new Point(44, 270);
            labelHeight.Margin = new Padding(4, 0, 4, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(65, 25);
            labelHeight.TabIndex = 15;
            labelHeight.Text = "Рост:";
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
            // labelChangeMinion
            // 
            labelChangeMinion.AutoSize = true;
            labelChangeMinion.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelChangeMinion.Location = new Point(30, 67);
            labelChangeMinion.Margin = new Padding(4, 0, 4, 0);
            labelChangeMinion.Name = "labelChangeMinion";
            labelChangeMinion.Size = new Size(325, 39);
            labelChangeMinion.TabIndex = 13;
            labelChangeMinion.Text = "Изменить миньона";
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
            Controls.Add(labelCountEyes);
            Controls.Add(labelName);
            Controls.Add(labelHeight);
            Controls.Add(numericUpDownHeight);
            Controls.Add(labelChangeMinion);
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
        private System.Windows.Forms.Label labelCountEyes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label labelChangeMinion;
        private System.Windows.Forms.RadioButton radioButtonOneEye;
        private System.Windows.Forms.RadioButton radioButtonTwoEyes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBody;
    }
}