namespace boimatov_pm
{
    partial class bacalavr
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.back_but = new System.Windows.Forms.Button();
            this.pricrepit_but = new System.Windows.Forms.Button();
            this.napravleniyaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.math_chek = new System.Windows.Forms.CheckBox();
            this.rus_check = new System.Windows.Forms.CheckBox();
            this.math_text = new System.Windows.Forms.TextBox();
            this.rus_text = new System.Windows.Forms.TextBox();
            this.ready_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 409);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(410, 22);
            this.txtFilePath.TabIndex = 17;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(836, 469);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(137, 58);
            this.back_but.TabIndex = 16;
            this.back_but.Text = "Назад";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // pricrepit_but
            // 
            this.pricrepit_but.Location = new System.Drawing.Point(453, 401);
            this.pricrepit_but.Name = "pricrepit_but";
            this.pricrepit_but.Size = new System.Drawing.Size(127, 38);
            this.pricrepit_but.TabIndex = 15;
            this.pricrepit_but.Text = "Выбрать PDF";
            this.pricrepit_but.UseVisualStyleBackColor = true;
            this.pricrepit_but.Click += new System.EventHandler(this.pricrepit_but_Click);
            // 
            // napravleniyaComboBox
            // 
            this.napravleniyaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.napravleniyaComboBox.FormattingEnabled = true;
            this.napravleniyaComboBox.Location = new System.Drawing.Point(12, 118);
            this.napravleniyaComboBox.Name = "napravleniyaComboBox";
            this.napravleniyaComboBox.Size = new System.Drawing.Size(535, 37);
            this.napravleniyaComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Прикрепите документ об образовании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ваш бал ЕГЭ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Бакалавриат";
            // 
            // math_chek
            // 
            this.math_chek.AutoSize = true;
            this.math_chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.math_chek.Location = new System.Drawing.Point(13, 208);
            this.math_chek.Name = "math_chek";
            this.math_chek.Size = new System.Drawing.Size(178, 33);
            this.math_chek.TabIndex = 18;
            this.math_chek.Text = "Математика";
            this.math_chek.UseVisualStyleBackColor = true;
            this.math_chek.CheckedChanged += new System.EventHandler(this.math_chek_CheckedChanged);
            // 
            // rus_check
            // 
            this.rus_check.AutoSize = true;
            this.rus_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus_check.Location = new System.Drawing.Point(12, 240);
            this.rus_check.Name = "rus_check";
            this.rus_check.Size = new System.Drawing.Size(185, 33);
            this.rus_check.TabIndex = 19;
            this.rus_check.Text = "Русский язык";
            this.rus_check.UseVisualStyleBackColor = true;
            this.rus_check.CheckedChanged += new System.EventHandler(this.rus_check_CheckedChanged);
            // 
            // math_text
            // 
            this.math_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.math_text.Location = new System.Drawing.Point(220, 213);
            this.math_text.Name = "math_text";
            this.math_text.Size = new System.Drawing.Size(100, 27);
            this.math_text.TabIndex = 23;
            // 
            // rus_text
            // 
            this.rus_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus_text.Location = new System.Drawing.Point(220, 245);
            this.rus_text.Name = "rus_text";
            this.rus_text.Size = new System.Drawing.Size(100, 27);
            this.rus_text.TabIndex = 27;
            // 
            // ready_but
            // 
            this.ready_but.Location = new System.Drawing.Point(416, 469);
            this.ready_but.Name = "ready_but";
            this.ready_but.Size = new System.Drawing.Size(164, 44);
            this.ready_but.TabIndex = 28;
            this.ready_but.Text = "Готово";
            this.ready_but.UseVisualStyleBackColor = true;
            this.ready_but.Click += new System.EventHandler(this.ready_but_Click);
            // 
            // bacalavr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 539);
            this.Controls.Add(this.ready_but);
            this.Controls.Add(this.rus_text);
            this.Controls.Add(this.math_text);
            this.Controls.Add(this.rus_check);
            this.Controls.Add(this.math_chek);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.pricrepit_but);
            this.Controls.Add(this.napravleniyaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bacalavr";
            this.Text = "bacalavr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button pricrepit_but;
        private System.Windows.Forms.ComboBox napravleniyaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox math_chek;
        private System.Windows.Forms.CheckBox rus_check;
        private System.Windows.Forms.TextBox math_text;
        private System.Windows.Forms.TextBox rus_text;
        private System.Windows.Forms.Button ready_but;
    }
}