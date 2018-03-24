namespace GroceryApp.Model.Implementations
{
    using GroceryApp.Model.Implementations.Base;

    public class Orange : Product
    {
        public override string Name { get => "Orange"; }
        public override decimal Price { get => 0.3M; }
    }
}