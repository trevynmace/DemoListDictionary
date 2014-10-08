using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListDictionary
{
    public class City
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2}", Name, State, Zip);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //City city1 = new City() { Name = "SLC", State="UT", Zip = 12345 };
            //Console.WriteLine(city1);

            City sandy = new City() { Name = "Sandy", State = "UT", Zip = 84093 };
            City westJordan = new City() { Name = "West Jordan", State = "UT", Zip = 84081 };
            City southJordan = new City() { Name = "South Jordan", State = "UT", Zip = 84095 };

            Dictionary<int, City> zipCodes = new Dictionary<int, City>()
            {
                {84093, sandy},
                {84081, westJordan},
                {84095, southJordan}
            };

            foreach (KeyValuePair<int, City> element in zipCodes)
            {
                Console.WriteLine("{0} .. {1}", element.Key, element.Value);
            }
        }
    }
}
