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
    public partial class BellUpdate : Form
    {
        private int bellID;
        DBConnecter db;
        int couponNumber;

        public BellUpdate(int bellID)
        {
            InitializeComponent();
            this.bellID = bellID;
            db = DBConnecter.Instance;
            this.itemType.SelectedIndex = 0;
            this.litreInCoupon.SelectedIndex = 0;
            this.litreDiscount.Text = "0";
            this.litrePrice.Text = "0";
            this.bookPrice.Text = "0";
            this.litreNumber.Text = "0";
        }

        private void BellUpdate_Load(object sender, EventArgs e)
        {
            string query = "SELECT BellID,BellDate,BookNumber,CouponInBook,LitreInCoupon,ItemType,LitreNumber,LitrePrice,LiterDiscount,BookPrice,FirstCoupon,Price,PayingType,PayingWith,PayingDate,PayingNumber FROM Bell WHERE BellID = " + this.bellID;
            DataSet ds = db.select(query);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            

            this.bayDate.Value = DateTime.Parse(dr["BellDate"].ToString());
            this.bookNumber.Value =Int32.Parse(dr["BookNumber"].ToString());
            this.couponInBook.Value = Int32.Parse(dr["CouponInBook"].ToString());
            if(dr["LitreInCoupon"].ToString() == "25")
                this.litreInCoupon.SelectedIndex = 0;
            else if(dr["LitreInCoupon"].ToString() == "25")
                this.litreInCoupon.SelectedIndex = 1;
            this.itemType.SelectedIndex = Int32.Parse(dr["ItemType"].ToString());
            this.litrePrice.Text = dr["LitrePrice"].ToString();
            this.litreDiscount.Text = dr["LiterDiscount"].ToString();
            this.bookPrice.Text = dr["BookPrice"].ToString();
            this.firstCoupon.Text = dr["FirstCoupon"].ToString();
            this.payType.SelectedIndex = Int32.Parse(dr["PayingType"].ToString());
            this.payWith.SelectedIndex = Int32.Parse(dr["PayingWith"].ToString());
            this.payNumber.Text = dr["PayingNumber"].ToString();
            this.payDate.Value = this.bayDate.Value = DateTime.Parse(dr["PayingDate"].ToString());

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (this.firstCoupon.Text == "")
                MessageBox.Show("الرجاء إدخال رقم أول قسيمة من أول دفتر");
            else
            {
                calc();
                button1.Hide();
                saveButton.Show();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int firstCouponNumber = Int32.Parse(firstCoupon.Text);
            string query;
            string bayDate1, bookNumber1, couponInBook1, litreInCoupon1, itemType1, litreNumber1, litrePrice1, litreDiscount1, bookPrice1, firstCoupon1, price1, payType1, payWith1, payDate1, payNumber1;

            bayDate1 = db.makeDate(this.bayDate.Value.Day.ToString(), this.bayDate.Value.Month.ToString(), this.bayDate.Value.Year.ToString());
            bookNumber1 = bookNumber.Value.ToString();
            couponInBook1 = this.couponInBook.Value.ToString();
            litreInCoupon1 = this.litreInCoupon.Text;
            itemType1 = getNumericItemType().ToString(); ;
            litreNumber1 = this.litreNumber.Text;
            litrePrice1 = this.litrePrice.Text;
            litreDiscount1 = this.litreDiscount.Text;
            bookPrice1 = this.bookPrice.Text;
            firstCoupon1 = this.firstCoupon.Text;
            price1 = this.price.Text;
            payType1 = getNumericPayType().ToString();
            payWith1 = getNumericPayWith().ToString();
            payDate1 = db.makeDate(this.payDate.Value.Day.ToString(), this.payDate.Value.Month.ToString(), this.payDate.Value.Year.ToString());
            payNumber1 = this.payNumber.Text;

            query = "UPDATE Bell SET "
        + "BellDate= '" + bayDate1 + "',"
        + "BookNumber = " + bookNumber1 + ","
        + "CouponInBook = " + couponInBook1 + ","
        + "LitreInCoupon = " + litreInCoupon1 + ","
        + "ItemType = " + itemType1 + ","
        + "LitreNumber = " + litreNumber1 + ","
        + "LitrePrice = " + litrePrice1 + ","
        + "LiterDiscount = " + litreDiscount1 + ","
        + "BookPrice = " + bookPrice1 + ","
        + "FirstCoupon = " + firstCoupon1 + ","
        + "Price = " + price1 + ","
        + "PayingType = " + payType1 + ","
        + "PayingWith = " + payWith1 + ","
        + "PayingDate = '" + payDate1 + "',"
        + "PayingNumber = " + payNumber1 + " WHERE BellID = " + this.bellID;
            
            db.insert(query);
            MessageBox.Show("تم تعديل فاتورة الشراء");
            this.Close();
        
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


        private int getNumericPayType()
        {
            int val = 0;
            switch (payType.SelectedIndex)
            {
                case 0:
                    val = 0; break;
                case 1:
                    val = 1; break;
            }
            return val;
        }


        private int getNumericPayWith()
        {
            int val = 0;
            switch (payType.SelectedIndex)
            {
                case 0:
                    val = 0; break;
                case 1:
                    val = 1; break;
                case 2:
                    val = 2; break;
            }
            return val;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calc()
        {
            double litre_number = Double.Parse(bookNumber.Value.ToString()) * Double.Parse(couponInBook.Value.ToString()) * Double.Parse(litreInCoupon.Text);
            litreNumber.Text = litre_number.ToString();
            double all_discount = Double.Parse(litreNumber.Text) * Double.Parse(litreDiscount.Text);
            discount.Text = all_discount.ToString();
            double priceBeforDiscount = (Double.Parse(litreNumber.Text) * Double.Parse(litrePrice.Text)) + (Double.Parse(bookNumber.Value.ToString()) * Double.Parse(bookPrice.Text));
            priceWOdiscount.Text = priceBeforDiscount.ToString();
            double final_price = Double.Parse(priceWOdiscount.Text) - Double.Parse(discount.Text);
            price.Text = final_price.ToString();
            couponNumber = Int32.Parse(bookNumber.Value.ToString()) * Int32.Parse(couponInBook.Value.ToString());
        }

        private void bookNumber_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void litreInCoupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void litrePrice_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void litreDiscount_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void bookPrice_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void litrePrice_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void litreDiscount_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void bookPrice_TextChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}
