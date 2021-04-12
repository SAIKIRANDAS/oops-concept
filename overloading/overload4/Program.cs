using System;

namespace overload4
{
    class Program
    {
        static void Main()
        {
            company com=new company();
            com.speak();
            com.speak(25,"hindi");
            com.speak("hindi","language");
        }
        public class company
        {
            public void speak()
            {
                Console.WriteLine("everyone will speak in diffrent languages");
            }
            public void speak(int number,string languages)
            {
                if(25,"hindi")
                  {
                      Console.WriteLine("hindi");
                  }
                  else if(20,"lang")
                  {
                      Console.WriteLine("speak anything");
                  }
                  else 
                  {
                      Console.WriteLine("don't speak");
                  }
            }
            public void speak(string language, string type)
            {
                Console.WriteLine("he is speaking english");
            }
        }
    }
}
