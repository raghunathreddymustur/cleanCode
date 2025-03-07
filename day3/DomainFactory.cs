namespace hamaraBasket.Tests
{
    internal class DomainFactory
    {
        private static DomainFactory myInstance;

        [SetUp]
        public void Setup()
        {
            myInstance = new DomainFactory();
        }

        public static Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }

        public static HamaraBasket CreateHamaraBasket(IList<Item> items)
        {
            return new HamaraBasket(items);
        }
    }
}
