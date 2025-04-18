namespace boimatov_pm
{
    partial class magistr
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
            this.ready_but = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.back_but = new System.Windows.Forms.Button();
            this.pricrepit_but = new System.Windows.Forms.Button();
            this.balAtt_text = new System.Windows.Forms.TextBox();
            this.napravleniyaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ready_but
            // 
            this.ready_but.Location = new System.Drawing.Point(406, 479);
            this.ready_but.Name = "ready_but";
            this.ready_but.Size = new System.Drawing.Size(164, 44);
            this.ready_but.TabIndex = 39;
            this.ready_but.Text = "Готово";
            this.ready_but.UseVisualStyleBackColor = true;
            this.ready_but.Click += new System.EventHandler(this.ready_but_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(13, 419);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(410, 22);
            this.txtFilePath.TabIndex = 38;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(729, 479);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(137, 58);
            this.back_but.TabIndex = 37;
            this.back_but.Text = "Назад";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // pricrepit_but
            // 
            this.pricrepit_but.Location = new System.Drawing.Point(443, 411);
            this.pricrepit_but.Name = "pricrepit_but";
            this.pricrepit_but.Size = new System.Drawing.Size(127, 38);
            this.pricrepit_but.TabIndex = 36;
            this.pricrepit_but.Text = "Выбрать PDF";
            this.pricrepit_but.UseVisualStyleBackColor = true;
            this.pricrepit_but.Click += new System.EventHandler(this.pricrepit_but_Click);
            // 
            // balAtt_text
            // 
            this.balAtt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balAtt_text.Location = new System.Drawing.Point(13, 279);
            this.balAtt_text.Name = "balAtt_text";
            this.balAtt_text.Size = new System.Drawing.Size(535, 34);
            this.balAtt_text.TabIndex = 35;
            // 
            // napravleniyaComboBox
            // 
            this.napravleniyaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.napravleniyaComboBox.FormattingEnabled = true;
            this.napravleniyaComboBox.Location = new System.Drawing.Point(13, 161);
            this.napravleniyaComboBox.Name = "napravleniyaComboBox";
            this.napravleniyaComboBox.Size = new System.Drawing.Size(535, 37);
            this.napravleniyaComboBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 36);
            this.label4.TabIndex = 33;
            this.label4.Text = "Прикрепите документ об образовании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ваш средний бал диплома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Выберите направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "Магистратура";
            // 
            // magistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 563);
            this.Controls.Add(this.ready_but);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.pricrepit_but);
            this.Controls.Add(this.balAtt_text);
            this.Controls.Add(this.napravleniyaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "magistr";
            this.Text = "magistr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ready_but;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button pricrepit_but;
        private System.Windows.Forms.TextBox balAtt_text;
        private System.Windows.Forms.ComboBox napravleniyaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}