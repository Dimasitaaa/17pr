using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color(255, 128, 0);
            var c2 = c1;
            c2.r = 100;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
    struct Color
    {
        private int R;
        private int G;
        private int B;

        public int r
        {
            get { return R; }
            set
            {
                if (value >= 0 && value <= 255) { R = value; }
                else
                {
                    Console.WriteLine("Число должно быть от 0 до 255");
                }
            }
        }
        public int g
        {
            get { return G; }
            set
            {
                if (value >= 0 && value <= 255) { G = value; }
                else
                {
                    Console.WriteLine("Число должно быть от 0 до 255");
                }
            }
        }
        public int b
        {
            get { return B; }
            set
            {
                if (value >= 0 && value <= 255) { B = value; }
                else
                {
                    Console.WriteLine("Число должно быть от 0 до 255");
                }
            }
        }
        public Color (int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public override string ToString()
        {
            return R + ", " + G + ", " + B;
        }
    }
}
