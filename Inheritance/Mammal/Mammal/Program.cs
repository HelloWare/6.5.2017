using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal
{
    class Program
    {
        static void Main(string[] args)
        {
            Ape ape = new Ape("ape");
            Console.WriteLine(ape.Name);
            ape.ProduceMilk();
        }
    }

    abstract class Mammal
    {
        private bool isVertebrates = true;
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
        protected Mammal(string name)
        {
            this.name = name;
        }

        //properties
        public bool IsVertebrates
        {
            get
            {
                return  isVertebrates;
            }
        }


        public bool IsEndothermic { get; } = true;
        public bool HasHairOnBoday { get; } = true;

        //methods
        public abstract void ProduceMilk();
    }
    class Human : Mammal
    {
        public Human(string name):base(name)
        {

        }
        public override void ProduceMilk()
        {
            throw new NotImplementedException();
        }
    }
    class Ape : Mammal
    {
        public Ape(string name):base(name)
        {

        }

        public override void ProduceMilk()
        {
            throw new NotImplementedException();
        }
    }
}
