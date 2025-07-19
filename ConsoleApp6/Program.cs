namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var student = new FeaturesStudent("Иванов И.И.", "Группа 101", "123456", "111-222-333 44");
            Console.WriteLine("Задание 1: Студент\n" + student.Information);

            var cat = new FeaturesCat("Барсик", "Сиамская", 25.5, 4.3, "Петя");
            Console.WriteLine("\nЗадание 2: Котик\n" + cat.Information);

            var cinema = new FeaturesCinema("Интерстеллар", 500, 120, "Зал №3");
            Console.WriteLine("\nЗадание 3: Кинотеатр\n" + cinema.Information);

            var kitty = new Cat("Мурзик", 4.0, "Британец", new DateTime(2022, 3, 15));
            var parrot = new Parrot("Кеша", 0.3, "Волнистый", new DateTime(2023, 5, 10));
            Console.WriteLine("\nЗадание 4: Животные");
            Console.WriteLine(kitty.GetInfo());
            Console.WriteLine(parrot.GetInfo());

            var tower = new Tower("Свободное падение", TimeSpan.FromMinutes(2), 10, 150);
            var coaster = new RollerCoaster("Горки", TimeSpan.FromMinutes(3), 20, 200);
            Console.WriteLine("\nЗадание 5: Аттракционы");
            Console.WriteLine(tower.GetInfo() + $", Выручка: {tower.Revenue()} руб.");
            Console.WriteLine(coaster.GetInfo() + $", Выручка (15 чел): {coaster.Revenue(15)} руб.");

            var dish = new Dish("Лазанья", 450, "Итальянская кухня", 600, 300);
            var drink = new Drink("Лимонад", 120, "Прохладительный", 500);
            Console.WriteLine("\nЗадание 6: Кафе");
            Console.WriteLine(dish.GetInfo());
            Console.WriteLine(drink.GetInfo() + $", Со скидкой 20%: {drink.DiscountedPrice(20)} руб.");
        }
    }
}
