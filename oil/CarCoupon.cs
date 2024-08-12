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
    public partial class CarCoupon : Form
    {
        DBConnecter db;
        DataSet ds;
        DataTable dt;

        public CarCoupon()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void CarCoupon_Load(object sender, EventArgs e)
        {


            string receaverQuery = "select CarID from Car";
            ds = db.select(receaverQuery);
            dt = ds.Tables[0];
            string carID1;
            foreach (DataRow dr in dt.Rows)
            {
                carID1 = dr["CarID"].ToString();
                this.carID.Items.Add(carID1);
            }
            this.carID.SelectedIndex = 0;
            this.month.SelectedIndex = 0;
            this.month.Enabled = false;
            this.monthCheck.Enabled = false;
        }

        void getFreeCouponInfo()
        {
            string query0, query1;

            if (this.period.Checked)
            {
                string startYear, startMonth, startDay, endYear, endMonth, endDay;
                startYear = this.startDate.Value.Year.ToString();
                startMonth = this.startDate.Value.Month.ToString();
                startDay = this.startDate.Value.Day.ToString();
                endYear = this.endDate.Value.Year.ToString();
                endMonth = this.endDate.Value.Month.ToString();
                endDay = this.endDate.Value.Day.ToString();

                query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID ='" + this.carID.Text + "') AND (DATEPART(year, GivingCoupon.GivingDate) between '" + startYear + "' and '" + endYear + "') AND (DATEPART(month, GivingCoupon.GivingDate) between '" + startMonth + "' and '" + endMonth + "') AND (DATEPART(day, GivingCoupon.GivingDate) between '" + startDay + "' and '" + endDay + "')";

                query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID ='" + this.carID.Text + "') AND (DATEPART(year, GivingCoupon.GivingDate) between '" + startYear + "' and '" + endYear + "') AND (DATEPART(month, GivingCoupon.GivingDate) between '" + startMonth + "' and '" + endMonth + "') AND (DATEPART(day, GivingCoupon.GivingDate) between '" + startDay + "' and '" + endDay + "')";
            }
            else
            {
                query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID ='" + this.carID.Text + "')";

                query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID ='" + this.carID.Text + "')";
            }
/*
            if (this.yearCheck.Checked)
            {
                if (this.monthCheck.Checked)
                {
                    query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ") And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ") AND (DATEPART(month, GivingCoupon.GivingDate)= " + this.month.Text + ")";


                    query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ") And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ") AND (DATEPART(month, GivingCoupon.GivingDate)= " + this.month.Text + ")";
                }
                else
                {
                    query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ") And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ")";

                    query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ") And (DATEPART(year, GivingCoupon.GivingDate)= " + this.year.Value.ToString() + ")";
                }
            }
            else
            {
                query0 = "SELECT COUNT(*) as CouponNumber"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ")";

                query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (GivingCoupon.CarID =" + this.carID.Text + ")";
            }
 */
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

        private void carID_SelectedIndexChanged(object sender, EventArgs e)
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

        private void year_ValueChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void period_CheckedChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }
    }
}
