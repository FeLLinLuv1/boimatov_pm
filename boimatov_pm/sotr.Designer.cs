namespace boimatov_pm
{
    partial class sotr
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
            this.back_but = new System.Windows.Forms.Button();
            this.vhod_but = new System.Windows.Forms.Button();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(635, 488);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(97, 25);
            this.back_but.TabIndex = 15;
            this.back_but.Text = "Назад";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // vhod_but
            // 
            this.vhod_but.Location = new System.Drawing.Point(241, 341);
            this.vhod_but.Name = "vhod_but";
            this.vhod_but.Size = new System.Drawing.Size(164, 67);
            this.vhod_but.TabIndex = 13;
            this.vhod_but.Text = "Войти";
            this.vhod_but.UseVisualStyleBackColor = true;
            this.vhod_but.Click += new System.EventHandler(this.vhod_but_Click);
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_text.Location = new System.Drawing.Point(63, 294);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(504, 41);
            this.password_text.TabIndex = 12;
            // 
            // login_text
            // 
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text.Location = new System.Drawing.Point(63, 175);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(504, 41);
            this.login_text.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Авторизация";
            // 
            // sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 525);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.vhod_but);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sotr";
            this.Text = "sotr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button vhod_but;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}