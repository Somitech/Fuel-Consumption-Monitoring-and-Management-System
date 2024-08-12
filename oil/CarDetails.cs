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
    public partial class CarDetails : Form
    {
        DBConnecter db;
        private string carNumber;
        public CarDetails(string carNumber)
        {
            InitializeComponent();
            db = DBConnecter.Instance;
            this.carNumber = carNumber;
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT Year  as [السنة] ,Month  as [الشهر]  ,BeginCounter as [عداد البدية] ,EndCounter as [عداد النهاية] ,Distance as [المسافة المقطوعة] ,DefaultFuel as [كمية الوقود الواجب صرفها] ,RealFuel as [الكمية المصروفة] ,MonthlyExcess as [الفائض الشهري] ,ComulativeExcess as [الفائض التراكمي] "
                         + "FROM CounterWatch where carID = '" + this.carNumber + "'";
            DataSet ds = db.select(query);
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
