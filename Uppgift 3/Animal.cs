using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_3
{
    // interface
    class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

      

        // constructor
        public Animal(string name, int weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }

        public virtual string Stats()
        {
            return $"Name: {Name.ToString()}, Weight: {Weight.ToString()}, Age: {Age.ToString()}";
        }
    }

    class Horse : Animal
    {

        public Horse(string name, int weight, int age, string hourseDisese): base(name, weight, age) { HorseDisease = hourseDisese; }
        public string HorseDisease { get; set; }

        public override string Stats()
        {

            return base.Stats() +  $"HorseDisease: {HorseDisease}";
        }
    }

    class Dog : Animal
    {
        public Dog (string name, int weight, int age, string dogDisease) : base(name, weight, age) { DogDisease = dogDisease; }
        public string DogDisease { get; set; }

        public override string Stats()
        {

            return base.Stats() + $"DogDisease: {DogDisease}";
        }

        public void Speak()
        {
            Console.WriteLine("Woff");
        }
    }

    class Hedgehog : Animal
    {
        public Hedgehog(string name, int weight, int age, string hedgehogDisease) : base(name, weight, age) { HedgehogDisease = hedgehogDisease; }
        public string HedgehogDisease { get; set; }
       public override string Stats()
       {
        return base.Stats() +  $"HedgehogDisease: {HedgehogDisease}";
       }
     }

    class Bird : Animal
    {
        public Bird(string name, int weight, int age, string birdDisease) : base(name, weight, age)  { BirdDisease = birdDisease; }
        public string BirdDisease { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"BirdDisease: {BirdDisease}";
        }
    }

    class Pelican : Bird
    {
        public Pelican(string name, int weight, int age, string pelicanDisease) : base(name, weight, age, pelicanDisease) { PelicanDisease = pelicanDisease; }
        public string PelicanDisease { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"PelicanDisease: {PelicanDisease}";
        }


    }

    class Flamingo : Bird
    {
        public Flamingo(string name, int weight, int age , string flamingoDisease) : base(name, weight, age, flamingoDisease) { FlamingoDisease = flamingoDisease; }
        public string FlamingoDisease { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"FlamingoDisease: {FlamingoDisease}";
        }

    }

    class Swan : Bird
    {
        public Swan(string name, int weight, int age, string swanDisease) : base(name, weight, age, swanDisease) { SwanDisease = swanDisease; }
        public string SwanDisease { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"SwanDisease: {SwanDisease}";
        }


    }

    // Q8. Bird class
    // Q9. Animal class



}
