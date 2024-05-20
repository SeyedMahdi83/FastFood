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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pizzafileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Pizza";
            string pizzapath = Path.Combine(pizzafileaddress, textBox1.Text + ".txt");
            string sandfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Sandwich";
            string sandpath = Path.Combine(sandfileaddress, textBox1.Text + ".txt");
            string drinkfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Drink";
            string drinkpath = Path.Combine(drinkfileaddress, textBox1.Text + ".txt");
            string dessertfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Dessert";
            string dessertpath = Path.Combine(dessertfileaddress, textBox1.Text + ".txt");


            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("لطفا تمام فیلد هارو کامل کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("آیا از افزودن غذا اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (comboBox1.Text == "پیتزا")
                    {
                        using (FileStream fs = new FileStream(pizzapath, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(textBox1.Text + "$" + textBox2.Text);
                            }
                        }
                    }
                    if (comboBox1.Text == "ساندویچ")
                    {
                        using (FileStream fs = new FileStream(sandpath, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(textBox1.Text + "$" + textBox2.Text);
                            }
                        }
                    }
                    if (comboBox1.Text == "نوشیدنی")
                    {
                        using (FileStream fs = new FileStream(drinkpath, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(textBox1.Text + "$" + textBox2.Text);
                            }
                        }
                    }
                    if (comboBox1.Text == "دسر")
                    {
                        using (FileStream fs = new FileStream(dessertpath, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(textBox1.Text + "$" + textBox2.Text);
                            }
                        }
                    }
                    MessageBox.Show("غذای مورد نظر ثبت شد", "ثبت موفق");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
