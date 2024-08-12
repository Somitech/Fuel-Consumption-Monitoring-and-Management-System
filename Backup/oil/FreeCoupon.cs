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
    public partial class FreeCoupon : Form
    {

        DBConnecter db;

        public FreeCoupon()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FreeCoupon_Load(object sender, EventArgs e)
        {
            this.itemType.SelectedIndex = 0;
            getFreeCouponInfo();
        }

        void getFreeCouponInfo()
        {
            string query = "select count(*) as CouponNumber from Coupon where IsFree = 1 and ItemType = " + this.itemType.SelectedIndex;
            DataSet ds = db.select(query);
            DataTable dt = ds.Tables[0];
            string count = "";
            foreach (DataRow dr in dt.Rows)
            {
                count = dr["CouponNumber"].ToString();
            }
            this.label4.Text = count;

        }

        private void itemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFreeCouponInfo();
        }
    }
}
