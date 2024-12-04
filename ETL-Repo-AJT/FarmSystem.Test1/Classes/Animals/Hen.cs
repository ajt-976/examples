using FarmSystem.Interfaces.Animals;
using FarmSystem.Classes.Animals.Base;
using System;

namespace FarmSystem.Classes.Animals
{
    public partial class Hen : BaseAnimal, IAnimal
    {
        public Hen() : base(2, "CLUCKAAAAAWWWWK")
        {        
        }
    }
}