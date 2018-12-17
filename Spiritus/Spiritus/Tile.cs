using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiritus
{
    class Tile //Main Tile class
    {
        private double level;
        private double life;
        private double water;
        private double earth;

        public Tile()
        {
            this.Life = 0.3;
            this.Water = 0.3;
            this.Earth = 0.3;

            this.level = this.Life + this.Water + this.Earth;



        }

        public Tile(double earth, double water, double life)
        {
            this.Earth = earth;
            this.Water = water;
            this.Life = life;

            this.level = this.Life + this.Water + this.Earth;

        }

        public double Earth { get => earth; set => earth = value; }
        public double Water { get => water; set => water = value; }
        public double Life { get => life; set => life = value; }

        public void checker(Tile var)
        {
            if (this.level > var.level)
            {
                Console.WriteLine("positive OSMOSIS DETECTED! :D");
                /// osmosis 
            }
            else if (this.level < var.level)
            {
                Console.WriteLine("negative OSMOSIS DETECTED! :D");
            }

            else
            {
                Console.WriteLine("nOSMOSIS!! :D");
            }

        }

    }
}

