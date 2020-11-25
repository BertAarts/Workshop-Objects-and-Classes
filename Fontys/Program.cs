using System;

namespace Fontys
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            #region Create the workshop.

            Workshop workshop = new Workshop();
            workshop.Name = "Introduction to Objects and Classes";
            workshop.Location = "Teams - Unit 2";

            #endregion

            while (keepRunning)
            {
                #region Add a new student to the workshop.

                Console.WriteLine("What is the first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What is the last name?");
                string LastName = Console.ReadLine();

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = LastName;

                workshop.AddStudent(student);

                #endregion

                #region Display all the students enrolled in the workshop and the number of tables required.

                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine($"For the workshop '{workshop.Name}' in {workshop.Location} the following {workshop.Students.Count.ToString()} students have signed up:");
                foreach (Student studentInList in workshop.Students)
                {
                    Console.WriteLine($" - {studentInList.FirstName} {studentInList.LastName}");
                }
                Console.WriteLine($"For this workshop {workshop.GetRequiredNumberOfTables()} tables are required.");
                Console.WriteLine("======================================");
                Console.WriteLine();

                #endregion
            }
        }
    }
}
