using System;

namespace abstract2
{
    class Program
    {
        public abstract class sai
        {
            public void speak()
            {
                Console.WriteLine("he will speak 6 languages");
            }
            
        }
        public class kiran:sai
        {
            public void jump()
            {
                Console.WriteLine("he wil jump up to 5feet");
            }
        }
        public class das:kiran
        {
            public void run()
            {
                Console.WriteLine("he will run up to 2km without rest");
            }
        }
        public static void Main()
        {
            das d=new das();
            d.run();
            d.jump();
            d.speak();
        }
    }
}
