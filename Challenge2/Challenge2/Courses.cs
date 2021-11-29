using System;
using System.Collections.Generic;

namespace School
{
	class Courses
	{
        private string coursename;
        private static List<Courses> cList = new List<Courses>();
        private List<int> studentList; 

        public Courses(string courseid)
        {
            this.coursename = courseid;
            studentList = new List<int>();
            cList.Add(this);                   
        }

        public static void addStudents(string coursename, int student_id)
        {
            for(int i=0; i < cList.Count; ++i)
            {
                if(coursename == cList[i].coursename)
                {
                    cList[i].studentList.Add(student_id);  //adding the student to the course's student list
                }
                
            }
        }
        public static void displaycourseList()
        {
            
            Console.WriteLine("");
           
            for (int i = 0; i < cList.Count; ++i)
            {
                Console.WriteLine(cList[i].coursename);
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^");
                for (int j = 0; j < cList[i].studentList.Count; ++j)
                {
                    Console.WriteLine("Student {0}", cList[i].studentList[j]);
                }
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^");

            }
        }
        public static void displaylistCount()
        {

            Console.WriteLine("");
            Console.WriteLine("The total number of classes are: {0}", cList.Count);
        }
        public static bool checkcourseList(string checkcourse)
        {
            bool check = false;
            for (int i = 0; i < cList.Count; ++i)
            {
                if (cList[i].coursename == checkcourse)
                {
                    check = true;
                }   
            }
            return check;
        }









    }

}