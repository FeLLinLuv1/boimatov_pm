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
            this.napravlenia_data = new System.Windows.Forms.DataGridView();
            this.readyNapr_but = new System.Windows.Forms.Button();
            this.uroven_data = new System.Windows.Forms.DataGridView();
            this.readyUroven_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenia_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uroven_data)).BeginInit();
            this.SuspendLayout();
            // 
            // napravlenia_data
            // 
            this.napravlenia_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.napravlenia_data.Location = new System.Drawing.Point(12, 49);
            this.napravlenia_data.Name = "napravlenia_data";
            this.napravlenia_data.RowHeadersWidth = 51;
            this.napravlenia_data.RowTemplate.Height = 24;
            this.napravlenia_data.Size = new System.Drawing.Size(525, 442);
            this.napravlenia_data.TabIndex = 0;
            // 
            // readyNapr_but
            // 
            this.readyNapr_but.Location = new System.Drawing.Point(365, 506);
            this.readyNapr_but.Name = "readyNapr_but";
            this.readyNapr_but.Size = new System.Drawing.Size(172, 50);
            this.readyNapr_but.TabIndex = 1;
            this.readyNapr_but.Text = "Сохранить направления";
            this.readyNapr_but.UseVisualStyleBackColor = true;
            // 
            // uroven_data
            // 
            this.uroven_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uroven_data.Location = new System.Drawing.Point(543, 49);
            this.uroven_data.Name = "uroven_data";
            this.uroven_data.RowHeadersWidth = 51;
            this.uroven_data.RowTemplate.Height = 24;
            this.uroven_data.Size = new System.Drawing.Size(547, 442);
            this.uroven_data.TabIndex = 2;
            // 
            // readyUroven_but
            // 
            this.readyUroven_but.Location = new System.Drawing.Point(943, 506);
            this.readyUroven_but.Name = "readyUroven_but";
            this.readyUroven_but.Size = new System.Drawing.Size(147, 50);
            this.readyUroven_but.TabIndex = 3;
            this.readyUroven_but.Text = "Сохранить уровень";
            this.readyUroven_but.UseVisualStyleBackColor = true;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(949, 584);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(141, 35);
            this.back_but.TabIndex = 4;
            this.back_but.Text = "Выйти";
            this.back_but.UseVisualStyleBackColor = true;
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
            // slughebnoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.readyUroven_but);
            this.Controls.Add(this.uroven_data);
            this.Controls.Add(this.readyNapr_but);
            this.Controls.Add(this.napravlenia_data);
            this.Name = "slughebnoe";
            this.Text = "slughebnoe";
            ((System.ComponentModel.ISupportInitialize)(this.napravlenia_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uroven_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView napravlenia_data;
        private System.Windows.Forms.Button readyNapr_but;
        private System.Windows.Forms.DataGridView uroven_data;
        private System.Windows.Forms.Button readyUroven_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Label label1;
    }
}