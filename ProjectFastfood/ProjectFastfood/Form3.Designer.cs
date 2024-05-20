namespace ProjectFastfood
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            بازکردنToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            خروجازبرنامهToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            حسابکاربریToolStripMenuItem = new ToolStripMenuItem();
            خروجازحسابکاربریToolStripMenuItem = new ToolStripMenuItem();
            حذفحسابکاربریToolStripMenuItem = new ToolStripMenuItem();
            مشتریانToolStripMenuItem = new ToolStripMenuItem();
            افزودنمشتریToolStripMenuItem = new ToolStripMenuItem();
            حذفمشتریToolStripMenuItem = new ToolStripMenuItem();
            پنلهاToolStripMenuItem = new ToolStripMenuItem();
            ویرایشغذهاToolStripMenuItem = new ToolStripMenuItem();
            افزودنغذاToolStripMenuItem = new ToolStripMenuItem();
            ثبتسفارشToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "FastFood";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { بازکردنToolStripMenuItem, toolStripMenuItem1, خروجازبرنامهToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(165, 58);
            // 
            // بازکردنToolStripMenuItem
            // 
            بازکردنToolStripMenuItem.Name = "بازکردنToolStripMenuItem";
            بازکردنToolStripMenuItem.Size = new Size(164, 24);
            بازکردنToolStripMenuItem.Text = "بازکردن";
            بازکردنToolStripMenuItem.Click += بازکردنToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(161, 6);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            خروجازبرنامهToolStripMenuItem.Size = new Size(164, 24);
            خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            خروجازبرنامهToolStripMenuItem.Click += خروجازبرنامهToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { حسابکاربریToolStripMenuItem, مشتریانToolStripMenuItem, پنلهاToolStripMenuItem, ثبتسفارشToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1482, 40);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // حسابکاربریToolStripMenuItem
            // 
            حسابکاربریToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { خروجازحسابکاربریToolStripMenuItem, حذفحسابکاربریToolStripMenuItem });
            حسابکاربریToolStripMenuItem.Name = "حسابکاربریToolStripMenuItem";
            حسابکاربریToolStripMenuItem.Size = new Size(106, 36);
            حسابکاربریToolStripMenuItem.Text = "حساب کاربری";
            // 
            // خروجازحسابکاربریToolStripMenuItem
            // 
            خروجازحسابکاربریToolStripMenuItem.Name = "خروجازحسابکاربریToolStripMenuItem";
            خروجازحسابکاربریToolStripMenuItem.Size = new Size(225, 26);
            خروجازحسابکاربریToolStripMenuItem.Text = "خروج از حساب کاربری";
            خروجازحسابکاربریToolStripMenuItem.Click += خروجازحسابکاربریToolStripMenuItem_Click;
            // 
            // حذفحسابکاربریToolStripMenuItem
            // 
            حذفحسابکاربریToolStripMenuItem.Name = "حذفحسابکاربریToolStripMenuItem";
            حذفحسابکاربریToolStripMenuItem.Size = new Size(225, 26);
            حذفحسابکاربریToolStripMenuItem.Text = "حذف حساب کاربری";
            حذفحسابکاربریToolStripMenuItem.Click += حذفحسابکاربریToolStripMenuItem_Click;
            // 
            // مشتریانToolStripMenuItem
            // 
            مشتریانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { افزودنمشتریToolStripMenuItem, حذفمشتریToolStripMenuItem });
            مشتریانToolStripMenuItem.Name = "مشتریانToolStripMenuItem";
            مشتریانToolStripMenuItem.Size = new Size(76, 36);
            مشتریانToolStripMenuItem.Text = "مشتریان";
            // 
            // افزودنمشتریToolStripMenuItem
            // 
            افزودنمشتریToolStripMenuItem.Name = "افزودنمشتریToolStripMenuItem";
            افزودنمشتریToolStripMenuItem.Size = new Size(194, 26);
            افزودنمشتریToolStripMenuItem.Text = "افزودن مشتری";
            افزودنمشتریToolStripMenuItem.Click += افزودنمشتریToolStripMenuItem_Click;
            // 
            // حذفمشتریToolStripMenuItem
            // 
            حذفمشتریToolStripMenuItem.Name = "حذفمشتریToolStripMenuItem";
            حذفمشتریToolStripMenuItem.Size = new Size(194, 26);
            حذفمشتریToolStripMenuItem.Text = "لیست مشتری ها";
            حذفمشتریToolStripMenuItem.Click += حذفمشتریToolStripMenuItem_Click;
            // 
            // پنلهاToolStripMenuItem
            // 
            پنلهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ویرایشغذهاToolStripMenuItem, افزودنغذاToolStripMenuItem });
            پنلهاToolStripMenuItem.Name = "پنلهاToolStripMenuItem";
            پنلهاToolStripMenuItem.Size = new Size(58, 36);
            پنلهاToolStripMenuItem.Text = "غذاها";
            // 
            // ویرایشغذهاToolStripMenuItem
            // 
            ویرایشغذهاToolStripMenuItem.Name = "ویرایشغذهاToolStripMenuItem";
            ویرایشغذهاToolStripMenuItem.Size = new Size(172, 26);
            ویرایشغذهاToolStripMenuItem.Text = "لیست غذا ها";
            ویرایشغذهاToolStripMenuItem.Click += ویرایشغذهاToolStripMenuItem_Click;
            // 
            // افزودنغذاToolStripMenuItem
            // 
            افزودنغذاToolStripMenuItem.Name = "افزودنغذاToolStripMenuItem";
            افزودنغذاToolStripMenuItem.Size = new Size(172, 26);
            افزودنغذاToolStripMenuItem.Text = "افزودن غذا";
            افزودنغذاToolStripMenuItem.Click += افزودنغذاToolStripMenuItem_Click;
            // 
            // ثبتسفارشToolStripMenuItem
            // 
            ثبتسفارشToolStripMenuItem.Name = "ثبتسفارشToolStripMenuItem";
            ثبتسفارشToolStripMenuItem.Size = new Size(99, 36);
            ثبتسفارشToolStripMenuItem.Text = "ثبت سفارش";
            ثبتسفارشToolStripMenuItem.Click += ثبتسفارشToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.IndianRed;
            BackgroundImage = Properties.Resources._10351122_4452317;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 723);
            Controls.Add(menuStrip1);
            Font = new Font("IRANSansX DemiBold", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form3";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem بازکردنToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem حسابکاربریToolStripMenuItem;
        private ToolStripMenuItem خروجازحسابکاربریToolStripMenuItem;
        private ToolStripMenuItem حذفحسابکاربریToolStripMenuItem;
        private ToolStripMenuItem مشتریانToolStripMenuItem;
        private ToolStripMenuItem افزودنمشتریToolStripMenuItem;
        private ToolStripMenuItem حذفمشتریToolStripMenuItem;
        private ToolStripMenuItem پنلهاToolStripMenuItem;
        private ToolStripMenuItem ویرایشغذهاToolStripMenuItem;
        private ToolStripMenuItem ثبتسفارشToolStripMenuItem;
        private ToolStripMenuItem افزودنغذاToolStripMenuItem;
    }
}