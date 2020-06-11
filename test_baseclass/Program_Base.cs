using System;

namespace test_baseclass
{
  class Program_Base
  {
    static void Main(string[] args)
    {

      Person o;
      //Object o;
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

    }
  }
  public class Person
  {
    protected string name = "John Smith";
    public Person()
    { Console.WriteLine("Base Constructor"); } //base class contructor

    public virtual void GetInfo()
    { Console.WriteLine("Name: {0}", name); }
  }
  class Employee : Person
  {
    // public Employee():base() { }      //Base Constructor called implicitly
    public override void GetInfo()
    {
      name = "Employee: Joe Smith";
      base.GetInfo();                   
    }
  }
  class Customer : Person
  {
    public string id = "ABC123456";
    public Customer() : base() { }      //Base Constructor called explicitly
    public override void GetInfo()
    {
      base.GetInfo();            // Calling the base class GetInfo method:
      Console.WriteLine("Customer ID: {0}", id);
    }
  }
}
