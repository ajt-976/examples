using FarmSystem.Interfaces.Animals;
using FarmSystem.Classes.Animals.Base;
using System;

namespace FarmSystem.Classes.Animals
{
    public partial class Horse : BaseAnimal, IAnimal
    {
        public Horse() : base(4, "Neigh")
        {
        }        
    }
}