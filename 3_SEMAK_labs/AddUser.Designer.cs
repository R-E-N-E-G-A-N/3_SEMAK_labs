namespace _3_SEMAK_labs
{
    partial class AddUser
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
            this.Users_list = new System.Windows.Forms.ListBox();
            this.Balance_textbox = new System.Windows.Forms.TextBox();
            this.IQ_textbox = new System.Windows.Forms.TextBox();
            this.UserName_textbox = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.IQ = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Users_list
            // 
            this.Users_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Users_list.FormattingEnabled = true;
            this.Users_list.ItemHeight = 25;
            this.Users_list.Location = new System.Drawing.Point(395, 25);
            this.Users_list.Margin = new System.Windows.Forms.Padding(4);
            this.Users_list.Name = "Users_list";
            this.Users_list.Size = new System.Drawing.Size(551, 329);
            this.Users_list.TabIndex = 11;
            // 
            // Balance_textbox
            // 
            this.Balance_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Balance_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_textbox.Location = new System.Drawing.Point(182, 248);
            this.Balance_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Balance_textbox.Name = "Balance_textbox";
            this.Balance_textbox.Size = new System.Drawing.Size(184, 27);
            this.Balance_textbox.TabIndex = 8;
            // 
            // IQ_textbox
            // 
            this.IQ_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IQ_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IQ_textbox.Location = new System.Drawing.Point(182, 152);
            this.IQ_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.IQ_textbox.Name = "IQ_textbox";
            this.IQ_textbox.Size = new System.Drawing.Size(184, 27);
            this.IQ_textbox.TabIndex = 9;
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName_textbox.Location = new System.Drawing.Point(182, 54);
            this.UserName_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.Size = new System.Drawing.Size(184, 27);
            this.UserName_textbox.TabIndex = 10;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance.Location = new System.Drawing.Point(16, 245);
            this.Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(106, 31);
            this.Balance.TabIndex = 5;
            this.Balance.Text = "Баланс";
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IQ
            // 
            this.IQ.AutoSize = true;
            this.IQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IQ.Location = new System.Drawing.Point(16, 149);
            this.IQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IQ.Name = "IQ";
            this.IQ.Size = new System.Drawing.Size(155, 31);
            this.IQ.TabIndex = 6;
            this.IQ.Text = "Уровень IQ";
            this.IQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(16, 50);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(112, 31);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Никейм";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(363, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 560);
            this.Controls.Add(this.Users_list);
            this.Controls.Add(this.Balance_textbox);
            this.Controls.Add(this.IQ_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.IQ);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.button1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Users_list;
        private System.Windows.Forms.TextBox Balance_textbox;
        private System.Windows.Forms.TextBox IQ_textbox;
        private System.Windows.Forms.TextBox UserName_textbox;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label IQ;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button button1;
    }
}