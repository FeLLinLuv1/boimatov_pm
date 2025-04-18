namespace boimatov_pm
{
    partial class viborUrovna
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
            this.label1 = new System.Windows.Forms.Label();
            this.spo_But = new System.Windows.Forms.Button();
            this.bacalavr_but = new System.Windows.Forms.Button();
            this.specialitet_but = new System.Windows.Forms.Button();
            this.magistr_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите уровень образования";
            // 
            // spo_But
            // 
            this.spo_But.Location = new System.Drawing.Point(77, 169);
            this.spo_But.Name = "spo_But";
            this.spo_But.Size = new System.Drawing.Size(128, 125);
            this.spo_But.TabIndex = 1;
            this.spo_But.Text = "СПО";
            this.spo_But.UseVisualStyleBackColor = true;
            this.spo_But.Click += new System.EventHandler(this.spo_But_Click);
            // 
            // bacalavr_but
            // 
            this.bacalavr_but.Location = new System.Drawing.Point(250, 169);
            this.bacalavr_but.Name = "bacalavr_but";
            this.bacalavr_but.Size = new System.Drawing.Size(123, 125);
            this.bacalavr_but.TabIndex = 2;
            this.bacalavr_but.Text = "Бакалавриат";
            this.bacalavr_but.UseVisualStyleBackColor = true;
            this.bacalavr_but.Click += new System.EventHandler(this.bacalavr_but_Click);
            // 
            // specialitet_but
            // 
            this.specialitet_but.Location = new System.Drawing.Point(404, 169);
            this.specialitet_but.Name = "specialitet_but";
            this.specialitet_but.Size = new System.Drawing.Size(126, 125);
            this.specialitet_but.TabIndex = 3;
            this.specialitet_but.Text = "Специалитет";
            this.specialitet_but.UseVisualStyleBackColor = true;
            this.specialitet_but.Click += new System.EventHandler(this.specialitet_but_Click);
            // 
            // magistr_but
            // 
            this.magistr_but.Location = new System.Drawing.Point(569, 168);
            this.magistr_but.Name = "magistr_but";
            this.magistr_but.Size = new System.Drawing.Size(137, 126);
            this.magistr_but.TabIndex = 4;
            this.magistr_but.Text = "Магистратура";
            this.magistr_but.UseVisualStyleBackColor = true;
            this.magistr_but.Click += new System.EventHandler(this.magistr_but_Click);
            // 
            // viborUrovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 522);
            this.Controls.Add(this.magistr_but);
            this.Controls.Add(this.specialitet_but);
            this.Controls.Add(this.bacalavr_but);
            this.Controls.Add(this.spo_But);
            this.Controls.Add(this.label1);
            this.Name = "viborUrovna";
            this.Text = "viborUrovna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spo_But;
        private System.Windows.Forms.Button bacalavr_but;
        private System.Windows.Forms.Button specialitet_but;
        private System.Windows.Forms.Button magistr_but;
    }
}