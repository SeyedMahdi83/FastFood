namespace ProjectFastfood
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            signup = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANSansX DemiBold", 10F, FontStyle.Bold);
            label1.Location = new Point(436, 126);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IRANSansX DemiBold", 10F, FontStyle.Bold);
            label2.Location = new Point(451, 186);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "رمز عبور :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("IRANSansX DemiBold", 10F, FontStyle.Bold);
            label3.Location = new Point(378, 66);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 2;
            label3.Text = "نام و نام خانوادگی :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 30);
            textBox1.TabIndex = 3;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 30);
            textBox2.TabIndex = 4;
            textBox2.KeyDown += textBox1_KeyDown;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 183);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(283, 30);
            textBox3.TabIndex = 5;
            textBox3.KeyDown += textBox1_KeyDown;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox3.Validating += textBox3_Validating;
            // 
            // signup
            // 
            signup.Location = new Point(200, 303);
            signup.Name = "signup";
            signup.Size = new Size(184, 43);
            signup.TabIndex = 7;
            signup.Text = "ثبت نام";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(66, 243);
            textBox4.MaxLength = 10;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(283, 30);
            textBox4.TabIndex = 6;
            textBox4.KeyDown += textBox1_KeyDown;
            textBox4.Validating += textBox4_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("IRANSansX DemiBold", 10F, FontStyle.Bold);
            label4.Location = new Point(416, 244);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 8;
            label4.Text = "تکرار رمز عبور :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(209, 371);
            label5.Name = "label5";
            label5.Size = new Size(167, 22);
            label5.TabIndex = 10;
            label5.Text = "حساب کاربری فعال دارید؟";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // errorProvider2
            // 
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.ContainerControl = this;
            errorProvider2.RightToLeft = true;
            // 
            // errorProvider3
            // 
            errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider3.ContainerControl = this;
            errorProvider3.RightToLeft = true;
            // 
            // errorProvider4
            // 
            errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider4.ContainerControl = this;
            errorProvider4.RightToLeft = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 417);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(signup);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت نام";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button signup;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}