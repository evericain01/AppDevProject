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
    public partial class studentForm : Form
    {
        public string courseNo;
        public string path;
        /// <summary>
        /// Sets the Inputted Course Number as a global variable, and sets the current course path being used by the form.
        /// </summary>
        /// <param name="courseNo">Inputted Course Number.</param>
        public studentForm(string courseNo)
        {
            path = Environment.CurrentDirectory + "/" + courseNo;
            this.courseNo = courseNo;
            InitializeComponent();
        }

        /// <summary>
        /// Fills up the Students Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentForm_Load(object sender, EventArgs e)
        {
            finalGradeSummary();
            loadStudentGrid();
            fillGradeCategoryComboBox();
        }
        /// <summary>
        /// Loads the Students Data Grid View.
        /// </summary>
        public void loadStudentGrid()
        {
            finalGradeSummary();
            string studentPath = path + "/" + "students_" + courseNo + ".txt";
            string[] rowsOfStudentFile = File.ReadAllLines(studentPath);

            foreach (string eachRowOfStudentFile in rowsOfStudentFile)
            {
                string summaryPath = path + "/" + courseNo + "_summary" + ".txt";
                string[] arrOfStudents = eachRowOfStudentFile.Split(',');
                string[] rowsOfSummaryFile = File.ReadAllLines(summaryPath);

                foreach (string eachRowOfSummaryFile in rowsOfSummaryFile)
                {
                    string[] arrOfSummaryInfo = eachRowOfSummaryFile.Split(',');
                    if (arrOfStudents[2].Equals(arrOfSummaryInfo[0]))
                    {
                        List<string> listOfStudents = new List<string>(arrOfStudents);
                        listOfStudents.Add(arrOfSummaryInfo[2]);

                        studentGrid.Rows.Add(listOfStudents.ToArray());
                    }
                }
            }
        }

        /// <summary>
        /// Fills up the Course Summary File with all the newly calculated final grades for all the students.
        /// </summary>
        public void finalGradeSummary()
        {
            using(StreamWriter sw = new StreamWriter(path + "/" + courseNo + "_summary" + ".txt"))
            {
                sw.Write("");
            }
            string studentPath = path + "/" + "students_" + courseNo + ".txt";
            string[] rowsOfStudentFiles = File.ReadAllLines(studentPath);
            foreach(string eachRow in rowsOfStudentFiles)
            {
                string[] arrRow = eachRow.Split(',');
                string studentGradePath = path + "/" + arrRow[0] + "-" + courseNo + ".data";
                double totalAverage = studentFinalGrade(studentGradePath);
                string courseSummaryPath = path + "/" + courseNo + "_summary" + ".txt";
                if (!File.Exists(courseSummaryPath))
                {
                    File.CreateText(courseSummaryPath).Close();
                }
                using (StreamWriter sw = File.AppendText(courseSummaryPath))
                {
                    sw.WriteLine(arrRow[2] + ", " + arrRow[3] + ", " + Math.Round(totalAverage, 1));
                }
            }
            
        }
        /// <summary>
        /// Calculates the final grade of the inputted Student's File Path.
        /// </summary>
        /// <param name="studentGradePath">Inputted Path to Student File.</param>
        /// <returns></returns>
        public double studentFinalGrade(string studentGradePath)
        {
            string categoryPath = path + "/" + "categories_" + courseNo + ".txt";
            string[] rowsOfFiles = File.ReadAllLines(categoryPath);
            if (rowsOfFiles.Length == 0)
            {
                MessageBox.Show("There are no registered categories!");
            }
            else
            {
                string[] lines = File.ReadAllLines(categoryPath);

                string[] categoryNames = lines[0].Split(',');
                string[] categoryAssessment = lines[1].Split(',');
                string[] categoryNumOfAssessments = lines[2].Split(',');

                double totalWeights = 0.0;
                foreach (string assessment in categoryAssessment)
                {
                    totalWeights += Double.Parse(assessment);
                }

                string[] rowsOfGradeFiles = File.ReadAllLines(studentGradePath);
                List<Category> categories = new List<Category>();
                foreach (string eachGradeRow in rowsOfGradeFiles)
                {
                    string[] arrGradeRow = eachGradeRow.Split(',');

                    if (!categories.Exists(x => x.name == arrGradeRow[0]))
                    {
                        categories.Add(new Category()
                        {
                            name = arrGradeRow[0],
                            grades = new List<int>()
                        });
                    }
                    int index = categories.FindIndex(category => category.name.Equals(arrGradeRow[0]));
                    categories[index].grades.Add(Int32.Parse(arrGradeRow[2]));
                }
                for (int i = 0; i < categories.Count; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < categories[i].grades.Count; j++)
                    {
                        sum += categories[i].grades[j];
                    }
                    double average = 0.0;
                    for (int j = 0; j < categoryAssessment.Length; j++)
                    {
                        if (categories[i].name.Equals(categoryNames[j].Trim().Substring(0, 1)))
                        {
                            average = sum / Int32.Parse(categoryNumOfAssessments[j]);
                        }
                    }
                    categories[i].average = average;
                }
                for (int i = 0; i < categories.Count; i++)
                {
                    for(int j = 0; j < categoryAssessment.Length; j++)
                    {
                        if (categories[i].name.Equals(categoryNames[j].Trim().Substring(0,1)))
                        {
                            categories[i].totalCategoryGrade = (categories[i].average * (Double.Parse(categoryAssessment[j])/100)) / totalWeights;
                        }
                    }
                }
                double totalAverage = 0.0;
                for (int i = 0; i < categories.Count; i++)
                {
                    totalAverage += categories[i].totalCategoryGrade * 100;
                }
                return totalAverage;
            }
            return 0;
        }
        /// <summary>
        /// Fills the Student Grade Grid View with the Student you have most recently clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadStudentGradeGrid();
        }
        /// <summary>
        /// Loads The Student Grade Data View With The Most Recently Clicked Student In the Student Grid View.
        /// </summary>
        public void loadStudentGradeGrid()
        {
            studentGradesGrid.Rows.Clear();
            if (studentGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.studentGrid.SelectedRows[0];
                string chosenStudent = (string)row.Cells["StudentID"].Value;
                string studentGradePath = path + "/" + chosenStudent + "-" + courseNo + ".data";
                if (!File.Exists(studentGradePath))
                {
                    File.CreateText(studentGradePath).Close();
                }
                else
                {
                    string[] rowsOfFiles = File.ReadAllLines(studentGradePath);
                    foreach (string eachRow in rowsOfFiles)
                    {
                        string[] arrRow = eachRow.Split(',');
                        studentGradesGrid.Rows.Add(arrRow);
                    }
                }
            }
        }
        /// <summary>
        /// Fills The Grade Category ComboBox (In the Add Grades fragment) with all of the possible categories. 
        /// </summary>
        public void fillGradeCategoryComboBox()
        {
            addGradeCategory.Items.Clear();
            string categoryPath = path + "/" + "categories_" + courseNo + ".txt";

            string[] lines = File.ReadAllLines(categoryPath);
            if(lines.Length == 0)
            {

            }
            else
            {
                string[] categoryNames = lines[0].Split(',');
                foreach (string name in categoryNames)
                {
                    addGradeCategory.Items.Add(name.Trim());
                }
            }
            
        }

        /// <summary>
        /// Adds A New Student To The Student File.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addStuBtn_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            if (string.IsNullOrWhiteSpace(addStuID.Text))
            {
                MessageBox.Show("Missing student id Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (string.IsNullOrWhiteSpace(addStuSecNo.Text))
            {
                MessageBox.Show("Missing section number Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (string.IsNullOrWhiteSpace(addStuLName.Text))
            {
                MessageBox.Show("Missing last name Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (string.IsNullOrWhiteSpace(addStuFName.Text))
            {
                MessageBox.Show("Missing first name Input : Category Not Added");
                isValid = false;
                return;
            }
            else
            {
                isValid = true;
            }

            if (isValid)
            {
                studentGrid.Rows.Clear();
                studentGradesGrid.Rows.Clear();
                string studentPath = path + "/" + "students_" + courseNo + ".txt";
                using (StreamWriter sw = File.AppendText(studentPath))
                {
                    sw.WriteLine(addStuID.Text + ", " + addStuSecNo.Text + ", " + addStuLName.Text + ", " + addStuFName.Text);
                }
                string studentGradePath = path + "/" + addStuID.Text + "-" + courseNo + ".data";
                File.CreateText(studentGradePath).Close();
                loadStudentGrid();
            }
        }

        /// <summary>
        /// Adds A New Grade For The Student Who Has Been Most Recently Clicked On.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGradeBtn_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;

            int n;
            //Checks if a Student has been Selected
            bool isSelected = false;
            for(int i = 0; i < studentGrid.Rows.Count; i++)
            {
                if (studentGrid.Rows[i].Selected)
                {
                    isSelected = true;
                }
            }
            if (!isSelected)
            {
                MessageBox.Show("You haven't selected a Student to Add the Grade to!");
                isValid = false;
                return;
            }
            
            if(addGradeCategory.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Missing grade category Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (string.IsNullOrWhiteSpace(addGradeItem.Text))
            {
                MessageBox.Show("Missing grade item Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (string.IsNullOrWhiteSpace(addGradePoints.Text))
            {
                MessageBox.Show("Missing grade points Input : Category Not Added");
                isValid = false;
                return;
            }
            else if (!int.TryParse(addGradeItem.Text, out n))
            {
                MessageBox.Show("item not a number : Category Not Added");
                isValid = false;
                return;
            }
            else if (!int.TryParse(addGradePoints.Text, out n))
            {
                MessageBox.Show("amount of points not a number : Category Not Added");
                isValid = false;
                return;
            }
            else
            {
                isValid = true;
            }

            if (isValid)
            {
                studentGradesGrid.Rows.Clear();
                DataGridViewRow row = this.studentGrid.SelectedRows[0];
                string chosenStudent = (string)row.Cells["StudentID"].Value;
                string studentGradePath = path + "/" + chosenStudent + "-" + courseNo + ".data";
                using (StreamWriter sw = File.AppendText(studentGradePath))
                {
                    sw.WriteLine(addGradeCategory.SelectedItem.ToString().Substring(0,1) + ", " + addGradeItem.Text + ", " + addGradePoints.Text);
                }
                loadStudentGradeGrid();
            }
        }
    }
}
