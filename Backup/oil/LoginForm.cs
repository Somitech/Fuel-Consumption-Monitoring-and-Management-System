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
    public partial class LoginForm : Form
    {

        DBConnecter db;

        public LoginForm()
        {
            InitializeComponent();
            db = DBConnecter.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.userTextBox.Text != "" && this.passTextBox.Text != "")
            {
                string user = this.userTextBox.Text;
                string pass = this.passTextBox.Text;
                if (db.checkUser(user, pass))
                {
                    this.Visible = false;
                    using (MainForm mainForm = new MainForm())
                        mainForm.ShowDialog(this);
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور خاطئة");
                }
            }
            else 
            {
                MessageBox.Show("الرجاء إدخال البيانات كاملةً");
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
