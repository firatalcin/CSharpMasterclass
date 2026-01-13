namespace _03_PolymorphismInheritanceInterfaces.Pizzeria
{
    public class SpecialTomatoSauce : TomatoSauce
    {
        public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }

        //public override void Prepare() =>
        //    Console.WriteLine("Special tomato sauce");
    }
}
