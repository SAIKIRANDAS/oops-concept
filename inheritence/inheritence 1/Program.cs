using System;

namespace inheritence_1
{
    class Program
    {
        public class hospital
        {
            public void dentist()
            {
                Console.WriteLine("thid id for teeths");
            }
            public void eyesspecialist()
            {
                Console.WriteLine("only for eyes");
            }
        }
        public class generaldoctor:hospital
        {
          public void surgeon()
          {
            Console.WriteLine("this is spplicable for everyone");
          }
        }
        public static void Main()
        {
            hospital hos=new hospital();
            hos.dentist();
            hos.eyesspecialist();
            generaldoctor genenral=new generaldoctor();
            genenral.surgeon();
        }
    }
}
