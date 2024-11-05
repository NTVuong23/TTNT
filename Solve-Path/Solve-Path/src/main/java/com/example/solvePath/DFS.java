package com.example.solvePath;

import java.util.Stack;
import java.util.Vector;

public class DFS {
    public Node startNode;
    public Node goalNode;
    public Node currentNode;
    private final Stack<Node> FRINGE;
    private Vector<Node> CHILD;
    public Vector<int[]> RESULT;
    protected int approvedNodes;
    protected int totalNodes;
    protected long time;
    protected static boolean stop = false;
    protected String error;

    public DFS() {
        FRINGE = new Stack<>();
        CHILD = new Vector<>();
        RESULT = new Vector<>();
    }

    public void solve(int maxDepth) {
        RESULT.clear();
        long startTime = System.currentTimeMillis();
        FRINGE.push(startNode);
        try {
            while (!FRINGE.isEmpty()) {
                currentNode = FRINGE.pop();

                // Kiểm tra thời gian
                if (System.currentTimeMillis() - startTime > 60000) {
                    error = "Thuật toán quá tốn thời gian!";
                    FRINGE.clear();
                    return;
                }

                // Kiểm tra trạng thái dừng
                if (stop) {
                    FRINGE.clear();
                    return;
                }

                // Kiểm tra nếu đã đạt đến node mục tiêu
                if (currentNode.equals(goalNode)) {
                    addResult(currentNode);
                    time = System.currentTimeMillis() - startTime;
                    totalNodes = approvedNodes + FRINGE.size();
                    FRINGE.clear();
                    return;
                }

                // Lấy các node con
                CHILD = currentNode.successors();

                // Lọc node cha khỏi danh sách node con
                CHILD.removeIf(child -> child.equals(currentNode.parent));

                // Thêm các node con vào FRINGE
                for (Node child : CHILD) {
                    child.parent = currentNode;
                    // Kiểm tra độ sâu trước khi thêm
                    if (child.cost <= maxDepth) {
                        FRINGE.push(child);
                    }
                }

                CHILD.clear();
                approvedNodes++;
            }
        } catch (OutOfMemoryError e) {
            FRINGE.clear();
            error = "Tràn bộ nhớ!";
            e.printStackTrace();
        }
    }

    // Truy vết kết quả
    public void addResult(Node n) {
        if (n.parent != null) {
            addResult(n.parent);
        }
        RESULT.add(n.state.value);
    }
}
