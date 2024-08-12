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
    public partial class InsertCar : Form
    {
        DBConnecter db;
        int currentType;
        public InsertCar()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void InsertCar_Load(object sender, EventArgs e)
        {
            this.carType.SelectedIndex = 0;
            string receaverQuery = "select ReceaverName from Receaver";
            DataSet ds = db.select(receaverQuery);
            DataTable dt = ds.Tables[0];
            string receaverName1;
            foreach (DataRow dr in dt.Rows)
            {
                receaverName1 = dr["ReceaverName"].ToString();
                this.carReceaver.Items.Add(receaverName1);
            }
            //this.carReceaver.SelectedIndex = 0;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (carID.Text != "" && carModel.Text != "" && this.carReceaver.Text != "")
            {
                string carId1, carModel1, carReceaver1, carType1, consumingRate1;
                string query;
                if (currentType == 0)
                {
                    carReceaver1 = carReceaver.Text;
                    query = "select ID from Receaver where ReceaverName = '" + carReceaver1 + "'";
                    DataSet ds = db.select(query);
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        carReceaver1 = dr["ID"].ToString();
                    }
                    carId1 = carID.Text;
                    carModel1 = carModel.Text;
                    carType1 = getNumericCarType().ToString();
                    query = "INSERT INTO Car(CarID,CarModel,UsingType,ReceaverID) VALUES"
                  + "(" + carId1 + ",'"
                        + carModel1 + "',"
                        + carType1 + ","
                        + carReceaver1 + ")";
                    db.insert(query);
                }

                if (currentType == 1)
                {
                    carReceaver1 = carReceaver.Text;
                    query = "select ID from Receaver where ReceaverName = '" + carReceaver1 + "'";
                    DataSet ds = db.select(query);
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        carReceaver1 = dr["ID"].ToString();
                    }
                    carId1 = carID.Text;
                    carModel1 = carModel.Text;
                    carType1 = getNumericCarType().ToString();
                    consumingRate1 = ConsumingRate.Value.ToString();
                    query = "INSERT INTO Car(CarID,CarModel,UsingType,ReceaverID,ConsumingRate) VALUES"
                  + "(" + carId1 + ",'"
                        + carModel1 + "',"
                        + carType1 + ","
                        + carReceaver1 + ","
                        + consumingRate1 + ")";
                    db.insert(query);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء إدخال البيانات كاملةً");
            }
        }

        private int getNumericCarType()
        {
            int val = 0;
            switch (carType.SelectedIndex)
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

        private void carType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.carType.SelectedIndex == 0)
            {
                currentType = 0;
                //this.label3.Show();
                //this.carReceaver.Show();
                //this.label5.Hide();
                //this.label6.Hide();
                //this.initialCounter.Hide();
                //this.ConsumingRate.Hide();
            }
            else
            {
                currentType = 1;
                //this.label5.Show();
                //this.label6.Show();
                //this.initialCounter.Show();
                //this.ConsumingRate.Show();
                //this.label3.Hide();
                //this.carReceaver.Hide();
            }
        }

        private void carReceaver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
