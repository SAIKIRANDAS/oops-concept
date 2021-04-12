using System;

namespace inhertence5
{
    class Program
    {
        public static void Main()
        {
            a8 a=new a8();
            a.employer();
            a.pramod();
            a.vasanthi();
        }
        public class skilllync
        {
            public void employer()
            {
               Console.WriteLine("he will do the work");
            }
            public void client()
            {
                Console.WriteLine("he is came for knowing some content");
            }
        }
        public class a9:skilllync
        {
            public void saikiran()
            {
                Console.WriteLine("he is the first person");
            }
            public void pramod()
            {
                Console.WriteLine("second person");
            }
        }
        public class a8:a9
        {
            public void vasanthi()
            {
                Console.WriteLine("third person");
            }
        } 
    }
}
