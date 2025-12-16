namespace WindowsForm
{
    partial class ChangeQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeQuest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save_changes = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.day_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.place_textbox = new System.Windows.Forms.TextBox();
            this.day_textbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // save_changes
            // 
            this.save_changes.Location = new System.Drawing.Point(192, 421);
            this.save_changes.Margin = new System.Windows.Forms.Padding(4);
            this.save_changes.Name = "save_changes";
            this.save_changes.Size = new System.Drawing.Size(175, 52);
            this.save_changes.TabIndex = 1;
            this.save_changes.Text = "Сохранить изменения";
            this.save_changes.UseVisualStyleBackColor = true;
            this.save_changes.Click += new System.EventHandler(this.save_changes_Click);
            // 
            // name_text
            // 
            this.name_text.AutoSize = true;
            this.name_text.Location = new System.Drawing.Point(699, 249);
            this.name_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(121, 16);
            this.name_text.TabIndex = 2;
            this.name_text.Text = "Название квеста";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(703, 268);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(293, 22);
            this.name_textbox.TabIndex = 3;
            // 
            // day_text
            // 
            this.day_text.AutoSize = true;
            this.day_text.Location = new System.Drawing.Point(699, 332);
            this.day_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day_text.Name = "day_text";
            this.day_text.Size = new System.Drawing.Size(90, 16);
            this.day_text.TabIndex = 2;
            this.day_text.Text = "День недели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Место квеста";
            // 
            // place_textbox
            // 
            this.place_textbox.Location = new System.Drawing.Point(703, 448);
            this.place_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.place_textbox.Name = "place_textbox";
            this.place_textbox.Size = new System.Drawing.Size(293, 22);
            this.place_textbox.TabIndex = 3;
            // 
            // day_textbox
            // 
            this.day_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_textbox.FormattingEnabled = true;
            this.day_textbox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.day_textbox.Location = new System.Drawing.Point(703, 352);
            this.day_textbox.Name = "day_textbox";
            this.day_textbox.Size = new System.Drawing.Size(293, 24);
            this.day_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Добавить описание к квесту:";
            // 
            // tips
            // 
            this.tips.Location = new System.Drawing.Point(702, 48);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(294, 198);
            this.tips.TabIndex = 7;
            this.tips.Text = "";
            // 
            // ChangeQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day_textbox);
            this.Controls.Add(this.place_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.day_text);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.save_changes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeQuest";
            this.Text = "Редактор квеста";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save_changes;
        private System.Windows.Forms.Label name_text;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label day_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox place_textbox;
        private System.Windows.Forms.ComboBox day_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tips;
    }
}