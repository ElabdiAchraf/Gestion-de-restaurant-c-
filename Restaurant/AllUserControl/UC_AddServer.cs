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
    public partial class UC_AddServer : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddServer()
        {
            InitializeComponent();
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            query = "select * from serveur";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        protected int n,id;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            query = "insert into serveur (num_Table,nbr_place,nom_serv,prenom_serveur) values ("+comboNumTable.Text+"," +labelNbrPlace.Text+ ",'" +labelName.Text+ "','" +labelPrenom.Text+"')";
            fn.setData(query);
            loadData();


            clearAll();



            //n = guna2DataGridView1.Rows.Add();
            //guna2DataGridView1.Rows[n].Cells[0].Value = comboNumTable.Text;
            //guna2DataGridView1.Rows[n].Cells[1].Value = labelNbrPlace.Text;
            //guna2DataGridView1.Rows[n].Cells[2].Value = labelName.Text;
            //guna2DataGridView1.Rows[n].Cells[3].Value = labelPrenom.Text




        }
        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            String Prenom = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String numTable = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String nbrPlace = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            labelName.Text = name;
            labelPrenom.Text = Prenom;
            comboNumTable.Text = numTable;
            labelNbrPlace.Text = nbrPlace;
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from serveur where num_Table like'" + txtSearchNbr.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_AddServer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboNumTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelNbrPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[n].Cells[0].Value.ToString());
                query = "delete from serveur where num_Table=" + comboNumTable.Text +"";
                fn.setData(query);
                loadData();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                int id = int.Parse(guna2DataGridView1.Rows[n].Cells[0].Value.ToString());
                query = "update serveur set num_Table = "+ comboNumTable.Text + ",nbr_place = " + labelNbrPlace.Text + ",nom_serv='" + labelName.Text + "',prenom_serveur='" + labelPrenom.Text + "'where id_serv = " + id + "";

                fn.setData(query);
                loadData();

                clearAll();
            }
        }

        public void clearAll()
        {
            comboNumTable.SelectedIndex = -1;
            labelNbrPlace.Clear();
            labelName.Clear();
            labelPrenom.Clear();
        }
    }
}
