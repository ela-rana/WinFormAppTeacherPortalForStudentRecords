using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormAppTeacherPortalForStudentRecords
{
    public partial class TeacherPortal : Form
    {
        string path = "StudentFiles.txt";
        string topStudentPath = "TopStudents.txt";
        List<Student> students = new List<Student>();
        public TeacherPortal()
        {
            InitializeComponent();
        }
        private void TeacherPortal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //to close the app when we exit out of the Teacher Portal form
            //without this statement the app will continue running because the Login Form is still active, although not visible
        }
        private void TeacherPortal_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            dtgrdDisplayStudent.DataSource = null;
            students.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        students.Add(new Student()
                        {
                            StudentId = Int32.Parse(sr.ReadLine()),
                            Name = sr.ReadLine(),
                            GPA = Single.Parse(sr.ReadLine())
                        });
                    }
                    dtgrdDisplayStudent.DataSource = students;
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("There are currently no student records to display. Grid will be blank.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtStudentID.Clear();
            txtName.Clear();
            txtGPA.Clear();
        }
        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            int temp;   //a temporary variable to hold the value entered in the Student ID textbox
            bool parsed = Int32.TryParse(txtStudentID.Text, out temp);  //bool to check if user entered value parses to an integer
            if(parsed== false || temp < 1)  //if user entry is not an int or id is 0 or a negative number, then we need to get new entry
            {
                MessageBox.Show("Student ID must be a whole number ID greater than 0.\nIt cannot be blank"); //show error message
                txtStudentID.Clear();   //blank out the textbox so value can be reentered
                e.Cancel = true;    //the value is invalid, so keep the focus (cursor) still on this box
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                MessageBox.Show("Name cannot be blank"); //show error message
                e.Cancel = true;    //e.cancel says that the value is invalid, keep focus still on the same textbox 
            }
        }
        private void txtGPA_Validating(object sender, CancelEventArgs e)
        {
            float temp;   //a temporary variable to hold the value entered in the GPA textbox
            bool parsed = Single.TryParse(txtGPA.Text, out temp);  //bool to check if user entered value parses to a float
            if (parsed == false || temp < 0 || temp > 4)  //if user entry is not a float or GPA is not between 0.0-4.0
            {
                MessageBox.Show("GPA value must be a whole number or decimal between 0.00 to 4.00\nIt cannot be blank"); //show error message
                txtGPA.Clear();   //blank out the textbox so value can be reentered
                e.Cancel = true;    //the value is invalid, so keep the focus (cursor) still on this box
            }
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(txtStudentID.Text != String.Empty && txtName.Text != String.Empty && txtGPA.Text != String.Empty)
            {
                try
                {
                    File.AppendAllText(path, txtStudentID.Text + "\n");
                    File.AppendAllText(path, txtName.Text + "\n");
                    File.AppendAllText(path, txtGPA.Text + "\n");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Record added.");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("All fields must be filled before adding record");
            }
        }
        private void btnSaveTopStudent_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            try
            {
                float maxGPA = students.Max(x => x.GPA);
                File.WriteAllText(topStudentPath, String.Empty);
                foreach (Student student in students)
                {
                    if (student.GPA == maxGPA)
                    {
                        File.AppendAllText(topStudentPath, student.StudentId + "\n");
                        File.AppendAllText(topStudentPath, student.Name + "\n");
                        File.AppendAllText(topStudentPath, student.GPA + "\n");
                    }
                }
                MessageBox.Show($"Top students have been added to the file: {topStudentPath}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dtgrdDisplayStudent.SelectedRows == null)
            {
                MessageBox.Show("There is nothing available or selected to delete");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete: ", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string idToDelete = dtgrdDisplayStudent.CurrentRow.Cells[0].Value.ToString();
                    int deleteLine = 1;
                    StringBuilder sb = new StringBuilder(); //sb will hold the file's contents minus the record to delete
                    try
                    {
                        using (StreamReader sr = new StreamReader(path))
                        {
                            while (!sr.EndOfStream)
                            {
                                if(sr.ReadLine() != idToDelete) //reads id line
                                {
                                    sr.ReadLine();  //to read name line for that record
                                    sr.ReadLine();  //to read GPA line for that record
                                    deleteLine += 3;    //to move up 3 lines to the location of the next record
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        using (StreamReader sr = new StreamReader(path))
                        {
                            for(int line = 1; line<deleteLine; line++)
                            {
                                sb.AppendLine(sr.ReadLine());   //adds (appends) every line of text before the line to delete to sb 
                            }
                            sr.ReadLine();  //to skip adding the record to delete to sb by reading the line but not assigning it to anything
                            sr.ReadLine();  //to skip the name field of that record
                            sr.ReadLine();  //to skip the GPA field of that record
                            while(!sr.EndOfStream)
                            {
                                sb.AppendLine(sr.ReadLine());   //to add all the remaining lines after skipping the delete line to sb
                            }
                        }
                        //Now sb contains our entire file minus the record to delete. 
                        //Now we will open the file in write mode and overwrite the old data with everything stored in sb
                        File.WriteAllText(path, sb.ToString());
                        MessageBox.Show("Record deleted");
                        RefreshGrid();  //then we will refresh our grid to display the updated data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
