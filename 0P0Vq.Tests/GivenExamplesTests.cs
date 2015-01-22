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
            var nodes = new[]
            {
                new Node {Id = 0},
                new Node {Id = 1},
                new Node {Id = 2},
            };

            nodes[0].AddConnection(nodes[1]);
            nodes[1].AddConnection(nodes[2]);
            nodes[0].AddConnection(nodes[2]);

            var candidates = new[]
            {
                new Candidate { Id = 0, StartNode = nodes[0]},
                new Candidate { Id = 1, StartNode = nodes[1]}
            };

            var container = new Container();

            var calulator = container.GetInstance<ExpenseCalculator>() as IExpenseCalculator;

            var expenses = calulator.CalculateExpenses(nodes, candidates).ToArray();

            Assert.NotEmpty(expenses);
            Assert.Equal(expenses[0], 1);
            Assert.Equal(expenses[1], 2);
        }

        [Fact]
        public void Example2()
        {
            var nodes = new[]
            {
                new Node {Id = 0},
                new Node {Id = 1},
                new Node {Id = 2},
                new Node {Id = 3},
                new Node {Id = 4},
                new Node {Id = 5},
            };

            nodes[1].AddConnection(nodes[0]);
            nodes[2].AddConnection(nodes[1]);
            nodes[3].AddConnection(nodes[0]);
            nodes[3].AddConnection(nodes[1]);
            nodes[3].AddConnection(nodes[2]);
            nodes[4].AddConnection(nodes[2]);
            nodes[4].AddConnection(nodes[3]);
            nodes[5].AddConnection(nodes[0]);
            nodes[5].AddConnection(nodes[2]);

            var candidates = new[]
            {
                new Candidate { Id = 0, StartNode = nodes[0]},
                new Candidate { Id = 1, StartNode = nodes[1]},
                new Candidate { Id = 2, StartNode = nodes[5]},
            };

            var container = new Container();

            var calulator = container.GetInstance<ExpenseCalculator>() as IExpenseCalculator;

            var expenses = calulator.CalculateExpenses(nodes, candidates).ToArray();

            Assert.NotEmpty(expenses);
            Assert.Equal(1, expenses[0]);
            Assert.Equal(2, expenses[1]);
            Assert.Equal(3, expenses[2]);
        }




    }
}
