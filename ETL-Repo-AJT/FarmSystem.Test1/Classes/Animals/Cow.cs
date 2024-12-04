using FarmSystem.Interfaces.Animals;
using FarmSystem.Classes.Animals.Base;
using System;

namespace FarmSystem.Classes.Animals
{
    public partial class Cow : BaseMilkableAnimal, IMilkableAnimal
    {
        public Cow() : base(4, "moo")
        {
        }
    }
}