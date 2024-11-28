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
    public partial class AddCustomer : Form
    {
        kirvem_rentacar Kirvem_Rentacar = new kirvem_rentacar();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into customer (tcno,namesurname,phonenumber,address,email) values (@tcno,@namesurname,@phonenumber,@address,@email) ";
                SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tcno",txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNamesurname.Text);
            komut2.Parameters.AddWithValue("@phonenumber", txtPhonenumber.Text);
            komut2.Parameters.AddWithValue("@address", txtAddress.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            Kirvem_Rentacar.add_delete_update(komut2, cümle);
            string message = "Adding Successfuly";
            string title = "Great";
            MessageBox.Show(message, title);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
