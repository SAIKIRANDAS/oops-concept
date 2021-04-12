using System;
using System.Collections.Generic;

namespace get
{
    class Program
    {
        public static void Main()
     {
           hospital hos1=new hospital()
       {
           Name="sai",
           Salary=10000,
           Work="doctor",
        };
       
           hospital hos2=new hospital()
        {
           Name="kiran",
           Salary=15000,
           Work="nurse",
        };
       
           hospital hos3=new hospital()
        {
           Name="das",
           Salary=10400,
           Work="management",
        };

        List<hospital> hos=new List<hospital>();
        hos.Add(hos1);
        hos.Add(hos2);
        hos.Add(hos3);

        foreach (hospital h in hos)
        {
          Console.WriteLine("Name = {0}, work = {1}, Salary = {2}",h.Name, h.Work, h.Salary);
                      
        }
     }
    
        
        public class hospital
        {
            public string Name{get; set;}
            public int Salary {get; set;}
            public string Work{get; set;}
        }

    }
}
