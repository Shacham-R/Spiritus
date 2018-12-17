using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiritus
{
    class Program
    {
        static void Main(string[] args)
        {
            Tile t1 = new Tile();
            Tile t2 = new Tile(0.5, 0.3, 0.3);
            Tile t3 = new Tile(0.1, 0.6, 0.3);
            Tile t4 = new Tile(0.2, 0.3, 0.2);
            Tile t6 = new Tile();

            t1.checker(t6); //// VERGLEICH Zwischen tile 1 und 6 


            Console.ReadLine();
        }
    }
}
