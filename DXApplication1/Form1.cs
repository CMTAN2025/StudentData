using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.CLASSES;

namespace DXApplication1
{
    public partial class StudentData : DevExpress.XtraEditors.XtraForm
    {
        private List<Student> students = new List<Student>();
        private DataTable dtStudent = new DataTable();

        public StudentData()
        {
            InitializeComponent();
            grdControlListOfStudent.DataSource = CreateStudentTable();
        }

        private DataTable CreateStudentTable() // Creating Columns for students
        {
            dtStudent.Columns.Add("FirstName", typeof(string));
            dtStudent.Columns.Add("MiddleName", typeof(string));
            dtStudent.Columns.Add("LastName", typeof(string));
            dtStudent.Columns.Add("Age", typeof(int));
            dtStudent.Columns.Add("Course", typeof(string));
            dtStudent.Columns.Add("YearLevel", typeof(string));

            return dtStudent;
        }

        // Add function to add a student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    FirstName = txtEditFirstName.Text.Trim(),
                    MiddleName = txtEditMiddleName.Text.Trim(),
                    LastName = txtEditLastName.Text.Trim(),
                    Age = Convert.ToInt32(txtEditAge.Text.Trim()),
                    Course = txtEditCourse.Text.Trim(),
                    YearLevel = txtEditYearLevel.Text.Trim()
                };

                students.Add(student); // Add student to the list

                DataRow newRow = dtStudent.NewRow();

                newRow["FirstName"] = student.FirstName;
                newRow["MiddleName"] = student.MiddleName;
                newRow["LastName"] = student.LastName;
                newRow["Age"] = student.Age;
                newRow["Course"] = student.Course;
                newRow["YearLevel"] = student.YearLevel;

                dtStudent.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            grdControlListOfStudent.DataSource = dtStudent;
            grdViewListOfStudent.RefreshData();
            Clear(); // Clear input fields
        }


        //REMOVING A DATA
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = grdViewListOfStudent.FocusedRowHandle;

            if (focusedRowHandle == 0)
            {
                DataRow rowToDelete = grdViewListOfStudent.GetDataRow(focusedRowHandle);
                if (rowToDelete != null)
                {
                    dtStudent.Rows.Remove(rowToDelete);

                    grdControlListOfStudent.DataSource = dtStudent;
                    grdViewListOfStudent.RefreshData();
                    grdViewListOfStudent.RefreshData();

                }
            }
            else
            {
                XtraMessageBox.Show("Please select a row to remove.", "EMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Clear() //To Clear TextBoxes after adding
        {
            txtEditFirstName.Text = "";
            txtEditMiddleName.Text = "";
            txtEditLastName.Text = "";
            txtEditAge.Text = "";
            txtEditCourse.Text = "";
            txtEditYearLevel.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected student's index based on FirstName (or any unique identifier)
                string selectedFirstName = grdViewListOfStudent.GetFocusedRowCellValue("FirstName")?.ToString();

                var student = students.FirstOrDefault(s => s.FirstName == selectedFirstName);

                if (student != null)
                {
                    // Update student object in the list
                    student.FirstName = txtEditFirstName.Text.Trim();
                    student.MiddleName = txtEditMiddleName.Text.Trim();
                    student.LastName = txtEditLastName.Text.Trim();
                    student.Age = Convert.ToInt32(txtEditAge.Text.Trim());
                    student.Course = txtEditCourse.Text.Trim();
                    student.YearLevel = txtEditYearLevel.Text.Trim();

                    // Find corresponding row in DataTable and update it
                    DataRow rowToUpdate = dtStudent.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(row => row["FirstName"].ToString() == selectedFirstName);

                    if (rowToUpdate != null)
                    {
                        rowToUpdate["FirstName"] = student.FirstName;
                        rowToUpdate["MiddleName"] = student.MiddleName;
                        rowToUpdate["LastName"] = student.LastName;
                        rowToUpdate["Age"] = student.Age;
                        rowToUpdate["Course"] = student.Course;
                        rowToUpdate["YearLevel"] = student.YearLevel;
                    }

                    // Refresh GridControl
                    grdControlListOfStudent.DataSource = dtStudent;
                    grdViewListOfStudent.RefreshData();

                    XtraMessageBox.Show("Student record successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear(); // Clear input fields
        }
        private void ReLoadListOfStudents(string searchKeyword = "") //Method to Filter Student
        {
            DataView dv = dtStudent.DefaultView;

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                dv.RowFilter = $"FirstName LIKE '%{searchKeyword}%' OR " +
                               $"MiddleName LIKE '%{searchKeyword}%' OR " +
                               $"LastName LIKE '%{searchKeyword}%' OR " +
                               $"Course LIKE '%{searchKeyword}%' OR " +
                               $"YearLevel LIKE '%{searchKeyword}%'";
            }
            else
            {
                dv.RowFilter = ""; // Reset filter if empty
            }

            grdControlListOfStudent.DataSource = dv.ToTable(); // Update GridControl
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtEditSearchStudent.Text.Trim();
            ReLoadListOfStudents(searchKeyword);
        }
    }
}








