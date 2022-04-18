using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblback1.Hide();
            lblback2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void lblMultClassico_Click(object sender, EventArgs e)
        {
            if(lblMultClassico.Text != "Online")
            {
                lblMultClassico.Text = "Online";
                lblSingleClassico.Text = "Local";
                lblback1.Show();
            }
            else
            {

            }
        }

        private void lblMultSuper_Click(object sender, EventArgs e)
        {
            if (lblMultSuper.Text != "Online")
            {
                lblMultSuper.Text = "Online";
                lblSingleSuper.Text = "Local";
                lblback2.Show();
            }
            else
            {

            }
            
        }

        private void lblback1_Click(object sender, EventArgs e)
        {
            lblMultClassico.Text = "Multiplayer";
            lblSingleClassico.Text = "Online";
            lblback1.Hide();

        }
    }
}
