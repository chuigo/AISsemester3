namespace WinFormsApp
{
    partial class CreateMinion
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
            labelAdd = new Label();
            numericUpDownHeight = new NumericUpDown();
            labelHeight = new Label();
            labelName = new Label();
            pictureBoxBody = new PictureBox();
            radionButtonTwoEyes = new RadioButton();
            radioButtonOneEyes = new RadioButton();
            label4 = new Label();
            panel1 = new Panel();
            textBoxName = new TextBox();
            CreateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelChangeMinion
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAdd.Location = new Point(14, 14);
            labelAdd.Margin = new Padding(4, 0, 4, 0);
            labelAdd.Name = "labelChangeMinion";
            labelAdd.Size = new Size(323, 39);
            labelAdd.TabIndex = 2;
            labelAdd.Text = "Добавить миньона";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownHeight.Location = new Point(141, 216);
            numericUpDownHeight.Margin = new Padding(4, 3, 4, 3);
            numericUpDownHeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(250, 29);
            numericUpDownHeight.TabIndex = 3;
            numericUpDownHeight.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHeight.Location = new Point(28, 217);
            labelHeight.Margin = new Padding(4, 0, 4, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(65, 25);
            labelHeight.TabIndex = 4;
            labelHeight.Text = "Рост:";
            // 
            // labelGroup
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(28, 168);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelGroup";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 5;
            labelName.Text = "Имя:";
            // 
            // pictureBoxBody
            // 
            pictureBoxBody.BackColor = Color.Transparent;
            pictureBoxBody.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxBody.Location = new Point(420, 14);
            pictureBoxBody.Margin = new Padding(4, 3, 4, 3);
            pictureBoxBody.Name = "pictureBoxBody";
            pictureBoxBody.Size = new Size(444, 545);
            pictureBoxBody.TabIndex = 0;
            pictureBoxBody.TabStop = false;
            // 
            // radionButtonTwoEyes
            // 
            radionButtonTwoEyes.AutoSize = true;
            radionButtonTwoEyes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radionButtonTwoEyes.Location = new Point(125, 17);
            radionButtonTwoEyes.Margin = new Padding(4, 3, 4, 3);
            radionButtonTwoEyes.Name = "radionButtonTwoEyes";
            radionButtonTwoEyes.Size = new Size(69, 29);
            radionButtonTwoEyes.TabIndex = 6;
            radionButtonTwoEyes.TabStop = true;
            radionButtonTwoEyes.Text = "Два";
            radionButtonTwoEyes.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneEyes
            // 
            radioButtonOneEyes.AutoSize = true;
            radioButtonOneEyes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonOneEyes.Location = new Point(22, 17);
            radioButtonOneEyes.Margin = new Padding(4, 3, 4, 3);
            radioButtonOneEyes.Name = "radioButtonOneEyes";
            radioButtonOneEyes.Size = new Size(82, 29);
            radioButtonOneEyes.TabIndex = 7;
            radioButtonOneEyes.TabStop = true;
            radioButtonOneEyes.Text = "Один";
            radioButtonOneEyes.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(28, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "labelSearch";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 8;
            label4.Text = "Количество глаз:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonOneEyes);
            panel1.Controls.Add(radionButtonTwoEyes);
            panel1.Location = new Point(176, 301);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 66);
            panel1.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(141, 162);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 31);
            textBoxName.TabIndex = 10;
            // 
            // CreateButton
            // 
            CreateButton.FlatStyle = FlatStyle.System;
            CreateButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateButton.Location = new Point(128, 580);
            CreateButton.Margin = new Padding(4, 3, 4, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(153, 52);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateMinion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 703);
            Controls.Add(CreateButton);
            Controls.Add(textBoxName);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(labelName);
            Controls.Add(labelHeight);
            Controls.Add(numericUpDownHeight);
            Controls.Add(labelAdd);
            Controls.Add(pictureBoxBody);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(894, 742);
            MinimumSize = new Size(894, 742);
            Name = "CreateMinion";
            Text = "CreateMinion";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBody;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radionButtonTwoEyes;
        private System.Windows.Forms.RadioButton radioButtonOneEyes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button CreateButton;
    }
}