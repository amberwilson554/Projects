using System;

namespace Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ms. Frizzle's class");
            Console.WriteLine("Populating class of 10");
            Teacher frizzlesClass = new Teacher();

                int i = 0;
                while(i < 10)
                {
                    Student student = new Student();
                    frizzlesClass.addStudent(student);
                    ++i;
                }
            Console.WriteLine("Ms. Frizzle is taking attendance.....");
            frizzlesClass.takingAttendance();

        }
    }
}
