using System;

namespace override2
{
    class Program
    {
       public  static void Main()
        {
            management ma=new management();
            
            hospital hos=(hospital)ma;
            ma.collect();
            ma.collect();
        }
        public class hospital
        {
            public virtual void collect()
            {
                Console.WriteLine("they will do their work");
            }
        }
        public class management:hospital
        {
            public override void collect()
            {
                Console.WriteLine("they will collect the money");
            } 
        }
    }
}
