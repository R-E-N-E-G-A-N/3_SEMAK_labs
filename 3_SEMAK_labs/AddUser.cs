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
using System.Xml;

namespace _3_SEMAK_labs
{
    public partial class AddUser : Form
    {

        Logic Logic { get; set; }
        public AddUser(Logic logic)
        {
            InitializeComponent();
            Logic = logic;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if(Int32.TryParse(Balance_textbox.Text, out int tempBalance)) 
            {


                Logic.AddUser(UserName_textbox.Text, IQ_trackBar.Value, tempBalance);
                USERSdataGridView.Refresh();


            }
            else 
            {

                MessageBox.Show("неправильно введено значение баланса!");
            
            }

        }

        private void IQ_trackBar_Scroll(object sender, EventArgs e)
        {

            IQ_label.Text = $"{IQ_trackBar.Value}";

        }

        private void UserslistView_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void USERSdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}