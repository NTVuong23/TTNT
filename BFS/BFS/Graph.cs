using System.Collections.Generic;

public class Graph
{
    private List<List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new List<List<int>>();
    }

    public void AddVertex(int vertex)
    {
        // Đảm bảo chỉ thêm một danh sách rỗng mới khi đỉnh chưa tồn tại
        while (adjacencyList.Count <= vertex)
        {
            adjacencyList.Add(new List<int>());
        }
    }


    public void AddEdge(int startVertex, int endVertex)
    {
        if (startVertex < adjacencyList.Count && endVertex < adjacencyList.Count)
        {
            adjacencyList[startVertex].Add(endVertex);
            adjacencyList[endVertex].Add(startVertex); // Nếu đồ thị vô hướng
        }
    }

    public List<int> GetVertices()
    {
        List<int> vertices = new List<int>();
        for (int i = 0; i < adjacencyList.Count; i++)
        {
            vertices.Add(i);
        }
        return vertices;
    }


    public List<int> DFS(int startVertex)
    {
        bool[] visited = new bool[adjacencyList.Count];
        List<int> result = new List<int>();
        DFSUtil(startVertex, visited, result);
        return result;
    }

    private void DFSUtil(int vertex, bool[] visited, List<int> result)
    {
        visited[vertex] = true;
        result.Add(vertex);
        foreach (var neighbor in adjacencyList[vertex])
        {
            if (!visited[neighbor])
            {
                DFSUtil(neighbor, visited, result);
            }
        }
    }

    public List<int> BFS(int startVertex)
    {
        bool[] visited = new bool[adjacencyList.Count];
        List<int> result = new List<int>();
        Queue<int> queue = new Queue<int>();
        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            result.Add(vertex);

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }
}
