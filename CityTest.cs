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
            var countryOneName = "Russia";
            
            ICity cityOne = new City(countryOneName, 1, 1);

            ICoin coinOne = new Coin(countryOneName);
            ICoin coinTwo = new Coin("Ukraine");           


            cityOne.AddCoin(coinOne);
            cityOne.AddCoin(coinTwo);

            var uniqueCoinsAmmount = cityOne.UniqueCoinsTypeCount();

            Assert.AreEqual(2, uniqueCoinsAmmount);

            //ICoin coinTwo = new Coin("Ukraine");
        }
    }
}