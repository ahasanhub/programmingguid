using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub=new Publisher();
            Subscriber sub1=new Subscriber("Sub1",pub);
            Subscriber sub2 = new Subscriber("Sub2", pub);
            pub.Dosomething();
            Console.WriteLine("Please enter for exit.");
            Console.ReadKey();
        }
    }
}
