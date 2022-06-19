using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Restaurant.AllUserControl
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            query = "select name_item from items where category='" + category + "'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            query = "select name_item from items where category='" + category + "' and name_item like '" +txtSearch.Text+"%'";
            showItemList(query);
        }
        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQauntityUpDown.ResetText();
            txtTotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItername.Text = text;
            query= "select price from items where name_item = '"+text+"'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtQauntityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQauntityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();

        }
        protected int n, total = 0;
        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }

            total -= amount;
            labelTotalAmount.Text = "" + total + " DHS";
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title= "Facture";
            printer.SubTitle =string.Format( DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            printer.PrinterName= "Prix Total: " + labelTotalAmount.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer= "Prix Totat: "+labelTotalAmount.Text;
            printer.FooterSpacing=1;
            printer.PrintDataGridView(guna2DataGridView1);
            

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "" + total + " DHS";

        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text= string.Format(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddtocard_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text!= "0" && txtTotal.Text != "") {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItername.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQauntityUpDown.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "" + total + " DHS";

                query = "insert into orders (name_item,quantity,priceTotale) values ('" + txtItername.Text + "','" + txtQauntityUpDown.Text + "'," + txtTotal.Text + ")";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("la quantite minimum doit etre 1 :", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
