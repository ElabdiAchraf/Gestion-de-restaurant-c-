using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnAddServer.Hide();
                btnRemoveItems.Hide();
                btnUpdateItems.Hide();
            }
            else if(user == "Admin")
            {
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_AddServer1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1 .BringToFront();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            uC_AddServer1.Visible = true;
            uC_AddServer1.BringToFront();
        }
    }
}
