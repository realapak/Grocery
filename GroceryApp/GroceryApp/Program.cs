namespace GroceryApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GroceryApp.Extensions;
    using GroceryApp.Model.Enums;
    using GroceryApp.Model.Implementations;
    using GroceryApp.Model.Interfaces;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hi... Buy your things...");
            Console.WriteLine("(Press 'Enter' to exit)");
            var buying = true;
            var productList = new List<IProduct>();
            do
            {
                var product = Console.ReadLine();
                if (string.IsNullOrEmpty(product))
                {
                    buying = false;
                    continue;
                }

                productList.Add(GetProduct(product));
            } while (buying);

            var total = productList.GroupBy(x => x.Name)
                       .Select((y) => (y.FirstOrDefault()?.CalculateTotal(y.Count())).GetValueOrDefault(0))
                       .Sum();
            Console.WriteLine($"Total: {total}");
            Console.ReadKey();
        }

        private static Func<string, IProduct> GetProduct = (type) =>
        {
            var specsType = type.GetEnumValue<ProductType>();
            switch (specsType)
            {
                case ProductType.Apple:
                    return new Apple();

                case ProductType.Banana:
                    return new Banana();

                case ProductType.Orange:
                    return new Orange();

                case ProductType.Papaya:
                    return new Papaya();

                default:
                    throw new KeyNotFoundException();
            }
        };
    }
}