package com.example.solvePath;
import javafx.animation.ScaleTransition;
import javafx.application.Platform;
import javafx.fxml.FXML;
import javafx.geometry.Point2D;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.image.WritableImage;
import javafx.scene.text.Font;
import javafx.embed.swing.SwingFXUtils;
import javafx.scene.SnapshotParameters;
import javafx.scene.input.MouseEvent;
import javafx.scene.paint.Color;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.stage.FileChooser;
import javafx.stage.Stage;
import javafx.util.Duration;

import javax.imageio.ImageIO;
import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.*;
import java.util.stream.Collectors;

public class N_DothiController {
    @FXML
    private Label lblResultDFS;
    @FXML
    private Label lblStepsDFS;
    @FXML
    private Label lblTimeDFS;
    @FXML
    private Label lblFindDFS;
    @FXML
    private Label lblResultBFS;
    @FXML
    private Label lblStepsBFS;
    @FXML
    private Label lblTimeBFS;
    @FXML
    private Label lblFindBFS;
    @FXML
    private Canvas drawingPanel;

    @FXML
    private Button btnSaveImage;
    @FXML
    private Button btnExit;
    @FXML
    private Button btnReset;
    @FXML
    private Button btnTraverse;
    @FXML
    private Button btnAddEdge;

    @FXML
    private TextField txtStartVertex;
    @FXML
    private TextField txtEndVertex;

    @FXML
    private ImageView imgView;

    private Graph graph;
    private List<Tuple<Integer, Integer>> edges;
    private List<Point2D> vertices;
    final private double radius = 10;
    private int vertexCount = 0;

    @FXML
    public void initialize() {
        URL imageUrl = getClass().getResource("img/dothhi.png");
        if (imageUrl == null) {
            System.out.println("Image not found!");
        } else {
            imgView.setImage(new Image(imageUrl.toExternalForm()));
        }
        drawingPanel.setOnMouseClicked(this::handleMouseClicked);

        txtStartVertex.focusedProperty().addListener((observable, oldValue, newValue) -> {
            if (newValue) {
                if (txtStartVertex.getText().equals("Đỉnh bắt đầu")) {
                    txtStartVertex.setText("");
                    txtStartVertex.setStyle("-fx-text-fill: black;");
                }
            } else {
                if (txtStartVertex.getText().isEmpty()) {
                    txtStartVertex.setText("Đỉnh bắt đầu");
                    txtStartVertex.setStyle("-fx-text-fill: gray;");
                }
            }
        });

        txtEndVertex.focusedProperty().addListener((observable, oldValue, newValue) -> {
            if (newValue) {
                if ("Đỉnh kết thúc".equals(txtEndVertex.getText())) {
                    txtEndVertex.setText("");
                    txtEndVertex.setStyle("-fx-text-fill: black;");
                }
            } else {
                if (txtEndVertex.getText().isEmpty()) {
                    txtEndVertex.setText("Đỉnh kết thúc");
                    txtEndVertex.setStyle("-fx-text-fill: gray;");
                }
            }
        });

        graph = new Graph();
        edges = new ArrayList<>();
        vertices = new ArrayList<>();
        applyButtonAnimation(btnExit);
        applyButtonAnimation(btnSaveImage);
        applyButtonAnimation(btnReset);
        applyButtonAnimation(btnTraverse);
        applyButtonAnimation(btnAddEdge);
    }

    private void applyButtonAnimation(Button button) {
        button.setOnMouseEntered(e -> {
            ScaleTransition scaleTransition = new ScaleTransition(Duration.millis(200), button);
            scaleTransition.setFromX(1.0);
            scaleTransition.setFromY(1.0);
            scaleTransition.setToX(1.1);
            scaleTransition.setToY(1.1);
            scaleTransition.play();
        });
        button.setOnMouseExited(e -> {
            ScaleTransition scaleTransition = new ScaleTransition(Duration.millis(200), button);
            scaleTransition.setFromX(1.1);
            scaleTransition.setFromY(1.1);
            scaleTransition.setToX(1.0);
            scaleTransition.setToY(1.0);
            scaleTransition.play();
        });
    }

    public void onbtnTraverseClick() {
        if (vertexCount > 0) {
            try {
                int start = Integer.parseInt(txtStartVertex.getText()) - 1;
                int end = Integer.parseInt(txtEndVertex.getText()) - 1;
                if (start < 0 || start >= vertexCount || end < 0 || end >= vertexCount) {
                    showAlert("Đỉnh bắt đầu hoặc đỉnh kết thúc không hợp lệ!", "Lỗi", Alert.AlertType.ERROR);
                    return;
                }
                long startTime = System.nanoTime();
                List<Integer> dfsResult = graph.dfs(0);
                long elapsedTime = System.nanoTime() - startTime;

                lblResultDFS.setText("Kết quả DFS: " + dfsResult.stream()
                        .map(v -> String.valueOf(v + 1))
                        .collect(Collectors.joining(", ")));
                lblStepsDFS.setText("Số bước DFS: " + dfsResult.size());
                lblTimeDFS.setText("Thời gian DFS: " + (elapsedTime / 1_000_000) + " ms");
                List<Integer> dfsPath = new ArrayList<>();
                if (dfsShortestPath(start, end, dfsPath)) {
                    lblFindDFS.setText("Đường đi ngắn nhất DFS: " + dfsPath.stream()
                            .map(v -> String.valueOf(v + 1))
                            .collect(Collectors.joining(" -> ")));
                } else {
                    lblFindDFS.setText("Không tìm thấy đường đi DFS.");
                }
                startTime = System.nanoTime();
                List<Integer> bfsResult = graph.bfs(0);
                elapsedTime = System.nanoTime() - startTime;

                lblResultBFS.setText("Kết quả BFS: " + bfsResult.stream()
                        .map(v -> String.valueOf(v + 1))
                        .collect(Collectors.joining(", ")));
                lblStepsBFS.setText("Số bước BFS: " + bfsResult.size());
                lblTimeBFS.setText("Thời gian BFS: " + (elapsedTime / 1_000_000) + " ms");
                List<Integer> bfsPath = bfsShortestPath(start, end);
                if (bfsPath.isEmpty()) {
                    lblFindBFS.setText("Không tìm thấy đường đi BFS.");
                } else {
                    lblFindBFS.setText("Đường đi ngắn nhất BFS: " + bfsPath.stream()
                            .map(v -> String.valueOf(v + 1))
                            .collect(Collectors.joining(" -> ")));
                }
            } catch (NumberFormatException e) {
                showAlert("Vui lòng nhập các số hợp lệ cho đỉnh!", "Lỗi", Alert.AlertType.ERROR);
            }
        } else {
            showAlert("Chưa có đỉnh nào trong đồ thị!", "Lỗi", Alert.AlertType.ERROR);
        }
    }


    public List<Integer> bfsShortestPath(int start, int end) {
        boolean[] visited = new boolean[vertexCount];
        int[] parent = new int[vertexCount];
        Queue<Integer> queue = new LinkedList<>();

        visited[start] = true;
        queue.offer(start);
        parent[start] = -1;

        while (!queue.isEmpty()) {
            int current = queue.poll();
            if (current == end) {
                return constructPath(parent, start, end);
            }

            for (Integer neighbor : graph.getNeighbors(current)) {
                if (!visited[neighbor]) {
                    visited[neighbor] = true;
                    queue.offer(neighbor);
                    parent[neighbor] = current;
                }
            }
        }
        return Collections.emptyList();
    }

    // Xây dựng đường đi từ cha
    private List<Integer> constructPath(int[] parent, int start, int end) {
        List<Integer> path = new ArrayList<>();
        for (int v = end; v != -1; v = parent[v]) {
            path.add(v);
        }
        Collections.reverse(path);
        if(path.isEmpty() || path.get(0) != start) {
            System.out.println("Đường đi không bắt đầu từ đỉnh: " + (start + 1));
            return Collections.emptyList();
        }
        return path;
    }

    public boolean dfsShortestPath(int start, int end, List<Integer> path) {
        boolean[] visited = new boolean[vertexCount];
        return dfsHelper(start, end, visited, path);
    }

    private boolean dfsHelper(int current, int end, boolean[] visited, List<Integer> path) {
        visited[current] = true;
        path.add(current);

        if (current == end) {
            return true;
        }

        for (Integer neighbor : graph.getNeighbors(current)) {
            if (!visited[neighbor]) {
                if (dfsHelper(neighbor, end, visited, path)) {
                    return true;
                }
            }
        }

        path.remove(path.size() - 1);
        return false;
    }

    public void onbtnResetClick() {
        graph = new Graph();
        edges.clear();
        vertices.clear();
        vertexCount = 0;
        GraphicsContext g = drawingPanel.getGraphicsContext2D();
        g.clearRect(0, 0, drawingPanel.getWidth(), drawingPanel.getHeight());
        lblFindDFS.setText("Đường đi ngắn nhất DFS: ");
        lblFindBFS.setText("Đường đi ngắn nhất BFS: ");
        lblResultDFS.setText("Kết quả DFS: ");
        lblResultBFS.setText("Kết quả BFS: ");
        lblStepsDFS.setText("Số bước DFS: ");
        lblStepsBFS.setText("Số bước BFS: ");
        lblTimeDFS.setText("Thời gian DFS: ");
        lblTimeBFS.setText("Thời gian BFS: ");
    }

    public void onbtnExitClick() {
        Platform.exit();
    }

    public void onbtnSaveImageClick() {
        if (vertexCount > 0) {
            FileChooser fileChooser = new FileChooser();
            fileChooser.getExtensionFilters().addAll(
                    new FileChooser.ExtensionFilter("PNG Image", "*.png"),
                    new FileChooser.ExtensionFilter("JPEG Image", "*.jpeg"),
                    new FileChooser.ExtensionFilter("Bitmap Image", "*.bmp")
            );
            fileChooser.setTitle("Lưu ảnh");
            File file = fileChooser.showSaveDialog(new Stage());
            if (file != null) {
                try {
                    WritableImage writableImage = new WritableImage((int) drawingPanel.getWidth(), (int) drawingPanel.getHeight());
                    drawingPanel.snapshot(new SnapshotParameters(), writableImage);
                    ImageIO.write(SwingFXUtils.fromFXImage(writableImage, null), getFileExtension(file), file);
                    showAlert("Ảnh đã được lưu thành công!", "Thông báo", Alert.AlertType.INFORMATION);
                } catch (IOException ex) {
                    showAlert("Lỗi khi lưu ảnh: " + ex.getMessage(), "Lỗi", Alert.AlertType.ERROR);
                }
            }
        } else {
            showAlert("Không có đỉnh nào để lưu hình ảnh!", "Lỗi", Alert.AlertType.ERROR);
        }
    }

    private String getFileExtension(File file) {
        String fileName = file.getName();
        if (fileName.lastIndexOf(".") != -1 && fileName.lastIndexOf(".") != 0) {
            return fileName.substring(fileName.lastIndexOf(".") + 1);
        } else {
            return "";
        }
    }

    public static class Tuple<X, Y> {
        private final X x; // Giá trị thứ nhất
        private final Y y; // Giá trị thứ hai

        public Tuple(X x, Y y) {
            this.x = x;
            this.y = y;
        }

        public X getItem1() {
            return x;
        }

        public Y getItem2() {
            return y;
        }
    }

    private void handleMouseClicked(MouseEvent event) {
        if (event.getX() - radius >= 10 && event.getX() + radius <= drawingPanel.getWidth() - 10 &&
                event.getY() - radius >= 10 && event.getY() + radius <= drawingPanel.getHeight() - 10) {
            vertices.add(new Point2D(event.getX(), event.getY()));
            graph.addVertex(vertexCount);
            System.out.println("Vertex added at: " + event.getX() + ", " + event.getY());
            vertexCount++;
            updateDrawingPanel();
        } else {
            showAlert("Đỉnh không được vẽ ngoài phạm vi của khu vực vẽ!", "Lỗi", Alert.AlertType.ERROR);
        }
    }

    private void updateDrawingPanel() {
        GraphicsContext g = drawingPanel.getGraphicsContext2D();
        g.clearRect(0, 0, drawingPanel.getWidth(), drawingPanel.getHeight());
        for (int i = 0; i < vertices.size(); i++) {
            Point2D point = vertices.get(i);
            g.setFill(Color.BLUE);
            g.fillOval(point.getX() - radius, point.getY() - radius, radius * 2, radius * 2);
            g.setFill(Color.WHITE);
            g.setFont(Font.font(14));
            String vertexLabel = String.valueOf(i + 1);
            double textWidth = g.getFont().getSize() * vertexLabel.length() / 2;
            double textHeight = g.getFont().getSize();
            g.fillText(vertexLabel, point.getX() - textWidth / 2, point.getY() + textHeight / 4);
        }
        for (Tuple<Integer, Integer> edge : edges) {
            Point2D start = vertices.get(edge.getItem1());
            Point2D end = vertices.get(edge.getItem2());
            g.setStroke(Color.BLACK);
            g.strokeLine(start.getX(), start.getY(), end.getX(), end.getY());
        }
    }


    private void showAlert(String content, String title, Alert.AlertType alertType) {
        Alert alert = new Alert(alertType);
        alert.setTitle(title);
        alert.setContentText(content);
        alert.showAndWait();
    }

    @FXML
    public void onaddEdgeBtnClick() {
        String startVertexStr = txtStartVertex.getText();
        String endVertexStr = txtEndVertex.getText();
        int startVertex;
        int endVertex;

        try {
            startVertex = Integer.parseInt(startVertexStr) - 1;
            endVertex = Integer.parseInt(endVertexStr) - 1;
            if (startVertex < 0 || startVertex >= vertexCount || endVertex < 0 || endVertex >= vertexCount) {
                throw new NumberFormatException();
            }
            graph.addEdge(startVertex, endVertex);
            edges.add(new Tuple<>(startVertex, endVertex));
            updateDrawingPanel();
            txtStartVertex.clear();
            txtEndVertex.clear();
        } catch (NumberFormatException e) {
            showAlert("Vui lòng nhập các chỉ số đỉnh hợp lệ!", "Lỗi", Alert.AlertType.ERROR);
        }
    }




}