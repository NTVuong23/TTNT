using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BFS
{
    public partial class Form1 : Form
    {
        private Graph graph; // Đồ thị
        private List<Tuple<int, int>> edges; // Danh sách các cạnh đã thêm
        private List<Point> vertices; // Danh sách để lưu trữ vị trí các đỉnh
        private int radius = 10; // Bán kính của đỉnh
        private int vertexCount = 0; // Đếm số lượng đỉnh đã thêm

        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
            edges = new List<Tuple<int, int>>(); // Khởi tạo danh sách các cạnh
            vertices = new List<Point>(); // Khởi tạo danh sách vị trí đỉnh

            // Khu vực vẽ
           
            drawingPanel.BringToFront();
        }

        // Thêm đỉnh khi nhấn chuột
        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            // Kiểm tra xem nhấn chuột có nằm trong khu vực của drawingPanel không
            if (e.X - radius >= 10 && e.X + radius <= drawingPanel.Width -10 &&
                e.Y - radius >= 10 && e.Y + radius <= drawingPanel.Height -10)
            {
                // Thêm đỉnh vào danh sách
                vertices.Add(e.Location);
                graph.AddVertex(vertexCount); // Thêm đỉnh vào đồ thị
                vertexCount++; // Tăng số lượng đỉnh đã thêm

                // Vẽ lại tất cả các đỉnh
                drawingPanel.Invalidate(); // Kích hoạt vẽ lại panel
            }
            else
            {
                MessageBox.Show("Đỉnh không được vẽ ngoài phạm vi của khu vực vẽ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Vẽ đỉnh trong hàm OnPaint của drawingPanel
        private void drawingPanel_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.White;

            // Vẽ các đỉnh và số thứ tự
            for (int i = 0; i < vertices.Count; i++)
            {
                Point currentVertex = vertices[i]; // Đổi tên thành currentVertex

                // Kiểm tra nếu đỉnh nằm trong khu vực vẽ với bán kính
                if (currentVertex.X - radius >= 0 && currentVertex.X + radius <= drawingPanel.Width &&
                    currentVertex.Y - radius >= 0 && currentVertex.Y + radius <= drawingPanel.Height)
                {
                    // Vẽ hình tròn đại diện cho đỉnh
                    g.FillEllipse(Brushes.Blue, currentVertex.X - radius, currentVertex.Y - radius, radius * 2, radius * 2);

                    // Vẽ số ở giữa đỉnh (số thứ tự tăng dần)
                    string number = (i + 1).ToString(); // Số bắt đầu từ 1
                    SizeF textSize = g.MeasureString(number, font); // Kích thước của số
                    g.DrawString(number, font, brush,
                                 currentVertex.X - textSize.Width / 2, // Tọa độ X để số nằm giữa
                                 currentVertex.Y - textSize.Height / 2); // Tọa độ Y để số nằm giữa
                }
            }

            // Vẽ các cạnh (nếu có)
            foreach (var edge in edges)
            {
                int startIndex = edge.Item1; // Chỉ số đỉnh bắt đầu
                int endIndex = edge.Item2;   // Chỉ số đỉnh kết thúc

                // Lấy vị trí của đỉnh bắt đầu và đỉnh kết thúc
                Point start = vertices[startIndex];
                Point end = vertices[endIndex];

                // Vẽ đường nối giữa hai đỉnh
                g.DrawLine(Pens.Black, start, end);
            }
        }




        // Thêm cạnh giữa các đỉnh
        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStartVertex.Text, out int startVertex) &&
                int.TryParse(txtEndVertex.Text, out int endVertex) &&
                startVertex >= 1 && endVertex >= 1 &&
                startVertex <= vertexCount && endVertex <= vertexCount) // Kiểm tra đỉnh hợp lệ
            {
                // Điều chỉnh chỉ số của đỉnh nhập từ người dùng để phù hợp với danh sách bắt đầu từ 0
                graph.AddEdge(startVertex - 1, endVertex - 1);
                edges.Add(new Tuple<int, int>(startVertex - 1, endVertex - 1)); // Thêm cạnh vào danh sách
                edges.Add(new Tuple<int, int>(endVertex - 1, startVertex - 1)); // Thêm cạnh ngược lại nếu đồ thị vô hướng
                drawingPanel.Invalidate(); // Gọi lại phương thức OnPaint để vẽ lại
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đỉnh hợp lệ trong phạm vi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Duyệt đồ thị bằng DFS và BFS
        private void btnTraverse_Click(object sender, EventArgs e)
        {
            if (vertexCount > 0) // Kiểm tra xem có đỉnh nào trong đồ thị chưa
            {
                int startVertex = 0; // Duyệt từ đỉnh đầu tiên (0)

                // Thực hiện DFS
                Stopwatch sw = new Stopwatch(); // Đo thời gian chạy
                sw.Start();
                List<int> dfsResult = graph.DFS(startVertex); // Bắt đầu từ đỉnh 0
                sw.Stop();

                lblResultDFS.Text = $"Kết quả DFS: {string.Join(", ", dfsResult.Select(v => v + 1))}"; // Hiển thị từ 1
                lblStepsDFS.Text = $"Số bước DFS: {dfsResult.Count}";
                lblTimeDFS.Text = $"Thời gian DFS: {sw.ElapsedMilliseconds} ms"; // Hiển thị thời gian chạy

                // Thực hiện BFS
                sw.Restart();
                List<int> bfsResult = graph.BFS(startVertex); // Bắt đầu từ đỉnh 0
                sw.Stop();

                lblResultBFS.Text = $"Kết quả BFS: {string.Join(", ", bfsResult.Select(v => v + 1))}"; // Hiển thị từ 1
                lblStepsBFS.Text = $"Số bước BFS: {bfsResult.Count}";
                lblTimeBFS.Text = $"Thời gian BFS: {sw.ElapsedMilliseconds} ms"; // Hiển thị thời gian chạy
            }
            else
            {
                MessageBox.Show("Chưa có đỉnh nào trong đồ thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút reset để xóa toàn bộ đồ thị
        private void btnReset_Click(object sender, EventArgs e)
        {
            graph = new Graph(); // Tạo một đồ thị mới
            edges.Clear(); // Xóa danh sách các cạnh
            vertices.Clear(); // Xóa danh sách các vị trí đỉnh
            vertexCount = 0; // Đặt lại số đỉnh về 0
            drawingPanel.Invalidate(); // Gọi lại phương thức OnPaint để vẽ lại

            // Đặt lại các nhãn kết quả
            lblResultDFS.Text = "Kết quả DFS: ";
            lblResultBFS.Text = "Kết quả BFS: ";
            lblStepsDFS.Text = "Số bước DFS: ";
            lblStepsBFS.Text = "Số bước BFS: ";
            lblTimeDFS.Text = "Thời gian DFS: ";
            lblTimeBFS.Text = "Thời gian BFS: ";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (vertexCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpeg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Lưu ảnh";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
                    drawingPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height)); // Vẽ lên bitmap

                    bitmap.Save(saveFileDialog.FileName); // Lưu hình ảnh vào tệp
                    MessageBox.Show("Ảnh đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có đỉnh nào để lưu hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStartVertex_Enter(object sender, EventArgs e)
        {
            if (txtStartVertex.Text == "Đỉnh bắt đầu")
            {
                txtStartVertex.Text = "";
                txtStartVertex.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void txtStartVertex_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartVertex.Text))
            {
                txtStartVertex.Text = "Đỉnh bắt đầu"; // Trả lại văn bản giữ chỗ
                txtStartVertex.ForeColor = Color.Gray; // Đổi lại màu chữ
            }
        }

        private void txtEndVertex_Enter(object sender, EventArgs e)
        {
            if (txtEndVertex.Text == "Đỉnh kết thúc")
            {
                txtEndVertex.Text = "";
                txtEndVertex.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void txtEndVertex_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndVertex.Text))
            {
                txtEndVertex.Text = "Đỉnh kết thúc"; // Trả lại văn bản giữ chỗ
                txtEndVertex.ForeColor = Color.Gray; // Đổi lại màu chữ
            }
        }

        
    }



    public class Graph
    {
        private List<List<int>> adjList; // Danh sách kề

        public Graph()
        {
            adjList = new List<List<int>>(); // Khởi tạo danh sách kề
        }

        public void AddVertex(int vertex)
        {
            // Thêm đỉnh mới vào danh sách kề
            adjList.Add(new List<int>());
        }

        public void AddEdge(int start, int end)
        {
            // Thêm cạnh giữa hai đỉnh
            if (start < adjList.Count && end < adjList.Count)
            {
                adjList[start].Add(end); // Thêm cạnh từ start đến end
                adjList[end].Add(start); // Thêm cạnh từ end đến start (đồ thị vô hướng)
            }
        }

        public List<int> DFS(int startVertex)
        {
            bool[] visited = new bool[adjList.Count]; // Mảng để theo dõi các đỉnh đã thăm
            List<int> result = new List<int>(); // Danh sách kết quả

            DFSUtil(startVertex, visited, result); // Gọi phương thức DFS
            return result;
        }

        private void DFSUtil(int vertex, bool[] visited, List<int> result)
        {
            visited[vertex] = true; // Đánh dấu đỉnh là đã thăm
            result.Add(vertex); // Thêm đỉnh vào kết quả

            foreach (int neighbor in adjList[vertex]) // Duyệt qua các đỉnh kề
            {
                if (!visited[neighbor]) // Nếu chưa thăm
                {
                    DFSUtil(neighbor, visited, result); // Gọi đệ quy cho đỉnh kề
                }
            }
        }   

        public List<int> BFS(int startVertex)
        {
            bool[] visited = new bool[adjList.Count]; // Mảng để theo dõi các đỉnh đã thăm
            List<int> result = new List<int>(); // Danh sách kết quả
            Queue<int> queue = new Queue<int>(); // Hàng đợi cho BFS

            visited[startVertex] = true; // Đánh dấu đỉnh bắt đầu là đã thăm
            queue.Enqueue(startVertex); // Đưa đỉnh vào hàng đợi

            while (queue.Count > 0) // Trong khi hàng đợi còn đỉnh
            {
                int vertex = queue.Dequeue(); // Lấy đỉnh từ hàng đợi
                result.Add(vertex); // Thêm đỉnh vào kết quả

                foreach (int neighbor in adjList[vertex]) // Duyệt qua các đỉnh kề
                {
                    if (!visited[neighbor]) // Nếu chưa thăm
                    {
                        visited[neighbor] = true; // Đánh dấu là đã thăm
                        queue.Enqueue(neighbor); // Thêm vào hàng đợi
                    }
                }
            }
            return result; // Trả về kết quả
        }
    }

    public class DrawingPanel : Panel
    {
        // Phần vẽ sẽ được thực hiện trong Form1
    }
}
