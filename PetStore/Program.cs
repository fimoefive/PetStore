using PetStore.Pets;
using System;


namespace PetStore
{
    class Program
    {
        // static means shared across all instances
        static void Main(string[] args)
        {
            // DOG
         //   var melba = new Dog();
         //   melba.Name = "Melba";
         //   melba.Size = "Medium";
         //   melba.Weight = 60;
            // this won't work, can't dynamically add properties to a class in C#
            // melba.CoatType = "Short";

            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            // property is privately settable only
            // melba.Weight -= 15;

            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();
            melba.Eat("Healthy Food");


        //    var barley = new Dog();
        //    barley.Name = "Barley";
        //    barley.Size = "Medium";
        //    barley.Weight = 50;
           
            var barley = new Dog("Barley", 50, "Medium");
            barley.Bark();

            Console.WriteLine($"What kind of food should {barley.Name} eat?");
            var typeOfFoodForBarley = Console.ReadLine();
            barley.Eat("table scraps");

            // BEAR
            var bear = new Bear("Yogi", "Brown");
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(-5);

            // passing an object reference to a property
            bear.BestTigerFriend = new Tiger { Name = "Bob", Size = "Miniature"};

            bear.HangOutWithBestFriend();

            var tiger = new Tiger();
            tiger.Name = "Kisa";
            tiger.NumberOfKills = 0;
            tiger.Size = "Medium";

            // object intializer (this is not a Constructor)
            //var tiger = new Tiger
            //{
            //    Name = "Kisa",
            //    NumberOfKills = 0,
            //    Size = "Medium"
            //};

            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            
        }
    }
}
