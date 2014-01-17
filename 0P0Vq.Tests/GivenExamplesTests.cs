using System.Linq;
using SimpleInjector;
using Xunit;

namespace _0P0Vq.Tests
{
    public class GivenExamplesTests
    {

        [Fact]
        public void Example1()
        {
            var n = 3;
            var connections = new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 } };
            var k = 2;
            var startIndexes = new[] { 0, 1 };

            var container = new Container();

            var calulator = container.GetInstance<ExpenseCalculator>() as IExpenseCalculator;

            var expenses = calulator.CalculateExpenses(n, connections, k, startIndexes).ToArray();

            Assert.NotEmpty(expenses);
            Assert.Equal(expenses[0], 1);
            Assert.Equal(expenses[1], 2);
        }
    }
}
