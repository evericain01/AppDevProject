using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    /// <summary>
    /// Initializes the grades for each category the student takes for their course.
    /// </summary>
    public class Category
    {
        // Name of the Category.
        public string name { get; set; }
        // List of Grades for said Category.
        public List<int> grades;
        // The average of all the grades together.
        public double average;
        // The total worth of the grade to the Student.
        public double totalCategoryGrade;
    }
}
