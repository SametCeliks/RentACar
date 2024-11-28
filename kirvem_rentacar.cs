using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_carBitirmeproje
{
    class kirvem_rentacar
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TSAR6EO\\SQLEXPRESS01;Initial Catalog=kirvem_rentacar;Integrated Security=True");
        DataTable tablo;

        public void add_delete_update(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable Listt(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Empty_Cars(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["numberplate"].ToString());
            }
            baglanti.Close();
        }
        public void TC_SEARCH(TextBox tcsearch, TextBox tc, TextBox Namesurname, TextBox phonenumber, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tcno"].ToString();
                Namesurname.Text = read["namesurname"].ToString();
                phonenumber.Text = read["phonenumber"].ToString();

            }
            baglanti.Close();
        }
        public void price_calculate(ComboBox cmbrenttype,TextBox pprice, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {

                if (cmbrenttype.SelectedIndex == 0) pprice.Text = (int.Parse(read["price"].ToString()) * 1).ToString();
                if (cmbrenttype.SelectedIndex == 1) pprice.Text = (int.Parse(read["price"].ToString()) * 0.80).ToString();
                if (cmbrenttype.SelectedIndex == 2) pprice.Text = (int.Parse(read["price"].ToString()) * 0.70).ToString();





            }
            baglanti.Close();
        }
        public void takecmb(ComboBox Cars, TextBox brand, TextBox serie, TextBox year, TextBox color, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                brand.Text = read["brand"].ToString();
                serie.Text = read["serie"].ToString();
                year.Text = read["year"].ToString();
                color.Text = read["color"].ToString();

            }
            baglanti.Close();
        }

        public void salescalculate( Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(total) from sales",baglanti);
            lbl.Text = "Toplam Tutar=" +komut.ExecuteScalar()+ " TL";
            baglanti.Close();
           
         
        }

    }
}
