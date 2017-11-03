using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudN2.Models;

namespace CrudN2
{
    public partial class Form1 : Form
    {
        private crudEntities db = new crudEntities();
        private Course selectId;
        private Course selectName;

        public Form1()
        {
            InitializeComponent();
            getData();
        }

        //data
        private void getData()
        {
            dgwData.DataSource = db.Course.ToList();
        }


        //add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add_name = boxName.Text;

            if (add_name.Length > 0)
            {

                Course crs = new Course();
                crs.name = add_name;

                db.Course.Add(crs);
                db.SaveChanges();
                MessageBox.Show("added");
                boxName.Clear();
                getData();


            }
            else
            {
                MessageBox.Show("Errorrrr");
            }
        }

        //mouseClick
        private void deleteMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgwData.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.selectId = db.Course.Find(id);

            //for del
            boxDelId.Text = this.selectId.id.ToString();
            boxDelName.Text = this.selectId.name.ToString();
            //MessageBox.Show(boxDelId.Text);

            //for upd
            boxUpName.Text = this.selectId.name;

        }
         
        //delete
        private void btnDel_Click(object sender, EventArgs e)
        {

            db.Course.Remove(selectId);
            db.SaveChanges();
            boxDelId.Clear();
            MessageBox.Show("Deleted");
            getData();
        }

        //update
        private void btnUp_Click(object sender, EventArgs e)
        {
            this.selectId.name = boxUpName.Text;
            db.SaveChanges();
            getData();
        }


        //search
        private void boxSearchName_TextChanged(object sender, EventArgs e)
        {
            string search = boxSearchName.Text;
            dgwData.DataSource = db.Course.Where(course => course.name.Contains(search)).ToList();
        }

      


    }
}
