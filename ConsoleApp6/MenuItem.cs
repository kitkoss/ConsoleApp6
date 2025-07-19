using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MenuItem
    {
        public string Title;
        public decimal Price;
        public string Category;

        public MenuItem(string title, decimal price, string category)
        {
            Title = title;
            Price = price;
            Category = category;
        }

        public virtual string GetInfo() =>
            $"Название: {Title}, Категория: {Category}, Стоимость: {Price}";
    }

    class Dish : MenuItem
    {
        public int Calories;
        public double WeightGrams;

        public Dish(string title, decimal price, string category, int calories, double weightGrams)
            : base(title, price, category)
        {
            Calories = calories;
            WeightGrams = weightGrams;
        }

        public double PricePerGram() => (double)Price / WeightGrams;

        public override string GetInfo() =>
            base.GetInfo() + $", Калории: {Calories}, Вес: {WeightGrams} г, Цена за грамм: {PricePerGram():F2}";
    }

    class Drink : MenuItem
    {
        public double VolumeML;

        public Drink(string title, decimal price, string category, double volumeML)
            : base(title, price, category)
        {
            VolumeML = volumeML;
        }

        public decimal DiscountedPrice(double discountPercent)
        {
            return Price * (decimal)(1 - discountPercent / 100);
        }

        public override string GetInfo() =>
            base.GetInfo() + $", Объем: {VolumeML} мл";
    }
}
