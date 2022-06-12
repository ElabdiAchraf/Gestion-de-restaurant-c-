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
    public partial class UC_Additems : UserControl
    {
        function fn = new function();
        String query;
        public UC_Additems()
        {
            InitializeComponent();
        }

        private void UC_Additems_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name_item,category,price) values ('"+txtItemName.Text+"','" +txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_Additems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
