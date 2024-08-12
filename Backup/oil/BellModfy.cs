using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oil
{
    public partial class BellModfy : Form
    {

        DBConnecter db;
        DataSet ds;

        public BellModfy()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void BellModfy_Load(object sender, EventArgs e)
        {
            ds = db.select("select BellID, BellDate as 'تاريخ الفاتورة', PayingNumber as 'الرقم' from Bell");
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int bellID = Int32.Parse(row.Cells[0].Value.ToString());

            this.Visible = false;
            using (BellUpdate bell = new BellUpdate(bellID))
                bell.ShowDialog(this);
            this.Visible = true;
           // MessageBox.Show("CEll Double_Click event calls BellId : " + row.Cells[0].Value);
        }
    }
}
