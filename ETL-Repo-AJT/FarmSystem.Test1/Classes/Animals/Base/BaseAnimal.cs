using FarmSystem.Interfaces.Animals;
using System;

namespace FarmSystem.Classes.Animals.Base
{
    /// <summary>
    /// Base class for all animals, implements IAnimal interface 
    /// </summary>
    public abstract class BaseAnimal : IAnimal
    {
        #region Private Members

        private string _id;
        private int _noOfLegs;
        private string _sound;

        #endregion

        #region Constructors

        public BaseAnimal(int noOfLegs, string sound)
        {
            this.Id = Guid.NewGuid().ToString();
            this.NoOfLegs = noOfLegs;
            this.Sound = sound;
        }

        #endregion

        #region Properties

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }
        public string Sound
        {
            get
            {
                return _sound;
            }
            set
            {
                _sound = value;
            }
        }

        #endregion

        #region Public Methods

        public void Walk()
        {
            Console.WriteLine($"{this.Name} is walking");
        }
        void IAnimal.Run()
        {
            Console.WriteLine($"{this.Name} is running");
        }
        void IAnimal.Talk()
        {
            Console.WriteLine($"{this.Name} says {this.Sound}!");
        }
        void IAnimal.Release()
        {
            Console.WriteLine($"{this.Name} has left the farm");
        }

        #endregion
    }
}
