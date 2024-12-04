using FarmSystem.Events;
using FarmSystem.Classes.Farms;
using System;
using FarmSystem.Classes.Animals;
using FarmSystem.Interfaces.Animals;
using System.Collections.Generic;
using FarmSystem.Interfaces.Farms;

namespace FarmSystem.Test1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();

            Console.ReadKey();
        }

/************************************************************************************************************
Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
modify the code to get the output below
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
***************************************************************************************************************/
        private static void Excercise1()
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");            
            Console.ReadKey();

            IFarmSystem farm1 = new EmydexFarmSystem();
            farm1.Enter(new Cow());
            farm1.Enter(new Hen());
            farm1.Enter(new Horse());
            farm1.Enter(new Sheep());
            
            Console.ReadKey();
        }

/***************************************************************************************************************
 Test Excercise 2
 If you have completed the first test excercise, you can continue with the second one
 Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
 Expected Test 2 Program Output

 Exercise 2 : Press any key to scare the animals in the farm
    Cow has entered the farm
    Hen has entered the farm
    Horse has entered the farm
    Sheep has entered the farm
    Cow says Moo!
    Hen says CLUCKAAAAAWWWWK!
    Horse says Neigh!
    Sheep says baa!
 *****************************************************************************************************************/
        private static void Excercise2()
        {
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();

            IFarmSystem farm2 = new EmydexFarmSystem(new List<IAnimal> { new Cow(), new Hen(), new Horse(), new Sheep() });

            farm2.MakeNoise();

            Console.ReadKey();
        }

/*****************************************************************************************************************
Test Excercise 3
If you have completed the previous test excercise, you can continue with this one 
The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

Expected Test 3 Program Output

Exercise 3 : Press any key when it is time to milk animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow was milked!
************************************************************************************************************/
        private static void Excercise3()
        {
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();

            IFarmSystem farm3 = new EmydexFarmSystem(new List<IAnimal> { new Cow(), new Hen(), new Horse(), new Sheep() });

            farm3.MilkAnimals();

            Console.ReadKey();
        }

/****************************************************************************************************
Test Excercise 4
Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
Subscribe to that event in the main to get the expected output

Expected Test 4 Program Output

Exercise 4: Press any key to free all animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow has left the farm
Hen has left the farm
Horse has left the farm
Sheep has left the farm
Emydex Farm is now empty
********************************************************************************************************************/
        private static void Excercise4()
        {
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();

            IFarmSystem farm4 = new EmydexFarmSystem(new List<IAnimal> { new Cow(), new Hen(), new Horse(), new Sheep() });
            farm4.FarmEmpty += (sender, e) => Console.WriteLine(((FarmEmptyEventArgs)e).Message);

            farm4.ReleaseAllAnimals();

            farm4.FarmEmpty -= (sender, e) => Console.WriteLine(((FarmEmptyEventArgs)e).Message);

            Console.ReadKey();
        }
    }
}