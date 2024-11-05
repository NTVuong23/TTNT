module com.example.npuzzleai {
    requires javafx.fxml;
    requires javafx.swing;
    requires java.logging;
    requires javafx.web;


    opens com.example.solvePath to javafx.fxml;
    exports com.example.solvePath;
}