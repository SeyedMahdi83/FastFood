namespace ProjectFastfood
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 30);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 150);
            label1.Name = "label1";
            label1.Size = new Size(54, 22);
            label1.TabIndex = 2;
            label1.Text = "قیمت :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 150);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 3;
            label2.Text = "هزار تومان";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 95);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 4;
            label3.Text = "نام غذا :";
            // 
            // button1
            // 
            button1.Location = new Point(302, 238);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 5;
            button1.Text = "بازگشت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(80, 238);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 6;
            button2.Text = "افزودن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "پیتزا", "ساندویچ", "نوشیدنی", "دسر" });
            comboBox1.Location = new Point(80, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 30);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 44);
            label4.Name = "label4";
            label4.Size = new Size(43, 22);
            label4.TabIndex = 8;
            label4.Text = "دسته";
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 322);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFood";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "افزودن غذا";
            Load += AddFood_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label4;
    }
}