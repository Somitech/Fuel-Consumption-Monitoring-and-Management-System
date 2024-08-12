﻿namespace oil
{
    partial class CarCoupon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.period = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.carID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.ComboBox();
            this.monthCheck = new System.Windows.Forms.CheckBox();
            this.yearCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::oil.Properties.Resources.Background2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.period);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.carID);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.month);
            this.panel1.Controls.Add(this.monthCheck);
            this.panel1.Controls.Add(this.yearCheck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(137, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 394);
            this.panel1.TabIndex = 2;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(76, 17);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(93, 17);
            this.period.TabIndex = 80;
            this.period.Text = "خلال مدة معينة";
            this.period.UseVisualStyleBackColor = true;
            this.period.CheckedChanged += new System.EventHandler(this.period_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "إلى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = " من";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "yyyy-MM-dd";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(29, 67);
            this.endDate.Name = "endDate";
            this.endDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endDate.RightToLeftLayout = true;
            this.endDate.Size = new System.Drawing.Size(112, 20);
            this.endDate.TabIndex = 77;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "yyyy-MM-dd";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(29, 40);
            this.startDate.Name = "startDate";
            this.startDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startDate.RightToLeftLayout = true;
            this.startDate.Size = new System.Drawing.Size(112, 20);
            this.startDate.TabIndex = 76;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // carID
            // 
            this.carID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carID.FormattingEnabled = true;
            this.carID.Location = new System.Drawing.Point(290, 28);
            this.carID.Name = "carID";
            this.carID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carID.Size = new System.Drawing.Size(190, 21);
            this.carID.TabIndex = 75;
            this.carID.SelectedIndexChanged += new System.EventHandler(this.carID_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(537, 251);
            this.dataGridView1.TabIndex = 61;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(188, 71);
            this.year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(101, 20);
            this.year.TabIndex = 60;
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.year.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.year.Visible = false;
            this.year.ValueChanged += new System.EventHandler(this.year_ValueChanged);
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(175, 95);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(98, 21);
            this.month.TabIndex = 59;
            this.month.Visible = false;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // monthCheck
            // 
            this.monthCheck.AutoSize = true;
            this.monthCheck.Location = new System.Drawing.Point(279, 97);
            this.monthCheck.Name = "monthCheck";
            this.monthCheck.Size = new System.Drawing.Size(70, 17);
            this.monthCheck.TabIndex = 57;
            this.monthCheck.Text = "خلال شهر";
            this.monthCheck.UseVisualStyleBackColor = true;
            this.monthCheck.Visible = false;
            this.monthCheck.CheckedChanged += new System.EventHandler(this.monthCheck_CheckedChanged);
            // 
            // yearCheck
            // 
            this.yearCheck.AutoSize = true;
            this.yearCheck.Location = new System.Drawing.Point(295, 74);
            this.yearCheck.Name = "yearCheck";
            this.yearCheck.Size = new System.Drawing.Size(68, 17);
            this.yearCheck.TabIndex = 56;
            this.yearCheck.Text = "خلال سنة";
            this.yearCheck.UseVisualStyleBackColor = true;
            this.yearCheck.Visible = false;
            this.yearCheck.CheckedChanged += new System.EventHandler(this.yearCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "قسيمة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "عدد القسائم الممنوحة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السيارة";
            // 
            // CarCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CarCoupon";
            this.Text = "CarCoupon";
            this.Load += new System.EventHandler(this.CarCoupon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.CheckBox monthCheck;
        private System.Windows.Forms.CheckBox yearCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carID;
        private System.Windows.Forms.CheckBox period;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
    }
}