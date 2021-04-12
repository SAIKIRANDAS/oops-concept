using System;

namespace overloading_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            skilllync skill=new skilllync();
            skill.students(15);
            skill.students(15,"king");
            skill.students(15,"king","sklm");
            a9 a=new a9();
            a.students("kiran"); 
            a.students(15);
            a.students(15,"king");
            a.students(15,"king","sklm");    
        }
        public class skilllync
        {
            public void students(int name)
            {
                Console.WriteLine("sai");
            }
            public void students(int name,string place)
            {
                Console.WriteLine("kiran");
            }
            public void students(int name,string place,string age)
            {
                Console.WriteLine("das");
            }
        }
        public class a9:skilllync
        {
            public void students(string names)
            {
            Console.WriteLine("v nfvnvfojvo");
            }
        }
    }
}
