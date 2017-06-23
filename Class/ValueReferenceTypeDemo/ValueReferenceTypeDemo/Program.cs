using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb(3);

            int newLumen = 3500;
            Projector projector = new Projector(bulb);
            projector.Lumen = newLumen;
            Console.WriteLine("Lumen: {0}",projector.Lumen); //3500
            Console.WriteLine("Bulb lifeSpan: {0}",projector.Bulb.LifeSpan); // 3
            newLumen = 4000;
            bulb.LifeSpan = 4;
            Console.WriteLine("Lumen: {0}", projector.Lumen); //3500
            Console.WriteLine("Bulb lifeSpan: {0}", projector.Bulb.LifeSpan); // 4

            projector.Bulb.LifeSpan = 5;
            Console.WriteLine("Bulb lifeSpan: {0}", bulb.LifeSpan); // 


        }
    }

    class Projector
    {
        int lumen = 3000;
        Bulb bulb;

        public Projector(Bulb bulb)
        {
            this.Bulb = bulb;
        }

        public int Lumen
        {
            get
            {
                return lumen;
            }

            set
            {
                lumen = value;
            }
        }

        public Bulb Bulb
        {
            get
            {
                return bulb;
            }

            set
            {
                bulb = value;
            }
        }
    }

    class Bulb
    {
        int lifeSpan = 0;

        public Bulb(int lifeSpan)
        {
            this.lifeSpan = lifeSpan;
        }

        public int LifeSpan
        {
            get
            {
                return lifeSpan;
            }

            set
            {
                lifeSpan = value;
            }
        }
    }
}
