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
    public partial class ReceaverModify : Form
    {

        DBConnecter db;
        DataSet ds;

        public ReceaverModify()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void ReceaverModify_Load(object sender, EventArgs e)
        {
            ds= db.select("SELECT ID, ReceaverName as 'اسم المستلم' FROM Receaver");
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            int receaverID = Int32.Parse(row.Cells[0].Value.ToString());

            this.Visible = false;
            using (ReceaverUpdate bell = new ReceaverUpdate(receaverID))
                bell.ShowDialog(this);
            this.Visible = true;

            //MessageBox.Show("CEll Double_Click event calls ReceaverId : " + row.Cells[0].Value);
        }
    }
}
