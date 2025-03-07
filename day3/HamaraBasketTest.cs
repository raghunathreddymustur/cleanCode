using static hamaraBasket.Tests.DomainFactory;


namespace hamaraBasket
{
    [TestFixture]
    public class HamaraBasketTest
    {
        [Test]
        public void GeneralItem_QualityAndSellInDecreaseByOne()
        {
            IList<Item> Items = new List<Item> { CreateItem("foo", 10, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
            Assert.That(Items[0].Quality, Is.EqualTo(9));
        }

        [Test]
        public void GeneralItem_QualityDoesNotGoBelowZero()
        {
            IList<Item> Items = new List<Item> { CreateItem("foo", 10, 0) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void GeneralItem_QualityDecreasesByTwoAfterSellInDate()
        {
            IList<Item> Items = new List<Item> { CreateItem("foo", 0, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(8));
        }

        [Test]
        public void IndianWine_QualityIncreasesByOne()
        {
            IList<Item> Items = new List<Item> { CreateItem("Indian Wine", 10, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(11));
        }

        [Test]
        public void IndianWine_QualityDoesNotExceedFifty()
        {
            IList<Item> Items = new List<Item> { CreateItem("Indian Wine", 10, 50) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(50));
        }

        [Test]
        public void IndianWine_QualityIncreasesByTwoAfterSellInDate()
        {
            IList<Item> Items = new List<Item> { CreateItem("Indian Wine", 0, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(12));
        }

        [Test]
        public void MovieTickets_QualityIncreasesByOneWhenSellInGreaterThanTen()
        {
            IList<Item> Items = new List<Item> { CreateItem("Movie Tickets", 11, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(11));
        }

        [Test]
        public void MovieTickets_QualityIncreasesByTwoWhenSellInTenOrLess()
        {
            IList<Item> Items = new List<Item> { CreateItem("Movie Tickets", 10, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(12));
        }

        [Test]
        public void MovieTickets_QualityIncreasesByThreeWhenSellInFiveOrLess()
        {
            IList<Item> Items = new List<Item> { CreateItem("Movie Tickets", 5, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(13));
        }

        [Test]
        public void MovieTickets_QualityDropsToZeroAfterSellInDate()
        {
            IList<Item> Items = new List<Item> { CreateItem("Movie Tickets", 0, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void ForestHoney_QualityDoesNotChange()
        {
            IList<Item> Items = new List<Item> { CreateItem("Forest Honey", 10, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].Quality, Is.EqualTo(10));
        }

        [Test]
        public void ForestHoney_SellInDoesNotChange()
        {
            IList<Item> Items = new List<Item> { CreateItem("Forest Honey", 10, 10) };
            HamaraBasket app = CreateHamaraBasket(Items);
            app.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(10));
        }
    }
}
