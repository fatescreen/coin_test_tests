using NUnit.Framework;
using coin_test.EuroDiffusion;

namespace coint_test_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void UniqueCoinsTypeCountTest()
        {
            ICity cityOne = new City("Russia", 1, 1);
            ICity cityTwo = new City("Ukraine", 1, 2);

            ICoin coinOne = new Coin(cityOne);
            ICoin coinTwo = new Coin(cityTwo);

            cityOne.AddCoin(coinOne);
            cityOne.AddCoin(coinTwo);

            var uniqueCoinsAmmount = cityOne.UniqueCoinsTypeCount();

            Assert.AreEqual(uniqueCoinsAmmount, 2);
        }
    }
}