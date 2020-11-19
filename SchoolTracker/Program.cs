using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrades = new int[] { 80, 77, 87, 87, 65, 98, 70, 55, 92, 83, 39 };

            foreach (var student in studentsGrades)
            {
                Console.WriteLine(student);
            }
            

        }
    }
}
