using System;
using System.Collections.Generic;

namespace List2
{
    class Program
    {
        public static void Main()
        {
            bank ban1=new bank()
            {
                customer="employee1",
                age=15,
                name="saikiran"
            };
            bank ban2=new bank()
            {
                customer="employee2",
                age=25,
                name="sai"
            };
             bank ban3=new bank()
            {
                customer="employee3",
                age=35,
                name="kiran"
            };
          List<bank> ba=new List<bank>();
          ba.Add(ban1);
          ba.Add(ban2);
          ba.Add(ban3); 
          foreach (bank b in ba)
          {
              Console.WriteLine("customer={0}, age={1}, name={2}" ,b.customer,b.age,b.name);
          }
        }
    }
    public class bank
    {
        public string customer{get; set;}
        public int age{get; set;}
        public string name {get; set;}
    }
}
