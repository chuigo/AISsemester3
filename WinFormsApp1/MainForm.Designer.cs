namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.GruText = new System.Windows.Forms.Label();
            this.pictureBoxBody = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonReset = new System.Windows.Forms.RadioButton();
            this.radioButtonShort = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewMinions = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.Location = new System.Drawing.Point(583, 166);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(200, 78);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "добавить";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.Location = new System.Drawing.Point(583, 250);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(200, 78);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.Location = new System.Drawing.Point(583, 334);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(200, 78);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "изменить";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // GruText
            // 
            this.GruText.AutoSize = true;
            this.GruText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GruText.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.GruText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GruText.ForeColor = System.Drawing.Color.Black;
            this.GruText.Location = new System.Drawing.Point(237, 18);
            this.GruText.Name = "GruText";
            this.GruText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GruText.Size = new System.Drawing.Size(96, 26);
            this.GruText.TabIndex = 3;
            this.GruText.Text = "Миньоны";
            this.GruText.UseWaitCursor = true;
            // 
            // pictureBoxBody
            // 
            this.pictureBoxBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBody.Location = new System.Drawing.Point(268, 162);
            this.pictureBoxBody.Name = "pictureBoxBody";
            this.pictureBoxBody.Size = new System.Drawing.Size(176, 250);
            this.pictureBoxBody.TabIndex = 4;
            this.pictureBoxBody.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(580, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сгруппировать по росту:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonReset);
            this.panel1.Controls.Add(this.radioButtonShort);
            this.panel1.Controls.Add(this.radioButtonMedium);
            this.panel1.Controls.Add(this.radioButtonHigh);
            this.panel1.Location = new System.Drawing.Point(583, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 159);
            this.panel1.TabIndex = 18;
            // 
            // radioButtonReset
            // 
            this.radioButtonReset.AutoSize = true;
            this.radioButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonReset.Location = new System.Drawing.Point(7, 84);
            this.radioButtonReset.Name = "radioButtonReset";
            this.radioButtonReset.Size = new System.Drawing.Size(71, 22);
            this.radioButtonReset.TabIndex = 3;
            this.radioButtonReset.TabStop = true;
            this.radioButtonReset.Text = "Сброс";
            this.radioButtonReset.UseVisualStyleBackColor = true;
            // 
            // radioButtonShort
            // 
            this.radioButtonShort.AutoSize = true;
            this.radioButtonShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonShort.Location = new System.Drawing.Point(7, 55);
            this.radioButtonShort.Name = "radioButtonShort";
            this.radioButtonShort.Size = new System.Drawing.Size(77, 22);
            this.radioButtonShort.TabIndex = 2;
            this.radioButtonShort.TabStop = true;
            this.radioButtonShort.Text = "Низкий";
            this.radioButtonShort.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 27);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(86, 22);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Средний";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHigh.Location = new System.Drawing.Point(7, 3);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(88, 22);
            this.radioButtonHigh.TabIndex = 0;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "Высокий";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(246, 180);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 18);
            this.labelName.TabIndex = 19;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "выбранный миньон:";
            // 
            // listViewMinions
            // 
            this.listViewMinions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMinions.HideSelection = false;
            this.listViewMinions.Location = new System.Drawing.Point(12, 415);
            this.listViewMinions.Name = "listViewMinions";
            this.listViewMinions.Size = new System.Drawing.Size(558, 322);
            this.listViewMinions.TabIndex = 21;
            this.listViewMinions.UseCompatibleStateImageBehavior = false;
            this.listViewMinions.SelectedIndexChanged += new System.EventHandler(this.ListViewMinions_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(580, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Поиск по имени:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 686);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetSearch.Location = new System.Drawing.Point(606, 714);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(154, 23);
            this.buttonResetSearch.TabIndex = 26;
            this.buttonResetSearch.Text = "очистить поиск";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.ButtonResetSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.gru;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 382);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonResetSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewMinions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxBody);
            this.Controls.Add(this.GruText);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBody)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label GruText;
        private System.Windows.Forms.PictureBox pictureBoxBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonShort;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewMinions;
        private System.Windows.Forms.RadioButton radioButtonReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

