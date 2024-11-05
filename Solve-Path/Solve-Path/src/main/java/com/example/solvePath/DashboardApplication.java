package com.example.solvePath;


import javafx.animation.*;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.*;
import javafx.scene.paint.Color;
import javafx.scene.paint.LinearGradient;
import javafx.scene.paint.Stop;
import javafx.scene.shape.CubicCurveTo;
import javafx.scene.shape.MoveTo;
import javafx.scene.shape.Path;
import javafx.stage.Stage;
import javafx.application.Platform;
import javafx.util.Duration;

import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.logging.Level;
import java.util.logging.Logger;

public class DashboardApplication extends Application {

    private Stage primaryStage;
    private ImageView imageViewN_PuzzleAI;
    private ImageView imageViewGraph;
    private List<Image> nPuzzleImages;
    private List<Image> graphImages;
    private int currentImageIndexN_PuzzleAI = 0;
    private int currentImageIndexGraph = 0;

    private Timeline slideshowTimeline;
    private static final Logger logger = Logger.getLogger(DashboardApplication.class.getName());

    @Override
    public void start(Stage stage) throws IOException {
        this.primaryStage = stage;
        loadStartScene();
    }

    private void loadStartScene() throws IOException {
        Pane root = new Pane();
        root.setBackground(new Background(new BackgroundFill(
                new LinearGradient(0, 0, 1, 1, true, javafx.scene.paint.CycleMethod.NO_CYCLE,
                        new Stop(0, Color.web("#123")),
                        new Stop(1, Color.web("#345"))),
                CornerRadii.EMPTY, null)));
        startSakuraEffect(root);
//        Tạo chấm tròm di chuyển
//        for (int i = 0; i < 100; i++) {
//            Circle dot = new Circle(7, Color.hsb(200, 1.0, 0.5, 0.9));
//            dot.setOpacity(0.9);
//            dot.setLayoutX(Math.random() * 800);
//            dot.setLayoutY(Math.random() * 600);
//            TranslateTransition transition = new TranslateTransition(Duration.seconds(4), dot);
//            transition.setByX(20);
//            transition.setByY(20);
//            transition.setAutoReverse(true);
//            transition.setCycleCount(TranslateTransition.INDEFINITE);
//            transition.play();
//            root.getChildren().add(dot);
//        }

        StackPane homeLayout = createHomeLayout();
        StackPane layeredPane = new StackPane(root, homeLayout);
        Scene homeScene = new Scene(layeredPane, 840, 640);
        primaryStage.setScene(homeScene);
        primaryStage.setTitle("Home");
        primaryStage.getIcons().add(new Image(Objects.requireNonNull(DashboardApplication.class.getResourceAsStream("img/TTNT.jpg"))));

        primaryStage.setOnCloseRequest(event -> {
            Platform.exit();
            System.exit(0);
        });

        primaryStage.show();
        startImageSlideshow();
    }

    private void startSakuraEffect(Pane root) {
        for (int i = 0; i < 100; i++) {
            Path petal = new Path();
            petal.getElements().add(new MoveTo(0, 0));
            petal.getElements().add(new CubicCurveTo(10, -10, 20, -10, 15, 0));
            petal.getElements().add(new CubicCurveTo(20, 10, 10, 10, 0, 0));

            petal.setFill(Color.rgb(255, 182, 193, 0.8));
            petal.setOpacity(0.7);
            petal.setLayoutX(Math.random() * 840);
            petal.setLayoutY(Math.random() * -640);
            root.getChildren().add(petal);


            TranslateTransition fallTransition = new TranslateTransition(Duration.seconds(5 + Math.random() * 5), petal);
            fallTransition.setFromY(-100);
            fallTransition.setToY(740);
            fallTransition.setCycleCount(TranslateTransition.INDEFINITE);
            fallTransition.setInterpolator(javafx.animation.Interpolator.LINEAR);


            RotateTransition rotateTransition = new RotateTransition(Duration.seconds(3 + Math.random() * 2), petal);
            rotateTransition.setByAngle(180);
            rotateTransition.setCycleCount(RotateTransition.INDEFINITE);
            rotateTransition.setAutoReverse(true);

            fallTransition.play();
            rotateTransition.play();
        }
    }



    private StackPane createHomeLayout() {

        VBox titleBox = new VBox(10);
        titleBox.getChildren().addAll(
                new javafx.scene.control.Label("Đồ án TTNT"),
                new javafx.scene.control.Label("Design by: Nhóm 6"),
                new javafx.scene.control.Label("Đề tài 21: Nghiên cứu các giải thuật tìm kiếm trên đồ thị")
        );
        titleBox.setAlignment(Pos.CENTER);
        for (javafx.scene.Node node : titleBox.getChildren()) {
            if (node instanceof javafx.scene.control.Label) {
                node.setStyle("-fx-font-size: 15px; -fx-text-fill: white;");
            }
        }

        titleBox.setStyle("-fx-background-color: #2F4F4F;");

        Button btnN_PuzzleAI = new Button("N-PuzzleAI");
        Button btnGraph = new Button("Graph");

        btnN_PuzzleAI.setStyle("-fx-font-size: 16px; -fx-pref-width: 150; -fx-pref-height: 50; -fx-background-color: #6A5ACD; -fx-text-fill: white; -fx-background-radius: 10;");
        btnGraph.setStyle("-fx-font-size: 16px; -fx-pref-width: 150; -fx-pref-height: 50; -fx-background-color: #4682B4; -fx-text-fill: white; -fx-background-radius: 10;");

        imageViewN_PuzzleAI = new ImageView();
        imageViewGraph = new ImageView();
        imageViewN_PuzzleAI.setFitWidth(350);
        imageViewN_PuzzleAI.setFitHeight(150);
        imageViewGraph.setFitWidth(350);
        imageViewGraph.setFitHeight(150);

        loadImages();

        btnN_PuzzleAI.setOnAction(e -> {
            try {
                loadGameView();
            } catch (IOException ex) {
                logger.log(Level.SEVERE, "Failed to load N-PuzzleAI", ex);
            }
        });
        btnGraph.setOnAction(e -> {
            try {
                loadGraphView();
            } catch (IOException ex) {
                logger.log(Level.SEVERE, "Failed to load Graph", ex);
            }
        });

        applyButtonAnimation(btnN_PuzzleAI, "#7B68EE");
        applyButtonAnimation(btnGraph, "#5F9EA0");

        VBox vboxN_PuzzleAI = new VBox(10, btnN_PuzzleAI, imageViewN_PuzzleAI);
        vboxN_PuzzleAI.setAlignment(Pos.CENTER);

        VBox vboxGraph = new VBox(10, btnGraph, imageViewGraph);
        vboxGraph.setAlignment(Pos.CENTER);

        VBox mainVBox = new VBox(20, titleBox, vboxN_PuzzleAI, vboxGraph);
        mainVBox.setAlignment(Pos.CENTER);

        VBox instructionBox = new VBox(10);
        instructionBox.getChildren().addAll(
                new javafx.scene.control.Label("Thông tin hướng dẫn:"),
                new javafx.scene.control.Label("- Nhấn nút \"N-PuzzleAI\" để chơi trò chơi"),
                new javafx.scene.control.Label("- Nhấn nút \"Graph\" để xem đồ thị")
        );
        for (javafx.scene.Node node : instructionBox.getChildren()) {
            if (node instanceof javafx.scene.control.Label) {
                node.setStyle("-fx-font-size: 16px; -fx-text-fill: white;");
            }
        }

        instructionBox.setAlignment(Pos.CENTER);
        mainVBox.getChildren().add(instructionBox);

        StackPane homeLayout = new StackPane();
        homeLayout.getChildren().add(mainVBox);
        StackPane.setAlignment(mainVBox, Pos.CENTER);

        return homeLayout;
    }


    private void loadImages() {
        nPuzzleImages = new ArrayList<>();
        graphImages = new ArrayList<>();
        loadImage("img/npuzzle1.png", nPuzzleImages);
        loadImage("img/npuzzle2.png", nPuzzleImages);
        loadImage("img/npuzzle3.png", nPuzzleImages);
        loadImage("img/graph1.png", graphImages);
        loadImage("img/graph2.png", graphImages);
        loadImage("img/graph3.png", graphImages);

        if (!nPuzzleImages.isEmpty()) {
            imageViewN_PuzzleAI.setImage(nPuzzleImages.get(currentImageIndexN_PuzzleAI));
        } else {
            System.err.println("Không có hình ảnh nào được tải cho N-PuzzleAI.");
        }

        if (!graphImages.isEmpty()) {
            imageViewGraph.setImage(graphImages.get(currentImageIndexGraph));
        } else {
            System.err.println("Không có hình ảnh nào được tải cho Graph.");
        }
    }

    private void loadImage(String imagePath, List<Image> imageList) {
        InputStream inputStream = DashboardApplication.class.getResourceAsStream(imagePath);
        if (inputStream == null) {
            System.err.println("Lỗi: Hình ảnh " + imagePath + " không tìm thấy!");
        } else {
            imageList.add(new Image(inputStream));
        }
    }


    private void applyButtonAnimation(Button button, String hoverColor) {
        button.setOnMouseEntered(e -> button.setStyle("-fx-background-color: " + hoverColor + "; -fx-text-fill: white; -fx-background-radius: 10;"));
        button.setOnMouseExited(e -> button.setStyle("-fx-background-color: #6A5ACD; -fx-text-fill: white; -fx-background-radius: 10;"));

        ScaleTransition scaleTransition = new ScaleTransition(Duration.millis(200), button);
        scaleTransition.setFromX(1.0);
        scaleTransition.setFromY(1.0);
        scaleTransition.setToX(1.1);
        scaleTransition.setToY(1.1);
        button.setOnMouseEntered(e -> scaleTransition.playFromStart());
        button.setOnMouseExited(e -> {
            scaleTransition.setRate(-1);
            scaleTransition.play();
        });
    }


    private void startImageSlideshow() {
        if (slideshowTimeline != null) {
            slideshowTimeline.stop();
        }

        slideshowTimeline = new Timeline(new KeyFrame(Duration.seconds(1), event -> {
            currentImageIndexN_PuzzleAI = (currentImageIndexN_PuzzleAI + 1) % nPuzzleImages.size();
            imageViewN_PuzzleAI.setImage(nPuzzleImages.get(currentImageIndexN_PuzzleAI));

            currentImageIndexGraph = (currentImageIndexGraph + 1) % graphImages.size();
            imageViewGraph.setImage(graphImages.get(currentImageIndexGraph));
        }));

        slideshowTimeline.setCycleCount(Timeline.INDEFINITE);
        slideshowTimeline.play();
    }

    private void stopImageSlideshow() {
        if (slideshowTimeline != null) {
            slideshowTimeline.stop();
        }
    }

    private void loadGameView() throws IOException {
        stopImageSlideshow();
        FXMLLoader fxmlLoader = new FXMLLoader(DashboardApplication.class.getResource("game-view.fxml"));
        Scene gameScene = new Scene(fxmlLoader.load(), 840, 640);
        primaryStage.setScene(gameScene);
        primaryStage.setTitle("N-Puzzle");
        primaryStage.getIcons().add(new Image(Objects.requireNonNull(DashboardApplication.class.getResourceAsStream("img/logo.png"))));
        primaryStage.setOnCloseRequest(e -> {
            try {
                e.consume();
                loadStartScene();
            } catch (IOException ex) {
                logger.log(Level.SEVERE, ex.getMessage(), ex);
            }
        });
    }

    private void loadGraphView() throws IOException {
        stopImageSlideshow();
        FXMLLoader fxmlLoader = new FXMLLoader(DashboardApplication.class.getResource("GraphView.fxml"));
        Scene graphScene = new Scene(fxmlLoader.load(), 840, 640);
        primaryStage.setScene(graphScene);
        primaryStage.setTitle("Graph");
        primaryStage.getIcons().add(new Image(Objects.requireNonNull(DashboardApplication.class.getResourceAsStream("img/graph.png"))));
        primaryStage.setOnCloseRequest(e -> {
            primaryStage.getIcons().clear();
            try {
                e.consume();
                loadStartScene();
            } catch (IOException ex) {
                logger.log(Level.SEVERE, ex.getMessage(), ex);
            }
        });


    }

    public static void main(String[] args) {
        launch();
    }
}
