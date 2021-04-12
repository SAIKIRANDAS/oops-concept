using System;
using System.Collections.Generic;
namespace List3
{
    class Program
    {
        public static void Main()
        {
            skilllync skill1= new skilllync()
            {
                name="sai",
                work="developer"
            };
            skilllync skill2= new skilllync()
            {
                name="kiran",
                work="associate developer"
            };
            skilllync skill3= new skilllync()
            {
                name="das",
                work="fullstackdeveloper"
            };
            List<skilllync> sk=new List<skilllync>();
            sk.Add(skill1);
            sk.Add(skill2);
            sk.Add(skill3);
            foreach (skilllync s in sk)
            {
                Console.WriteLine("name={0}, work={1}", s.name, s.work);
            }
        }
        public class skilllync
        {
            public string name{get; set;}
            public string work{get; set;}
        }
    }
}
