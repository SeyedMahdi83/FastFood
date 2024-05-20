namespace ProjectFastfood
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Usertxtbx = new TextBox();
            passtxtbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Usertxtbx
            // 
            Usertxtbx.Location = new Point(85, 113);
            Usertxtbx.Name = "Usertxtbx";
            Usertxtbx.Size = new Size(282, 30);
            Usertxtbx.TabIndex = 0;
            Usertxtbx.KeyDown += Usertxtbx_KeyDown;
            // 
            // passtxtbx
            // 
            passtxtbx.Location = new Point(85, 170);
            passtxtbx.Name = "passtxtbx";
            passtxtbx.PasswordChar = '*';
            passtxtbx.RightToLeft = RightToLeft.Yes;
            passtxtbx.Size = new Size(282, 30);
            passtxtbx.TabIndex = 1;
            passtxtbx.KeyDown += passtxtbx_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold);
            label1.Location = new Point(394, 116);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 2;
            label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold);
            label2.Location = new Point(405, 173);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 3;
            label2.Text = "رمز عبور :";
            // 
            // login
            // 
            login.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            login.Location = new Point(160, 248);
            login.Name = "login";
            login.Size = new Size(185, 49);
            login.TabIndex = 4;
            login.Text = "ورود";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(117, 30);
            label3.Name = "label3";
            label3.Size = new Size(267, 44);
            label3.TabIndex = 6;
            label3.Text = "خوش آمدیـــــــــد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(185, 309);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 8;
            label4.Text = "حساب کاربری ندارید؟";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(525, 358);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passtxtbx);
            Controls.Add(Usertxtbx);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usertxtbx;
        private TextBox passtxtbx;
        private Label label1;
        private Label label2;
        private Button login;
        private Label label3;
        private Label label4;
    }
}
