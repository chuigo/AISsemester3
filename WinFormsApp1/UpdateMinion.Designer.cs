namespace WindowsFormsApp
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonOneEye = new System.Windows.Forms.RadioButton();
            this.radioButtonTwoEyes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBody = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(124, 549);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(131, 45);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(135, 186);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 31);
            this.textBoxName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество глаз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Рост:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHeight.Location = new System.Drawing.Point(135, 233);
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
            this.numericUpDownHeight.TabIndex = 14;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Изменить миньона";
            // 
            // radioButtonOneEyes
            // 
            this.radioButtonOneEye.AutoSize = true;
            this.radioButtonOneEye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOneEye.Location = new System.Drawing.Point(19, 15);
            this.radioButtonOneEye.Name = "radioButtonOneEyes";
            this.radioButtonOneEye.Size = new System.Drawing.Size(82, 29);
            this.radioButtonOneEye.TabIndex = 7;
            this.radioButtonOneEye.TabStop = true;
            this.radioButtonOneEye.Text = "Один";
            this.radioButtonOneEye.UseVisualStyleBackColor = true;
            // 
            // radionButtonTwoEyes
            // 
            this.radioButtonTwoEyes.AutoSize = true;
            this.radioButtonTwoEyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTwoEyes.Location = new System.Drawing.Point(107, 15);
            this.radioButtonTwoEyes.Name = "radionButtonTwoEyes";
            this.radioButtonTwoEyes.Size = new System.Drawing.Size(69, 29);
            this.radioButtonTwoEyes.TabIndex = 6;
            this.radioButtonTwoEyes.TabStop = true;
            this.radioButtonTwoEyes.Text = "Два";
            this.radioButtonTwoEyes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOneEye);
            this.panel1.Controls.Add(this.radioButtonTwoEyes);
            this.panel1.Location = new System.Drawing.Point(165, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 57);
            this.panel1.TabIndex = 18;
            // 
            // pictureBoxBody
            // 
            this.pictureBoxBody.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxBody.Location = new System.Drawing.Point(374, 58);
            this.pictureBoxBody.Name = "pictureBoxBody";
            this.pictureBoxBody.Size = new System.Drawing.Size(381, 472);
            this.pictureBoxBody.TabIndex = 12;
            this.pictureBoxBody.TabStop = false;
            // 
            // UpdateMinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 652);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBody);
            this.MaximumSize = new System.Drawing.Size(796, 691);
            this.MinimumSize = new System.Drawing.Size(796, 691);
            this.Name = "UpdateMinion";
            this.Text = "UpdateMinion";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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