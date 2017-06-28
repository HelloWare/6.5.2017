using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrument
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar();
            EletronicGuitar eleGuitar = new EletronicGuitar();
            Piano piano = new Piano();

            List<Instrument> instruments = new List<Instrument>();
            instruments.Add(guitar);
            instruments.Add(piano);
            instruments.Add(eleGuitar);

            foreach (Instrument instrument in instruments)
            {
                instrument.Play();
            }
        }
    }

   abstract class Instrument
    {
        private string name;

        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public abstract void Play();
    }

    class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Play Guitar");
        }
    }

    class EletronicGuitar : Guitar
    {
        public override void Play()
        {
            Console.WriteLine("Eletronic: ");
            base.Play();
        }
    }

    class Piano : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Play Piano");
        }
    }
}
