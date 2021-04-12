using System;

namespace abstractclass
{
    class Program
    {
        public abstract class hospital
        {
            public void doctors()
            {
                Console.WriteLine("they will do their work");
            }
            public abstract void nurses();
        }  
        public class surgeons:hospital
        {
            public void medicine()
            {
              Console.WriteLine("they will come for giving medicine");
            }
            public override void nurses()
            {
                Console.WriteLine("they will come for checking");
            }
        }
        public static void Main()
        {
            surgeons sur=new surgeons();
            sur.medicine();
            sur.nurses();
            sur.doctors();
        }
    }
}
