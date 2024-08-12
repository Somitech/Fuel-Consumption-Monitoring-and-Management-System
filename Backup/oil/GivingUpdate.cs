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
    public partial class GivingUpdate : Form
    {

        DBConnecter db;
        private int givingID;
        public GivingUpdate(int givingID)
        {
            InitializeComponent();
            db = DBConnecter.Instance;
            this.givingID = givingID;
        }

        private void GivingUpdate_Load(object sender, EventArgs e)
        {
            this.itemType.SelectedIndex = 0;

            string receaverQuery = "select ReceaverName from Receaver";
            DataSet ds = db.select(receaverQuery);
            DataTable dt = ds.Tables[0];
            string receaverName1;
            foreach (DataRow dr in dt.Rows)
            {
                receaverName1 = dr["ReceaverName"].ToString();
                this.receaverName.Items.Add(receaverName1);
            }

            receaverQuery = "select CarID from Car";
            ds = db.select(receaverQuery);
            dt = ds.Tables[0];
            string carID1;
            foreach (DataRow dr in dt.Rows)
            {
                carID1 = dr["CarID"].ToString();
                this.carID.Items.Add(carID1);
            }

            this.desc.Text = " ";

        }

        private int getReceaverID()
        {
            string receaver = this.receaverName.Text;
            string recquery = "select ID from Receaver where ReceaverName = '" + receaver + "'";
            DataSet ds = db.select(recquery);
            DataTable dt = ds.Tables[0];
            int recid = 0;
            foreach (DataRow dr in dt.Rows)
            {
                recid = Int32.Parse(dr["ID"].ToString());
            }
            return recid;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
