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
    public partial class CarRecord : Form
    {
        kirvem_rentacar rentacar = new kirvem_rentacar();

        public CarRecord()
        {
            InitializeComponent();
        }

        private void bttnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

                else if (brandcmb.SelectedIndex==1)
                {
                    seriecmb.Items.Add("Doblo");
                    seriecmb.Items.Add("Egea");
                    seriecmb.Items.Add("Linea");
                }


                else if (brandcmb.SelectedIndex==2)
                {
                    seriecmb.Items.Add("Astra");
                    seriecmb.Items.Add("Combo");
                    seriecmb.Items.Add("Vectra");

                }
                else if (brandcmb.SelectedIndex==3)
                {
                    seriecmb.Items.Add("Primera");
                    seriecmb.Items.Add("Almera");
                    seriecmb.Items.Add("Sentra");

                }
                else if (brandcmb.SelectedIndex==4)
                {
                    seriecmb.Items.Add("Civic");
                    seriecmb.Items.Add("City");
                    seriecmb.Items.Add("Accord");

                }
                else if (brandcmb.SelectedIndex==5)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into car(numberplate,brand,serie,year,color,km,fuel,price,picture,date,position) values(@numberplate,@brand,@serie,@year,@color,@km,@fuel,@price,@picture,@date,@position) ";           
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@numberplate", numberplatetxt.Text);
            komut2.Parameters.AddWithValue("@brand", brandcmb.Text);
            komut2.Parameters.AddWithValue("@serie", seriecmb.Text);
            komut2.Parameters.AddWithValue("@year", yeartxt.Text);
            komut2.Parameters.AddWithValue("@color", colortxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@fuel", fuelcmb.Text);
            komut2.Parameters.AddWithValue("@price", int.Parse(pricetxt.Text));
            komut2.Parameters.AddWithValue("@picture", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@position", "EMPTY");
            rentacar.add_delete_update(komut2, cümle);
            seriecmb.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = " ";

        }

        private void CarRecord_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
} 
