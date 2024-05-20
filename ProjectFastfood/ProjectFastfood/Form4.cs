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
    public partial class Form4 : Form
    {
        Form5 f5 = new Form5();
        public Form4()
        {
            InitializeComponent();

        }
        public string Customerpath = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Customer";
        private void Form4_Load(object sender, EventArgs e)
        {
            CBcustomer.Items.Clear();
            foreach (string f in Directory.GetFiles(Customerpath, "*.txt"))
            {
                CBcustomer.Items.Add(Path.GetFileNameWithoutExtension(f));
            }

            string pizzafileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Pizza";
            string sandfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Sandwich";
            string drinkfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Drink";
            string dessertfileaddress = "C:\\Users\\ASUS\\Desktop\\Fast Food\\Foods\\Dessert";


            string[] Pizaa = Directory.GetFiles(pizzafileaddress, "*.txt");
            string[] sandwich = Directory.GetFiles(sandfileaddress, "*.txt");
            string[] drink = Directory.GetFiles(drinkfileaddress, "*.txt");
            string[] desset = Directory.GetFiles(dessertfileaddress, "*.txt");



            foreach (string s in Pizaa)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    Pizzagrid.Rows.Add(parts[0], parts[1], 0);
                }
            }

            foreach (string s in sandwich)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    sandgrid.Rows.Add(parts[0], parts[1], 0);
                }
            }

            foreach (string s in drink)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    drinkgrid.Rows.Add(parts[0], parts[1], 0);
                }
            }

            foreach (string s in desset)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    dessergrid.Rows.Add(parts[0], parts[1], 0);
                }
            }


        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showprice_Click(object sender, EventArgs e)
        {
            int totalprice = 0;

            foreach (DataGridViewRow row in Pizzagrid.Rows)
            {
                if (row.Cells["Column3"].Value != null && row.Cells["Column2"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["Column2"].Value.ToString());
                    int price = int.Parse(row.Cells["Column3"].Value.ToString());
                    totalprice += quantity * price * 1000;
                }
            }

            foreach (DataGridViewRow row in sandgrid.Rows)
            {
                if (row.Cells["Price"].Value != null && row.Cells["num"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["num"].Value.ToString());
                    int price = int.Parse(row.Cells["Price"].Value.ToString());
                    totalprice += quantity * price * 1000;
                }
            }

            foreach (DataGridViewRow row in drinkgrid.Rows)
            {
                if (row.Cells["Price2"].Value != null && row.Cells["num2"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["num2"].Value.ToString());
                    int price = int.Parse(row.Cells["Price2"].Value.ToString());
                    totalprice += quantity * price * 1000;
                }
            }

            foreach (DataGridViewRow row in dessergrid.Rows)
            {
                if (row.Cells["price3"].Value != null && row.Cells["num3"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["num3"].Value.ToString());
                    int price = int.Parse(row.Cells["price3"].Value.ToString());
                    totalprice += quantity * price * 1000;
                }
            }


            lbltotalprice.Text = $"قیمت کل: {totalprice} تومان";
        }
    }
}
