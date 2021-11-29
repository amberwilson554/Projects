using System;
using System.Collections.Generic;

namespace School
{
    class Janitor : Employee
    {
        private int id;
        private static int janitor;
        private static List<Janitor> jList = new List<Janitor>();

        public Janitor()
        {
            ++janitor;
            this.id = janitor;
            jList.Add(this);
        }
        public static int getjanitor()
        {
            return janitor;
        }

        public static void displayjanitorList()
        {
            Console.WriteLine("");
            Console.WriteLine("The total number of janitors are: {0}", jList.Count);
        }
    }
}