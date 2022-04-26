using System;

namespace CsvInterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person nick = new Person("Nick De Meester", 21);
            Dog viper = new Dog("Viper", "Nora the Chicken");

            ICsv person = nick;
            ICsv dog = viper;

            Console.WriteLine(nick.AsCsv());
            Console.WriteLine(viper.AsCsv());

            CsvFileWriter csv = new CsvFileWriter();
            csv.Append(nick);
            csv.Append(viper);

        }
    }
}
