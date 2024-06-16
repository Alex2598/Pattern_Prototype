using Pattern_Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Prototype.Classes
{
    public class WildAnimal : Animal
    {
        public string Habitat { get; set; }

        public WildAnimal(string name, string habitat) : base(name)
        {
            Habitat = habitat;
        }

        public override Animal Clone()
        {
            return new WildAnimal(Name, Habitat);
        }
    }
}
