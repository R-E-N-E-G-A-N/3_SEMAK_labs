using BuisnessLogic;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Menu : Form
    {

        Logic logic = new Logic();

        public Menu()
        {

            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            new BackgroundMusicPlayer().PlayBackgroundMusicAsync(@"music.mp3", true);
            foreach (string s in logic.GetAll())
            {
            
                var list = s.Split(' ');
                quest_datagrid.Rows.Add(list);
            
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quest_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_quest_button_Click(object sender, EventArgs e)
        {

            if (name.Text != "" && day.Text != "" && place.Text != "")
            {
                
                int count = 0;
                foreach (string s in logic.GetAll())
                {

                    var list = s.Split('.');
                    if (name.Text == list[0]) { count++; }

                }
                if (count == 0)
                {

                    logic.AddQuest(name.Text, day.Text, place.Text);
                    quest_datagrid.Rows.Clear();
                    foreach (string s in logic.GetAll())
                    {

                        var list = s.Split('.');
                        quest_datagrid.Rows.Add(list[0], list[1], list[2]);

                    }

                }
                else 
                {

                    MessageBox.Show("Такой квест уже существует!");
                
                }

            }
            else 
            {

                MessageBox.Show("Неккоретно введены данные!");
            
            }

        }

        private void change_quest_button_Click(object sender, EventArgs e)
        {

            if (quest_datagrid.SelectedRows.Count == 0)
            {

                MessageBox.Show("Сначала выделите квест!");

            }
            else
            {

                int id = 0;
                foreach (string s in logic.GetAll()) 
                {

                    var list = s.Split('.');
                    if (quest_datagrid.SelectedCells[0].Value.ToString() == list[0]) 
                    {
                    
                        id = Int32.Parse(list[3]);
                        break;
                    
                    }
                
                }

                this.Hide();
                Form form = new ChangeQuest(quest_datagrid.SelectedCells[0].Value.ToString(), quest_datagrid.SelectedCells[1].Value.ToString(), quest_datagrid.SelectedCells[2].Value.ToString(), id, logic);
                form.FormClosed += (s, args) => this.Show();
                form.FormClosed += (s, args) => 
                {
                
                    quest_datagrid.Rows.Clear();
                    foreach (string quest in logic.GetAll()) 
                    {
                    
                        var list = quest.Split('.');
                        quest_datagrid.Rows.Add(list[0], list[1], list[2]);

                    }
                
                };
                form.ShowDialog();

            }

        }
    }
}
