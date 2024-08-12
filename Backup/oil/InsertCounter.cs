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
    public partial class InsertCounter : Form
    {
        DBConnecter db;
        int currentCar;
        DataSet ds0 = new DataSet();
        DataSet ds1 = new DataSet();
        DataTable dt0,dt1;
        DataRow dr;
        int carNum;

        public InsertCounter()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertCounter_Load(object sender, EventArgs e)
        {
            this.carType.SelectedIndex = 0;
            getCars();
            
        }

        private void getCars()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox4.Clear();
            this.button1.Hide();
            this.button2.Hide();
            string query1 ="SELECT Car.CarID, Car.CarModel FROM Car"
                          +" WHERE (Car.UsingType = " + (this.carType.SelectedIndex + 1) + ") AND ((SELECT COUNT(*) FROM Counter WHERE Counter.CarID = Car.CarID AND Counter.Year = " + this.CounterDate.Value.Year.ToString() + " AND Counter.Month = " + this.CounterDate.Value.Month.ToString() + ") = 0 )";
            ds0.Clear();
            ds0 = db.select(query1);
            dt0 = ds0.Tables[0];
            carNum = dt0.Rows.Count;
            currentCar = 0;
            if (carNum != 0)
            {
                getCar(dt0, currentCar);
            }
            if (carNum > 1)
            {
                this.button2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentCar++;
            getCar(dt0, currentCar);
            if (currentCar == carNum - 1)
            {
                this.button2.Hide();
            }
            this.button1.Show();
        }

        private void getCar(DataTable dt, int current)
        {
            DataRow dr = dt.Rows[current];
            textBox1.Text = dr["CarID"].ToString();
            textBox2.Text = dr["CarModel"].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentCar--;
            getCar(dt0, currentCar);
            if (currentCar == 0)
            {
                this.button1.Hide();
            }
            this.button2.Show();

        }

        private void carType_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCars();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox4.Text != "")
            {
                string query0 = "INSERT INTO Counter (CarID, Month, Year, CounterValue)"
                                + "VALUES ("
                                + this.textBox1.Text + ","
                                + this.CounterDate.Value.Month.ToString() + ","
                                + this.CounterDate.Value.Year.ToString() + ","
                                + this.textBox4.Text + ")";
                db.insert(query0);

                int carID = Int32.Parse(this.textBox1.Text);
                string query1 = "select * from Counter where CarID = " + carID;
                ds1 = db.select(query1);
                dt1 = ds1.Tables[0];
                int count1 = dt1.Rows.Count;

                query1 = "select * from CounterWatch where CarID = " + carID;
                ds1 = db.select(query1);
                dt1 = ds1.Tables[0];
                int count2 = dt1.Rows.Count;

                int year, month, beginCounter, endCounter, distance, consumingRate, defaultFuel, realFuel, monthlyExcess, preComulativeExcess, comulativeExcess;

                if (this.CounterDate.Value.Month == 1)
                {
                    month = 12;
                    year = this.CounterDate.Value.Year - 1;
                }
                else
                {
                    month = this.CounterDate.Value.Month - 1;
                    year = this.CounterDate.Value.Year;
                }

                int month2, year2;
                if (month == 1)
                {
                    month2 = 12;
                    year2 = year - 1;
                }
                else
                {
                    month2 = month - 1;
                    year2 = year;
                }


                if (count1 > 1)
                {
                    endCounter = Int32.Parse(this.textBox4.Text);
                    query1 = "select CounterValue from Counter where Year = " + year + " and Month = " + month + " and CarID = " + carID;
                    ds1 = db.select(query1);
                    dt1 = ds1.Tables[0];
                    dr = dt1.Rows[0];
                    beginCounter = Int32.Parse(dr["CounterValue"].ToString());
                    distance = endCounter - beginCounter;
                    query1 = "select ConsumingRate from Car where carID = " + carID;
                    ds1 = db.select(query1);
                    dt1 = ds1.Tables[0];
                    dr = dt1.Rows[0];
                    consumingRate = Int32.Parse(dr["ConsumingRate"].ToString());
                    defaultFuel = consumingRate * distance / 100;
                    query1 = "SELECT Sum(Coupon.LitreNumber) as [LitreNumber] from Coupon INNER JOIN GivingCoupon ON Coupon.CouponID = GivingCoupon.CouponID"
                           + " WHERE Coupon.IsFree = 0 AND GivingCoupon.CarID = " + carID + " And DATEPART(year, GivingCoupon.GivingDate) = " + year + " AND DATEPART(month, GivingCoupon.GivingDate) = " + month;
                    ds1 = db.select(query1);
                    dt1 = ds1.Tables[0];
                    dr = dt1.Rows[0];
                    realFuel = Int32.Parse(dr["LitreNumber"].ToString());
                    monthlyExcess = defaultFuel - realFuel;

                    query1 = "Select comulativeExcess from CounterWatch where Month = " + month2 + " and Year = " + year2;
                    ds1 = db.select(query1);
                    dt1 = ds1.Tables[0];
                    dr = dt1.Rows[0];
                    preComulativeExcess = Int32.Parse(dr["comulativeExcess"].ToString());
                    comulativeExcess = preComulativeExcess + monthlyExcess;
                    query1 = "INSERT INTO CounterWatch (Year,Month,CarID,BeginCounter,EndCounter,Distance,DefaultFuel,RealFuel,MonthlyExcess,ComulativeExcess)"
                           + " VALUES ("
                           + year + ","
                           + month + ","
                           + carID + ","
                           + beginCounter + ","
                           + endCounter + ","
                           + distance + ","
                           + defaultFuel + ","
                           + realFuel + ","
                           + monthlyExcess + ","
                           + comulativeExcess + ")";
                    db.insert(query1);
                }
                else if (count1 == 1)
                {
                    query1 = "INSERT INTO CounterWatch (Year,Month,CarID,BeginCounter,EndCounter,Distance,DefaultFuel,RealFuel,MonthlyExcess,ComulativeExcess)"
                           + " VALUES ("
                           + year + ","
                           + month + ","
                           + carID + ","
                           + 0 + ","
                           + 0 + ","
                           + 0 + ","
                           + 0 + ","
                           + 0 + ","
                           + 0 + ","
                           + 0 + ")";
                    db.insert(query1);
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء إدخال قيمة العداد");
            }
        }

        private void CounterDate_ValueChanged(object sender, EventArgs e)
        {
            getCars();
        }
        
    }
}
