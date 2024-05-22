// See https://aka.ms/new-console-template for more information
using lab4;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bakery> bakerys = new List<Bakery>
        {
            new Bread("ржаной", 20),
            new Donut("пшеничный", 50),
            new Bread("ржаной", 30),
            new Donut("пшеничный", 10),
            new Bread("ржаной", 40)
        };
            Console.WriteLine("введите сорт муки:");
            var abc = Console.ReadLine();
            if (string.IsNullOrEmpty(abc))
            {
                throw new ArgumentException("вы ниче не ввели..");
            }
            else
            {
                var result2Linq = from bakery in bakerys
                                  group bakery by bakery.FlourGrade
                        into groupedBakery
                                  select new
                                  {
                                      FlourGrade = groupedBakery.Key,
                                      AverageCost = groupedBakery.Average(x => x.Cost),
                                  };
                foreach (var grouped in result2Linq)
                {
                    Console.WriteLine($"Сорт муки: {grouped.FlourGrade}, средняя стоимость:{grouped.AverageCost}");
                }

                Console.WriteLine();

                var result2Ex = bakerys
                    .GroupBy(bakery => bakery.FlourGrade)
                    .Select(groupedBakery =>
                    new
                    {
                        FlourGrade = groupedBakery.Key,
                        AverageCost = groupedBakery.Average(x => x.Cost),
                    });
                foreach (var grouped in result2Ex)
                {
                    Console.WriteLine($"Сорт муки: {grouped.FlourGrade}, средняя стоимость:{grouped.AverageCost}");
                }
            }


        }
    }
}

