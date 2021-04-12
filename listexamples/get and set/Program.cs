using System;
using System.Collections.Generic;

namespace get_and_set
{
    class Program
    {
        public static void Main()
        {
          room room1=new room()
          {
            chairs="sitting",
            price=1000,
            discount=5,
          };
          room room2=new room()
          {
            chairs="sleeping",
            price=1500,
            discount=10,
          };
          room room3=new room()
          {
            chairs="lying",
            price=1200,
            discount=15,
          };
          List<room> roo=new List<room>();
          roo.Add(room1);
          roo.Add(room2);
          roo.Add(room3);

          foreach(room r in roo)
          {
             Console.WriteLine("chairs={0},price={1},discount={2}" ,r.chairs, r.price, r.discount );
          }
        }

        public class room
        {
            public string chairs{get;set;}
            public int price{get;set;}
            public int discount{get;set;}
        }
        
    }
}
