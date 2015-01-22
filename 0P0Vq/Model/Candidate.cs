namespace _0P0Vq
{
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