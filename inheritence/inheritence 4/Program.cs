using System;

namespace inheritence_4
{
    class Program
    {
        public class animal
        {
            public void eat()
           {
                Console.WriteLine("animals will eat anything");
           }
           public void run()
           {
               Console.WriteLine("it will run very fast");
           }
        }
        public class lion:animal
        {
          public void eat1()
          {
            Console.WriteLine("the nature of the animals");
          }
          public void run1()
          {
              Console.WriteLine("some of animals will run very fast");
          }
        }
        public static void Main()
        {
            animal an=new animal();
            lion l=new lion();
            an.run();
            an.eat();
            l.run1();
            l.eat1();
            l.run();
        }
    }
}
