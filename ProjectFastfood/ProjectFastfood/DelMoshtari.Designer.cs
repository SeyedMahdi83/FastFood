namespace ProjectFastfood
{
    partial class ListMoshtari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMoshtari));
            label1 = new Label();
            CBcustomer = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Deletebtn = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 3;
            label1.Text = "نام مشتری ها";
            // 
            // CBcustomer
            // 
            CBcustomer.AutoCompleteMode = AutoCompleteMode.Append;
            CBcustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBcustomer.FormattingEnabled = true;
            CBcustomer.Location = new Point(141, 26);
            CBcustomer.Name = "CBcustomer";
            CBcustomer.Size = new Size(252, 30);
            CBcustomer.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(141, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(141, 146);
            textBox3.MaxLength = 11;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(49, 208);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(344, 153);
            textBox4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 95);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 8;
            label2.Text = "نام و نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 149);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 9;
            label3.Text = "شماره تلفن : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 211);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 10;
            label4.Text = "آدرس :";
            // 
            // button1
            // 
            button1.Location = new Point(34, 417);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 13;
            button1.Text = "تایید";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 417);
            button2.Name = "button2";
            button2.Size = new Size(121, 44);
            button2.TabIndex = 10;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(294, 417);
            button3.Name = "button3";
            button3.Size = new Size(121, 44);
            button3.TabIndex = 11;
            button3.Text = "ویرایش";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Enabled = false;
            Deletebtn.Location = new Point(164, 417);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(121, 44);
            Deletebtn.TabIndex = 12;
            Deletebtn.Text = "حذف";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // button5
            // 
            button5.Font = new Font("IRANSansX DemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button5.Location = new Point(24, 24);
            button5.Name = "button5";
            button5.Size = new Size(99, 33);
            button5.TabIndex = 9;
            button5.Text = "نمایش مشتری";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ListMoshtari
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(578, 495);
            Controls.Add(button5);
            Controls.Add(Deletebtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(CBcustomer);
            Controls.Add(label1);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListMoshtari";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لیست مشتری ها";
            Load += ListMoshtari_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListView listView1;
        private Label label1;
        private ComboBox CBcustomer;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Deletebtn;
        private Button button5;
    }
}