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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static string pathaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Customer\\";

        private void button1_Click(object sender, EventArgs e)
        {


            string filepath = (pathaddress + textBox1.Text + ".txt");

            if (File.Exists(filepath))
            {
                MessageBox.Show("یک فایل با نام مشابه وجود دارد. لطفاً نام دیگری انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (FileStream fs = new FileStream(filepath, FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        StringBuilder output = new StringBuilder();
                        output.Append(textBox1.Text + "@");
                        output.Append(textBox2.Text + "@");
                        output.Append(textBox3.Text);
                        writer.WriteLine(output.ToString());
                        output.Clear();
                        writer.Close();
                        MessageBox.Show("!مشتری جدید ثبت شد", "پیغام");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
