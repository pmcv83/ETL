using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Specialized;
using System.Collections;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
      public  ObservableCollection<Animal> Animals { get; }

        public EmydexFarmSystem()
        {
            Animals = new ObservableCollection<Animal>();

            Animals.CollectionChanged += (s, e) =>
            {
                string enterExit = null;
                IList animals = null;

                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:

                        enterExit = "entered";
                        animals = e.NewItems;

                        break;

                    case NotifyCollectionChangedAction.Remove:

                        enterExit = "exited";
                        animals = e.OldItems;

                        break;
                }

                foreach (var animal in animals.Cast<Animal>())
                {
                    Console.WriteLine(animal.Name + " has " + enterExit + " the Emydex farm");
                }

                if (Animals.Count == 0)
                {
                    Console.WriteLine("Emydex Farm is now empty");
                }
            };
        }

        //TEST 1
        public void Enter()
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            Animals.Add(new Cow());
            Animals.Add(new Hen());
            Animals.Add(new Horse());
            Animals.Add(new Sheep());
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
         
            foreach (Animal animal in Animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (Animal animal in Animals)
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
           //Console.WriteLine("There are still animals in the farm, farm is not free");

            while (Animals.Count > 0)
            {
                Animals.Remove(Animals.First());
            }
        }
    }
}