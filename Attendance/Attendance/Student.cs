using System;

namespace Attendance
{

	public class Student
	{
		private static int student;
		private int response;
		private int studentId;
		private int grade;
		
		public Student()
        {
			student++;
			studentId = student;
			response = pickResponse();   //1 for yes and 2 for no
			grade = 100;
		}
				
		public int pickResponse()
        {
			Random randomNum1 = new Random();
			return randomNum1.Next(1, 3);
		}
		public int getId()
        {
			return this.studentId;
        }
		public int getResponse()
		{
			return this.response;
		}
		public int getGrade()
		{
			return this.grade;
		}
		public void setGrade()
		{
			 this.grade = 0;
		}

	}
}
