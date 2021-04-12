using System;
using System.Collections.Generic;

namespace get3
{
    class Program
    {
        public static void Main()
        {
          application app1=new application()
          {
              instagram="app4",
              facebook="icon1",
              twitter="social1",
          };
          application app2=new application()
          {
             instagram="app5",
             facebook="icon2",
             twitter="social2", 
          };
          application app3=new application()
          {
              instagram="app6",
              facebook="icon3",
              twitter="social3",
          }; 
          List<application> app=new List<application>();
            app.Add(app1);
            app.Add(app2);
            app.Add(app3);

            foreach (application a in app)
            {
                Console.WriteLine("instagram={0},facebook={1},twitter={2}",a.instagram,a.facebook,a.twitter);
            }
        }
        public  class application
        {
            public string instagram{get;set;}
            public string facebook{get;set;}
            public string twitter{get;set;}
        }
    }
}
