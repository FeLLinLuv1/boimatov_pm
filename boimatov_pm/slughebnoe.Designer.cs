namespace boimatov_pm
{
    partial class slughebnoe
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
            this.napravlenDataGridView = new System.Windows.Forms.DataGridView();
            this.readyNapr_but = new System.Windows.Forms.Button();
            this.urovenDataGridView = new System.Windows.Forms.DataGridView();
            this.readyUroven_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addNapravlenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urovenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // napravlenDataGridView
            // 
            this.napravlenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.napravlenDataGridView.Location = new System.Drawing.Point(12, 49);
            this.napravlenDataGridView.Name = "napravlenDataGridView";
            this.napravlenDataGridView.RowHeadersWidth = 51;
            this.napravlenDataGridView.RowTemplate.Height = 24;
            this.napravlenDataGridView.Size = new System.Drawing.Size(525, 442);
            this.napravlenDataGridView.TabIndex = 0;
            // 
            // readyNapr_but
            // 
            this.readyNapr_but.Location = new System.Drawing.Point(365, 506);
            this.readyNapr_but.Name = "readyNapr_but";
            this.readyNapr_but.Size = new System.Drawing.Size(172, 50);
            this.readyNapr_but.TabIndex = 1;
            this.readyNapr_but.Text = "Сохранить направления";
            this.readyNapr_but.UseVisualStyleBackColor = true;
            this.readyNapr_but.Click += new System.EventHandler(this.readyNapr_but_Click);
            // 
            // urovenDataGridView
            // 
            this.urovenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urovenDataGridView.Location = new System.Drawing.Point(543, 49);
            this.urovenDataGridView.Name = "urovenDataGridView";
            this.urovenDataGridView.RowHeadersWidth = 51;
            this.urovenDataGridView.RowTemplate.Height = 24;
            this.urovenDataGridView.Size = new System.Drawing.Size(547, 442);
            this.urovenDataGridView.TabIndex = 2;
            // 
            // readyUroven_but
            // 
            this.readyUroven_but.Location = new System.Drawing.Point(943, 506);
            this.readyUroven_but.Name = "readyUroven_but";
            this.readyUroven_but.Size = new System.Drawing.Size(147, 50);
            this.readyUroven_but.TabIndex = 3;
            this.readyUroven_but.Text = "Сохранить уровень";
            this.readyUroven_but.UseVisualStyleBackColor = true;
            this.readyUroven_but.Click += new System.EventHandler(this.readyUroven_but_Click);
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(949, 584);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(141, 35);
            this.back_but.TabIndex = 4;
            this.back_but.Text = "Выйти";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите необходимые данные для изменения (БУДЬТЕ ОСТОРОЖНЫ!!!)";
            // 
            // addNapravlenButton
            // 
            this.addNapravlenButton.Location = new System.Drawing.Point(12, 513);
            this.addNapravlenButton.Name = "addNapravlenButton";
            this.addNapravlenButton.Size = new System.Drawing.Size(179, 43);
            this.addNapravlenButton.TabIndex = 6;
            this.addNapravlenButton.Text = "новая строка";
            this.addNapravlenButton.UseVisualStyleBackColor = true;
            this.addNapravlenButton.Click += new System.EventHandler(this.addNapravlenButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "новая строка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // slughebnoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addNapravlenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.readyUroven_but);
            this.Controls.Add(this.urovenDataGridView);
            this.Controls.Add(this.readyNapr_but);
            this.Controls.Add(this.napravlenDataGridView);
            this.Name = "slughebnoe";
            this.Text = "slughebnoe";
            this.Load += new System.EventHandler(this.slughebnoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.napravlenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urovenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView napravlenDataGridView;
        private System.Windows.Forms.Button readyNapr_but;
        private System.Windows.Forms.DataGridView urovenDataGridView;
        private System.Windows.Forms.Button readyUroven_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNapravlenButton;
        private System.Windows.Forms.Button button1;
    }
}