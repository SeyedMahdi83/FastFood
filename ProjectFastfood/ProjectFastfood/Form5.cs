using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectFastfood
{
    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void Form5_Load(object sender, EventArgs e)
        {
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
                    string name = parts[0];
                    string price = parts[1];

                    listPizza.Items.Add($"{name}({price})");
                }
            }
            foreach (string s in sandwich)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string price = parts[1];

                    listSandwich.Items.Add($"{name}({price})");
                }
            }
            foreach (string s in drink)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string price = parts[1];

                    listDrink.Items.Add($"{name}({price})");
                }
            }
            foreach (string s in desset)
            {
                string content = File.ReadAllText(s);

                string[] parts = content.Split('$');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string price = parts[1];

                    listDessert.Items.Add($"{name}({price})");
                }
            }

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
