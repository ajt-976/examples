using FarmSystem.Interfaces.Animals;
using FarmSystem.Classes.Animals.Base;
using System;

namespace FarmSystem.Classes.Animals
{
    public partial class Sheep : BaseAnimal, IAnimal
    {
        public Sheep() : base(4, "baa")
        {
        }
    }

}