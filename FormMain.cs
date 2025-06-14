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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        // Method to add controls in main form
        public void AddControls(Form f)
        {
            ContainerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ContainerPanel.Controls.Add(f);
            f.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myButtonBG(object sender, EventArgs e)
        {
            foreach (Control c in panelButtons.Controls)
            {
                c.BackgroundImage = null;
            }
            // Setting the clicked button
            Control click = (Control)sender;
            click.BackgroundImage = Properties.Resources.pink_button__2_;

        }

        #region Evints
        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUser.Text = MainClass.USER;
        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonHome, null);
            AddControls(new FormHome());
        }
        
        private void buttonCategories_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonCategories, null);
        }
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonProducts, null);
            
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonTables, null);
        }

        private void buttonStaf_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonStaf, null);
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonPOS, null);
        }

        private void buttonKitchen_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonKitchen, null);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            myButtonBG(buttonSettings, null);
        }
        #endregion

        #region Methods
        /*private void buttonColor()
        {
            if (buttonHome.BackgroundImage == null
                || buttonCategories.BackgroundImage == null
                || buttonProducts.BackgroundImage == null
                || buttonTables.BackgroundImage == null
                || buttonStaf.BackgroundImage == null
                || buttonPOS.BackgroundImage == null
                || buttonKitchen.BackgroundImage == null
                || buttonSettings.BackgroundImage == null
                )
            {
                buttonHome.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonCategories.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonProducts.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonTables.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonStaf.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonPOS.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonKitchen.BackgroundImage = Properties.Resources.pink_button__2_;
                buttonSettings.BackgroundImage = Properties.Resources.pink_button__2_;
            }
            else
            {
                buttonHome.BackgroundImage = null;
            }
        }*/
        #endregion
    }
}
