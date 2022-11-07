using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj2 = new employee();
            obj2.display();
            obj2.show();
            Console.ReadLine();
        }
    }
    public class cls
    {
        public void display()
        {
            Console.WriteLine("HELLO");
        }
    }
    public class employee : cls
    {
        public void show()
        {
            Console.WriteLine("welcome");
        }
    }
}
