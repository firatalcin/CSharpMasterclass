namespace _03_PolymorphismInheritanceInterfaces.Pizzeria
{
    public abstract class Cheese : Ingredient
    {
        public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }
    }
}
