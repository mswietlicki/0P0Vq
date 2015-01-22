using System.Collections.Generic;
using System.Linq;

namespace _0P0Vq
{
    public interface IExpenseCalculator
    {
        IEnumerable<int> CalculateExpenses(IEnumerable<Node> nodes, IEnumerable<Candidate> candidates);
    }

    public class ExpenseCalculator : IExpenseCalculator
    {

        public IEnumerable<int> CalculateExpenses(IEnumerable<Node> nodes, IEnumerable<Candidate> candidates)
        {
            return CalculateExpenses(nodes.ToList(), candidates.ToList());
        }
        public IEnumerable<int> CalculateExpenses(List<Node> nodes, List<Candidate> candidates)
        {
            bool somethingChanged = true;
            while (somethingChanged)
            {
                somethingChanged = false;
                foreach (var candidate in candidates)
                {
                    foreach (var node in nodes.Where(n => n.HQ == candidate).SelectMany(n => n.Connections))
                    {
                        if (node.HQ == null)
                            node.Committes.Add(candidate);
                    }
                }

                foreach (var node in nodes.Where(n => n.Committes.Any()))
                {
                    var winner =
                        node.Connections.Where(n => n.HQ != null).GroupBy(n => n.HQ)
                            .Select(g => new { Cantidate = g.Key, Count = g.Count() })
                            .OrderByDescending(g => g.Count)
                            .First()
                            .Cantidate;
                    if (node.HQ != winner)
                        somethingChanged = true;

                    node.HQ = winner;
                    node.Committes.Remove(winner);
                }
            }
            return candidates.Select(c => nodes.Count(n => n.HQ == c));
        }
    }

    public class Node
    {
        public Node()
        {
            Connections = new List<Node>();
            Committes = new List<Candidate>();
        }
        public int Id { get; set; }
        public List<Node> Connections { get; set; }
        public List<Candidate> Committes { get; set; }

        public Candidate HQ { get; set; }

        public void AddConnection(Node node)
        {
            this.Connections.Add(node);
            node.Connections.Add(this);
        }

        public override string ToString()
        {
            return "Node: " + Id;
        }
    }

    public class Candidate
    {
        public int Id { get; set; }

        private Node _startNode;

        public Node StartNode
        {
            get { return _startNode; }
            set
            {
                _startNode = value;
                _startNode.HQ = this;
            }
        }

        public override string ToString()
        {
            return "Candidate: " + Id;
        }
    }
}
