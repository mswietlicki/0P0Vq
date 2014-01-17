using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0P0Vq
{
    public interface IExpenseCalculator
    {
        IEnumerable<int> CalculateExpenses();
        IEnumerable<int> CalculateExpenses(int n, int[][] connections, int k, int[] startIndexes);
    }

    public class ExpenseCalculator : IExpenseCalculator
    {
        public ExpenseCalculator()
        {

        }

        public IEnumerable<int> CalculateExpenses()
        {
            return null;
        }

        public IEnumerable<int> CalculateExpenses(int n, int[][] connections, int k, int[] startIndexes)
        {
            return null;
        }
    }

}
