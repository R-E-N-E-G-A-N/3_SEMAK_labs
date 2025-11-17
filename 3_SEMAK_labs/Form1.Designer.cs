namespace _3_SEMAK_labs
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
            this.AddUser = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.UserName_textbox = new System.Windows.Forms.TextBox();
            this.IQ = new System.Windows.Forms.Label();
            this.IQ_textbox = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.Balance_textbox = new System.Windows.Forms.TextBox();
            this.Users_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.Location = new System.Drawing.Point(315, 327);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(145, 63);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Добавить пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(46, 62);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(89, 25);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Никейм";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName_textbox.Location = new System.Drawing.Point(170, 65);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.Size = new System.Drawing.Size(138, 22);
            this.UserName_textbox.TabIndex = 2;
            // 
            // IQ
            // 
            this.IQ.AutoSize = true;
            this.IQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IQ.Location = new System.Drawing.Point(46, 142);
            this.IQ.Name = "IQ";
            this.IQ.Size = new System.Drawing.Size(122, 25);
            this.IQ.TabIndex = 1;
            this.IQ.Text = "Уровень IQ";
            this.IQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IQ_textbox
            // 
            this.IQ_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IQ_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IQ_textbox.Location = new System.Drawing.Point(170, 145);
            this.IQ_textbox.Name = "IQ_textbox";
            this.IQ_textbox.Size = new System.Drawing.Size(138, 22);
            this.IQ_textbox.TabIndex = 2;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance.Location = new System.Drawing.Point(46, 220);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(85, 25);
            this.Balance.TabIndex = 1;
            this.Balance.Text = "Баланс";
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Balance_textbox
            // 
            this.Balance_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Balance_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_textbox.Location = new System.Drawing.Point(170, 223);
            this.Balance_textbox.Name = "Balance_textbox";
            this.Balance_textbox.Size = new System.Drawing.Size(138, 22);
            this.Balance_textbox.TabIndex = 2;
            // 
            // Users_list
            // 
            this.Users_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Users_list.FormattingEnabled = true;
            this.Users_list.ItemHeight = 20;
            this.Users_list.Location = new System.Drawing.Point(349, 12);
            this.Users_list.Name = "Users_list";
            this.Users_list.Size = new System.Drawing.Size(414, 284);
            this.Users_list.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Users_list);
            this.Controls.Add(this.Balance_textbox);
            this.Controls.Add(this.IQ_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.IQ);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.AddUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserName_textbox;
        private System.Windows.Forms.Label IQ;
        private System.Windows.Forms.TextBox IQ_textbox;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox Balance_textbox;
        private System.Windows.Forms.ListBox Users_list;
    }
}

