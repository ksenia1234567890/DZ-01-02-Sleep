﻿namespace DZ_01_02_Sleep
{
    partial class Authorization
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
            this.Tlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.auto = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // Tlogin
            // 
            this.Tlogin.Location = new System.Drawing.Point(66, 62);
            this.Tlogin.Multiline = true;
            this.Tlogin.Name = "Tlogin";
            this.Tlogin.Size = new System.Drawing.Size(178, 24);
            this.Tlogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(66, 148);
            this.Tpassword.Multiline = true;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(178, 24);
            this.Tpassword.TabIndex = 1;
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(159, 216);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(144, 23);
            this.auto.TabIndex = 2;
            this.auto.Text = "Авторизоваться";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 216);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 251);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tlogin);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.Button exit;
    }
}

