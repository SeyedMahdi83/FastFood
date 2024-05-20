namespace ProjectFastfood
{
    partial class deluser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deluser));
            txtPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(49, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 30);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 65);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 1;
            label1.Text = "رمز عبور خود را وارد کنید :";
            // 
            // button1
            // 
            button1.Location = new Point(293, 146);
            button1.Name = "button1";
            button1.Size = new Size(139, 45);
            button1.TabIndex = 2;
            button1.Text = "بازگشت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 146);
            button2.Name = "button2";
            button2.Size = new Size(139, 45);
            button2.TabIndex = 3;
            button2.Text = "حذف حساب کاربری";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deluser
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(520, 241);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "deluser";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حذف حساب کاربری";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}