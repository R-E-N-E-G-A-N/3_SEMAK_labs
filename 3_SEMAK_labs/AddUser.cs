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

namespace _3_SEMAK_labs
{
    public partial class AddUser : Form
    {

        Logic Logic { get; set; }
        public AddUser()
        {
            InitializeComponent();
            Logic = new Logic();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Logic.AddGamer(UserName_textbox.Text, IQ_textbox.Text, Balance_textbox.Text);
            Users_list.Items.Clear();
            foreach (string s in Logic.GetAll())
            {

                Users_list.Items.Add(s);

            }

        }
    }
}