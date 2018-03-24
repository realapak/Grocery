namespace GroceryApp.Model.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        decimal Price { get; }

        decimal CalculateTotal(int quantity);
    }
}