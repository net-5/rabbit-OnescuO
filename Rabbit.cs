using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public enum EyesType
    {
        Blue,
        Red,
        Black
    }
    public enum FurType
    {
        White,
        Brown,
        Black,
        Grey
    }
    public enum GenderType
    {
        Male,
        Female
    }
    public class Rabbit
    {
        //a rabbit can have Blue, Red or Black eyes
        //a rabbit's fur can be white, brown, black or grey
        //it has a gender
        //has a birth date, and based on that you should be able to see how old the rabbit is
        //we also know that a rabbit is a mammal that moves, sleeps and eats
        
        public int BirthDate { get; set; }
        public string Type { get; set; }
        public string Behavior { get; set; }
        public Rabbit(EyesType eyes, FurType fur, GenderType gender, int birthDate, string type, string behavior)
        {
            eyes = eyes;
            fur = fur;
            gender = gender;
            BirthDate = birthDate;
            Type = type;
            Behavior = behavior;

        }


        private int CurrentYear = 2019;
        
        public string GetRabbitInfo
        {
            get
            {
                return $"The rabbit has { EyesType.Blue} eyes, { FurType.White} fur and it is a { GenderType.Male }";
            }
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
