using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvInterfacesDemo
{
    class Dog : ICsv
    {
        public Dog(string callname, string favoriteToy)
        {
            Callname = callname;
            FavoriteToy = favoriteToy;
        }

        public string AsCsv()
        {
            return $"{Callname},{FavoriteToy}";
        }

        public string Callname { get; set; }
        public string FavoriteToy { get; set; }
    }
}
