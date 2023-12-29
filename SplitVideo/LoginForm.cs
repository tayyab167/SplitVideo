using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SplitVideo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private static DateTime expirationDate = new DateTime(2023, 12, 31);

        private static List<UserCredentials> userCredentialsList = new List<UserCredentials>
        {
            new UserCredentials { Username = "tamoorpardesi", Password = "tamoor123" },
            new UserCredentials { Username = "admin", Password = "admin123" },
            new UserCredentials { Username = "Test3", Password = "789" },
            new UserCredentials { Username = "Test4", Password = "abc" },
            new UserCredentials { Username = "Test5", Password = "def" }
        };

        private void button1_Click_1(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            // Find the user credentials in the list
            UserCredentials userCredentials = userCredentialsList.Find(uc => uc.Username == enteredUsername && uc.Password == enteredPassword);

            if (userCredentials != null)
            {
                // Valid credentials
                if (DateTime.Now <= expirationDate)
                {
                    // Expiration date is valid
                    Enter_Video form1 = new Enter_Video();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account has expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This button is used to close the form.
            this.Close();
        }
    }
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
