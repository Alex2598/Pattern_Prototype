using Pattern_Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Prototype.Classes
{
    public abstract class Animal : IMyCloneable<Animal>, Pattern_Prototype.Interfaces.ICloneable
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract Animal Clone();

        object Pattern_Prototype.Interfaces.ICloneable.Clone()
        {
            return Clone();
        }
    }

}
