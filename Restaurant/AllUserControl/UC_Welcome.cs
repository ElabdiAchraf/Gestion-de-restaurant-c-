using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.AllUserControl
{
    public partial class UC_Welcome : UserControl
    {
        function fn = new function();
        String query;
        String query2;
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {

        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            query = " SELECT COUNT(*)  from serveur";

            DataSet ds = fn.getData(query);
            guna2Button1.Text = "serveurs                           \n \n \n" + "                                        " + ds.Tables[0].Rows[0][0].ToString();
            //guna2Button1.Text = "5555";
            query2 = " SELECT COUNT(*)  from items";
            DataSet ds2 = fn.getData(query2);
            guna2Button2.Text = "items                           \n \n \n" + "                                        " + ds2.Tables[0].Rows[0][0].ToString();

            query2 = " SELECT COUNT(*)  from orders";
            DataSet ds3 = fn.getData(query2);
            guna2Button3.Text = "total orders                           \n \n \n" + "                                        " + ds3.Tables[0].Rows[0][0].ToString();

            query2 = " SELECT  SUM(priceTotale) from orders";
            DataSet ds4 = fn.getData(query2);
            guna2Button4.Text = "total mount                      \n \n " + "                                                     " + ds4.Tables[0].Rows[0][0].ToString()+"DH";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
