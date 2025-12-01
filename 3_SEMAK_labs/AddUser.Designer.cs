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
            this.UserName_textbox = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.IQ = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IQ_trackBar = new System.Windows.Forms.TrackBar();
            this.Balance_textbox = new System.Windows.Forms.TextBox();
            this.IQ_label = new System.Windows.Forms.Label();
            this.USERSdataGridView = new System.Windows.Forms.DataGridView();
            this.nickname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iq_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IQ_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USERSdataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(391, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IQ_trackBar
            // 
            this.IQ_trackBar.LargeChange = 1;
            this.IQ_trackBar.Location = new System.Drawing.Point(182, 158);
            this.IQ_trackBar.Maximum = 200;
            this.IQ_trackBar.Name = "IQ_trackBar";
            this.IQ_trackBar.Size = new System.Drawing.Size(146, 56);
            this.IQ_trackBar.TabIndex = 12;
            this.IQ_trackBar.Scroll += new System.EventHandler(this.IQ_trackBar_Scroll);
            // 
            // Balance_textbox
            // 
            this.Balance_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Balance_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_textbox.Location = new System.Drawing.Point(182, 249);
            this.Balance_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Balance_textbox.Name = "Balance_textbox";
            this.Balance_textbox.Size = new System.Drawing.Size(184, 27);
            this.Balance_textbox.TabIndex = 10;
            // 
            // IQ_label
            // 
            this.IQ_label.AutoSize = true;
            this.IQ_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IQ_label.Location = new System.Drawing.Point(337, 158);
            this.IQ_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IQ_label.Name = "IQ_label";
            this.IQ_label.Size = new System.Drawing.Size(29, 31);
            this.IQ_label.TabIndex = 7;
            this.IQ_label.Text = "0";
            this.IQ_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USERSdataGridView
            // 
            this.USERSdataGridView.AllowUserToAddRows = false;
            this.USERSdataGridView.AllowUserToDeleteRows = false;
            this.USERSdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.USERSdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickname_column,
            this.iq_column,
            this.balance_column});
            this.USERSdataGridView.Location = new System.Drawing.Point(391, 26);
            this.USERSdataGridView.Name = "USERSdataGridView";
            this.USERSdataGridView.ReadOnly = true;
            this.USERSdataGridView.RowHeadersWidth = 51;
            this.USERSdataGridView.RowTemplate.Height = 24;
            this.USERSdataGridView.Size = new System.Drawing.Size(556, 357);
            this.USERSdataGridView.TabIndex = 13;
            this.USERSdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.USERSdataGridView_CellContentClick);
            // 
            // nickname_column
            // 
            this.nickname_column.HeaderText = "Nickname";
            this.nickname_column.MinimumWidth = 6;
            this.nickname_column.Name = "nickname_column";
            this.nickname_column.Width = 125;
            // 
            // iq_column
            // 
            this.iq_column.HeaderText = "Уровень IQ";
            this.iq_column.MinimumWidth = 6;
            this.iq_column.Name = "iq_column";
            this.iq_column.Width = 125;
            // 
            // balance_column
            // 
            this.balance_column.HeaderText = "Баланс";
            this.balance_column.MinimumWidth = 6;
            this.balance_column.Name = "balance_column";
            this.balance_column.Width = 125;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(753, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 78);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить выделенного пользователя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.USERSdataGridView);
            this.Controls.Add(this.IQ_trackBar);
            this.Controls.Add(this.Balance_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.IQ);
            this.Controls.Add(this.IQ_label);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.button1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.IQ_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USERSdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName_textbox;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label IQ;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar IQ_trackBar;
        private System.Windows.Forms.TextBox Balance_textbox;
        private System.Windows.Forms.Label IQ_label;
        private System.Windows.Forms.DataGridView USERSdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn iq_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance_column;
        private System.Windows.Forms.Button button2;
    }
}