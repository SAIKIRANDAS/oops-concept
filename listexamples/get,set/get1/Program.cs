using System;
using System.Collections.Generic;

namespace get1
{
    class Program
    {
       public static void Main()
     {  
         
       google g1=new google()
       {
          Name="pramod",
          Function="manager",
          Hours=8,
        };
       google g2=new google()
       {
          Name="sai",
          Function="associatemanager",
          Hours=18,
        };
        google g3=new google()
        {
          Name="vasanti",
          Function="branchmanager",
          Hours=5,
        };
        List<google> goo=new List<google>();
         goo.Add(g1);
         goo.Add(g2);
         goo.Add(g3);
         
        foreach (google g in goo)
        {
           Console.WriteLine("Name={0},Function={1},Hours={2}",g.Name,g.Function,g.Hours);
        }

     }
     public class google
     {
        public string Name{get;set;}
        public string Function{get; set;}
        public int Hours{get;set;}
     }
     
    }
}
