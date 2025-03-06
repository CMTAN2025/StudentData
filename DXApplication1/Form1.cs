using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DXApplication1.CLASSES;

namespace DXApplication1
{
    public partial class StudentData : DevExpress.XtraEditors.XtraForm
    {
        private List<Student> students = new List<Student>();
        public StudentData()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Creating an object from Student Class
            Student newStudent = new Student
            {
                FirstName = txtEditFirstName.Text,
                MiddleName = txtEditMiddleName.Text,
                LastName = txtEditLastName.Text,
                Age = ConvertIntoInt32(txtEditAge.Text),
                Course = txtEditCourse.Text,
                YearLevel = ConvertIntoInt32(txtEditYearLevel.Text),
            };


            students.Add(newStudent); //add the input data to the grid

            // Set the grid control's data source
            gridControl1.DataSource = null;
            gridControl1.DataSource = students;

            txtEditFirstName.Text = "";
            txtEditMiddleName.Text = "";
            txtEditLastName.Text = "";
            txtEditAge.Text = "";
            txtEditCourse.Text = "";
            txtEditYearLevel.Text = "";


            gridControl1.RefreshDataSource();

        }

        private int ConvertIntoInt32(object text)
        {
            throw new NotImplementedException();
        }
    }
}
