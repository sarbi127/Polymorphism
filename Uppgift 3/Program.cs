using System;
using System.Collections.Generic;

namespace Uppgift_3
{
    class Program
    {

        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person();

            var personhandler = new PersonHandler();
            person1 = personhandler.CreatePerson(12, "sara", "Binazir", 160, 58);
            Console.WriteLine($" {person1.Age},  {person1.FName} , {person1.LName}, {person1.Height}, {person1.Weight} ");
            Console.WriteLine("...............................");

            personhandler.SetAge(person2, 20);
            personhandler.SetName(person2, "Rosa", "Rad");
            personhandler.SetWeight(person2, 70);
            personhandler.SetHight(person2, 190);
            Console.WriteLine($" {person2.Age},  {person2.FName} , {person2.LName}, {person2.Height}, {person2.Weight} ");
            Console.WriteLine("...............................");

            //Print out which animals are in the ​list ​with a ​foreach ​loop​.
            var animal1 = new List<IAnimal>()
            {
                new Horse("horse", 12, 13),
                new Dog("Dog", 12, 13),
                new Pelican("Hedgehog", 12, 13),
                new Flamingo("Hedgehog", 12, 13),
                new Swan("Hedgehog", 12, 13),
            };

            foreach (var v in animal1)
            {
                Console.WriteLine(v);
                Console.WriteLine("-------------");
            }

            var dog = new List<Dog>();
            //dog.Add(new Horse("horse", 12, 13));

            // Q7. Because it is child not parent and not inheritance from Gog class
            // Q8. Animal.

            //Try to print out all ​Animals Stats()​ using a ​foreach ​loop.
            var animal2 = new List<IAnimal>()
            {
                new Horse("horse", 12, 13),
                new Dog("Dog", 12, 13),
                new Hedgehog("Hedgehog", 12, 13),
                new Bird("Hedgehog", 12, 13),
                new Pelican("Hedgehog", 12, 13),
                new Flamingo("Hedgehog", 12, 13),
                new Swan("Hedgehog", 12, 13),

            };

            foreach (var v in animal2)
            {
                Console.WriteLine(v.Stats());
                Console.WriteLine("-------------");
            }
            // Q10. get result from return

            //Print out ​Stats()​ for only object of the type ​Dog​, using a ​foreach ​on ​Animals​.
            foreach (var v in animal2)
            {
                if (v is Dog )    
                {
                    Console.WriteLine(v.Stats());
                    Console.WriteLine("-------------");
                }
                   
            }

            // Q13. because the list have different animals not only Dog

            // ​Speak()​-method on all dogs in the ​Animals ​listusing a ​foreach ​loop.
            foreach (var v in animal2)
            { 
                IsDog(v);
                Console.WriteLine("-------------");
            }

             void IsDog(IAnimal animal)
            {
                if (animal is Dog dog)
                {
                    dog.Speak();
                }
                else
                {
                    Console.WriteLine("Not Dog");
                }

            }

            // Create a ​List ​that takes ​UserError ​in ​Program.cs​​Main()​. Populate it with instanses ofNumericInputError ​and ​TextInputError
            var usererror1 = new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
            };

            foreach (var v in usererror1)
            {
                Console.WriteLine(v.UEMessage());
                Console.WriteLine("-------------");
            }


            //Create three different classes of your own that inherits from UserError, they should all haveunique implementations of ​UEMessage()
            var usererror2 = new List<UserError>()
            {   
                new TextInputError2(),
                new TextInputError3(),
                new TextInputError4(),

            };

            foreach (var v in usererror2)
            {
                Console.WriteLine(v.UEMessage());
                Console.WriteLine("-------------");
            }

            // Q11.This enables to easily change the system without making much changes to the application.

            // Q12. If an object should behave differently based on its state, if you have to check the same condition in multiple places.

            // Q13.
            // 1.Abstract classes can have constants, members, method stubs and defined methods, whereas interfaces can only have constants and methods stubs.
            // 2.Methods and members of an abstract class can be defined with any visibility, whereas all methods of an interface must be defined as public.
            // 3.When inheriting an abstract class, a concrete child class must define the abstract methods.
            // 4.A child class can only extend a single class (abstract or concrete), whereas an interface can extend 
            //or a class can implement multiple other interfaces.

        }



    }

}
