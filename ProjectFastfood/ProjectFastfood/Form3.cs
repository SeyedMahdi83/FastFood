using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjectFastfood
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = Form1.Fullname;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ویرایشغذهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Form5))
                {
                    f.Activate();
                    return;
                }
            }
            f5.MdiParent = this;
            f5.Show();
        }

        private void ثبتسفارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Form4))
                {
                    f.Activate();
                    return;
                }
            }
            f4.Show();
            f4.MdiParent = this;
        }

        private void افزودنمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Form6))
                {
                    f.Activate();
                    return;
                }
            }
            f6.ShowDialog();
            f6.MdiParent = this;

        }

        private void حذفمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListMoshtari lm = new ListMoshtari();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ListMoshtari))
                {
                    f.Activate();
                    return;
                }
            }
            lm.ShowDialog();
            lm.MdiParent = this;
        }

        private void افزودنغذاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.ShowDialog();
            addFood.MdiParent = this;
        }

        private void حذفحسابکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deluser du = new deluser();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(deluser))
                {
                    f.Activate();
                    return;
                }
            }
            du.ShowDialog();
            du.MdiParent = this;
        }

        private void خروجازحسابکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r =  MessageBox.Show("آیا از حساب کاربری خود خارج میشوید؟" , "پیغام" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }
    }
}
