using FarmSystem.Interfaces.Animals;
using System;

namespace FarmSystem.Classes.Animals.Base
{
    /// <summary>
    /// Base class for all milkable animals, inherits from BaseAnimal and implements IMilkableAnimal method for ProduceMilk
    /// </summary>
    public abstract class BaseMilkableAnimal : BaseAnimal, IMilkableAnimal
    {
        #region Constructors

        protected BaseMilkableAnimal(int noOfLegs, string sound) : base(noOfLegs, sound)
        {
        }

        #endregion

        #region Public Methods

        void IMilkableAnimal.ProduceMilk()
        {
            Console.WriteLine($"{this.Name} was milked!");
        }   

        #endregion
    }
}
