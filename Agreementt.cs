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
    public partial class Agreementt : Form
    {
        public Agreementt()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from car where numberplate like '" + cmbCars.SelectedItem + "'";
            car.takecmb(cmbCars, txtbrand, txtserie, txtyear, txtcolor, sorgu2 );
        }
        kirvem_rentacar car = new kirvem_rentacar();
        private void Agreementt_Load(object sender, EventArgs e)
        {
            Empty_Cars();
            refresh();

        }

        private void Empty_Cars()
        {
            string sorgu2 = "select * from car where position ='EMPTY'";
            car.Empty_Cars(cmbCars, sorgu2);
        }

        private void refresh()
        {
            string sorgu3 = "select * from agreement ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = car.Listt(adtr2, sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbrenttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from car where numberplate like '" + cmbCars.SelectedItem + "'";
            car.price_calculate(cmbrenttype, txtrentprice, sorgu2);
        }

        private void bttncalculate_Click(object sender, EventArgs e)
        {
            TimeSpan day = DateTime.Parse(datereturn.Text) - DateTime.Parse(dateexit.Text);
            int day2 = day.Days;
            txtday.Text = day2.ToString();
            txttotal.Text = (day2 * int.Parse(txtrentprice.Text)).ToString();
        }

        private void bttnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dateexit.Text = DateTime.Now.ToShortDateString();
            datereturn.Text = DateTime.Now.ToShortDateString();
            cmbrenttype.Text = "";
            txtrentprice.Text = "";
            txtday.Text = "";
            txttotal.Text = "";
        }

        private void bttnadd_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into agreement (tc, namesurname, phonenumber, dlicense, dl_date, dl_place, numberplate, brand, serie, year, color, rent_type, rent_price, day, total, exdate, returndate) values(@tc, @namesurname, @phonenumber, @dlicense, @dl_date, @dl_place, @numberplate, @brand, @serie, @year, @color, @rent_type, @rent_price, @day, @total, @exdate, @returndate)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNamesurname.Text);
            komut2.Parameters.AddWithValue("@phonenumber", txtPhonenumber.Text);
            komut2.Parameters.AddWithValue("@dlicense", txtdl_no.Text);
            komut2.Parameters.AddWithValue("@dl_date", txtdl_date.Text);
            komut2.Parameters.AddWithValue("@dl_place", txtdl_place.Text);
            komut2.Parameters.AddWithValue("@numberplate", cmbCars.Text);
            komut2.Parameters.AddWithValue("@brand", txtbrand.Text);
            komut2.Parameters.AddWithValue("@serie", txtserie.Text);
            komut2.Parameters.AddWithValue("@year", txtyear.Text);
            komut2.Parameters.AddWithValue("@color", txtcolor.Text);
            komut2.Parameters.AddWithValue("@rent_type", cmbrenttype.Text);
            komut2.Parameters.AddWithValue("@rent_price", int.Parse(txtrentprice.Text));
            komut2.Parameters.AddWithValue("@day", int.Parse(txtday.Text));
            komut2.Parameters.AddWithValue("@total", int.Parse(txttotal.Text));
            komut2.Parameters.AddWithValue("@exdate", dateexit.Text);
            komut2.Parameters.AddWithValue("@returndate", datereturn.Text);
            car.add_delete_update(komut2, sorgu2);
            string sorgu3 = "update car set position = 'FULL' where numberplate= '" +cmbCars.Text +"'";
            SqlCommand komut3 = new SqlCommand();
            car.add_delete_update(komut3, sorgu3);
            cmbCars.Items.Clear();
            Empty_Cars();
            refresh();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbCars.Text = ""; 
            Clear();
            MessageBox.Show("Agreement succesful!");
        }

        private void txtTcSerarch_TextChanged(object sender, EventArgs e)
        {
            if (txtTcSerarch.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from customer where tcno like '" + txtTcSerarch.Text + "'";
            car.TC_SEARCH(txtTcSerarch, txtTc, txtNamesurname, txtPhonenumber, sorgu2);
        }

        private void bttnupdate_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update agreement set tc=@tc, namesurname=@namesurname, phonenumber=@phonenumber, dlicense=@dlicense, dl_date=@dl_date, dl_place=@dl_place,numberplate=@numberplate, brand=@brand, serie=@serie, year=@year, color=@color, rent_type=@rent_type, rent_price=@rent_price, day=@day, total=@total, exdate=@exdate, returndate=@returndate where numberplate=@numberplate";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNamesurname.Text);
            komut2.Parameters.AddWithValue("@phonenumber", txtPhonenumber.Text);
            komut2.Parameters.AddWithValue("@dlicense", txtdl_no.Text);
            komut2.Parameters.AddWithValue("@dl_date", txtdl_date.Text);
            komut2.Parameters.AddWithValue("@dl_place", txtdl_place.Text);
            komut2.Parameters.AddWithValue("@numberplate", cmbCars.Text);
            komut2.Parameters.AddWithValue("@brand", txtbrand.Text);
            komut2.Parameters.AddWithValue("@serie", txtserie.Text);
            komut2.Parameters.AddWithValue("@year", txtyear.Text);
            komut2.Parameters.AddWithValue("@color", txtcolor.Text);
            komut2.Parameters.AddWithValue("@rent_type", cmbrenttype.Text);
            komut2.Parameters.AddWithValue("@rent_price", int.Parse(txtrentprice.Text));
            komut2.Parameters.AddWithValue("@day", int.Parse(txtday.Text));
            komut2.Parameters.AddWithValue("@total", int.Parse(txttotal.Text));
            komut2.Parameters.AddWithValue("@exdate", dateexit.Text);
            komut2.Parameters.AddWithValue("@returndate", datereturn.Text);
            car.add_delete_update(komut2, sorgu2);
            
            cmbCars.Items.Clear();
            Empty_Cars();
            refresh();
      
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbCars.Text = "";
            Clear();
            MessageBox.Show("Agreement updated!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtNamesurname.Text = satır.Cells[1].Value.ToString();
            txtPhonenumber.Text = satır.Cells[2].Value.ToString();
            txtdl_no.Text = satır.Cells[3].Value.ToString();
            txtdl_date.Text = satır.Cells[4].Value.ToString();
            txtdl_place.Text = satır.Cells[5].Value.ToString();
            cmbCars.Text = satır.Cells[6].Value.ToString();
            txtbrand.Text = satır.Cells[7].Value.ToString();
            txtserie.Text = satır.Cells[8].Value.ToString();
            txtyear.Text = satır.Cells[9].Value.ToString();
            txtcolor.Text = satır.Cells[10].Value.ToString();
            cmbrenttype.Text = satır.Cells[11].Value.ToString();
            txtrentprice.Text = satır.Cells[12].Value.ToString();
            txtday.Text = satır.Cells[13].Value.ToString();
            txttotal.Text = satır.Cells[14].Value.ToString();
            dateexit.Text = satır.Cells[15].Value.ToString();
            datereturn.Text = satır.Cells[16].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //gün farkı hesaplaycak
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime ret = DateTime.Parse(satır.Cells["returndate"].Value.ToString());
            int price = int.Parse(satır.Cells["rent_price"].Value.ToString());
            TimeSpan daygap = today - ret;
            int _daygap = daygap.Days;
            int pricegap;
            //ücret farkı değişkeni
            pricegap = _daygap * price;
            txtExtra.Text = pricegap.ToString();
            //toplam tutarı hesaplaması için
        }

        private void bttntakecar_Click(object sender, EventArgs e)
        {
            if (txtExtra.Text!="")
            {

                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
                int price = int.Parse(satır.Cells["rent_price"].Value.ToString());
                int total = int.Parse(satır.Cells["total"].Value.ToString());
                DateTime ex = DateTime.Parse(satır.Cells["exdate"].Value.ToString());
                TimeSpan day = today - ex;
                int _day = day.Days;
                int totalprice = _day * price;
                string sorgu1 = "delete from agreement where numberplate= '" + satır.Cells["numberplate"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                car.add_delete_update(komut, sorgu1);
                string sorgu2= "update car set position = 'EMPTY' where numberplate='"+satır.Cells["numberplate"].Value.ToString()+"' ";
                SqlCommand komut3 = new SqlCommand();
                car.add_delete_update(komut3, sorgu2);

                string sorgu3 = "insert into sales (tc, namesurname, numberplate, brand, serie, year, color, day, total, date1, date2, price) values(@tc, @namesurname, @numberplate, @brand, @serie, @year, @color, @day, @total, @date1, @date2, @price)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@namesurname", satır.Cells["namesurname"].Value.ToString());
                
                komut2.Parameters.AddWithValue("@numberplate", satır.Cells["numberplate"].Value.ToString());
                komut2.Parameters.AddWithValue("@brand", satır.Cells["brand"].Value.ToString());
                komut2.Parameters.AddWithValue("@serie", satır.Cells["serie"].Value.ToString());
                komut2.Parameters.AddWithValue("@year", satır.Cells["year"].Value.ToString());
                komut2.Parameters.AddWithValue("@color", satır.Cells["color"].Value.ToString());
                
                komut2.Parameters.AddWithValue("@day", _day);
                komut2.Parameters.AddWithValue("@total", totalprice);
                komut2.Parameters.AddWithValue("@date1", satır.Cells["exdate"].Value.ToString());
                komut2.Parameters.AddWithValue("@date2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@price", price);

                car.add_delete_update(komut2, sorgu3);

                MessageBox.Show("Car has been taked");
                cmbCars.Text = "";
                cmbCars.Items.Clear();
                Empty_Cars();
                refresh();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                cmbCars.Text = "";
                Clear();


                txtExtra.Text = "";
            }

            else if (txtExtra.Text == "")
            {
                MessageBox.Show("Please Choose", "Wrong!");
            }
        }
    }
}
