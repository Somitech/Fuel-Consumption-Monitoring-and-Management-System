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
    public partial class CouponSearch : Form
    {

        DBConnecter db;
        
        public CouponSearch()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void CouponSearch_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Hide();
            string query0, query1;
            DataSet ds;
            DataTable dt;

            query0 = "select * from Coupon WHERE CouponID = " + this.couponNumber.Text;
            ds = db.select(query0);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("القسيمة المطلوبة غير موجودة في قاعدة البيانات" + "\n" + "الرجاء التأكد من رقم القسيمة");
            }
            else
            {
                query0 = "select * from Coupon WHERE IsFree = 0 AND CouponID = " + this.couponNumber.Text;
                ds.Clear();
                ds = db.select(query0);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("القسيمة المطلوبة شاغرة- غير ممنوحة");
                }
                else
                {
                    query0 = "select ItemType from Coupon WHERE CouponID = " + this.couponNumber.Text;
                    ds.Clear();
                    ds = db.select(query0);
                    dt = ds.Tables[0];
                    string itemtype = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        itemtype = dr["ItemType"].ToString();
                    }
                    switch (itemtype)
                    {
                        case "0":
                            {
                                this.label2.Text = "بنزين ممتاز";
                                label2.Show();
                                break;
                            }
                        case "1":
                            {
                                this.label2.Text = "مازوت";
                                label2.Show();
                                break;
                            }
                    }


                    query1 = "SELECT Coupon.CouponID AS [رقم القسيمة], Coupon.LitreNumber AS [عدد الليترات], CONVERT(varchar,GivingCoupon.GivingDate,103) AS [تاريخ التسليم], Receaver.ReceaverName AS [اسم المستلم], GivingCoupon.CarID AS [رقم السيارة]"
                   + " FROM   Receaver INNER JOIN Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID ON Receaver.ID = GivingCoupon.ReceaverID"
                   + " WHERE  (Coupon.IsFree = 0) AND (Coupon.CouponID =" + this.couponNumber.Text + ")";
                    ds.Clear();
                    ds = db.select(query1);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                }
            }

        }
    }
}
