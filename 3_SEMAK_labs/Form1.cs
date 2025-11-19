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
    public partial class Form1 : Form
    {

        Logic Logic { get; set; }
        public Form1()
        {
            InitializeComponent();
            Logic = new Logic();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddUser form = new AddUser(Logic);
            form.ShowDialog();

        }
    }
}
