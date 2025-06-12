using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(MainClass.IsValidUser(textBoxUserName.Text, textBoxPassword.Text) == false)
            {
                MessageBox.Show("Invaild username or Password");
                return;
            }
            else
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }

            
        }
    }
}
