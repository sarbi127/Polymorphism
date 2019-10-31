using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_3
{
    // interface
    class Animal : IAnimal
    {
        private string Name { get; set; }
        private int Weight { get; set; }
        private int Age { get; set; }

        public Animal()
        {

        }

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
        private object horse;

        public Horse(string name, int weight, int age): base(name, weight, age) { }
        public string HorseDisease { get; set; }

        public string print()
        {

            return $"HorseDisease: {horse}";
        }
        public override string Stats()
        {

            return $"HorseDisease: {HorseDisease}";
        }
    }

    class Dog : Animal
    {
        public Dog (string name, int weight, int age) : base(name, weight, age) { }
        public string DogDisease { get; set; }

        public override string Stats()
        {

            return $"DogDisease: {DogDisease}";
        }

        public void Speak()
        {
            Console.WriteLine("Woff");
        }
    }

    class Hedgehog : Animal
    {
        public Hedgehog(string name, int weight, int age) : base(name, weight, age) { }
        public string HedgehogDisease { get; set; }
       public override string Stats()
       {
        return $"HedgehogDisease: {HedgehogDisease}";
       }
     }

    class Bird : Animal
    {
        public Bird(string name, int weight, int age) : base(name, weight, age) { }
        public string BirdDisease { get; set; }

        public override string Stats()
        {
            return $"BirdDisease: {BirdDisease}";
        }
    }

    class Pelican : Bird
    {
        public Pelican(string name, int weight, int age) : base(name, weight, age) { }
        public string PelicanDisease { get; set; }

        public override string Stats()
        {
            return $"PelicanDisease: {PelicanDisease}";
        }


    }

    class Flamingo : Bird
    {
        public Flamingo(string name, int weight, int age) : base(name, weight, age) { }
        public string FlamingoDisease { get; set; }

        public override string Stats()
        {
            return $"FlamingoDisease: {FlamingoDisease}";
        }

    }

    class Swan : Bird
    {
        public Swan(string name, int weight, int age) : base(name, weight, age) { }
        public string SwanDisease { get; set; }

        public override string Stats()
        {
            return $"SwanDisease: {SwanDisease}";
        }


    }

    // Q8. Bird class
    // Q9. Animal class



}
