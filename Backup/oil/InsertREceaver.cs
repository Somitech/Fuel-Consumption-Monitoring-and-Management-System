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
    public partial class InsertREceaver : Form
    {
        DBConnecter db;

        public InsertREceaver()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.ReceaverTextBox.Text != "")
            {
                string receaverName = this.ReceaverTextBox.Text;
                string query;
                query = "INSERT INTO Receaver(ReceaverName) VALUES"
                    + "('" + receaverName + "')";
                db.insert(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم");
            }
        }
    }
}
