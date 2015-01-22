using System.Collections.Generic;

namespace _0P0Vq
{
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
}