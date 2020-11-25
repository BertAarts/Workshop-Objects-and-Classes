using System;
using System.Collections.Generic;
using System.Text;

namespace Fontys
{
    public class Workshop
    {
        public string Name;
        public string Location;

        public List<Student> Students = new List<Student>();

        public Workshop()
        { }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public int GetRequiredNumberOfTables()
        {
            return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Students.Count) / 3));
        }
    }
}
