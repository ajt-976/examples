using FarmSystem.Interfaces.Animals;
using System;
using System.Collections.Generic;

namespace FarmSystem.Interfaces.Farms
{
    public interface IFarmSystem
    {
        void InitializeFarm(List<IAnimal> animals);
        void Enter(IAnimal animal);
        void MakeNoise();
        void MilkAnimals();
        void ReleaseAllAnimals();

        event EventHandler FarmEmpty;
    }
}
