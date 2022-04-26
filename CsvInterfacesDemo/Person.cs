using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvInterfacesDemo
{
    class Person : ICsv         // Implement interface ICsv
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string AsCsv()
        {
            return $"{Name},{Age}";
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
