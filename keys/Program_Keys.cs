using System;

namespace keys
{
  class Program_Keys
  {
    static void Main(string[] args)
    {
      string str = "";
      ConsoleKeyInfo c = new ConsoleKeyInfo();
      
      while (c.Key != ConsoleKey.Escape)
      {
         c = Console.ReadKey();
        str += c.KeyChar;
      }
      
      Console.WriteLine("\n"+str);
      Console.ReadKey();

    }
  }
}
