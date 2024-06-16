using Pattern_Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Prototype.Classes
{
    public class Pet : Animal
    {
        public string Owner { get; set; }

        public Pet(string name, string owner) : base(name)
        {
            Owner = owner;
        }

        public override Animal Clone()
        {
            return new Pet(Name, Owner);
        }
    }
}
