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
    public partial class ReceaverUpdate : Form
    {
        DBConnecter db;
        private int receaverID;

        public ReceaverUpdate(int receaverID)
        {
            InitializeComponent();
            db = DBConnecter.Instance;
            this.receaverID = receaverID;
        }

        private void ReceaverUpdate_Load(object sender, EventArgs e)
        {
            string query = "SELECT ReceaverName FROM Receaver WHERE ID = " + this.receaverID;
            DataSet ds = db.select(query);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            this.ReceaverTextBox.Text = dr["ReceaverName"].ToString();
        }



        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Receaver SET ReceaverName = " + this.ReceaverTextBox.Text.ToString() + " WHERE ID = " + this.receaverID;
            db.update(query);
            this.Close();
        }
    }
}
