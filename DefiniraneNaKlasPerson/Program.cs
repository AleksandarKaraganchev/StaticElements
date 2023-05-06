using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Person person1 = new Person("Maria", 20);
            Person person2 = new Person("Petur", 25);
            Person person3 = new Person("Ivan", 30);
            Console.WriteLine(Person.Counter);
        }
    }
}
