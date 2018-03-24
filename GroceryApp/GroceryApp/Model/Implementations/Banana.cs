namespace GroceryApp.Model.Implementations
{
    using GroceryApp.Model.Implementations.Base;

    public class Banana : Product
    {
        public override string Name { get => "Banana"; }
        public override decimal Price { get => 0.15M; }
    }
}