using System;

namespace School
{
      class Employee
    {
       private int id;    
       private static int employee;

      public Employee()
      {
         ++employee;
         this.id = employee;   
      }
      public static int getemployee()
      {
         return employee;
      }
      public static void getemployeeTotal()
      {
            Console.WriteLine("");
            Console.WriteLine("The total number of employees is: {0}", employee);
      }
           
    }
   
}