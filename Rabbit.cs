using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Rabbit
    {
        //a rabbit can have Blue, Red or Black eyes
        //a rabbit's fur can be white, brown, black or grey
        //it has a gender
        //has a birth date, and based on that you should be able to see how old the rabbit is
        //we also know that a rabbit is a mammal that moves, sleeps and eats
        public string Eyes { get; set; }
        public string Fur { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }
        public string Type { get; set; }
        public string Behavior { get; set; }


        private int CurrentYear = 2019;


        public void GetRabitInfo()
        {
            Console.WriteLine($"The rabbit has {this.Eyes} eyes, {this.Fur} fur and it is a {this.Gender}.");
        }

        public int Age
        {
            get { return this.CurrentYear - this.BirthDate; }
        }
        public string RabbitAge
        {
            get { return $"The rabbit is {this.Age} years old."; }
        }
        public void RabbitBehavior()
        {
            Console.WriteLine($"The rabbit is a {this.Type} and he likes to {this.Behavior}.");
        }
    }
}
