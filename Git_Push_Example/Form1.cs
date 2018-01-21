using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Git_Push_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (btnNo.Text == "Yes")
            {
                MessageBox.Show("I know that!!!");
                this.Close();
            }
            if (btnNo.Text == "No")
            {
                btnNo.Text = "Yes";
                btnYes.Text = "No";
            }               
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (btnYes.Text == "Yes")
            {
                MessageBox.Show("I know that!!!");
                this.Close();
            }
            if (btnYes.Text == "No")
            {                
                btnYes.Text = "Yes";
                btnNo.Text = "No";
            }
        }
    }
}
