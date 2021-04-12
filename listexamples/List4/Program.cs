using System;
using System.Collections.Generic;

namespace List4
{
    class Program
    {
        public static void Main( )
        {
            employee em1=new employee()
            {
            personname="sai",
            age=20
            };
            employee em2=new employee()
            {
               personname="kiran",
               age=25
            };
            employee em3= new employee()
            {
               personname="das",
               age=28
            };
            List<employee> em= new List<employee>();
            em.Add(em1);
            em.Add(em2);
            em.Add(em3);
            foreach (employee e in em)
            {
              Console.WriteLine("personname={0}, age={1}" , e.personname, e.age);
            }
        }
        public class employee
      {
        public string personname {get; set;}
        public int age {get; set;}
      }
    }
    
}
