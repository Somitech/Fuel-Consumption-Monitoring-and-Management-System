namespace oil
{
    partial class InsertCar
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
            this.ConsumingRate = new System.Windows.Forms.NumericUpDown();
            this.carReceaver = new System.Windows.Forms.ComboBox();
            this.cancleButton = new System.Windows.Forms.Button();
            this.carType = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.carModel = new System.Windows.Forms.TextBox();
            this.carID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumingRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
//            this.panel1.BackgroundImage = global::oil.Properties.Resources.Background2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ConsumingRate);
            this.panel1.Controls.Add(this.carReceaver);
            this.panel1.Controls.Add(this.cancleButton);
            this.panel1.Controls.Add(this.carType);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.carModel);
            this.panel1.Controls.Add(this.carID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 415);
            this.panel1.TabIndex = 0;
            // 
            // ConsumingRate
            // 
            this.ConsumingRate.Location = new System.Drawing.Point(208, 267);
            this.ConsumingRate.Name = "ConsumingRate";
            this.ConsumingRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConsumingRate.Size = new System.Drawing.Size(216, 20);
            this.ConsumingRate.TabIndex = 74;
            // 
            // carReceaver
            // 
            this.carReceaver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carReceaver.FormattingEnabled = true;
            this.carReceaver.Location = new System.Drawing.Point(208, 226);
            this.carReceaver.Name = "carReceaver";
            this.carReceaver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carReceaver.Size = new System.Drawing.Size(216, 21);
            this.carReceaver.TabIndex = 72;
            this.carReceaver.SelectedIndexChanged += new System.EventHandler(this.carReceaver_SelectedIndexChanged);
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(233, 345);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 23);
            this.cancleButton.TabIndex = 71;
            this.cancleButton.Text = "إغلاق";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // carType
            // 
            this.carType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "مخصص",
            "خدمة",
            "قصر"});
            this.carType.Location = new System.Drawing.Point(208, 173);
            this.carType.Name = "carType";
            this.carType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carType.Size = new System.Drawing.Size(216, 21);
            this.carType.TabIndex = 24;
            this.carType.SelectedIndexChanged += new System.EventHandler(this.carType_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(331, 345);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 70;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // carModel
            // 
            this.carModel.Location = new System.Drawing.Point(208, 122);
            this.carModel.Name = "carModel";
            this.carModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carModel.Size = new System.Drawing.Size(216, 20);
            this.carModel.TabIndex = 23;
            // 
            // carID
            // 
            this.carID.Location = new System.Drawing.Point(208, 68);
            this.carID.Name = "carID";
            this.carID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carID.Size = new System.Drawing.Size(216, 20);
            this.carID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(528, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "معايرة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(494, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "صفة الاستخدام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(495, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "مستلم السيارة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(504, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "نوع السيارة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(504, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "رقم السيارة";
            // 
            // InsertCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::oil.Properties.Resources.wallpaper_36215;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InsertCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertCar";
            this.Load += new System.EventHandler(this.InsertCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumingRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.TextBox carID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox carReceaver;
        private System.Windows.Forms.NumericUpDown ConsumingRate;

    }
}