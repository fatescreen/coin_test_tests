using NUnit.Framework;
using coin_test.EuroDiffusion;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;

namespace coint_test_tests
{
    public class CaseRunnerTest
    {
        private static Mock<ILogger<CaseRunner>> loggerMock = new Mock<ILogger<CaseRunner>>();
        private static ILogger<CaseRunner> logger = loggerMock.Object;

        CaseRunner caseRunner = new CaseRunner(logger);

        [SetUp]
        public void Setup()
        {
            caseRunner = new CaseRunner(logger);
        }

        [Test]
        public void SolveCaseTest1()
        {
            caseRunner.CountriesWithCoordinates.Add("Russia", new List<int>() {1, 1, 1, 1});
            caseRunner.CountriesWithCoordinates.Add("Ukraine", new List<int>() {1, 2, 1, 2});

            Assert.AreEqual(1, caseRunner.SolveCase(caseRunner.CountriesWithCoordinates));
        }
        [Test]
        public void SolveCaseTest2()
        {
            caseRunner.CountriesWithCoordinates.Add("Russia", new List<int>() { 1, 1, 5, 1 });
            caseRunner.CountriesWithCoordinates.Add("Ukraine", new List<int>() { 1, 2, 5, 2 });

            Assert.AreEqual(1, caseRunner.SolveCase(caseRunner.CountriesWithCoordinates));
        }
        [Test]
        public void SolveCaseTest3()
        {
            caseRunner.CountriesWithCoordinates.Add("Russia", new List<int>() { 1, 1, 5, 1 });
            caseRunner.CountriesWithCoordinates.Add("Ukraine", new List<int>() { 1, 2, 5, 3 });

            Assert.GreaterOrEqual(caseRunner.SolveCase(caseRunner.CountriesWithCoordinates), 2);
        }
        [Test]
        public void SolveCaseTest4()
        {
            caseRunner.CountriesWithCoordinates.Add("Russia", new List<int>() { 1, 1, 5, 1 });
            caseRunner.CountriesWithCoordinates.Add("Ukraine", new List<int>() { 1, 2, 5, 4 });

            Assert.GreaterOrEqual(caseRunner.SolveCase(caseRunner.CountriesWithCoordinates), 3);
        }

    }
}