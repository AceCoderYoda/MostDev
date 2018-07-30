#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Zoo.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;
using MostDev.InheritZoo.Domain.Animals;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Animals.Mammals;
using MostDev.InheritZoo.Domain.Animals.Others;
using MostDev.InheritZoo.Domain.Animals.Reptiles;
using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Business
{
    public class Zoo
    {
        private static Zoo _instance;

        private readonly IList<IAnimal> animals = new List<IAnimal>();
        private readonly FoodStock foodStock = new FoodStock();

        protected Zoo()
        {
        }

        public static Zoo Instance()
        {
            if (_instance == null) _instance = new Zoo();

            return _instance;
        }

        public void FillZoo()
        {
            animals.Add(new Lion(60));
            animals.Add(new Lion(14));
            animals.Add(new Lion(15));
            animals.Add(new Lion(156));
            animals.Add(new Lion(10));
            animals.Add(new Dog(50));

            animals.Add(new Giraffe(150));
            animals.Add(new Giraffe(12));
            animals.Add(new Giraffe(5));
            animals.Add(new Giraffe(63));
            animals.Add(new Giraffe(155));
            animals.Add(new Giraffe(234));
            animals.Add(new Crocodile(250));

            animals.Add(new Terran());
            animals.Add(new Terran());
            animals.Add(new Terran());
            animals.Add(new Terran());
        }

        public void AddLion(int weight)
        {
            animals.Add(new Lion(weight));
        }

        public void AddZergling()
        {
            animals.Add(new Zergling());
        }

        public void PrintInfo()
        {
            PrintNumberOfAnimals();
            PrintAnimalInfo();
            PrintFoodStock();
        }

        public void Iterate()
        {
            // Check food
            //  No food > murder
            //  No food > die
            // Check alive

            // a comment
            foreach (var animal in animals)
                if (animal.IsAlive)
                {
                    animal.Eat();
                    Console.WriteLine($"{animal.GetType().Name} IsHungy: {animal.IsHungry}");
                }

            var animalsToRemove = animals.Where(x => !x.IsAlive).ToList();
            foreach (var animal in animalsToRemove) animals.Remove(animal);
        }

        public void PrintNumberOfAnimals()
        {
            var type = typeof(Animal);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsSubclassOf(type) && !p.IsAbstract);

            foreach (var typeOfAnimal in types)
                Console.WriteLine(
                    $"Animal Type: {typeOfAnimal.Name}, # of Animals for type: {animals.Count(x => x.GetType() == typeOfAnimal)}");
        }

        private void PrintAnimalInfo()
        {
            Console.WriteLine("Animals in the zoo");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Type of Animal: {animal.GetType().Name}. " +
                                  $"Name: {animal.Name}, Weight: {animal.Weight}.");
                //Console.Write("Eat: ");
                //animal.Eat();
                Console.Write("Sound: ");
                animal.MakeSound();
            }
        }

        public void PrintFoodStock()
        {
            Console.WriteLine("Print food stock information");
            foodStock.PrintInfo();
        }

        public bool GetFood<T>(float requiredNumberOfFood)
            where T : IFood
        {
            return foodStock.RemoveFoodFromStock<T>(requiredNumberOfFood);
        }

        public int GetNumberOfAnimals()
        {
            return animals.Count;
        }

        public IHerbivore FindHerbivore()
        {
            var herbivore = animals.OfType<IHerbivore>().FirstOrDefault(x => x.IsAlive);
            if (herbivore != null) herbivore.IsAlive = false;

            return herbivore;
        }

        public T Find<T>()
            where T : IAnimal
        {
            var animal = animals.OfType<T>().FirstOrDefault(x => x.IsAlive);
            if (animal != null) animal.IsAlive = false;

            return animal;
        }
    }
}