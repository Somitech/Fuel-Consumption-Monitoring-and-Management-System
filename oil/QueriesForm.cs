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
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (FreeCoupon fc = new FreeCoupon())
                fc.ShowDialog(this);
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (GivinCoupon gc = new GivinCoupon())
                gc.ShowDialog(this);
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (CouponSearch cs = new CouponSearch())
                cs.ShowDialog(this);
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (CarCoupon cc = new CarCoupon())
                cc.ShowDialog(this);
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (ReceaverCoupon rc = new ReceaverCoupon())
                rc.ShowDialog(this);
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (BellModfy bm = new BellModfy())
                bm.ShowDialog(this);
            this.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (CarModify cm = new CarModify())
                cm.ShowDialog(this);
            this.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (GivingModify cm = new GivingModify())
                cm.ShowDialog(this);
            this.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (ReceaverModify cm = new ReceaverModify())
                cm.ShowDialog(this);
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (CarInfo ci = new CarInfo())
                ci.ShowDialog(this);
            this.Visible = true;
        }
    }
}
