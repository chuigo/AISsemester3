namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBody = new System.Windows.Forms.PictureBox();
            this.radionButtonTwoEyes = new System.Windows.Forms.RadioButton();
            this.radioButtonOneEyes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить миньона";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHeight.Location = new System.Drawing.Point(121, 187);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(214, 29);
            this.numericUpDownHeight.TabIndex = 3;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя:";
            // 
            // pictureBoxBody
            // 
            this.pictureBoxBody.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxBody.Location = new System.Drawing.Point(360, 12);
            this.pictureBoxBody.Name = "pictureBoxBody";
            this.pictureBoxBody.Size = new System.Drawing.Size(381, 472);
            this.pictureBoxBody.TabIndex = 0;
            this.pictureBoxBody.TabStop = false;
            // 
            // radionButtonTwoEyes
            // 
            this.radionButtonTwoEyes.AutoSize = true;
            this.radionButtonTwoEyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radionButtonTwoEyes.Location = new System.Drawing.Point(107, 15);
            this.radionButtonTwoEyes.Name = "radionButtonTwoEyes";
            this.radionButtonTwoEyes.Size = new System.Drawing.Size(69, 29);
            this.radionButtonTwoEyes.TabIndex = 6;
            this.radionButtonTwoEyes.TabStop = true;
            this.radionButtonTwoEyes.Text = "Два";
            this.radionButtonTwoEyes.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneEyes
            // 
            this.radioButtonOneEyes.AutoSize = true;
            this.radioButtonOneEyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOneEyes.Location = new System.Drawing.Point(19, 15);
            this.radioButtonOneEyes.Name = "radioButtonOneEyes";
            this.radioButtonOneEyes.Size = new System.Drawing.Size(82, 29);
            this.radioButtonOneEyes.TabIndex = 7;
            this.radioButtonOneEyes.TabStop = true;
            this.radioButtonOneEyes.Text = "Один";
            this.radioButtonOneEyes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество глаз:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOneEyes);
            this.panel1.Controls.Add(this.radionButtonTwoEyes);
            this.panel1.Location = new System.Drawing.Point(151, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 57);
            this.panel1.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(121, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 31);
            this.textBoxName.TabIndex = 10;
            // 
            // CreateButton
            // 
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(110, 503);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(131, 45);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateMinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 609);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBody);
            this.MaximumSize = new System.Drawing.Size(769, 648);
            this.MinimumSize = new System.Drawing.Size(769, 648);
            this.Name = "CreateMinion";
            this.Text = "CreateMinion";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radionButtonTwoEyes;
        private System.Windows.Forms.RadioButton radioButtonOneEyes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button CreateButton;
    }
}