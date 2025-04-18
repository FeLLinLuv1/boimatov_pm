namespace boimatov_pm
{
    partial class kabinet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_but = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.new_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.viewDocumentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои заявки:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(153, 520);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заявка №";
            // 
            // delete_but
            // 
            this.delete_but.Location = new System.Drawing.Point(85, 560);
            this.delete_but.Name = "delete_but";
            this.delete_but.Size = new System.Drawing.Size(168, 37);
            this.delete_but.TabIndex = 4;
            this.delete_but.Text = "Отозвать заявку";
            this.delete_but.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(293, 523);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(864, 118);
            this.textBox2.TabIndex = 6;
            // 
            // new_but
            // 
            this.new_but.Location = new System.Drawing.Point(457, 647);
            this.new_but.Name = "new_but";
            this.new_but.Size = new System.Drawing.Size(289, 66);
            this.new_but.TabIndex = 7;
            this.new_but.Text = "Подать заявку";
            this.new_but.UseVisualStyleBackColor = true;
            this.new_but.Click += new System.EventHandler(this.new_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(1006, 673);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(151, 40);
            this.exit_but.TabIndex = 8;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // viewDocumentButton
            // 
            this.viewDocumentButton.Location = new System.Drawing.Point(1029, 110);
            this.viewDocumentButton.Name = "viewDocumentButton";
            this.viewDocumentButton.Size = new System.Drawing.Size(143, 46);
            this.viewDocumentButton.TabIndex = 9;
            this.viewDocumentButton.Text = "Просмотреть документ";
            this.viewDocumentButton.UseVisualStyleBackColor = true;
            this.viewDocumentButton.Click += new System.EventHandler(this.viewDocumentButton_Click);
            // 
            // kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 735);
            this.Controls.Add(this.viewDocumentButton);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.new_but);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.delete_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kabinet";
            this.Text = "kabinet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_but;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button new_but;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button viewDocumentButton;
    }
}