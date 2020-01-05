using System;

namespace Virutal
{

    public class BaseClass
    {
        public  virtual void get()
        {
            Console.WriteLine("Inside Base class");
        }
    }

    public class SubClass1 : BaseClass
    {
        public  override void get()
        {
            Console.WriteLine("Inside SubClass1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SubClass1 obj = new SubClass1();
            obj.get();

            BaseClass obj1 = new BaseClass();
            obj1.get();
        }
    }
}
