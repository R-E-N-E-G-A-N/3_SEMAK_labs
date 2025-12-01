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

                if (USERSdataGridView.Rows.Count > 0)
                {

                    var user_row = new DataGridViewRow();

                    foreach (DataGridViewRow row in USERSdataGridView.Rows)
                    {

                        if (row.Cells[0].Value.ToString() == UserName_textbox.Text)
                        {

                            user_row = row;
                            break;

                        }

                    }
                    if (Logic.CheckUser(user_row.Cells[0].Value.ToString()))
                    {

                        Logic.ChangeUser(user_row.Cells[0].Value.ToString(), Int32.Parse(user_row.Cells[1].Value.ToString()), Int32.Parse(user_row.Cells[2].Value.ToString()));
                        USERSdataGridView.Rows.Clear();
                        foreach (string s in Logic.GetAll())
                        {

                            var list = s.Split(' ');
                            USERSdataGridView.Rows.Add(list[0], list[1], list[2]);

                        }

                    }

                }
                else
                {

                    Logic.AddGamer(UserName_textbox.Text, IQ_trackBar.Value, tempBalance);
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

        private void USERSdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
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