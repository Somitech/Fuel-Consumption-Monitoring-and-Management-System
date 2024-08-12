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

    public partial class GivingModify : Form
    {

        DBConnecter db;
        DataSet ds;

        public GivingModify()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void GivingModify_Load(object sender, EventArgs e)
        {
            ds = db.select("select GivingID, CouponID as 'رقم القسيمة', CarID as 'رقم السيارة',(SELECT ReceaverName FROM Receaver) as 'اسم المستلم', GivingDate as 'تاريخ التسليم' from GivingCoupon");
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            int givingID = Int32.Parse(row.Cells[0].Value.ToString());

            this.Visible = false;
            using (GivingUpdate giveup = new GivingUpdate(givingID))
                giveup.ShowDialog(this);
            this.Visible = true;
            //MessageBox.Show("CEll Double_Click event calls GivingId : " + row.Cells[0].Value);
        }
    }
}
