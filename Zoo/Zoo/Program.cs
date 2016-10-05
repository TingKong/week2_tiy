﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key Facts on the animals at Ting's Zoo"  );
            Console.WriteLine("");

            PolarBear myMam = new PolarBear();
            myMam.Weight = 700;
            Console.WriteLine("At Ting's zoo our animals fall into 3 categories: mammals, birds, and fish.");
            Console.WriteLine("We have two types of mammals at Ting's Zoo. The Polar Bear and Koala Bear. ");
            Console.WriteLine("We have two types of birds at Ting's Zoo. The Owl and Ostrich. ");
            Console.WriteLine("We have two types of fish at Ting's Zoo. The Penguin and the Shark. ");
            Console.WriteLine();

            Console.WriteLine("/***************Polar Bears***************/");

            Console.WriteLine("Polar Bears have " + myMam.NumOfLegs + " legs " + " and they typically live on " + myMam.Location.ToLower() +".");
            Console.WriteLine("It is " + myMam.MeatEaters.ToString().ToLower() + " that Polar Bears consume a lot of meat. Another " + myMam.Furry.ToString().ToLower() + " fact is that they are very furry.");
            Console.WriteLine("Polar Bears typically weigh about " + myMam.Weight + " pounds.");
            Console.WriteLine("Do Polar Bears live in the cold? " + myMam.ColdClimates + "!!");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("/***************Koala Bears***************/");

            Koala myMam2 = new Koala();
            myMam2.Hugs = "cuddle";
            myMam2.MeatEaters = false;
            myMam2.Trees = "they love to climb trees!";
            Console.WriteLine("Koala Bears are very similar to the Polar Bear. They too have " + myMam2.NumOfLegs + " legs and they also reside on " + myMam2.Location + ".");
            Console.WriteLine("Koala Bears are really friendly and they love to " + myMam2.Hugs + ".");
            Console.WriteLine("Koala Bears " + myMam2.Trees + ".");
            Console.WriteLine("Are Koala Bears Furry? " + myMam2.Furry + "!!!");
            Console.WriteLine("Do Koala's eat meet? " + myMam2.MeatEaters + " Unlike other mammals Koalas do not eat meat. ");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("/***************Owls***************/");

            Owl myBird = new Owl();
            myBird.Toes = 4;
            myBird.Food = "small animals";
            Console.WriteLine("The beautiful owl lives on " + myBird.Location + " and they have " + myBird.NumOfLegs + " legs.");
            Console.WriteLine("It is " + myBird.Nocturnal.ToString().ToLower() + " owls are nocturnal");
            Console.WriteLine("Owls have " + myBird.Toes + " toes, and it is " + myBird.Flys.ToString().ToLower() + " owls fly.");
            Console.WriteLine("For food Owls love to eat " + myBird.Food + ".");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("/***************Ostrich***************/");

            Ostrich myBird2 = new Ostrich();
            myBird2.Toes = 4;
            myBird2.Eggs = 2;
            Console.WriteLine("Ostriches live on " + myBird2.Location + " and they have " + myBird.NumOfLegs + " legs.");
            Console.WriteLine("Ostriches have " + myBird2.Toes + " toes, and it is " + myBird2.Flys.ToString().ToLower() + " ostriches cannot fly.");
            Console.WriteLine("Do ostriches scare easy? " + myBird2.ScaredEasily);
            Console.WriteLine("At one time ostriches can lay " + myBird2.Eggs + " eggs.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("/***************Penguins***************/");

            Penguins myFish = new Penguins();
            myFish.Slides = 10;
            Console.WriteLine("Pengruins live on " + myFish.Location + " and they have " + myFish.NumOfLegs + " legs.");
            Console.WriteLine("Do Penguins have gills? " + myFish.Gills );
            Console.WriteLine("Do Penguins live in water? " + myFish.LivesInWater);
            Console.WriteLine("Do Penguins mate for life? " + myFish.MatesForLife);
            Console.WriteLine("Penguins typically slide " + myFish.Slides + " times a day");
            Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("/***************Sharks**************/");

            Sharks myFish2 = new Sharks();
            myFish2.Teeth = 20;
            myFish2.Weight = 1000;
            myFish2.NumOfLegs = 0;
            Console.WriteLine("Sharks live in the " + myFish2.Location + " and they have " + myFish2.NumOfLegs + " legs.");
            Console.WriteLine("Do Sharks have gills? " + myFish2.Gills);
            Console.WriteLine("Do Sharks live in water? " + myFish2.LivesInWater);
            Console.WriteLine("Sharks typically have " + myFish2.Teeth + " sharp tooth.");
            Console.WriteLine("Sharks typically weigh " + myFish2.Weight + " pounds.");







            Console.ReadLine();

        }
    }
}
