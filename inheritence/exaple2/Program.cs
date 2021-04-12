using System;

namespace exaple2
{
    class Program
    {
        public static void Main()
        {
            rooms roo=new rooms();
            roo.cheif();
            roo.persons();
            room1 ro=new room1();
            ro.s1(20,"sai");
            ro.s1("male","reading");
        }
        public class hostel
        {
            public void cheif(){
                Console.WriteLine("he will cook");
            }  
            public void server(){
                Console.WriteLine("he will serve");
            }
        }
        public class rooms:hostel        {
            public void persons()
            {
                Console.WriteLine("they will do their work");
            }
            public void things(){
                Console.WriteLine("good things");
            }
        }
    }
    class program1
    {
        public class room1
        {
            public void s1(int age, string name)
            {
            Console.WriteLine("firstroom");
            }
            public void s1(string gender, string hobbies)
            {
                Console.WriteLine("good room");
            }
        }
    }


