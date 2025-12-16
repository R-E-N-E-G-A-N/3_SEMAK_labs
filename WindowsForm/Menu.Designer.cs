namespace WindowsForm
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_quest_button = new System.Windows.Forms.Button();
            this.change_quest_button = new System.Windows.Forms.Button();
            this.delete_quest_button = new System.Windows.Forms.Button();
            this.quest_datagrid = new System.Windows.Forms.DataGridView();
            this.quest_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quest_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quest_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1261, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_quest_button
            // 
            this.add_quest_button.BackColor = System.Drawing.Color.Transparent;
            this.add_quest_button.Location = new System.Drawing.Point(185, 450);
            this.add_quest_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_quest_button.Name = "add_quest_button";
            this.add_quest_button.Size = new System.Drawing.Size(192, 46);
            this.add_quest_button.TabIndex = 1;
            this.add_quest_button.Text = "Добавить новый квест";
            this.add_quest_button.UseVisualStyleBackColor = false;
            this.add_quest_button.Click += new System.EventHandler(this.add_quest_button_Click);
            // 
            // change_quest_button
            // 
            this.change_quest_button.BackColor = System.Drawing.Color.Transparent;
            this.change_quest_button.Location = new System.Drawing.Point(185, 503);
            this.change_quest_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.change_quest_button.Name = "change_quest_button";
            this.change_quest_button.Size = new System.Drawing.Size(192, 46);
            this.change_quest_button.TabIndex = 2;
            this.change_quest_button.Text = "Редактировать квест";
            this.change_quest_button.UseVisualStyleBackColor = false;
            this.change_quest_button.Click += new System.EventHandler(this.change_quest_button_Click);
            // 
            // delete_quest_button
            // 
            this.delete_quest_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_quest_button.Location = new System.Drawing.Point(185, 556);
            this.delete_quest_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_quest_button.Name = "delete_quest_button";
            this.delete_quest_button.Size = new System.Drawing.Size(192, 46);
            this.delete_quest_button.TabIndex = 3;
            this.delete_quest_button.Text = "Удалить квест";
            this.delete_quest_button.UseVisualStyleBackColor = false;
            // 
            // quest_datagrid
            // 
            this.quest_datagrid.AllowUserToAddRows = false;
            this.quest_datagrid.AllowUserToDeleteRows = false;
            this.quest_datagrid.AllowUserToResizeRows = false;
            this.quest_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quest_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quest_name,
            this.quest_day,
            this.quest_place});
            this.quest_datagrid.Location = new System.Drawing.Point(491, 97);
            this.quest_datagrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quest_datagrid.MinimumSize = new System.Drawing.Size(13, 0);
            this.quest_datagrid.MultiSelect = false;
            this.quest_datagrid.Name = "quest_datagrid";
            this.quest_datagrid.ReadOnly = true;
            this.quest_datagrid.RowHeadersWidth = 51;
            this.quest_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.quest_datagrid.Size = new System.Drawing.Size(669, 452);
            this.quest_datagrid.TabIndex = 4;
            this.quest_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quest_datagrid_CellContentClick);
            // 
            // quest_name
            // 
            this.quest_name.HeaderText = "Квест";
            this.quest_name.MinimumWidth = 6;
            this.quest_name.Name = "quest_name";
            this.quest_name.ReadOnly = true;
            this.quest_name.Width = 125;
            // 
            // quest_day
            // 
            this.quest_day.HeaderText = "День недели";
            this.quest_day.MinimumWidth = 6;
            this.quest_day.Name = "quest_day";
            this.quest_day.ReadOnly = true;
            this.quest_day.Width = 125;
            // 
            // quest_place
            // 
            this.quest_place.HeaderText = "Место квеста";
            this.quest_place.MinimumWidth = 6;
            this.quest_place.Name = "quest_place";
            this.quest_place.ReadOnly = true;
            this.quest_place.Width = 125;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(185, 219);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 22);
            this.name.TabIndex = 5;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(185, 370);
            this.place.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(132, 22);
            this.place.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(185, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название квеста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(185, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "День недели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(185, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Место квеста";
            // 
            // day
            // 
            this.day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.day.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.day.Location = new System.Drawing.Point(185, 293);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(132, 24);
            this.day.TabIndex = 11;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.place);
            this.Controls.Add(this.name);
            this.Controls.Add(this.quest_datagrid);
            this.Controls.Add(this.delete_quest_button);
            this.Controls.Add(this.change_quest_button);
            this.Controls.Add(this.add_quest_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "POSTAL 2 Repack by MELL";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add_quest_button;
        private System.Windows.Forms.Button change_quest_button;
        private System.Windows.Forms.Button delete_quest_button;
        private System.Windows.Forms.DataGridView quest_datagrid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest_place;
        private System.Windows.Forms.ComboBox day;
    }
}

