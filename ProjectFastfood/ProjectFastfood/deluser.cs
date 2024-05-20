using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFastfood
{
    public partial class deluser : Form
    {
        public deluser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            DialogResult result = MessageBox.Show("آیا از حذف حساب کاربری خود مطمئین هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                string filePath = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Admins\\Admin.txt";
                string passwordToCheck = txtPassword.Text;
                string username = Form1.Username;

                
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('#');
                    if (parts.Length == 4 && parts[2] == passwordToCheck && parts[1] == username)
                    {
                        flag = true;
                        parts[3] = "0";
                        lines[i] = string.Join("#", parts);
                        MessageBox.Show("حساب کاربری با موفقیت حذف شد", "پیغام");
                        this.Close();
                        Application.Restart();
                    }
                    if (!flag)
                    {
                        MessageBox.Show("رمز عبور شما اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                File.WriteAllLines(filePath, lines);
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
