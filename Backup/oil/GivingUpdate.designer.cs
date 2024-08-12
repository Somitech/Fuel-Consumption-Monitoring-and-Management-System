namespace oil
{
    partial class GivingUpdate
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
            this.itemType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carID = new System.Windows.Forms.ComboBox();
            this.receaverName = new System.Windows.Forms.ComboBox();
            this.cancleButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.givingDate = new System.Windows.Forms.DateTimePicker();
            this.litreNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.couponNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
//            this.panel1.BackgroundImage = global::oil.Properties.Resources.Background2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.couponNumber);
            this.panel1.Controls.Add(this.itemType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.carID);
            this.panel1.Controls.Add(this.receaverName);
            this.panel1.Controls.Add(this.cancleButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.desc);
            this.panel1.Controls.Add(this.givingDate);
            this.panel1.Controls.Add(this.litreNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 489);
            this.panel1.TabIndex = 1;
            // 
            // itemType
            // 
            this.itemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemType.FormattingEnabled = true;
            this.itemType.Items.AddRange(new object[] {
            "بنزين ممتاز",
            "مازوت"});
            this.itemType.Location = new System.Drawing.Point(229, 73);
            this.itemType.Name = "itemType";
            this.itemType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemType.Size = new System.Drawing.Size(258, 21);
            this.itemType.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(515, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "نوع المادة";
            // 
            // carID
            // 
            this.carID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carID.FormattingEnabled = true;
            this.carID.Location = new System.Drawing.Point(230, 156);
            this.carID.Name = "carID";
            this.carID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.carID.Size = new System.Drawing.Size(258, 21);
            this.carID.TabIndex = 74;
            // 
            // receaverName
            // 
            this.receaverName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receaverName.FormattingEnabled = true;
            this.receaverName.Location = new System.Drawing.Point(229, 251);
            this.receaverName.Name = "receaverName";
            this.receaverName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.receaverName.Size = new System.Drawing.Size(258, 21);
            this.receaverName.TabIndex = 73;
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(321, 440);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 23);
            this.cancleButton.TabIndex = 71;
            this.cancleButton.Text = "إغلاق";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(419, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 70;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(229, 291);
            this.desc.Name = "desc";
            this.desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.desc.Size = new System.Drawing.Size(258, 76);
            this.desc.TabIndex = 46;
            this.desc.Text = " ";
            // 
            // givingDate
            // 
            this.givingDate.CustomFormat = "dd/MM/yyyy";
            this.givingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.givingDate.Location = new System.Drawing.Point(229, 201);
            this.givingDate.Name = "givingDate";
            this.givingDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.givingDate.RightToLeftLayout = true;
            this.givingDate.Size = new System.Drawing.Size(258, 20);
            this.givingDate.TabIndex = 45;
            // 
            // litreNumber
            // 
            this.litreNumber.Location = new System.Drawing.Point(229, 115);
            this.litreNumber.Name = "litreNumber";
            this.litreNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.litreNumber.Size = new System.Drawing.Size(258, 20);
            this.litreNumber.TabIndex = 44;
            this.litreNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(530, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "ملاحظات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(516, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "اسم المستلم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(509, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "تاريخ التسليم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(516, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "رقم السيارة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(515, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "عدد الليترات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(516, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "رقم القسيمة";
            // 
            // couponNumber
            // 
            this.couponNumber.Location = new System.Drawing.Point(230, 33);
            this.couponNumber.Name = "couponNumber";
            this.couponNumber.Size = new System.Drawing.Size(258, 20);
            this.couponNumber.TabIndex = 78;
            // 
            // GivingUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Name = "GivingUpdate";
            this.Text = "GivingUpdate";
            this.Load += new System.EventHandler(this.GivingUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox itemType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox carID;
        private System.Windows.Forms.ComboBox receaverName;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.DateTimePicker givingDate;
        private System.Windows.Forms.TextBox litreNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox couponNumber;
    }
}