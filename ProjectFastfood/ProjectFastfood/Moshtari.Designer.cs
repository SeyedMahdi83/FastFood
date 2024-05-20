namespace ProjectFastfood
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 59);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 0;
            label1.Text = "نام و نام خانوادگی :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 132);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 1;
            label2.Text = "تلفن همراه :";
            // 
            // button1
            // 
            button1.Location = new Point(39, 423);
            button1.Name = "button1";
            button1.Size = new Size(155, 45);
            button1.TabIndex = 2;
            button1.Text = "ثبت مشتری";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 423);
            button2.Name = "button2";
            button2.Size = new Size(155, 45);
            button2.TabIndex = 3;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 30);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 129);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "*********09";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(242, 30);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 30);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 206);
            label3.Name = "label3";
            label3.Size = new Size(53, 22);
            label3.TabIndex = 7;
            label3.Text = "آدرس :";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(474, 495);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مشتری ها";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
    }
}