package com.example.solvePath;

import java.util.Arrays;
import java.util.Vector;

public class Node {
    public State state;
    public int f; // Tổng chi phí
    public int g; // Chi phí từ node gốc đến node này
    public int h; // Chi phí ước lượng từ node này đến node mục tiêu
    public int cost; // Chi phí đi vào node này
    public Node parent; // Node cha

    // Phương thức khởi tạo
    public Node(State state, int cost) {
        this.state = state;
        this.cost = cost;
    }

    // Kiểm tra value có giống value của n không
    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (obj == null || getClass() != obj.getClass()) return false;
        Node n = (Node) obj;
        return Arrays.equals(state.value, n.state.value);
    }

    @Override
    public int hashCode() {
        return Arrays.hashCode(state.value);
    }

    // Tính ước lượng h(x)
    public int estimate(State goalState) {
        return state.estimate(goalState);
    }

    // Vector các Node con
    public Vector<Node> successors() {
        Vector<Node> nodes = new Vector<>();
        Vector<State> states = state.successors();
        for (State value : states) {
            nodes.add(new Node(value, cost + 1)); // Tăng chi phí cho mỗi bước
        }
        return nodes;
    }

    // Tính toán giá trị f
    public void calculateF() {
        f = g + h;
    }
}
