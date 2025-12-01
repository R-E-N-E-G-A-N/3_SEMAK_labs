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
            foreach (string s in logic.GetAll()) 
            {
            
                var list = s.Split(' ');
                USERSdataGridView.Rows.Add(list[0], list[1], list[2]);

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if(Int32.TryParse(Balance_textbox.Text, out int tempBalance)) 
            {

                string user = UserName_textbox.Text + " " + IQ_trackBar.Value.ToString() + " " + Balance_textbox.Text;

                if (Logic.GetAll().Contains(user))
                {

                    MessageBox.Show("Пользователь с таким ником уже введен в систему!");

                }
                else
                {

                    Logic.AddUser(UserName_textbox.Text, IQ_trackBar.Value, tempBalance);
                    USERSdataGridView.Rows.Add(UserName_textbox.Text, IQ_trackBar.Value, tempBalance);

                }

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

        private void button2_Click(object sender, EventArgs e)
        {

            if (USERSdataGridView.SelectedRows.Count != 0)
            {

                var selected_row = USERSdataGridView.SelectedRows[0];
                Logic.DeleteUser(selected_row.Cells[0].Value.ToString());
                USERSdataGridView.Rows.Clear();
                foreach (string s in Logic.GetAll())
                {

                    var list = s.Split(' ');
                    USERSdataGridView.Rows.Add(list[0], list[1], list[2]);

                }

            }

        }

    }
}