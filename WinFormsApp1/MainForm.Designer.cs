namespace WinFormsApp
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
            ButtonCreate = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            GruText = new Label();
            pictureBoxBody = new PictureBox();
            labelGroup = new Label();
            panel1 = new Panel();
            radioButtonReset = new RadioButton();
            radioButtonShort = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonHigh = new RadioButton();
            labelName = new Label();
            labelOption = new Label();
            listViewMinions = new ListView();
            labelSearch = new Label();
            textBoxName = new TextBox();
            buttonResetSearch = new Button();
            pictureBox1 = new PictureBox();
            buttonStart = new Button();
            buttonSend = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCreate
            // 
            ButtonCreate.FlatStyle = FlatStyle.System;
            ButtonCreate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonCreate.Location = new Point(680, 192);
            ButtonCreate.Margin = new Padding(4, 3, 4, 3);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(233, 90);
            ButtonCreate.TabIndex = 0;
            ButtonCreate.Text = "добавить";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.FlatStyle = FlatStyle.System;
            ButtonDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonDelete.Location = new Point(680, 288);
            ButtonDelete.Margin = new Padding(4, 3, 4, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(233, 90);
            ButtonDelete.TabIndex = 1;
            ButtonDelete.Text = "удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.LightSkyBlue;
            ButtonUpdate.FlatStyle = FlatStyle.System;
            ButtonUpdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonUpdate.Location = new Point(680, 385);
            ButtonUpdate.Margin = new Padding(4, 3, 4, 3);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(233, 90);
            ButtonUpdate.TabIndex = 2;
            ButtonUpdate.Text = "изменить";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // GruText
            // 
            GruText.AutoSize = true;
            GruText.BorderStyle = BorderStyle.Fixed3D;
            GruText.Cursor = Cursors.WaitCursor;
            GruText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GruText.ForeColor = Color.Black;
            GruText.Location = new Point(276, 21);
            GruText.Margin = new Padding(4, 0, 4, 0);
            GruText.Name = "GruText";
            GruText.RightToLeft = RightToLeft.No;
            GruText.Size = new Size(96, 26);
            GruText.TabIndex = 3;
            GruText.Text = "Миньоны";
            GruText.UseWaitCursor = true;
            // 
            // pictureBoxBody
            // 
            pictureBoxBody.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxBody.Location = new Point(313, 187);
            pictureBoxBody.Margin = new Padding(4, 3, 4, 3);
            pictureBoxBody.Name = "pictureBoxBody";
            pictureBoxBody.Size = new Size(205, 288);
            pictureBoxBody.TabIndex = 4;
            pictureBoxBody.TabStop = false;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup.Location = new Point(677, 541);
            labelGroup.Margin = new Padding(4, 0, 4, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(180, 18);
            labelGroup.TabIndex = 17;
            labelGroup.Text = "Сгруппировать по росту:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonReset);
            panel1.Controls.Add(radioButtonShort);
            panel1.Controls.Add(radioButtonMedium);
            panel1.Controls.Add(radioButtonHigh);
            panel1.Location = new Point(680, 565);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 183);
            panel1.TabIndex = 18;
            // 
            // radioButtonReset
            // 
            radioButtonReset.AutoSize = true;
            radioButtonReset.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonReset.Location = new Point(8, 97);
            radioButtonReset.Margin = new Padding(4, 3, 4, 3);
            radioButtonReset.Name = "radioButtonReset";
            radioButtonReset.Size = new Size(71, 22);
            radioButtonReset.TabIndex = 3;
            radioButtonReset.TabStop = true;
            radioButtonReset.Text = "Сброс";
            radioButtonReset.UseVisualStyleBackColor = true;
            // 
            // radioButtonShort
            // 
            radioButtonShort.AutoSize = true;
            radioButtonShort.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonShort.Location = new Point(8, 63);
            radioButtonShort.Margin = new Padding(4, 3, 4, 3);
            radioButtonShort.Name = "radioButtonShort";
            radioButtonShort.Size = new Size(77, 22);
            radioButtonShort.TabIndex = 2;
            radioButtonShort.TabStop = true;
            radioButtonShort.Text = "Низкий";
            radioButtonShort.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonMedium.Location = new Point(8, 31);
            radioButtonMedium.Margin = new Padding(4, 3, 4, 3);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(86, 22);
            radioButtonMedium.TabIndex = 1;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Средний";
            radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            radioButtonHigh.AutoSize = true;
            radioButtonHigh.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonHigh.Location = new Point(8, 3);
            radioButtonHigh.Margin = new Padding(4, 3, 4, 3);
            radioButtonHigh.Name = "radioButtonHigh";
            radioButtonHigh.Size = new Size(88, 22);
            radioButtonHigh.TabIndex = 0;
            radioButtonHigh.TabStop = true;
            radioButtonHigh.Text = "Высокий";
            radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(287, 208);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 18);
            labelName.TabIndex = 19;
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOption
            // 
            labelOption.AutoSize = true;
            labelOption.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOption.Location = new Point(273, 187);
            labelOption.Margin = new Padding(4, 0, 4, 0);
            labelOption.Name = "labelOption";
            labelOption.Size = new Size(147, 18);
            labelOption.TabIndex = 20;
            labelOption.Text = "выбранный миньон:";
            // 
            // listViewMinions
            // 
            listViewMinions.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewMinions.Location = new Point(14, 479);
            listViewMinions.Margin = new Padding(4, 3, 4, 3);
            listViewMinions.Name = "listViewMinions";
            listViewMinions.Size = new Size(650, 371);
            listViewMinions.TabIndex = 21;
            listViewMinions.UseCompatibleStateImageBehavior = false;
            listViewMinions.SelectedIndexChanged += ListViewMinions_SelectedIndexChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.Location = new Point(677, 764);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(124, 18);
            labelSearch.TabIndex = 24;
            labelSearch.Text = "Поиск по имени:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(680, 792);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 23);
            textBoxName.TabIndex = 25;
            textBoxName.TextChanged += TextBox1_TextChanged;
            // 
            // buttonResetSearch
            // 
            buttonResetSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonResetSearch.Location = new Point(707, 824);
            buttonResetSearch.Margin = new Padding(4, 3, 4, 3);
            buttonResetSearch.Name = "buttonResetSearch";
            buttonResetSearch.Size = new Size(180, 27);
            buttonResetSearch.TabIndex = 26;
            buttonResetSearch.Text = "очистить поиск";
            buttonResetSearch.UseVisualStyleBackColor = true;
            buttonResetSearch.Click += ButtonResetSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = WinFormsApp1.Properties.Resources.gru;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 21);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 441);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(677, 55);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(233, 36);
            buttonStart.TabIndex = 28;
            buttonStart.Text = "НАЧАТЬ";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(680, 115);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(233, 71);
            buttonSend.TabIndex = 29;
            buttonSend.Text = "отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 864);
            Controls.Add(buttonSend);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Controls.Add(buttonResetSearch);
            Controls.Add(textBoxName);
            Controls.Add(labelSearch);
            Controls.Add(listViewMinions);
            Controls.Add(labelOption);
            Controls.Add(labelName);
            Controls.Add(panel1);
            Controls.Add(labelGroup);
            Controls.Add(pictureBoxBody);
            Controls.Add(GruText);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonCreate);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBody).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label GruText;
        private System.Windows.Forms.PictureBox pictureBoxBody;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonShort;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.ListView listViewMinions;
        private System.Windows.Forms.RadioButton radioButtonReset;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button buttonStart;
        private Button buttonSend;
    }
}

