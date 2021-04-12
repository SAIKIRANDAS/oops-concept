using System;

namespace inhertence3
{
    class Program
    {
       public class company
       {
           public void branches()
           {
               Console.WriteLine("every where in india");
           }
           public void address()
           {
               Console.WriteLine("u can visit any where");
           }
       }
       public class clintcompany:company
     {
       public void branch1()
       {
           Console.WriteLine("it is in chennai");
       }
       public void address1()
       {
           Console.WriteLine("perungudi,chennai");
       }
     }
     public static void Main()
     {
         company com=new company();
         com.branches();
         com.address();
         clintcompany clint=new clintcompany();
         clint.branch1();
         clint.branches();
         clint.address1();
     }
    }
}
