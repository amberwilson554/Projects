using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice= 0;
            bool flagExit = false;
            
            do
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1: Enroll an Employee");
                Console.WriteLine("2: Enroll a Student");
                Console.WriteLine("3: Register Classes");
                Console.WriteLine("4: Display Class Roster");
                Console.WriteLine("5: Class Count");
                Console.WriteLine("6: Add Student to Class");
        
                Console.WriteLine("7: To exit");
                Console.WriteLine("");
                Console.WriteLine("");


                try
                {
                    choice = int.Parse(Console.ReadLine());
                    bool flagExit2 = false;
                    switch (choice)
                    {
                        
                        case 1:
                            do
                            {
                                int choice2 = 0;
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Choose an option");
                                Console.WriteLine("1: Enroll a Janitor");
                                Console.WriteLine("2: Enroll a Teacher");
                                Console.WriteLine("3: Janitor Total");
                                Console.WriteLine("4: Teacher Roster and Total");
                                Console.WriteLine("5: Employee Total");
                                Console.WriteLine("6: Assign Teacher to a class");
                                Console.WriteLine("7: Go back to main menu");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                choice2 = int.Parse(Console.ReadLine());

                                switch (choice2)
                                {

                                    case 1:
                                        
                                        Janitor janitor_1 = new Janitor();
                                        Console.WriteLine("Janitor was added");
                                        Janitor.displayjanitorList();
                                        break;

                                    case 2:
                                        
                                        Teacher teacher_1 = new Teacher();
                                        Console.WriteLine("The teacher was added");
                                        Console.WriteLine("Enter the teacher's address");
                                        Console.WriteLine("Enter the street");
                                        string teacher_street = Console.ReadLine();
                                        Console.WriteLine("Enter the city");
                                        string teacher_city = Console.ReadLine();
                                        Console.WriteLine("Enter the state");
                                        string teacher_state = Console.ReadLine();
                                        Console.WriteLine("Enter the zipcode");
                                        string teacher_zipcode = Console.ReadLine();
                                        teacher_1.setAddress(teacher_street, teacher_city, teacher_state, teacher_zipcode);
                                        Console.WriteLine("Enter the email address");
                                        string teacher_email = Console.ReadLine();
                                        Console.WriteLine("Enter the phone number");
                                        string teacher_phone = Console.ReadLine();
                                        teacher_1.setcontactInfo(teacher_email, teacher_phone);
                                       
                                        Console.WriteLine();
                                        teacher_1.displayaddress();
                                      
                                        break;

                                    case 3:
                                        
                                        Janitor.displayjanitorList();
                                        break;

                                    case 4:
                                        
                                        Teacher.displayteacherList();
                                        break;

                                    case 5:
                                        Employee.getemployeeTotal();
                                        break;

                                    case 6:
                                        bool check2 = false;
                                        bool check3 = false;
                                        string course2 = "";
                                        int teacherid = 0;

                                        Console.WriteLine("Enter the teacher's id");
                                        teacherid = int.Parse(Console.ReadLine());
                                        check3 = Teacher.checkteacherList(teacherid);

                                        if (check3 == true)    //if the teacher exists
                                        {
                                            Console.WriteLine("Assign the teacher to one of the classes listed");
                                            Courses.displaycourseList();
                                            Console.WriteLine();
                                            course2 = Console.ReadLine();

                                            check2 = Courses.checkcourseList(course2);   
                                            if (check2 == true)  //if the course exists
                                            {
                                                Teacher.setCourse(teacherid, course2);
                                                Teacher.displayteacherList();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Class is not registered. Register the class before assigning.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Teacher is not enrolled. Enroll the teacher before trying to assign a class.");
                                        }
                                        break;

                                    case 7:
                                        flagExit2 = true;
                                        break;

                                    default:

                                        Console.WriteLine("Choose a valid menu option \n");
                                        break;
                                }
                            } while (flagExit2 != true);

                        break;

                        case 2:
                            Student student_1 = new Student();
                            student_1.addStudent(student_1);
                            Console.WriteLine("");
                            Console.WriteLine("The student was added");
                            Console.WriteLine("Enter the student's address");
                            Console.WriteLine("Enter the street");
                            string student_street = Console.ReadLine();
                            Console.WriteLine("Enter the city");
                            string student_city = Console.ReadLine();
                            Console.WriteLine("Enter the state");
                            string student_state = Console.ReadLine();
                            Console.WriteLine("Enter the zipcode");
                            string student_zipcode = Console.ReadLine();
                            student_1.setAddress(student_street, student_city, student_state, student_zipcode);
                            Console.WriteLine();
                            
                            Console.WriteLine("Enter the email address");
                            string student_email = Console.ReadLine();
                            Console.WriteLine("Enter the phone number");
                            string student_phone = Console.ReadLine();
                            student_1.setcontactInfo(student_email, student_phone);
                            student_1.displayaddress();
                            Student.displaystudentList();

                            Console.WriteLine("Add a grade: ");
                            var student_grade = Console.ReadLine();
                            student_1.addGrade(student_grade);  
                            break;

                        case 3:

                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            string course_name;
                            Console.WriteLine("Enter the class name");
                            course_name = Console.ReadLine();
                            Courses course_1 = new Courses(course_name);
                            break;

                        case 4:
                            Console.WriteLine("");
                            Courses.displaycourseList();
                            break;
     
                        case 5:
                            Console.WriteLine("");
                            Courses.displaylistCount();
                            break;
                      
                        case 6:
                            bool check5 = false;
                                Console.WriteLine("");
                                Console.WriteLine("Enter the Student's ID");
                                int student_id = int.Parse(Console.ReadLine());
                                check5 = Student.checkstudentList(student_id);

                                if (check5 == true)    //if the student exists
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Assign the student to one of the classes listed");
                                    Courses.displaycourseList();
                                    Console.WriteLine();

                                    Console.WriteLine("");
                                    Console.WriteLine("Enter the Class name");
                                    string coursename = Console.ReadLine();
                                    check5 = Courses.checkcourseList(coursename);

                                         if (check5 == true)  //if the course exists
                                         {
                                            Courses.addStudents(coursename, student_id);
                                         }
                                         else
                                         {
                                            Console.WriteLine("");
                                            Console.WriteLine("Class is not registered. Register the class before assigning.");
                                         }
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Student is not enrolled. Enroll the student before trying to assign to a class.");
                                }

                            break;
                        case 7:
       
                            Console.WriteLine("");
                            Console.WriteLine("Exiting program..........BYE");
                            flagExit = true;
                            break;

                        default:

                            Console.WriteLine("");
                            Console.WriteLine("Choose a valid menu option \n");
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            } while (flagExit != true);
        }

/*01. Enrolling employees to the school.  ---done
02. Enrolling teachers to the school.  ---done
03. Enrolling janitors to the school.  ---done
04. The school must be able to tell how many employees are in school.  ---done
05. The school must be able to tell how many teachers are in school.  ---done
06. The school must be able to tell how many janitors are in school.  ---done
07. The school must be able to tell how many students are in school.
08. Register the classes that the school offers.  ---done
09. The school must be able to return how many classes are there.  --done
10. Assign a class to each teacher. ---done
11. Assign students to a class.  ---done */
       
    }
}
