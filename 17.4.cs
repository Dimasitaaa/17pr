using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Weather("Владимир", -42);
            var w2 = new Weather ("Москва", null);
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2.Temperature ?? -999);
        }
    }
    struct Weather
    {
        public string City {  get; set; }
        public double? Temperature { get; set; }
        public Weather(string city, double? temperature)
        {
            City = city;
            Temperature = temperature;
        }
        public override string ToString()
        {
            string text = "Нет данных.";
            if (Temperature == null)
            {
                return City + ": " + text;
            }
            else
            {
                return City + ": " + Temperature;
            }
        }
    }
}
