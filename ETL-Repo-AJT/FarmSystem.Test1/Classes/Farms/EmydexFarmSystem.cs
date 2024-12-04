using FarmSystem.Interfaces.Animals;
using FarmSystem.Interfaces.Farms;
using FarmSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Classes.Farms
{
    public class EmydexFarmSystem : IFarmSystem
    {
        #region Private Members

        private List<IAnimal> _animals;

        #endregion

        #region Constructors
        public EmydexFarmSystem() : this(new List<IAnimal>())
        {
            
        }

        public EmydexFarmSystem(List<IAnimal> animals)
        {
            InitializeFarm(animals);
        }

        #endregion

        #region Public Methods

        public void InitializeFarm(List<IAnimal> animals)
        {
            _animals = _animals ?? new List<IAnimal>();
            _animals.Clear();

            foreach (var animal in animals)
            {
                this.Enter(animal);
            }
        }

        //TEST 1
        public void Enter(IAnimal animal)
        {
            Console.WriteLine($"{animal.Name} has entered the Emydex farm");
            _animals.Add(animal);
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (var animal in _animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in _animals)
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();   
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
       {
            foreach (var animal in _animals.ToList())
            {
                animal.Release();
                _animals.Remove(animal);
            }

            if (_animals.Count == 0)
            {
                OnFarmEmpty(new FarmEmptyEventArgs { Message = "Emydex Farm is now empty" });
            }
        }       

        #endregion

        #region Events

        public event EventHandler FarmEmpty;

        #endregion

        #region Private Methods

        private void OnFarmEmpty(EventArgs e)
        {
            FarmEmpty?.Invoke(this, e);
        }

        #endregion
    }
}