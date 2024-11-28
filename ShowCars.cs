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
    public partial class ShowCars : Form
    {
        kirvem_rentacar rentacar = new kirvem_rentacar();
        public ShowCars()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            numberplatetxt.Text = satır.Cells["numberplate"].Value.ToString();
            brandcmb.Text = satır.Cells["brand"].Value.ToString();
            seriecmb.Text = satır.Cells["serie"].Value.ToString();
            yeartxt.Text = satır.Cells["year"].Value.ToString();
            colortxt.Text = satır.Cells["color"].Value.ToString();
            kmtxt.Text = satır.Cells["km"].Value.ToString();
            fuelcmb.Text = satır.Cells["fuel"].Value.ToString();
            pricetxt.Text = satır.Cells["price"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["picture"].Value.ToString();

        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            string cümle = "update car set brand=@brand, serie=@serie, year=@year, color=@color, km=@km, fuel=@fuel, price=@price, picture=@picture, date=@date where numberplate=@numberplate";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@numberplate", numberplatetxt.Text);
            komut2.Parameters.AddWithValue("@brand", brandcmb.Text);
            komut2.Parameters.AddWithValue("@serie", seriecmb.Text);
            komut2.Parameters.AddWithValue("@year", yeartxt.Text);
            komut2.Parameters.AddWithValue("@color", colortxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@fuel", fuelcmb.Text);
            komut2.Parameters.AddWithValue("@price", int.Parse(pricetxt.Text));
            komut2.Parameters.AddWithValue("@picture", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            rentacar.add_delete_update(komut2, cümle);
            seriecmb.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = " ";
            refreshcarlist();
        }

        private void numberplatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowCars_Load(object sender, EventArgs e)
        {
            refreshcarlist();
            try
            {
                cmbCars.SelectedIndex = 0;
            }
            catch
            {

            }

        }

        private void refreshcarlist()
        {
            string cümle = "select * from car";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource= rentacar.Listt(adtr2, cümle);
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from car where numberplate = '" + satır.Cells["numberplate"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            rentacar.add_delete_update(komut2, cümle);
            pictureBox2.ImageLocation = " ";
            refreshcarlist();
            seriecmb.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brandcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                seriecmb.Items.Clear();
                if (brandcmb.SelectedItem.ToString() == "Renault")
                {
                    seriecmb.Items.Add("Megane");
                    seriecmb.Items.Add("Talisman");
                    seriecmb.Items.Add("Fluence");
                }

                else if (brandcmb.SelectedIndex == 1)
                {
                    seriecmb.Items.Add("Doblo");
                    seriecmb.Items.Add("Egea");
                    seriecmb.Items.Add("Linea");
                }


                else if (brandcmb.SelectedIndex == 2)
                {
                    seriecmb.Items.Add("Astra");
                    seriecmb.Items.Add("Combo");
                    seriecmb.Items.Add("Vectra");

                }
                else if (brandcmb.SelectedIndex == 3)
                {
                    seriecmb.Items.Add("Primera");
                    seriecmb.Items.Add("Almera");
                    seriecmb.Items.Add("Sentra");

                }
                else if (brandcmb.SelectedIndex == 4)
                {
                    seriecmb.Items.Add("Civic");
                    seriecmb.Items.Add("City");
                    seriecmb.Items.Add("Accord");

                }
                else if (brandcmb.SelectedIndex == 5)
                {
                    seriecmb.Items.Add("Focus");
                    seriecmb.Items.Add("Fiesta");
                    seriecmb.Items.Add("Mondeo");

                }
            }
            catch
            {

            }
        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbCars.SelectedIndex==0)
                {
                    refreshcarlist();
                }
                if (cmbCars.SelectedIndex == 1)
                {
                    string cümle = "select * from car where position='EMPTY'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacar.Listt(adtr2, cümle);
                }
                if (cmbCars.SelectedIndex == 2)
                {
                    string cümle = "select * from car where position='FULL'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacar.Listt(adtr2, cümle);
                }


            }
            catch
            {

            }
        }
    }
}
