using System;

namespace polymorphism
{
    class Program
    {
       public class vehicle
       {
           public void sound()
           {
           Console.WriteLine("too much sound");
           }
           public void sound(string bike)
           {
           Console.WriteLine("do something");
           }
           public void sound(string bike,int rate)
           {
               Console.WriteLine("daba daba....");
           }
        }
      public static void Main()
      {
         vehicle ve=new vehicle();
         ve.sound();
         ve.sound("bmw");
         ve.sound("yamaha",50000);
      }
    }
}
