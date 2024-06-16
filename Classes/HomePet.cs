using Pattern_Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Prototype.Classes
{
    public class HomePet : Pet
    {
        public bool IsHousebroken { get; set; }

        public HomePet(string name, string owner, bool isHousebroken) : base(name, owner)
        {
            IsHousebroken = isHousebroken;
        }

        public override Animal Clone()
        {
            return new HomePet(Name, Owner, IsHousebroken);
        }
    }
}

