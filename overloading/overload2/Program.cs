using System;

namespace overload2
{
    class Program
    {
        public class bank 
        {
            public void customer(int salary)
            {
                Console.WriteLine("welcome to office");
            }
            public void customer(string customername)
            {
                Console.WriteLine("write your name");
            }
        }
        public static void Main()
        {
            bank b=new bank();
            b.customer(50000);
            b.customer("saikirandas");
        }
    }
}
