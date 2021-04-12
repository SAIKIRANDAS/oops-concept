using System;

namespace overload1
{
    class Program
    {
        public class company
        {
            public void employees(string name)
            {
            Console.WriteLine("salary");
            }
            public void employees(string name,int salary)
            {
                Console.WriteLine("employeename");
            }
        }
        public static void Main()
        {
            company com=new company();
            com.employees("saikirandas");
            com.employees("ram",20000);

        }
    }
}
