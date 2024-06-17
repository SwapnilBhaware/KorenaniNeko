using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Customer c1 = Customer.Instance;
        Customer c2 = Customer.Instance;
        if (c1.Equals(c2))
        {
            Console.WriteLine("SAME");
        }
        else
        {
            Console.WriteLine("NOT SAME");
        }
        Console.ReadLine();
    }

        public class Customer
    {
        static Customer _obj = null;
        static int _counter = 1;
         private Customer()
        { }
        public static Customer Instance
        {
            get
            {
                if (_obj == null || _counter >= 1)
                {
                    _obj = new Customer();
                    _counter++;
                }
                else
                {
                    throw new Exception("only two vaiable methods are Possible");

                }
                return _obj;

            }

        }
    }
}
