using System;
using System.Collections.Generic;

namespace NPuzzleAI
{
    public class DFS
    {
        public Node StartNode { get; set; }
        public Node GoalNode { get; set; }
        public Node CurrentNode { get; private set; }
        private readonly Stack<Node> fringe; // Thay Queue bằng Stack
        private List<Node> child; // Thay Vector bằng List
        public List<int[]> Result { get; private set; } // Thay Vector bằng List
        public int approvedNodes;
        public int totalNodes;
        public long time;
        public static bool stop = false;
        public string error;

        public DFS()
        {
            fringe = new Stack<Node>();
            child = new List<Node>();
            Result = new List<int[]>();
        }

        public void Solve()
        {
            Result.Clear();
            long startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            fringe.Push(StartNode); // Sử dụng Push cho Stack
            try
            {
                while (fringe.Count > 0)
                {
                    CurrentNode = fringe.Pop(); // Sử dụng Pop cho Stack
                    if (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTime > 60000)
                    {
                        error = "Thuật toán quá tốn thời gian!";
                        fringe.Clear();
                        return;
                    }
                    if (stop)
                    {
                        fringe.Clear();
                        return;
                    }
                    if (CurrentNode.Equals(GoalNode))
                    {
                        AddResult(CurrentNode);
                        time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTime;
                        totalNodes = approvedNodes + fringe.Count;
                        fringe.Clear();
                        return;
                    }
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
                        }
                    }
                    foreach (Node c in child)
                    {
                        c.Parent = CurrentNode;
                        fringe.Push(c); // Sử dụng Push để thêm vào Stack
                    }
                    child.Clear();
                    approvedNodes++;
                }
            }
            catch (OutOfMemoryException)
            {
                fringe.Clear();
                error = "Tràn bộ nhớ!";
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
