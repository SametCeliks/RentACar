using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_carBitirmeproje
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();
                

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showcustomer listt = new showcustomer();
            listt.ShowDialog();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarRecord save = new CarRecord();
            save.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowCars list = new ShowCars();
            list.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agreementt agreement = new Agreementt();
            agreement.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmsales SALES = new frmsales();
            SALES.ShowDialog();


        }
    }
}
