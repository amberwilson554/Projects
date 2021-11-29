using System;
using System.Collections.Generic;

namespace School
{
    class Student
    {
        private int id;
        private static int student;
        private static List<Student> sList = new List<Student>();
        private static Dictionary<string, string> americanDictonary = new Dictionary<string, string>();
        private static Dictionary<string, string> mexicanDictonary = new Dictionary<string, string>();
        private static Address student_address;
        private static Contact student_contactinfo;
        protected string grade;

        public Student()      
        {
            student++;
            this.id = student;
            student_address = new Address("Street", "City", "State", "Zipcode");
            student_contactinfo = new Contact("Email", "Phone Number");
        }
        public void setcontactInfo(string email, string phonenumber)
        {
            student_contactinfo.Email = email;
            student_contactinfo.Phone_number = phonenumber;
        }
        public void setAddress(string street, string city, string state, string zipcode)
        {
            student_address.Street = street;
            student_address.City = city;
            student_address.State = state;
            student_address.Zipcode = zipcode;
        }
        public void displayaddress()
        {
            student_address.displayAddress();
            student_contactinfo.displayContact();
        }
        public static int getStudent()
        {
            return student;
        }
        public void addStudent(Student addstudent)
        {
            //adding a student to the list of students
            sList.Add(addstudent);
        }
        public static void displaystudentList()
        {
            Console.WriteLine("");
            Console.WriteLine("The total number of students are: {0}", sList.Count);
        }
        public static bool checkstudentList(int studentid)
        {
            bool check = false;
            for (int i = 0; i < sList.Count; ++i)
            {
                if (sList[i].id == studentid)
                {
                    check = true;
                }
            }
            return check;
        }

        public void addGrade <T>(T changeGrade)
        {
            
            this.grade = changeGrade.ToString();
            string grade = changeGrade.ToString();
            Console.WriteLine("");
            Console.WriteLine("The grade you entered is: {0}", this.grade);
            Console.WriteLine("Are you converting this grade to the American or the Mexican grading scale? Type: A or M");
            string choice = Console.ReadLine();
            string choice_Lowercase = choice.ToLower();

            if(choice_Lowercase == "a")
            {

                Student.toAmerican(grade);

            }
            else if(choice_Lowercase == "m")
            {
                Student.toMexican(grade);

            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }

        }
        public static void toAmerican(string pickGrade)
        {
            americanDictonary.Add("9", "F");
            americanDictonary.Add("10", "D");
            americanDictonary.Add("11", "C");
            americanDictonary.Add("12", "C+");
            americanDictonary.Add("13", "B");
            americanDictonary.Add("14", "A");
            americanDictonary.Add("15", "A+");
            americanDictonary.Add("16", "A++");
            
            americanDictonary.TryGetValue(pickGrade, out string americanGrade);
            Console.Write("Your grade on the American Grading Scale is: {0} ", americanGrade);
            Console.WriteLine("");
        }
        public static void toMexican(string pickGrade)
        {
            mexicanDictonary.Add("F","9");
            mexicanDictonary.Add("D", "10");
            mexicanDictonary.Add("C", "11");
            mexicanDictonary.Add("C+", "12");
            mexicanDictonary.Add("B", "13");
            mexicanDictonary.Add("A", "14");
            mexicanDictonary.Add("A+", "15");
            mexicanDictonary.Add("A++", "16");

            mexicanDictonary.TryGetValue(pickGrade, out string americanGrade);
            Console.Write("Your grade on the American Grading Scale is: {0} ", americanGrade);
            Console.WriteLine("");
        }



    }
}
