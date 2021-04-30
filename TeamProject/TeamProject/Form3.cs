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
    public partial class categoryForm : Form
    {
        public string courseNo;
        public string path;
        /// <summary>
        /// Sets the Inputted Course Number as a global variable, and sets the current course path being used by the form.
        /// </summary>
        /// <param name="courseNo">Inputted Course Number.</param>
        public categoryForm(string courseNo)
        {
            path = Environment.CurrentDirectory + "/" + courseNo;
            this.courseNo = courseNo;
            InitializeComponent();
        }

        /// <summary>
        /// Fills up the Category Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryForm_Load(object sender, EventArgs e)
        {
            loadCategoryGrid();
        }

        public void loadCategoryGrid()
        {
            string categoryPath = path + "/" + "categories_" + courseNo + ".txt";
            string[] rowsOfFiles = File.ReadAllLines(categoryPath);

            string[] lines = File.ReadAllLines(categoryPath);
            if(lines.Length == 0)
            {

            }
            else
            {
                string[] categoryNames = lines[0].Split(',');
                string[] categoryAssessment = lines[1].Split(',');
                string[] categoryNumOfAssessments = lines[2].Split(',');
                string[] rows;
                for (int i = 0; i < categoryNames.Length; i++)
                {
                    rows = new string[] { categoryNames[i], categoryAssessment[i], categoryNumOfAssessments[i] };
                    categoriesGrid.Rows.Add(rows);
                }
            }
            
        }

        /// <summary>
        /// Validates the inputted information for the category.
        /// </summary>
        /// <returns></returns>
        public Boolean IsCategoryValid()
        {
            int n;

            if (string.IsNullOrWhiteSpace(addCategoryName.Text))
            {
                MessageBox.Show("Missing name Input : Category Not Added");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(addCategoryWeight.Text))
            {
                MessageBox.Show("Missing weight Input : Category Not Added");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(addCategoryNoOfAssessment.Text))
            {
                MessageBox.Show("Missing assessment Input : Category Not Added");
                return false;
            }
            else if (!int.TryParse(addCategoryWeight.Text, out n))
            {
                MessageBox.Show("weight not a number : Category Not Added");
                return false;
            }
            else if (!int.TryParse(addCategoryNoOfAssessment.Text, out n))
            {
                MessageBox.Show("Number of assessments not a number : Category Not Added");
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Adds A New Category To The Category File.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string categoryPath = path + "/" + "categories_" + courseNo + ".txt";

            string[] checkLines = File.ReadAllLines(categoryPath);

            if(checkLines.Length == 0)
            {
                Boolean isValid = false;

                if (IsCategoryValid())
                {
                    isValid = true;
                } else
                {
                    return;
                }

                // If valid adds the new information to the category txt file 
                if (isValid)
                {
                    categoriesGrid.Rows.Clear();
                    List<string> finalTxt = new List<string>();
                    string[] lines = File.ReadAllLines(categoryPath);
                    if (lines.Length == 0)
                    {
                        finalTxt.Add(addCategoryName.Text);
                        finalTxt.Add(addCategoryWeight.Text);
                        finalTxt.Add(addCategoryNoOfAssessment.Text);
                    }
                    else
                    {
                        string names = lines[0];
                        string assessments = lines[1];
                        string numOfAssessments = lines[2];


                        string[] assessmentsArr = assessments.Split(',');
                        double totWeights = 0.0;
                        foreach (string assessment in assessmentsArr)
                        {
                            totWeights += Convert.ToDouble(assessment.Trim());
                        }
                        totWeights += Convert.ToDouble(addCategoryWeight.Text);
                        if (totWeights > 100)
                        {
                            MessageBox.Show("Your Assessment Weights Should NOT Exceed 100%");
                            isValid = false;
                            return;
                        }

                        finalTxt.Add(names + ", " + addCategoryName.Text);
                        finalTxt.Add(assessments + ", " + addCategoryWeight.Text);
                        finalTxt.Add(numOfAssessments + ", " + addCategoryNoOfAssessment.Text);
                    }
                    File.WriteAllLines(categoryPath, finalTxt.ToArray());
                    MessageBox.Show("Category Added");
                    loadCategoryGrid();
                }
            }
            else
            {
                string line = File.ReadLines(categoryPath).First();
                string[] words = line.Split();
                List<string> firstLetter = new List<string>();
                if (words.Length == 0)
                {

                }
                else
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = words[i];
                        firstLetter.Add(word.Substring(0, 1));
                    }
                }

                Boolean isValid = false;

                if (IsCategoryValid())
                {
                    isValid = true;
                }
                else
                {
                    return;
                }

                if (firstLetter.Count == 0)
                {

                }
                else
                {
                    foreach (string letter in firstLetter)
                    {
                        string categoryName = addCategoryName.Text.ToLower();
                        if (categoryName.Substring(0, 1).Equals(letter.ToLower()))
                        {
                            MessageBox.Show("First letter of category name cannot be the same as already included datas");
                            isValid = false;
                        }
                    }
                }

                if (isValid)
                {
                    categoriesGrid.Rows.Clear();
                    List<string> finalTxt = new List<string>();
                    string[] lines = File.ReadAllLines(categoryPath);
                    if (lines.Length == 0)
                    {
                        finalTxt.Add(addCategoryName.Text);
                        finalTxt.Add(addCategoryWeight.Text);
                        finalTxt.Add(addCategoryNoOfAssessment.Text);
                    }
                    else
                    {
                        string names = lines[0];
                        string assessments = lines[1];
                        string numOfAssessments = lines[2];


                        string[] assessmentsArr = assessments.Split(',');
                        double totWeights = 0.0;
                        foreach (string assessment in assessmentsArr)
                        {
                            totWeights += Convert.ToDouble(assessment.Trim());
                        }
                        totWeights += Convert.ToDouble(addCategoryWeight.Text);
                        if (totWeights > 100)
                        {
                            MessageBox.Show("Your Assessment Weights Should NOT Exceed 100%");
                            isValid = false;
                            return;
                        }

                        finalTxt.Add(names + ", " + addCategoryName.Text);
                        finalTxt.Add(assessments + ", " + addCategoryWeight.Text);
                        finalTxt.Add(numOfAssessments + ", " + addCategoryNoOfAssessment.Text);
                    }
                    File.WriteAllLines(categoryPath, finalTxt.ToArray());
                    MessageBox.Show("Category Added");

                    loadCategoryGrid();
                }
            }
            
        }
    }
}
