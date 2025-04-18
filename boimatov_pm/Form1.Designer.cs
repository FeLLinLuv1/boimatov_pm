namespace boimatov_pm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.vhod_but = new System.Windows.Forms.Button();
            this.register_but = new System.Windows.Forms.Button();
            this.worker_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // login_text
            // 
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text.Location = new System.Drawing.Point(19, 175);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(504, 41);
            this.login_text.TabIndex = 3;
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_text.Location = new System.Drawing.Point(19, 294);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(504, 41);
            this.password_text.TabIndex = 4;
            // 
            // vhod_but
            // 
            this.vhod_but.Location = new System.Drawing.Point(197, 341);
            this.vhod_but.Name = "vhod_but";
            this.vhod_but.Size = new System.Drawing.Size(164, 67);
            this.vhod_but.TabIndex = 5;
            this.vhod_but.Text = "Войти";
            this.vhod_but.UseVisualStyleBackColor = true;
            this.vhod_but.Click += new System.EventHandler(this.vhod_but_Click);
            // 
            // register_but
            // 
            this.register_but.Location = new System.Drawing.Point(127, 414);
            this.register_but.Name = "register_but";
            this.register_but.Size = new System.Drawing.Size(292, 41);
            this.register_but.TabIndex = 6;
            this.register_but.Text = "Зарегистрироваться";
            this.register_but.UseVisualStyleBackColor = true;
            this.register_but.Click += new System.EventHandler(this.register_but_Click);
            // 
            // worker_but
            // 
            this.worker_but.Location = new System.Drawing.Point(548, 490);
            this.worker_but.Name = "worker_but";
            this.worker_but.Size = new System.Drawing.Size(97, 25);
            this.worker_but.TabIndex = 7;
            this.worker_but.Text = "Сотрудник";
            this.worker_but.UseVisualStyleBackColor = true;
            this.worker_but.Click += new System.EventHandler(this.worker_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 527);
            this.Controls.Add(this.worker_but);
            this.Controls.Add(this.register_but);
            this.Controls.Add(this.vhod_but);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button vhod_but;
        private System.Windows.Forms.Button register_but;
        private System.Windows.Forms.Button worker_but;
    }
}

