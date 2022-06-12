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
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location = new Point(29, 376);
                labelBanner.ForeColor = Color.OrangeRed;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(266, 376);
                labelBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(459, 376);
                labelBanner.ForeColor = Color.MidnightBlue;
                num =0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
