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
    public partial class CarModify : Form
    {

        DBConnecter db;
        DataSet ds;
        public CarModify()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void CarModify_Load(object sender, EventArgs e)
        {
            ds = db.select("SELECT CarID as 'رقم السيارة', CarModel as 'موديل السيارة' FROM Car");
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int carID = Int32.Parse(row.Cells[0].Value.ToString());

            this.Visible = false;
            using (CarUpdate bell = new CarUpdate(carID))
                bell.ShowDialog(this);
            this.Visible = true;

            //MessageBox.Show("CEll Double_Click event calls carId : " + row.Cells[0].Value);
        }
    }
}
