using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_carBitirmeproje
{
    public partial class showcustomer : Form
    {
        kirvem_rentacar kirvem_Rentacar = new kirvem_rentacar();
        public showcustomer()
        {
            InitializeComponent();
        }

        private void showcustomer_Load(object sender, EventArgs e)
        {
            returnnlist();
        }

        private void returnnlist()
        {
            string cümle = "select * from customer";
            SqlDataAdapter adtr2 = new SqlDataAdapter();           
            dataGridView1.DataSource = kirvem_Rentacar.Listt(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TCNO";
            dataGridView1.Columns[1].HeaderText = "NAME-SURNAME";
            dataGridView1.Columns[2].HeaderText = "PHONE NUMBER";
            dataGridView1.Columns[3].HeaderText = "ADDRESS";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from customer where tcno like '%"+textBox1.Text +"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();          
            dataGridView1.DataSource = kirvem_Rentacar.Listt(adtr2, cümle);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
           
            string cümle = "update customer set namesurname=@namesurname, phonenumber=@phonenumber, address=@address, email=@email where tcno=@tcno ";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNamesurname.Text);
            komut2.Parameters.AddWithValue("@phonenumber", txtPhonenumber.Text);
            komut2.Parameters.AddWithValue("@address", txtAddress.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            kirvem_Rentacar.add_delete_update(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            returnnlist();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtNamesurname.Text = satır.Cells[1].Value.ToString();
            txtPhonenumber.Text = satır.Cells[2].Value.ToString();
            txtAddress.Text = satır.Cells[3].Value.ToString();
            txtEmail.Text = satır.Cells[4].Value.ToString();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from customer where tcno='" + satır.Cells["tcno"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            kirvem_Rentacar.add_delete_update(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            returnnlist();
        }

        private void dataGridView1_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
