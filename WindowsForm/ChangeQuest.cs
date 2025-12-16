using BuisnessLogic;
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
    public partial class ChangeQuest : Form
    {

        Logic Logic;

        int ID;

        public ChangeQuest(string name, string day, string place, int id, Logic logic)
        {
            InitializeComponent();

            name_textbox.Text = name;
            day_textbox.Text = day;
            place_textbox.Text = place;
            ID = id;
            Logic = logic;
            tips.Text = logic.GetTip(id);

        }

        private void save_changes_Click(object sender, EventArgs e)
        {

            if (name_textbox.Text != null && day_textbox.Text != null && place_textbox.Text != null) 
            {

                Logic.ChangeQuest(name_textbox.Text, day_textbox.Text, place_textbox.Text, ID);
                Logic.AddTip(tips.Text, ID);
                new BackgroundMusicPlayer().PlaySimple(@"save1.mp3");
                this.Close();
            
            }
            else 
            {

                MessageBox.Show("Неккоретно введены данные!");
            
            }

        }
    }
}
