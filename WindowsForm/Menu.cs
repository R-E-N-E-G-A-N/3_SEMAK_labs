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

        BackgroundMusicPlayer sounds = new BackgroundMusicPlayer();

        Logic logic = new Logic();
        SortLogic sortlogic = new SortLogic();

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
            place_sort.Items.Add("");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quest_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_quest_button_Click(object sender, EventArgs e)
        {

            quest_datagrid.RowsAdded += (s, args) =>
            {

                foreach (DataGridViewRow row in quest_datagrid.Rows)
                {

                    var cells = row.Cells;
                    if (place_sort.Items.Contains(cells[2].Value))
                    {

                        continue;

                    }
                    else
                    {

                        place_sort.Items.Add(cells[2].Value.ToString());

                    }

                }

            };

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
                    sounds.Stop();
                    sounds.PlaySimple(@"add1.mp3");

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

        private void delete_quest_button_Click(object sender, EventArgs e)
        {

            if (quest_datagrid.SelectedCells.Count > 0)
            {

                int id = 0;
                foreach (string s in logic.GetAll())
                {

                    var list = s.Split('.');
                    if (quest_datagrid.SelectedCells[0].Value.ToString() == list[0])
                    {

                        id = Int32.Parse(list[3]);
                        logic.DeleteQuest(id);

                        quest_datagrid.Rows.Clear();
                        if (day_sort.Text == "" && place_sort.Text == "")
                        {

                            foreach (string s1 in logic.GetAll())
                            {

                                var list1 = s1.Split('.');
                                quest_datagrid.Rows.Add(list1[0], list1[1], list1[2]);

                            }
                        }
                        else 
                        {

                            if (place_sort.Text != "")
                            {

                                quest_datagrid.Rows.Clear();
                                foreach (string s2 in sortlogic.Sort(logic.GetAll(), place_sort.Text))
                                {

                                    var list2 = s.Split('.');
                                    quest_datagrid.Rows.Add(list2[0], list2[1], list2[2]);

                                }

                            }
                            else 
                            {

                                quest_datagrid.Rows.Clear();
                                foreach (string s2 in sortlogic.Sort(logic.GetAll(), day_sort.Text))
                                {

                                    var list2 = s.Split('.');
                                    quest_datagrid.Rows.Add(list2[0], list2[1], list2[2]);

                                }

                            }

                        }
                        break;
                    }

                }
                sounds.Stop();
                sounds.PlaySimple(@"delete1.mp3");

            }
            else 
            {

                MessageBox.Show("Сначала выделите клетку!");
            
            }

        }

        private void day_sort_SelectedIndexChanged(object sender, EventArgs e)
        {

            place_sort.MouseClick += (s, args) => day_sort.Text = "";

            quest_datagrid.Rows.Clear();
            foreach (string s in sortlogic.Sort(logic.GetAll(), day_sort.Text)) 
            {
            
                var list = s.Split('.');
                quest_datagrid.Rows.Add(list[0], list[1], list[2]);
            
            }

        }

        private void place_sort_SelectedIndexChanged(object sender, EventArgs e)
        {

            day_sort.MouseClick += (s, args) => place_sort.Text = "";

            quest_datagrid.Rows.Clear();
            foreach (string s in sortlogic.Sort(logic.GetAll(), place_sort.Text))
            {

                var list = s.Split('.');
                quest_datagrid.Rows.Add(list[0], list[1], list[2]);

            }

        }

        private void dude_Click(object sender, EventArgs e)
        {

            sounds.Stop();
            sounds.PlaySimple(@"dude1.mp3");

        }
    }
}
