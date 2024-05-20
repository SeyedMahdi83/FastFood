namespace ProjectFastfood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        public static string Fullname = "";
        public static string Username = "";
        public static string Password = "";
        public static string status = "";

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(140, 0, 190);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\ASUS\\Desktop\\Fast Food\\Admins\\Admin.txt"))
            {
                bool flag = true;
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
                            Fullname = parts[0];
                            Username = parts[1];
                            Password = parts[2];
                            status = parts[3];
                            if (Username == Usertxtbx.Text && Password == passtxtbx.Text && status == "1")
                            {
                                flag = false;
                                Form3 f3 = new Form3();
                                Username = Usertxtbx.Text;
                                f3.Show();
                                this.Hide();
                                break;
                            }
                        }

                    } while (!reader.EndOfStream);
                    if (flag)
                    {
                        MessageBox.Show("!نام کاربری یا رمز عبور اشتباه است", "خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally { fs.Close(); }
                

            }
            else
                MessageBox.Show("!نام کاربری یا رمز عبور اشتباه است", "خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void passtxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }
        }

        private void Usertxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }
        }
    }
}
