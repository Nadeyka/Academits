using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Ivan", 29));
            persons.Add(new Person("Petr", 26));
            persons.Add(new Person("Elena", 19));
            persons.Add(new Person("Inna", 41));
            persons.Add(new Person("Inna", 41));

            persons.Distinct();
            persons.ForEach(value => Console.WriteLine(value.Name));
        }
    }
}
