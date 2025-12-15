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
        public ChangeQuest(string name, string day, string place, int id)
        {
            InitializeComponent();

            name_textbox.Text = name;
            day_textbox.Text = day;
            place_textbox.Text = place;

        }
    }
}
