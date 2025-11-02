using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.AddUser();
        }

        private void dyn_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.AddUser2(label_username.Text, label_password.Text);
        }
    }
}
