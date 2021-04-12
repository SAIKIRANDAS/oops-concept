using System;

namespace abstract1
{
    class Program
    {
        public abstract class bank
        {
            public void employee()
            {
                Console.WriteLine("they will do their work");
            }
            public abstract void client();
        }
        public class customer:bank
        {
            public void creat()
            {
                Console.WriteLine("came here for add money");
            }
            public override void client()
            {
                Console.WriteLine("came here for withdrawl money");
            }
        }
        public static void Main()
        {
            customer c=new customer();
            c.employee();
            c.client();
        }
    }
}
