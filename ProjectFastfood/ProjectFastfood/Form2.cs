using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectFastfood
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(140, 0, 190);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("لطفا تمامی فیلد هارا پر کنید !", "خطا در ثبت نام");
            }
            else
            {
                bool flag = true;
                if(File.Exists("C:\\Users\\ASUS\\Desktop\\Fast Food\\Admins\\Admin.txt"))
                {
                        string checkuser = "";
                        string status = "0";
                        FileStream fs = new FileStream("C:\\Users\\ASUS\\Desktop\\Fast Food\\Admins\\Admin.txt", FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fs);
                    try
                    {
                        do
                        {

                            string line = reader.ReadLine();
                            string[] parts = line.Split('#');
                            if (parts.Length == 4)
                            {
                                checkuser = parts[1];
                                status = parts[3];

                            }
                            if(checkuser == textBox2.Text && status == "1")
                            {
                                flag = false;
                            }
                        } while (!reader.EndOfStream);
                    }
                    finally
                    {
                        if(fs != null)
                        {
                            fs.Close();
                        }
                    }
                }
                
                if(!flag)
                {
                    MessageBox.Show("!نام کاربری تکراری است" , "خطا" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                if (textBox3.Text == textBox4.Text && flag)
                {
                    if (textBox3.Text.Length > 6)
                    {
                        FileStream fs = new FileStream("C:\\Users\\ASUS\\Desktop\\Fast Food\\Admins\\Admin.txt", FileMode.Append);
                        StreamWriter writer = new StreamWriter(fs);
                        StringBuilder output = new StringBuilder();
                        output.Append(textBox1.Text + "#");
                        output.Append(textBox2.Text + "#");
                        output.Append(textBox3.Text + "#1");
                        writer.WriteLine(output.ToString());
                        output.Clear();
                        writer.Close();
                        MessageBox.Show("حساب کاربری جدید ثبت شد !", "ثبت کاربر");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("رمز عبور باید بیشتر از 6 رقم باشد !", "خطای رمز عبور");
                }
                else if(textBox3.Text != textBox4.Text && flag)
                {
                    MessageBox.Show("رمز عبور همخوانی ندارد !", "خطای رمز عبور");
                }
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetIconPadding(textBox1, 10);
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
                errorProvider1.Clear();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            errorProvider2.SetIconPadding(textBox2, 10);
            if (textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
                errorProvider2.Clear();
        }



        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            errorProvider4.SetIconPadding(textBox4, 10);
            if (textBox4.Text == string.Empty)
            {
                errorProvider4.SetError(textBox4, "لطفا رمز عبور را وارد کنید");
            }
            else
                errorProvider4.Clear();
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            errorProvider3.SetIconPadding(textBox3, 10);
            if (textBox3.Text == string.Empty)
            {
                errorProvider3.SetError(textBox3, "لطفا رمز عبور را وارد کنید");
            }
            else
                errorProvider3.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signup_Click(sender, e);
            }
        }
    }
}
