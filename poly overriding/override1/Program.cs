using System;

namespace override1
{
    class Program
    {
        public class bank
        {
            public virtual void customer()
            {
                Console.WriteLine("he is came for creat an account");
            }
        }
        public class client:bank
        {
           public override void customer()
          {
            Console.WriteLine("came for knowing the information");
          }
        }
            public static void Main()
         {
           client c=new client();
           c.customer();
           bank b=(bank)c;
            c.customer();
         }
        
    }
}
