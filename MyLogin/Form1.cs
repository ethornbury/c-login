using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin
{
    public partial class Login : Form
    {
        HashCode hc = new HashCode();
        //instantiate the class

        string username = "admin";
        string password = "password";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBxUser.Text;
            string pass = hc.PassHash(txtBxPass.Text);
            

            // data is hashed and assigned
            if(user == username)
            {
                if(pass == password)
                {
                    txtBxPass.Clear();
                    txtBxUser.Clear();
                    MessageBox.Show("You are logged in!");                    
                }
                else
                {
                    txtBxPass.Clear();
                    txtBxUser.Clear();
                    MessageBox.Show("Password is wrong");                   
                }
            }
            else
            {
                txtBxPass.Clear();
                txtBxUser.Clear();
                MessageBox.Show("Username is wrong");
            }
            
        }
    }
}
