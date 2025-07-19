using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class FeaturesCat
    {
        public string Name { get; set; }
        public string Breed { get; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Owner { get; }

        public FeaturesCat(string name, string breed, double height, double weight, string owner)
        {
            Name = name;
            Breed = breed;
            Height = height;
            Weight = weight;
            Owner = owner;
        }

        public string Information => $"Кличка: {Name}, Порода: {Breed}, Рост: {Height}, Вес: {Weight}, Хозяин: {Owner}";
    }

    class MethodCat
    {
        private string name;
        private string breed;
        private double height;
        private double weight;
        private string owner;

        public MethodCat(string name, string breed, double height, double weight, string owner)
        {
            this.name = name;
            this.breed = breed;
            this.height = height;
            this.weight = weight;
            this.owner = owner;
        }

        public string GetName() => name;
        public void SetName(string value) => name = value;
        public double GetHeight() => height;
        public void SetHeight(double value) => height = value;
        public double GetWeight() => weight;
        public void SetWeight(double value) => weight = value;
        public string GetBreed() => breed;
        public string GetOwner() => owner;

        public string GetInformation() => $"Кличка: {name}, Порода: {breed}, Рост: {height}, Вес: {weight}, Хозяин: {owner}";
    }
}
