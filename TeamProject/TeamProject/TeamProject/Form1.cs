using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class courseChooserForm : Form
    {
        public courseChooserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Will open a Student form, appropriate to the Inputted Course Number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showStudentsBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + potentialCourseNo.Text;
            try
            {
                if(potentialCourseNo.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a course!");
                }
                else if (Directory.Exists(path))
                {
                    studentForm studentform = new studentForm(potentialCourseNo.Text);
                    studentform.ShowDialog();
                }
                else
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Course does NOT exist! Would you like to create the course?";
                    string caption = "Course doesn't exist";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    //if the user clicks Yes, will create the appropriate directory and files to set up the course.
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Directory.CreateDirectory(path);
                        string studentPath = path + "/" + "students_" + potentialCourseNo.Text + ".txt";
                        File.CreateText(studentPath).Close();
                        string categoryPath = path + "/" + "categories_" + potentialCourseNo.Text + ".txt";
                        File.CreateText(categoryPath).Close();
                        
                        studentForm studentform = new studentForm(potentialCourseNo.Text);
                        studentform.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Will open a Category form, appropriate to the Inputted Course Number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showCategoriesBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + potentialCourseNo.Text;
            try
            {
                if (potentialCourseNo.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a course!");
                }
                else if (Directory.Exists(path))
                {
                    categoryForm categoryform = new categoryForm(potentialCourseNo.Text);
                    categoryform.ShowDialog();
                }
                else
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Course does NOT exist! Would you like to create the course?";
                    string caption = "Course doesn't exist";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    //if the user clicks Yes, will create the appropriate directory and files to set up the course.
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Directory.CreateDirectory(path);
                        string studentPath = path + "/" + "students_" + potentialCourseNo.Text + ".txt";
                        File.CreateText(studentPath).Close();
                        string categoryPath = path + "/" + "categories_" + potentialCourseNo.Text + ".txt";
                        File.CreateText(categoryPath).Close();

                        categoryForm categoryform = new categoryForm(potentialCourseNo.Text);
                        categoryform.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
