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
    public partial class ReceaverCoupon : Form
    {

        DBConnecter db;
        DataSet ds;
        DataTable dt;

        public ReceaverCoupon()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        void getFreeCouponInfo()
        {
            string query0, query1;

            if (this.yearCheck.Checked)
            {
                if (this.monthCheck.Checked)
                {
                    query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text + "') And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ") AND (DATEPART(month, GivingCoupon.GivingDate)= " + this.month.Text + ")";


                    query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم], GivingCoupon.CarID AS [رقم السيارة]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text + "') And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ") AND (DATEPART(month, GivingCoupon.GivingDate)= " + this.month.Text + ")";
                }
                else
                {
                    query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text + "') And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ")";

                    query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم], GivingCoupon.CarID AS [رقم السيارة]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text + "') And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ")";
                }
            }
            else
            {
                query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text + "')";

                query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم], GivingCoupon.CarID AS [رقم السيارة]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Receaver.ReceaverName ='" + this.receaverName.Text  + "')";
            }




            ds = db.select(query0);
            dt = ds.Tables[0];
            string count = "";
            foreach (DataRow dr in dt.Rows)
            {
                count = dr["CouponNumber"].ToString();
            }
            this.label4.Text = count;

            ds.Clear();

            ds = db.select(query1);
            dt = ds.Tables[0];
            this.dataGridView1.DataSource = dt;
        }

        private void ReceaverCoupon_Load(object sender, EventArgs e)
        {
            string receaverQuery = "select ReceaverName from Receaver";
            DataSet ds = db.select(receaverQuery);
            DataTable dt = ds.Tables[0];
            string receaverName1;
            foreach (DataRow dr in dt.Rows)
            {
                receaverName1 = dr["ReceaverName"].ToString();
                this.receaverName.Items.Add(receaverName1);
            }
            this.receaverName.SelectedIndex = 0;
            this.month.SelectedIndex = 0;
            this.month.Enabled = false;
            this.monthCheck.Enabled = false;
        }

        private void receaverName_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void yearCheck_CheckedChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
            this.month.Enabled = true;
            this.monthCheck.Enabled = true;
        }

        private void monthCheck_CheckedChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

    }
}
