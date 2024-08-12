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
    public partial class GivingCoupon : Form
    {
        DBConnecter db;
        List<string> coupons = new List<string>();
        bool serial = true;
        DataSet ds;
        DataTable dt;
        public GivingCoupon()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void GivingCoupon_Load(object sender, EventArgs e)
        {
            this.coponID.Hide();
            this.verify.Hide();

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

            //this.carID.SelectedIndex = 0;
            //this.receaverName.SelectedIndex = 0;
            this.desc.Text = " ";
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.carID.Text != "" && this.receaverName.Text != "")
            {
                
                string query;
                string itemType0, carID0, receaverID0, givingDate0, desc0;
                givingDate0 = db.makeDate(this.givingDate.Value.Day.ToString(), this.givingDate.Value.Month.ToString(), this.givingDate.Value.Year.ToString());

                itemType0 = getNumericItemType().ToString();
                carID0 = this.carID.Text;
                receaverID0 = getReceaverID().ToString();
                //givingDate0 = this.givingDate.Value.ToShortDateString();
                desc0 = desc.Text;
                if (coupons.Count != 0)
                {
                    foreach (string couponID0 in coupons)
                    {

                        query = "INSERT INTO GivingCoupon(CouponID,ItemType,CarID,ReceaverID,GivingDate,GivingDesc) VALUES"
                            + "(" + couponID0 + ","
                                  + itemType0 + ",'"
                                  + carID0 + "',"
                                  + receaverID0 + ",'"
                                  + givingDate0 + "','"
                                  + desc0 + "')";
                        db.insert(query);
                        query = "UPDATE Coupon SET IsFree = 0 WHERE CouponID = " + couponID0;
                        db.update(query);
                    }
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("لا يوجد بطاقات محددة");
                }
            }
            else 
            {
                MessageBox.Show("الرجاء إدخال البيانات كاملةً");
            }
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

        private void couponNumber_ValueChanged(object sender, EventArgs e)
        {
            bringCoupon();
        }

        private int getNumericItemType()
        {
            int val = 0;
            switch (itemType.SelectedIndex)
            {
                case 0:
                    val = 0; break;
                case 1:
                    val = 1; break;
            }
            return val;
        }

        private void bringCoupon()
        {
            if (serial)
            {
                coupons.Clear();
                this.retrievedCoupons.Text = "";
                string couponNum, itemType1;
                string couponQuery;

                couponNum = this.couponNumber.Value.ToString();
                itemType1 = this.getNumericItemType().ToString();

                couponQuery = "SELECT TOP " + couponNum + " CouponID, LitreNumber FROM Coupon"
                             + " WHERE IsFree = 1 and ItemType = " + itemType1
                             + "ORDER BY ID ";
                DataSet ds = db.select(couponQuery);
                DataTable dt = ds.Tables[0];
                string retrievedCoupon;
                int litreNum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    retrievedCoupon = dr["CouponID"].ToString();
                    this.retrievedCoupons.Text = this.retrievedCoupons.Text + retrievedCoupon + "\n";
                    coupons.Add(retrievedCoupon);
                    litreNum += Int32.Parse(dr["LitreNumber"].ToString());
                }
                this.litreNumber.Text = litreNum.ToString();
            }
            else
            {
                string query0 = "select CouponID from Coupon WHERE CouponID = " + this.coponID.Text;
                ds = db.select(query0);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("القسيمة المطلوبة غير موجودة في قاعدة البيانات" + "\n" + "الرجاء التأكد من رقم القسيمة");
                }
                else
                {
                    query0 = "select * from Coupon WHERE IsFree = 1 AND CouponID = " + this.coponID.Text;
                    ds.Clear();
                    ds = db.select(query0);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("القسيمة المطلوبة ممنوحة مسبقاً الرجاء التأكد من المعلومات المدخلة");
                    }
                    else
                    {
                        string couponID = "";
                        query0 = "select CouponID, ItemType, LitreNumber from Coupon WHERE CouponID = " + this.coponID.Text;
                        ds.Clear();
                        ds = db.select(query0);
                        dt = ds.Tables[0];
                        string couponItemtype = "";
                        string couponLiterNumber = "";
                        foreach (DataRow dr in dt.Rows)
                        {
                            couponItemtype = dr["ItemType"].ToString();
                            couponLiterNumber = dr["LitreNumber"].ToString();
                            couponID = dr["CouponID"].ToString();
                        }
                        this.litreNumber.Text = couponLiterNumber;
                        switch (couponItemtype)
                        {
                            case "0":
                                {
                                    this.itemType.SelectedIndex = 0;
                                    break;
                                }
                            case "1":
                                {
                                    this.itemType.SelectedIndex = 1;
                                    break;
                                }
                        }
                        coupons.Add(couponID);
                    }
                }
            }
        }

        private void itemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serial)
            {
                bringCoupon();
            }
        }

        private void serialGive_CheckedChanged(object sender, EventArgs e)
        {
            if (serialGive.Checked == true)
            {
                serial = true;
                this.coupons.Clear();
                this.label1.Show();
                this.retrievedCoupons.Show();
                this.couponNumber.Show();
                this.coponID.Hide();
                this.verify.Hide();
            }
            else
            {
                serial = false;
                this.coupons.Clear();
                this.label1.Hide();
                this.retrievedCoupons.Hide();
                this.couponNumber.Hide();
                this.coponID.Show();
                this.verify.Show();
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            bringCoupon();
        }

    }
}
