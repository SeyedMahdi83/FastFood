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
    public partial class ListMoshtari : Form
    {
        public string Customerpath = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Customer";
        public ListMoshtari()
        {
            InitializeComponent();
        }

        private void ListMoshtari_Load(object sender, EventArgs e)
        {


            CBcustomer.Items.Clear();
            foreach (string f in Directory.GetFiles(Customerpath, "*.txt"))
            {
                CBcustomer.Items.Add(Path.GetFileNameWithoutExtension(f));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CBcustomer.Items.Contains(CBcustomer.Text))
            {
                MessageBox.Show("اسم وارد شده در لیست مشتریان وجود ندارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            string selectedCustomer = CBcustomer.SelectedItem.ToString();
            string filepath = Path.Combine(Customerpath, selectedCustomer + ".txt");
            if(textBox2.Enabled ==  false )
            {
                return;
            }
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox3.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("آیا از ویرایش کاربر اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine(textBox2.Text + "@" + textBox3.Text + "@" + textBox4.Text);
                            writer.Close();
                            MessageBox.Show("ویرایش کاربر با موفقیت انجام شد" , "ویرایش");
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            button3.Enabled = true;
                            Deletebtn.Enabled = false;
                        }
                    }
                }
            }
            else
                MessageBox.Show("لطفا تمامی فیلد هارا کامل کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!CBcustomer.Items.Contains(CBcustomer.Text))
            {
                MessageBox.Show("اسم وارد شده در لیست مشتریان وجود ندارد" , "اخطار" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                string selectedCustomer = CBcustomer.SelectedItem.ToString();
                string filepath = Path.Combine(Customerpath, selectedCustomer + ".txt");

                if (File.Exists(filepath))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(filepath))
                        {
                            string customerdetails = reader.ReadLine();
                            string[] parts = customerdetails.Split('@');
                            if (parts.Length == 3)
                            {
                                textBox2.Text = parts[0];
                                textBox3.Text = parts[1];
                                textBox4.Text = parts[2];
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا هنگام خواندن فایل: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("مشتری مورد نظر یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!CBcustomer.Items.Contains(CBcustomer.Text))
            {
                MessageBox.Show("مشتری برای ویرایش انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                Deletebtn.Enabled = true;
                button3.Enabled = false;
                button5_Click(sender, e);
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (!CBcustomer.Items.Contains(CBcustomer.Text))
            {
                MessageBox.Show("اسم وارد شده در لیست مشتریان وجود ندارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selected = CBcustomer.SelectedItem.ToString();
                string path = Path.Combine(Customerpath, selected + ".txt");
                DialogResult Delete = MessageBox.Show("آیا میخواهید مشتری انتخاب شده را حذف کنید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Delete == DialogResult.Yes)
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                        MessageBox.Show("مشتری با موفقیت حذف شد", "پیغام");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        CBcustomer.Items.Remove(selected);
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
