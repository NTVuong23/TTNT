using System.Collections.Generic;

namespace NPuzzleAI
{
    public class Node
    {
        public State State { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public int Cost { get; set; }
        public Node Parent { get; set; }

        // Phương thức khởi tạo
        public Node(State state, int cost)
        {
           this.State = state;
            this.Cost = cost;
        }



        // Kiểm tra value có giống value của n không
        public bool Equals(Node n)
        {
            bool flag = true;
            int[] val = State.Value;
            int[] newVal = n.State.Value;
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] != newVal[i])
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        // Tính ước lượng h(x)
        public int Estimate(State goalState)
        {
            return State.Estimate(goalState);
        }

        // Vector các Node con
        public List<Node> Successors()
        {
            List<Node> nodes = new List<Node>();
            List<State> states = State.Successors();
            foreach (State value in states)
            {
                nodes.Add(new Node(value, 1));
            }
            return nodes;
        }
    }
}
