namespace GroceryApp.Model.Implementations
{
    using System;
    using GroceryApp.Model.Implementations.Base;

    public class Papaya : Product
    {
        public override string Name { get => "Papaya"; }
        public override decimal Price { get => 0.5M; }

        public override decimal CalculateTotal(int quantity)
        {
            quantity = quantity - (int)Math.Truncate((decimal)quantity / 3);
            return base.CalculateTotal(quantity);
        }
    }
}