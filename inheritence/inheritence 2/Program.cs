using System;

namespace inheritence_2
{
    class Program
    {
       public class bank
      {
        public void deposit()
        {
          Console.WriteLine("add money to your account");
        }
        public void withdraw()
        {
            Console.WriteLine("u can take money from ur acount");
        }
      }
      public class atm:bank
      {
          public void addmoney()
          {
              Console.WriteLine("add some money");
          }
          public void withdrawal()
          {
              Console.WriteLine("i dont want money");
          }
      }
      public static void Main()
      {
          bank b=new bank();
          b.deposit();
          b.withdraw();
          atm a=new atm();
          a.addmoney();
          a.withdrawal();
          a.deposit();
          a.withdraw();
      } 
    }
}
