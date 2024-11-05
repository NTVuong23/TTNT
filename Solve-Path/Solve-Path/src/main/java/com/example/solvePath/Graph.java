package com.example.solvePath;

import java.util.*;

public class Graph {
    private List<List<Integer>> adjacencyList;

    public Graph() {
        adjacencyList = new ArrayList<>();
    }

    public void addVertex(int id) {
        adjacencyList.add(new ArrayList<>());
    }

    public void addEdge(int start, int end) {
        adjacencyList.get(start).add(end);
        adjacencyList.get(end).add(start); // Đồ thị vô hướng
    }

    public List<Integer> dfs(int start) {
        boolean[] visited = new boolean[adjacencyList.size()];
        List<Integer> result = new ArrayList<>();
        dfsUtil(start, visited, result);
        return result;
    }

    private void dfsUtil(int vertex, boolean[] visited, List<Integer> result) {
        visited[vertex] = true;
        result.add(vertex);

        for (int neighbor : adjacencyList.get(vertex)) {
            if (!visited[neighbor]) {
                dfsUtil(neighbor, visited, result);
            }
        }
    }

    public List<Integer> bfs(int start) {
        boolean[] visited = new boolean[adjacencyList.size()];
        List<Integer> result = new ArrayList<>();
        Queue<Integer> queue = new LinkedList<>();

        visited[start] = true;
        queue.offer(start);

        while (!queue.isEmpty()) {
            int vertex = queue.poll();
            result.add(vertex);

            for (int neighbor : adjacencyList.get(vertex)) {
                if (!visited[neighbor]) {
                    visited[neighbor] = true;
                    queue.offer(neighbor);
                }
            }
        }
        return result;
    }

    public List<Integer> getNeighbors(int vertex) {
        return adjacencyList.get(vertex);
    }


}

