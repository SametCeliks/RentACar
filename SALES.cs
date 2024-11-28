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
    public partial class frmsales : Form
    {
        public frmsales()
        {
            InitializeComponent();
        }
       
        kirvem_rentacar car = new kirvem_rentacar();

        private void SALES_Load(object sender, EventArgs e)
        {
                
            string sorgu2 = "select * from sales  ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = car.Listt(adtr2, sorgu2);
            car.salescalculate(label1); 
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 