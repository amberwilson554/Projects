using System;
using System.Collections.Generic;

namespace Attendance
{

	public class Teacher
	{
		private static List<Student> studentList;
		public delegate void StudentAbsentHandler();
		public event StudentAbsentHandler StudentAbsent;  //msfrizzle yelling
		private static int currentIndex;

		public Teacher()
		{
			studentList = new List<Student>();
			StudentAbsent = msfrizzleYelling;  //subscribing to event 
			currentIndex = 0;

		}

		public void addStudent(Student newStudent)
		{
			studentList.Add(newStudent);
		}

		public void takingAttendance()
		{

			for (int i = 0; i < studentList.Count; i++)
			{
				Console.WriteLine("---------------------------------");
				Console.WriteLine("");
				Console.WriteLine("Ms. Frizz:   Student {0} are you in class??", studentList[i].getId());
				//Console.WriteLine("Response is {0}", studentList[i].getResponse());
				currentIndex = i;

				if (studentList[i].getResponse() == 2)  //student absent
				{
					Console.WriteLine("Student:   No");
					//raise the event for ms frizzel to yell and change grade to 0
					StudentAbsent();
					StudentAbsent = msfrizzleYelling;

				}
                else
                {
					Console.WriteLine("Student:   Yes");
					Console.WriteLine("Your grade is {0}", studentList[i].getGrade());
				}
				

			}
		}
		public void msfrizzleYelling()
		{
			randomfrizzlePhrase();
			StudentAbsent = gradeZero;
			StudentAbsent();
		}
		public void gradeZero()
		{
			studentList[currentIndex].setGrade();
			Console.WriteLine("Your grade is now a {0}", studentList[currentIndex].getGrade());

		}

		public void randomfrizzlePhrase()
		{
			Random randomNum1 = new Random();
			int choice = randomNum1.Next(1, 10);
			//Console.WriteLine(choice);

			switch(choice)
			{
				case 1:
					Console.WriteLine("Ms. Frizz:   Why........");
					break;
				case 2:
					Console.WriteLine("Ms. Frizz:   Are you still sleeping????");
					break;
				case 3:
					Console.WriteLine("Ms. Frizz:   You are not going on the Magic School Bus!!!");
					break;
				case 4:
					Console.WriteLine("Ms. Frizz:   You are getting a 0!!!");
					break;
				case 5:
					Console.WriteLine("Ms. Frizz:   No soup for you!!!");
					break;
				case 6:
					Console.WriteLine("Ms. Frizz:   Fail!!!");
					break;

				case 7:
					Console.WriteLine("Ms. Frizz:   And that is why you need to be in school.......");
					break;
				case 8:
					Console.WriteLine("Ms. Frizz:   Learning is fun!!!");
					break;
				case 9:
					Console.WriteLine("Ms. Frizz:   You get a 0...and you get a 0...and you get a 0!!!");
					break;
				case 10:
					Console.WriteLine("Ms. Frizz:   The more you know -------*  ");
					break;
				default:
					Console.WriteLine("Ms. Frizz is out of phrases!!!");
					break;

			}



		}
	}
}
