using PetStore.Pets;
using System;


namespace PetStore
{
    class Program
    {
        // static means shared across all instances
        static void Main(string[] args)
        {
            var melba = new Dog();
            melba.Name = "Melba";
            melba.Size = "Medium";
            melba.Weight = 60;
            // this won't work, can't dynamically add properties to a class in C#
            // melba.CoatType = "Short";

            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            // property is privately settable only
            // melba.Weight -= 15;

            var barley = new Dog();
            barley.Name = "Barley";
            barley.Size = "Medium";
            barley.Weight = 50;
           
            var barley = new Dog("Barley", 50, "Medium");
            barley.Bark();
            barley.Eat("table scraps");



        }
    }
}
