using NUnit.Framework;
using coin_test.EuroDiffusion;

namespace coint_test_tests
{
    public class CityTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void UniqueCoinsTypeCountTest()
        {
            var countryOneName = "Russia";
            var countryTwoName = "Ukraine";
            var countryThreeName = "Belarus";
            
            ICity cityOne = new City(countryOneName, 1, 1);
            Assert.AreEqual(1, cityOne.UniqueCoinsTypeCount());

            cityOne.AddCoin(new Coin(countryOneName));
            cityOne.AddCoin(new Coin(countryTwoName));
            Assert.AreEqual(2, cityOne.UniqueCoinsTypeCount());

            cityOne.AddCoin(new Coin(countryTwoName));
            Assert.AreEqual(2, cityOne.UniqueCoinsTypeCount());

            cityOne.AddCoin(new Coin(countryThreeName));
            Assert.AreEqual(3, cityOne.UniqueCoinsTypeCount());

            cityOne.AddCoin(new Coin(countryThreeName));
            cityOne.AddCoin(new Coin(countryThreeName));
            Assert.AreEqual(3, cityOne.UniqueCoinsTypeCount());
        }
    }
}