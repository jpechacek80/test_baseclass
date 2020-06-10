using System;

namespace test_baseclass
{
  class Program_Base
  {
    static void Main(string[] args)
    {

      var o= new Person();
      char c;
      do
      {
        c = Console.ReadKey().KeyChar;

        if (c == 'e')
          o = new Employee();
        else
          o = new Customer();
         
         o.GetInfo();

      } while (c != 0x1B);

      Employee E = new Employee();
      E.GetInfo();
      Customer C = new Customer();
      C.GetInfo();

      Console.ReadKey();
    }
  }
  public class Person
  {
    protected string ssn = "444-55-6666";
    protected string name = "John Smith";

    public virtual void GetInfo()
    {
      Console.WriteLine("Name: {0}", name);
      Console.WriteLine("SSN: {0}", ssn);
    }
  }
  class Employee : Person
  {
    public string id = "ABC567EFG";
    public override void GetInfo()
    {
      base.GetInfo();            // Calling the base class GetInfo method:
      Console.WriteLine("Employee ID: {0}", id);
    }
  }
  class Customer : Person
  {
    public string id = "ABC123456";
    public override void GetInfo()
    {
      base.GetInfo();            // Calling the base class GetInfo method:
      Console.WriteLine("Customer ID: {0}", id);
    }
  }
}
