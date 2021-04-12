using System;

namespace overridding
{
   public class animal
    {
       public virtual void method1()
       {
           Console.WriteLine("print something");
       }
    }
   public class cat:animal
    {
       public override void method1()
       {
           Console.WriteLine("don't print anything");
       }
    }
  public class kiran
        {
            public static void Main()
           {
              cat c=new cat();
                c.method1();
                animal an=(animal)c;
                an.method1();
            }
            
        }
       
}
