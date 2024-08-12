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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (InsertBell bell = new InsertBell())
                bell.ShowDialog(this);
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (InsertREceaver insertReceaver = new InsertREceaver())
                insertReceaver.ShowDialog(this);
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (InsertCar insertCar = new InsertCar())
                insertCar.ShowDialog(this);
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (GivingCoupon givingCoupon = new GivingCoupon())
                givingCoupon.ShowDialog(this);
            this.Visible = true;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            //FormCollection fc = Application.OpenForms;
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (QueriesForm qf = new QueriesForm())
                qf.ShowDialog(this);
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (InsertCounter ic = new InsertCounter())
                ic.ShowDialog(this);
            this.Visible = true;
        }

    }
}
