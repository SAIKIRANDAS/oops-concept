using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        public static void Main( )
        {
            family fa1=new family()
            {
                name="saikirandas",
                age=21
            };
            family fa2=new family()
            {
                name="ramprasaddas",
                age=49 
            };
             family fa3=new family()
            {
                name="anithadas",
                age=20 
            };

             List<family> fam= new List<family>();
             fam.Add(fa1);
             fam.Add(fa2);
             fam.Add(fa3);
             foreach (family f in fam)
             {
                 Console.WriteLine("name={0}, age={1} " ,f.name, f.age);
             }
        }
    }
   

    public class family
    {
        public string name{get; set;}
        public int age{get; set;}
    }
}
