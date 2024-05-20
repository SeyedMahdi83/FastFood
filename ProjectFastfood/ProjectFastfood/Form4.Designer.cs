namespace ProjectFastfood
{
    partial class Form4
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            CBcustomer = new ComboBox();
            label1 = new Label();
            Pizzagrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            sandgrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            drinkgrid = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Price2 = new DataGridViewTextBoxColumn();
            num2 = new DataGridViewTextBoxColumn();
            dessergrid = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            price3 = new DataGridViewTextBoxColumn();
            num3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            showprice = new Button();
            lbltotalprice = new Label();
            ((System.ComponentModel.ISupportInitialize)Pizzagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sandgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drinkgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dessergrid).BeginInit();
            SuspendLayout();
            // 
            // CBcustomer
            // 
            CBcustomer.FormattingEnabled = true;
            CBcustomer.Location = new Point(521, 28);
            CBcustomer.Name = "CBcustomer";
            CBcustomer.Size = new Size(403, 30);
            CBcustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(958, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 1;
            label1.Text = "نام و نام خانوادگی مشتری :";
            // 
            // Pizzagrid
            // 
            Pizzagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Pizzagrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Pizzagrid.DefaultCellStyle = dataGridViewCellStyle1;
            Pizzagrid.Location = new Point(1182, 162);
            Pizzagrid.Name = "Pizzagrid";
            Pizzagrid.RowHeadersWidth = 51;
            Pizzagrid.Size = new Size(338, 515);
            Pizzagrid.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.FillWeight = 50F;
            Column1.HeaderText = "نام غذا";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "قیمت";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 85;
            // 
            // Column3
            // 
            Column3.FillWeight = 50F;
            Column3.HeaderText = "تعداد";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // sandgrid
            // 
            sandgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sandgrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Price, num });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            sandgrid.DefaultCellStyle = dataGridViewCellStyle2;
            sandgrid.Location = new Point(813, 162);
            sandgrid.Name = "sandgrid";
            sandgrid.RowHeadersWidth = 51;
            sandgrid.Size = new Size(338, 515);
            sandgrid.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 50F;
            dataGridViewTextBoxColumn1.HeaderText = "نام غذا";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Price
            // 
            Price.FillWeight = 50F;
            Price.HeaderText = "قیمت";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 85;
            // 
            // num
            // 
            num.FillWeight = 50F;
            num.HeaderText = "تعداد";
            num.MinimumWidth = 6;
            num.Name = "num";
            num.Width = 75;
            // 
            // drinkgrid
            // 
            drinkgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drinkgrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, Price2, num2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            drinkgrid.DefaultCellStyle = dataGridViewCellStyle3;
            drinkgrid.Location = new Point(419, 162);
            drinkgrid.Name = "drinkgrid";
            drinkgrid.RowHeadersWidth = 51;
            drinkgrid.Size = new Size(338, 515);
            drinkgrid.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 50F;
            dataGridViewTextBoxColumn4.HeaderText = "نام غذا";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Price2
            // 
            Price2.FillWeight = 50F;
            Price2.HeaderText = "قیمت";
            Price2.MinimumWidth = 6;
            Price2.Name = "Price2";
            Price2.Width = 85;
            // 
            // num2
            // 
            num2.FillWeight = 50F;
            num2.HeaderText = "تعداد";
            num2.MinimumWidth = 6;
            num2.Name = "num2";
            num2.Width = 75;
            // 
            // dessergrid
            // 
            dessergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dessergrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, price3, num3 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dessergrid.DefaultCellStyle = dataGridViewCellStyle4;
            dessergrid.Location = new Point(25, 162);
            dessergrid.Name = "dessergrid";
            dessergrid.RowHeadersWidth = 51;
            dessergrid.Size = new Size(338, 515);
            dessergrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 50F;
            dataGridViewTextBoxColumn7.HeaderText = "نام غذا";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // price3
            // 
            price3.FillWeight = 50F;
            price3.HeaderText = "قیمت";
            price3.MinimumWidth = 6;
            price3.Name = "price3";
            price3.Width = 85;
            // 
            // num3
            // 
            num3.FillWeight = 50F;
            num3.HeaderText = "تعداد";
            num3.MinimumWidth = 6;
            num3.Name = "num3";
            num3.Width = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IRANSansX DemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(1325, 95);
            label2.Name = "label2";
            label2.Size = new Size(76, 37);
            label2.TabIndex = 13;
            label2.Text = "پیتـــزا";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("IRANSansX DemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(923, 95);
            label3.Name = "label3";
            label3.Size = new Size(119, 37);
            label3.TabIndex = 14;
            label3.Text = "ساندویـــچ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("IRANSansX DemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.Location = new Point(528, 95);
            label4.Name = "label4";
            label4.Size = new Size(120, 37);
            label4.TabIndex = 15;
            label4.Text = "نوشیـــدنی";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("IRANSansX DemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.Location = new Point(152, 95);
            label5.Name = "label5";
            label5.Size = new Size(84, 37);
            label5.TabIndex = 16;
            label5.Text = "دســـــر";
            // 
            // showprice
            // 
            showprice.Location = new Point(134, 742);
            showprice.Name = "showprice";
            showprice.Size = new Size(131, 43);
            showprice.TabIndex = 17;
            showprice.Text = "نمایش قیمت";
            showprice.UseVisualStyleBackColor = true;
            showprice.Click += showprice_Click;
            // 
            // lbltotalprice
            // 
            lbltotalprice.AutoSize = true;
            lbltotalprice.Font = new Font("IRANSansX DemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lbltotalprice.Location = new Point(112, 810);
            lbltotalprice.Name = "lbltotalprice";
            lbltotalprice.Size = new Size(165, 30);
            lbltotalprice.TabIndex = 18;
            lbltotalprice.Text = "قیمت کل : 0 تومان";
            lbltotalprice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1544, 901);
            Controls.Add(lbltotalprice);
            Controls.Add(showprice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dessergrid);
            Controls.Add(drinkgrid);
            Controls.Add(sandgrid);
            Controls.Add(Pizzagrid);
            Controls.Add(label1);
            Controls.Add(CBcustomer);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت سفارش";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)Pizzagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sandgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)drinkgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dessergrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBcustomer;
        private Label label1;
        private DataGridView Pizzagrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView sandgrid;
        private DataGridView drinkgrid;
        private DataGridView dessergrid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button showprice;
        private Label lbltotalprice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Price2;
        private DataGridViewTextBoxColumn num2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn price3;
        private DataGridViewTextBoxColumn num3;
    }
}