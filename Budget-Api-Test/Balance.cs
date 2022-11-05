using Budget_Api.Services;

namespace Budget_Api_Test
{
    public class BalanceTests
    {

        private readonly IBalanceService _balanceService = new BalanceService();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetBalance_test()
        {
            _balanceService.GetBalance();
            
            Assert.Pass();
        }
    }
}