using System;

namespace overload3
{
    class Program
    {
        public class park
        {
            public void animal(string name)
            {
                 Console.WriteLine("animals are in forest");
            }
            public void animal(string place)
            {
                Console.WriteLine("lion won't eat grass");
            }     
        }
        public static void Main()
        {
            park zoo=new park();
            zoo.animal("lion");
            zoo.animal("gandhinagar");
        }
    }
}
