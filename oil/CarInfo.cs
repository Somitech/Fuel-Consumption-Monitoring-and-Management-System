using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oil
{

    
       
    public partial class CarInfo : Form
    {

        DBConnecter db;
        DataSet ds;
        public CarInfo()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string carID = row.Cells[0].Value.ToString();

            this.Visible = false;
            using (CarDetails cd = new CarDetails(carID))
                cd.ShowDialog(this);
            this.Visible = true;

            //MessageBox.Show("CEll Double_Click event calls carId : " + row.Cells[0].Value);
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {
            ds = db.select("SELECT CarID as 'رقم السيارة', CarModel as 'موديل السيارة' FROM Car Where UsingType != 0");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
