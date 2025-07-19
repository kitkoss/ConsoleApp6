using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Attraction
    {
        public string Name;
        public TimeSpan Duration;
        public int MaxCapacity;

        public Attraction(string name, TimeSpan duration, int maxCapacity)
        {
            Name = name;
            Duration = duration;
            MaxCapacity = maxCapacity;
        }

        public virtual string GetInfo() =>
            $"Название: {Name}, Длительность: {Duration.TotalMinutes} мин, Вместимость: {MaxCapacity}";
    }

    class Tower : Attraction
    {
        public decimal PricePerRide;

        public Tower(string name, TimeSpan duration, int maxCapacity, decimal pricePerRide)
            : base(name, duration, maxCapacity)
        {
            PricePerRide = pricePerRide;
        }

        public decimal Revenue(int people = -1)
        {
            if (people < 0) people = MaxCapacity;
            return PricePerRide * people;
        }

        public override string GetInfo() => base.GetInfo() + $", Цена: {PricePerRide}";
    }

    class RollerCoaster : Attraction
    {
        public decimal PricePerRide;

        public RollerCoaster(string name, TimeSpan duration, int maxCapacity, decimal pricePerRide)
            : base(name, duration, maxCapacity)
        {
            PricePerRide = pricePerRide;
        }

        public decimal Revenue(int people = -1)
        {
            if (people < 0) people = MaxCapacity;
            return PricePerRide * people;
        }

        public override string GetInfo() => base.GetInfo() + $", Цена: {PricePerRide}";
    }
}
