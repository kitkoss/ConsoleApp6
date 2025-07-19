using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Animal
    {
        public string Name;
        public double Weight;
        public string Breed;
        public DateTime BirthDate;

        public Animal(string name, double weight, string breed, DateTime birthDate)
        {
            Name = name;
            Weight = weight;
            Breed = breed;
            BirthDate = birthDate;
        }

        public virtual string GetInfo() =>
            $"Имя: {Name}, Вес: {Weight}, Порода: {Breed}, Дата рождения: {BirthDate.ToShortDateString()}";
    }

    class Cat : Animal
    {
        private static Random rnd = new Random();

        public Cat(string name, double weight, string breed, DateTime birthDate)
            : base(name, weight, breed, birthDate) { }

        public bool CatchMouse() => rnd.Next(0, 101) > 50;

        public override string GetInfo() => base.GetInfo() + $", Ловит мышку: {(CatchMouse() ? "Да" : "Нет")}";
    }

    class Parrot : Animal
    {
        public Parrot(string name, double weight, string breed, DateTime birthDate)
            : base(name, weight, breed, birthDate) { }

        public override string GetInfo() => base.GetInfo() + ", Умеет говорить!";
    }
}
