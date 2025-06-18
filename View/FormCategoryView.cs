using RS.Model;
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

namespace RS.View
{
    public partial class FormCategoryView : FormSambleView
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * From category where catName like '%"+ textBoxSearch.Text +"%' ";
            ListBox ld = new ListBox();
            ld.Items.Add(dgvid);
            ld.Items.Add(dgvName);

            MainClass.LoadData(qry, dataGridView1, ld);
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd add = new FormCategoryAdd();
            add.ShowDialog();
            GetData();
        }

        public override void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormCategoryAdd formCategoryAdd = new FormCategoryAdd();
                formCategoryAdd.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                formCategoryAdd.textBoxName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                formCategoryAdd.ShowDialog();
                GetData();
            }
            if(dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from category where catID= " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQl(qry,ht);

                MessageBox.Show("Deleted Successfully");
                GetData();
            }
        }
    }
}
