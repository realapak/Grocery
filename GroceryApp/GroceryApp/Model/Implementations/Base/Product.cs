namespace GroceryApp.Model.Implementations.Base
{
    using GroceryApp.Model.Interfaces;

    public abstract class Product : IProduct
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }

        public virtual decimal CalculateTotal(int quantity)
        {
            return Price * quantity;
        }
    }
}