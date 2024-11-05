using System.Collections.Generic;

namespace NPuzzleAI
{
    public class AStar
    {
        public Node StartNode { get; set; }
        public Node GoalNode { get; set; }
        public Node CurrentNode { get; private set; }
        private readonly List<Node> fringe; // Thay Vector bằng List
        private List<Node> child; // Thay Vector bằng List
        public List<Node> Closed { get; private set; } // Thay Vector bằng List
        public List<int[]> Result { get; private set; } // Thay Vector bằng List
        public int approvedNodes;
        public int totalNodes;
        public long time;
        public static bool stop = false;
        public string error;

        public AStar()
        {
            fringe = new List<Node>();
            child = new List<Node>();
            Closed = new List<Node>();
            Result = new List<int[]>();
        }

        public void Solve()
        {
            Result.Clear();
            long startTime = System.Diagnostics.Stopwatch.GetTimestamp();
            StartNode.F = StartNode.H = StartNode.Estimate(GoalNode.State);
            StartNode.G = 0;
            totalNodes = approvedNodes = 0;
            fringe.Add(StartNode);
            while (fringe.Count > 0)
            {
                // Điều kiện dừng thuật toán
                if ((System.Diagnostics.Stopwatch.GetTimestamp() - startTime) / System.Diagnostics.Stopwatch.Frequency * 1000 > 60000)
                {
                    error = "Thuật toán quá tốn thời gian!";
                    approvedNodes = int.MaxValue;
                    fringe.Clear();
                    child.Clear();
                    Closed.Clear();
                    return;
                }
                if (stop)
                {
                    fringe.Clear();
                    child.Clear();
                    Closed.Clear();
                    return;
                }
                // Tìm node có hàm đánh giá - f(n) nhỏ nhất trong fringe
                int fMin = fringe[0].F;
                CurrentNode = fringe[0];
                foreach (Node node in fringe)
                {
                    if (node.F < fMin)
                    {
                        fMin = node.F;
                        CurrentNode = node;
                    }
                }
                fringe.Remove(CurrentNode);
                Closed.Add(CurrentNode);
                // Kiểm tra node hiện tại có phải đích hay không
                if (CurrentNode.H == 0)
                {
                    totalNodes = approvedNodes + fringe.Count;
                    time = (System.Diagnostics.Stopwatch.GetTimestamp() - startTime) / System.Diagnostics.Stopwatch.Frequency * 1000;
                    AddResult(CurrentNode); // Thêm kết quả vào Result
                    fringe.Clear();
                    child.Clear();
                    Closed.Clear();
                    return;
                }
                // Thiết lập các node con
                child = CurrentNode.Successors();
                if (CurrentNode.Parent != null)
                {
                    for (int i = 0; i < child.Count; i++)
                    {
                        Node c = child[i];
                        if (c.Equals(CurrentNode.Parent))
                        {
                            child.RemoveAt(i);
                            break;
                        }
                        // Kiểm tra trạng thái đã được duyệt chưa
                        foreach (Node node in Closed)
                        {
                            if (node.Equals(c))
                            {
                                child.Remove(c);
                                break;
                            }
                        }
                    }
                }
                // Đưa các node con vào fringe
                foreach (Node c in child)
                {
                    c.Parent = CurrentNode;
                    c.G = CurrentNode.G + c.Cost;
                    c.H = c.Estimate(GoalNode.State);
                    c.F = c.G + c.H;
                    // Nếu trạng thái đã tồn tại trong fringe và hàm đánh giá tốt hơn => Thay thế
                    foreach (Node node in fringe)
                    {
                        if (node.Equals(c) && c.F < node.F)
                        {
                            fringe.Remove(node);
                            break;
                        }
                    }
                    fringe.Insert(0, c);
                }
                child.Clear();
                approvedNodes++;
            }
        }

        // Truy vết kết quả
        public void AddResult(Node n)
        {
            if (n.Parent != null)
            {
                AddResult(n.Parent);
            }
            Result.Add(n.State.Value);
        }
    }
}
