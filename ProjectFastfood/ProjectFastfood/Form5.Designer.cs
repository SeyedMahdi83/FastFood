namespace ProjectFastfood
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            listPizza = new ListBox();
            listSandwich = new ListBox();
            listDrink = new ListBox();
            listDessert = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // listPizza
            // 
            listPizza.FormattingEnabled = true;
            listPizza.ItemHeight = 22;
            listPizza.Location = new Point(594, 69);
            listPizza.Name = "listPizza";
            listPizza.Size = new Size(150, 334);
            listPizza.TabIndex = 0;
            // 
            // listSandwich
            // 
            listSandwich.FormattingEnabled = true;
            listSandwich.ItemHeight = 22;
            listSandwich.Location = new Point(415, 69);
            listSandwich.Name = "listSandwich";
            listSandwich.Size = new Size(150, 334);
            listSandwich.TabIndex = 1;
            // 
            // listDrink
            // 
            listDrink.FormattingEnabled = true;
            listDrink.ItemHeight = 22;
            listDrink.Location = new Point(236, 69);
            listDrink.Name = "listDrink";
            listDrink.Size = new Size(150, 334);
            listDrink.TabIndex = 2;
            // 
            // listDessert
            // 
            listDessert.FormattingEnabled = true;
            listDessert.ItemHeight = 22;
            listDessert.Location = new Point(57, 69);
            listDessert.Name = "listDessert";
            listDessert.Size = new Size(150, 334);
            listDessert.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 29);
            label1.Name = "label1";
            label1.Size = new Size(37, 22);
            label1.TabIndex = 4;
            label1.Text = "پیتزا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 5;
            label2.Text = "ساندویچ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 29);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 6;
            label3.Text = "نوشیدنی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 29);
            label4.Name = "label4";
            label4.Size = new Size(35, 22);
            label4.TabIndex = 7;
            label4.Text = "دسر";
            // 
            // button2
            // 
            button2.Location = new Point(620, 431);
            button2.Name = "button2";
            button2.Size = new Size(124, 38);
            button2.TabIndex = 9;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listDessert);
            Controls.Add(listDrink);
            Controls.Add(listSandwich);
            Controls.Add(listPizza);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form5";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.Manual;
            Text = "لیست غذا";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPizza;
        private ListBox listSandwich;
        private ListBox listDrink;
        private ListBox listDessert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}