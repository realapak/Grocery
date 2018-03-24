namespace GroceryApp.Model.Implementations
{
    using GroceryApp.Model.Implementations.Base;

    public class Apple : Product
    {
        public override string Name { get => "Apple"; }
        public override decimal Price { get => 0.25M; }
    }
}