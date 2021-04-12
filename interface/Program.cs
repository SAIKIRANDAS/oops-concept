using System;

namespace exampple
{
    class Program
    {
        public static void Main()
        {
            sai s=new sai();
            s.talk();
            s.run();
            s.speak();
            s.eat();
        }
        public abstract class ramprasad
        {
              public abstract void talk();
              public abstract void run(); 
        }
         interface  Inew
           {
               void eat();
            }
        public class sai:ramprasad,Inew
        {
            public void speak()
            { 
                Console.WriteLine("he will speak anything");
            }
            public void jump()
            {
                Console.WriteLine("he will jump");
            }   
            public override void talk()
            {
                Console.WriteLine("i will speak");
            }
             public override  void run()
            {
                Console.WriteLine("i will run");
            }
            public void eat()
            {
                Console.WriteLine("i will eat more");
            }
        }
        
    }
}
