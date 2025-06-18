using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS.Model
{
    public partial class FormCategoryAdd : FormSampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Insert
            {
                qry = "Insert into category Values(@Name)";
            }
            else // Update
            {
                qry = "Update into category catName = @Name where catID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textBoxName.Text);

            if (MainClass.SQl(qry, ht) >0)
            {
                MessageBox.Show("Saved successfully..");
                id = 0;
                textBoxName.Text = "";
                textBoxName.Focus();
            }
        }

        public override void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
