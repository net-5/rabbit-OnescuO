using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //use Human class
            Human oana = new Human();//Oana is the object, human is the class
            oana.Eyes = 2;// setter
            oana.Name = "Oana";// setter
            oana.SaySomething();
            oana.Yell();

            var myName = oana.Name; // getter
            Console.WriteLine($"myName = {myName}");

            // Another Human

            Human otherHuman = new Human();
            otherHuman.CanYell = true;
            otherHuman.SaySomething();
            otherHuman.Yell();

            // Third Human
            Human thirdHuman = new Human(2, "Scoala Informala");
            thirdHuman.SaySomething();


            //First dog
            Dog firstDog = new Dog(4, "Bobita");
            //new Dog()
            firstDog.Bark();
            Dog secondDog = new Dog();
            secondDog.Bark();
            secondDog.SaySomething();

            //First car
            Car firstCar = new Car();
            firstCar.Name = "Ford";
            firstCar.Weels = 4;
            firstCar.NumberOfDoors = 6;
            firstCar.SayCarName();
            Console.WriteLine($"{firstCar.Name} has {firstCar.Weels} wheels and {firstCar.NumberOfDoors} doors");
            //Print const and readonly
            Console.WriteLine($"dateOfBirth = {firstCar.dateOfBirth}");

            //third dog
            Dog thirdDog = new Dog()
            {
                Legs = 4,
                Name = "Azorel"

            };
            Console.WriteLine($"thirdDog name = {thirdDog.Name}");
            Console.WriteLine(thirdDog.DogInformation);

            //static
            Console.WriteLine($"My static animal is {Animal.GetName()}");
            Console.WriteLine($"My static animal is {Animal.Name}");

            //structss
            Color color = new Color();
            color.red = "Red";
            Console.WriteLine($"I like color{color.red}");
            //Enum
            Console.WriteLine($"Week Monday = {week.Monday}");
            Console.WriteLine($"Week Monday = {(int)week.Monday}");
            Console.WriteLine($"Week Tuesday = {(int)week.Tuesday}");

            //i get

            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Ford";
            vehicle.Country = "USA";
            vehicle.Wheels = 4;
            vehicle.Price = 20000;
            vehicle.CreationDate = 2015;
            vehicle.GetCarInfo();
            Console.WriteLine(vehicle.CarAge);
            vehicle.GetCarPrice();

            //Rabbit
            Rabbit rabbit = new Rabbit();
            rabbit.Eyes = "blue";
            rabbit.Fur = "white";
            rabbit.Gender = "male";
            rabbit.BirthDate = 2012;
            rabbit.Behavior = "moves, sleeps and eats";
            rabbit.Type = "mammal";
            rabbit.GetRabitInfo();
            Console.WriteLine(rabbit.RabbitAge);
            rabbit.RabbitBehavior();


        }
        struct Color
        {
            public string red;
            public string green;
        }
        struct Square
        {
            public int area;
            public Color borderColor;
        }
        enum week
        {
            Monday = 3,
            Tuesday = 0,
            Wednesday = 23,
            Thursday = 20,
            Saturday,
            Sunday
                       
        }

    }

    }

 

    
    
    

