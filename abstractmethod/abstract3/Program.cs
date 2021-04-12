using System;

namespace abstract3
{
    class Program
    {
        public abstract class hospital
        {
            public void speak()
            {
                Console.WriteLine("polite");
            }
        }
        public class employee:hospital
        {
            public void target()
            {
                Console.WriteLine("they will foucs on their work");
            }
        } 
        public class management:employee
        {
            public void money()
            {
                Console.WriteLine("money wil do any work");
            }
             public void work()
           {
              Console.WriteLine("count the money");
            }
            
        }
        public static void Main()
        {
            management em=new management();
            em.speak();
            em.target();
            em.money();
        }
    }
}
