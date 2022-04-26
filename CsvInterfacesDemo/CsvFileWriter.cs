using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsvInterfacesDemo
{
    class CsvFileWriter
    {
        // TIGHTLY COUPLED !!!!!!!

        //public void Append(Person person)
        //{
        //    StreamWriter writer = File.AppendText("output.csv");
        //    writer.WriteLine(person.AsCsv());
        //    writer.Close();
        //}

        //public void Append(Dog dog)
        //{
        //    StreamWriter writer = File.AppendText("output.csv");
        //    writer.WriteLine(dog.AsCsv());
        //    writer.Close();
        //}

        public void Append(ICsv obj)
        {
            StreamWriter writer = File.AppendText("output.csv");
            writer.WriteLine(obj.AsCsv());
            writer.Close();
        }
    }
}
