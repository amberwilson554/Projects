using System;
using System.Collections.Generic;

namespace School
{


    class Teacher : Employee
    {
        private int id;
        private static int teacher;
        private string courseid;
        private static List<Teacher> tList = new List<Teacher>();
        private static Address teacher_address;
        private static Contact teacher_contactinfo;
    
        public Teacher()
        {
            ++teacher;
            this.id = teacher;
            this.courseid = "Class Unassigned";
            teacher_address = new Address("Street", "City", "State", "Zipcode");
            teacher_contactinfo = new Contact("Email", "Phone Number");
            tList.Add(this);
        }

        public void setcontactInfo(string email, string phonenumber)
        {
            teacher_contactinfo.Email = email;
            teacher_contactinfo.Phone_number = phonenumber; 
        }


        public void setAddress(string street, string city, string state, string zipcode)
        {
            teacher_address.Street = street;
            teacher_address.City = city;
            teacher_address.State = state;
            teacher_address.Zipcode = zipcode;
        }

        public static int getTeacher()
        {
            return teacher;
        }
        public int getteacherId()
        {
            return id;
        }
        public int getteacherList()
        {
            return tList.Count;
        }
  
        public void assignteacherCourse(string courseName)
        {
            this.courseid = courseName;
        }
        public static void setCourse(int teacherid, string course_id)
        {
            for (int i = 0; i < tList.Count; ++i)
            {
                if (tList[i].id == teacherid)
                {
                    tList[i].courseid = course_id;
                }
            }
        }

        public static bool checkteacherList(int teacherid)
        {
            bool check = false;
            for (int i = 0; i < tList.Count; ++i)
            {
                if (tList[i].id == teacherid)
                {
                    check = true;
                }
            }
            return check;
        }

        public static void displayteacherList()
        {
            Console.WriteLine("");

            for (int i = 0; i < tList.Count; ++i)
            {
                Console.WriteLine("Teacher {0} is assigned to {1}", tList[i].id, tList[i].courseid);  
            }
           
            Console.WriteLine("The total number of teachers are: {0}", tList.Count);
        }

        public void displayaddress()
        {
           teacher_address.displayAddress();
           teacher_contactinfo.displayContact();
        }
        
        
    }
}