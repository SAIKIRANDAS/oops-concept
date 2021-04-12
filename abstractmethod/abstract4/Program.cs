using System;

namespace abstract4
{
    class Program
    {
        public static void Main()
        {
            queen k=new queen();
            k.eating();
            k.sleeping();
            k.jacking();
            k.waliking();
            k.hacking();
        }
        public  abstract  class palace
        {
            public void eating()
            {
                Console.WriteLine("he need good food");
            }
            public abstract void sleeping();
            public abstract void waliking();
        }
        public class king:palace
        {
            public void jacking()
            {
                Console.WriteLine("he will go every day");
            }
            public  override void sleeping()
            {
                Console.WriteLine("he won't sleep");
            }
             
        }
        public class queen:king
        {
            public void hacking()
            {
                Console.WriteLine("he will do");
            }
            public override void waliking()
            {
                Console.WriteLine("he won,t do");
            }
           
        }
    }

}
