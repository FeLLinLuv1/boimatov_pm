namespace boimatov_pm
{
    partial class obrabotka
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
            this.spoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ready_but = new System.Windows.Forms.Button();
            this.otklonit_but = new System.Windows.Forms.Button();
            this.dorabotka_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.date_but = new System.Windows.Forms.Button();
            this.vseZayavki_but = new System.Windows.Forms.Button();
            this.slughebnoe_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filterDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.spoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // spoDataGridView
            // 
            this.spoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spoDataGridView.Location = new System.Drawing.Point(18, 41);
            this.spoDataGridView.Name = "spoDataGridView";
            this.spoDataGridView.RowHeadersWidth = 51;
            this.spoDataGridView.RowTemplate.Height = 24;
            this.spoDataGridView.Size = new System.Drawing.Size(1018, 572);
            this.spoDataGridView.TabIndex = 0;
            this.spoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spoDataGridView_CellClick);
            this.spoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.spoDataGridView_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите заявку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1041, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Обработка";
            // 
            // ready_but
            // 
            this.ready_but.Location = new System.Drawing.Point(1066, 361);
            this.ready_but.Name = "ready_but";
            this.ready_but.Size = new System.Drawing.Size(153, 42);
            this.ready_but.TabIndex = 3;
            this.ready_but.Text = "ГОТОВО";
            this.ready_but.UseVisualStyleBackColor = true;
            this.ready_but.Click += new System.EventHandler(this.ready_but_Click);
            // 
            // otklonit_but
            // 
            this.otklonit_but.Location = new System.Drawing.Point(1066, 409);
            this.otklonit_but.Name = "otklonit_but";
            this.otklonit_but.Size = new System.Drawing.Size(153, 41);
            this.otklonit_but.TabIndex = 4;
            this.otklonit_but.Text = "ОТКЛОНИТЬ";
            this.otklonit_but.UseVisualStyleBackColor = true;
            this.otklonit_but.Click += new System.EventHandler(this.otklonit_but_Click);
            // 
            // dorabotka_but
            // 
            this.dorabotka_but.Location = new System.Drawing.Point(1066, 456);
            this.dorabotka_but.Name = "dorabotka_but";
            this.dorabotka_but.Size = new System.Drawing.Size(153, 42);
            this.dorabotka_but.TabIndex = 5;
            this.dorabotka_but.Text = "В ДОРАБОТКУ";
            this.dorabotka_but.UseVisualStyleBackColor = true;
            this.dorabotka_but.Click += new System.EventHandler(this.dorabotka_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(1066, 557);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(153, 56);
            this.exit_but.TabIndex = 6;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите комментарий";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentsTextBox.Location = new System.Drawing.Point(18, 651);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(1018, 108);
            this.commentsTextBox.TabIndex = 8;
            // 
            // date_but
            // 
            this.date_but.Location = new System.Drawing.Point(1077, 142);
            this.date_but.Name = "date_but";
            this.date_but.Size = new System.Drawing.Size(142, 34);
            this.date_but.TabIndex = 10;
            this.date_but.Text = "Выбрать дату";
            this.date_but.UseVisualStyleBackColor = true;
            // 
            // vseZayavki_but
            // 
            this.vseZayavki_but.Location = new System.Drawing.Point(1077, 43);
            this.vseZayavki_but.Name = "vseZayavki_but";
            this.vseZayavki_but.Size = new System.Drawing.Size(142, 31);
            this.vseZayavki_but.TabIndex = 11;
            this.vseZayavki_but.Text = "Все заявки";
            this.vseZayavki_but.UseVisualStyleBackColor = true;
            this.vseZayavki_but.Click += new System.EventHandler(this.vseZayavki_but_Click);
            // 
            // slughebnoe_but
            // 
            this.slughebnoe_but.Location = new System.Drawing.Point(1066, 528);
            this.slughebnoe_but.Name = "slughebnoe_but";
            this.slughebnoe_but.Size = new System.Drawing.Size(153, 23);
            this.slughebnoe_but.TabIndex = 12;
            this.slughebnoe_but.Text = "служебное";
            this.slughebnoe_but.UseVisualStyleBackColor = true;
            this.slughebnoe_but.Click += new System.EventHandler(this.slughebnoe_but_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1066, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 82);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterDatePicker
            // 
            this.filterDatePicker.Location = new System.Drawing.Point(1057, 101);
            this.filterDatePicker.Name = "filterDatePicker";
            this.filterDatePicker.Size = new System.Drawing.Size(177, 22);
            this.filterDatePicker.TabIndex = 14;
            this.filterDatePicker.ValueChanged += new System.EventHandler(this.filterDatePicker_ValueChanged);
            // 
            // obrabotka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 771);
            this.Controls.Add(this.filterDatePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slughebnoe_but);
            this.Controls.Add(this.vseZayavki_but);
            this.Controls.Add(this.date_but);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.dorabotka_but);
            this.Controls.Add(this.otklonit_but);
            this.Controls.Add(this.ready_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spoDataGridView);
            this.Name = "obrabotka";
            this.Text = "obrabotka";
            ((System.ComponentModel.ISupportInitialize)(this.spoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ready_but;
        private System.Windows.Forms.Button otklonit_but;
        private System.Windows.Forms.Button dorabotka_but;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button date_but;
        private System.Windows.Forms.Button vseZayavki_but;
        private System.Windows.Forms.Button slughebnoe_but;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker filterDatePicker;
    }
}