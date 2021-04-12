using System;

namespace override3
{
    class Program
    {
        public class hospital
        {
            public virtual void doctor()
            {
               Console.WriteLine("he is came for checking the patient");
            }
        }
        public class client:hospital
        {
            public override void doctor()
            {
                Console.WriteLine("came for the doctor");
            }
        }
        public static void Main()
        {
                client cl=new client();
                cl.doctor();
                hospital hos=(hospital)cl;
                cl.doctor();
        }
    }
}
