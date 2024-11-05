using System;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;



using System.Drawing.Imaging;
using Image = System.Drawing.Image;

namespace NPuzzleAI
{
    public partial class Form1 : Form
    {

        


        public Image image;
        private HandleImage handleImage;

        private State state;
        private State goalState;

       

        private DFS dFS;
        private BFS bFS;
        private AStar aStar;

        private int[] value;
        private List<int[]> result;
        private string algorithm;
        private int countStep = 0;
        private bool isPlaying = false;
        private bool isSolving = false;
        private int approvedNodes, totalNodes, size;
        private long solveTime;
        private long startTime;
        private String error;
        private Image img;
        private readonly List<Result> compareResults = new List<Result>();


        public Form1()
        {
            InitializeComponent();
            Initialize();

            
            goal1.Checked = true;




            int[] puzzleValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 }; // Mảng giá trị ví dụ

            handleImage = new HandleImage(img, 3, puzzleValues); // Khởi tạo HandleImage

            DisplayImage(img);


        }

    public void Initialize()
        {

            State.Heuristic = 1;
            State.Goal = 1;
            int size = 3;
            string algorithm = "A*";

            state = new State(size);
            value = state.CreateGoalArray();

            goalState = new State(size);
            goalState.CreateGoalArray();

            

            goal1Image.Image = Image.FromFile("img/goal-1.png");
            goal2Image.Image = Image.FromFile("img/goal-2.png");
            
            //OnChangeGoal();
            DisplayImage(null);
            progressBar.Visible = false;

            imgCanvas.Image = Image.FromFile("img/goal-1.png");
            goal1.CheckedChanged += (s, e) => OnChangeGoal();
            goal2.CheckedChanged += (s, e) => OnChangeGoal();
            
        }

        private void playBtn_Click(object sender, EventArgs e)
        {

        }




        public void DisplayImage(Image img)
        {
            if (imgCanvas != null)
            {
                imgCanvas.Invalidate(); // Yêu cầu vẽ lại canvas

                if (img == null)
                {
                    displayPane.BackColor = Color.FromArgb(255, 139, 69, 19); // Nếu không có ảnh
                }
                else
                {
                    displayPane.BackColor = Color.Transparent; // Nếu có ảnh
                    handleImage = new HandleImage(img, size, value);
                    // Kiểm tra nếu trạng thái hiện tại là đích
                    if (state.IsGoal(goalState))
                    {
                        handleImage.win = true;
                    }

                    // Lưu hình ảnh vào biến toàn cục hoặc control khác nếu cần
                    using (Graphics g = imgCanvas.CreateGraphics())
                    {
                        handleImage.paint(g);
                    }
                }
            }
            else
            {
                MessageBox.Show("imgCanvas is null!");
            }
        }


        //private void imgCanvas_Paint(object sender, PaintEventArgs e)
        //{
        //    if (imgCanvas.Tag is HandleImage handleImage)
        //    {
        //        handleImage.paint(e.Graphics); // Gọi phương thức paint của HandleImage
        //    }
        //}

        // Thay đổi trạng thái đích
        public void OnChangeGoal()
        {
            RadioButton selectedGoal = null;

            // Lấy radio button được chọn từ một nhóm
            foreach (RadioButton rb in goalGroup.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    selectedGoal = rb;
                    break;
                }
            }

            // Kiểm tra nếu có radio button được chọn
            if (selectedGoal != null)
            {
                // Thay đổi trạng thái dựa trên ID của radio button được chọn
                if (selectedGoal.Name.Equals("goal1"))
                {
                    State.Goal = 1;
                    image = Image.FromFile("img/goal-1.png");

                }
                else
                {
                    State.Goal = 2;
                    image = Image.FromFile("img/goal-2.png");

                }

                // Cập nhật lại trạng thái và hiển thị hình ảnh
                value = state.CreateGoalArray();
                goalState.CreateGoalArray();
                DisplayImage(image); // Gọi hiển thị hình ảnh mới
            }
        }

        private void OnChangeImageSize()
        {
            RadioButton selectedDiff = null;

            foreach (RadioButton rb in goalGroup.Controls)
            {
                if (rb.Checked)
                {
                    selectedDiff = rb;
                    break;
                }
            }

            if (selectedDiff != null)
            {
                switch (selectedDiff.Name)
                {
                    case "T.Bình":
                        size = 4;
                        break;
                    case "Khó":
                        size = 5;
                        break;
                    default:
                        size = 3;
                        break;
                }

                sizeMenu.Text = selectedDiff.Text;

                // Cập nhật lại state với kích thước mới
                state = new State(size);
                value = state.CreateGoalArray();
                goalState = new State(size);
                goalState.CreateGoalArray();

                // Hiển thị hình ảnh cập nhật
                DisplayImage(image);
            }
        }

        private void algorithmMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy thuật toán đã chọn từ ComboBox
            string selectedAlgorithm = algorithmMenu.SelectedItem.ToString();
            switch (selectedAlgorithm)
            {
                case "A* H1":
                        State.Heuristic = 1;
                        algorithm = "A*";
                    break;
                case "A* H2":
                        State.Heuristic = 2;
                        algorithm = "A*";
                    break;
                case "A* H3":
                        State.Heuristic = 3;
                        algorithm = "A*";
                    break;
                case "A* H4":
                        State.Heuristic = 4;
                        algorithm = "A*";
                    break;
                case "A* H5":
                        State.Heuristic = 5;
                        algorithm = "A*";
                    break;
                case "A* H6":
                        State.Heuristic = 6;
                        algorithm = "A*";
                    break;
                case "DFS":
                    algorithm = "DFS";
                    break;

                default:
                    algorithm = "BFS";
                    break;
            }
            algorithmMenu.Text = selectedAlgorithm;
        }

        


        private void addImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập các bộ lọc mở rộng tệp
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.gif";

                // Hiện hộp thoại mở tệp
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy tệp hình ảnh đã chọn
                        string filePath = openFileDialog.FileName;
                        Bitmap image = new Bitmap(filePath);

                        // Kiểm tra null
                        if (image == null || pictureBox1 == null || state == null)
                        {
                            MessageBox.Show("Error initializing image or components.");
                            return; // Thoát hàm nếu có lỗi
                        }

                        // Thêm ảnh nhỏ
                        //if (image.Height > image.Width)
                        //{
                        //    double width = image.Width * 180.0 / image.Height;
                        //    pictureBox1.Location = new Point((180 - (int)width) / 2, pictureBox1.Location.Y);
                        //}
                        //else
                        //{
                        //    pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                        //} 

                        countStep = 0;
                        stepField.Text = "0";

                        // Cập nhật hình ảnh hiển thị
                        pictureBox1.Image = image;

                        // Tạo lại mảng mục tiêu
                        value = state.CreateGoalArray();
                        DisplayImage(image);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }



        private void addNumber_Click(object sender, EventArgs e)
        {
            countStep = 0;
            image = null;
            stepField.SelectedText = "0";
            pictureBox1.Image = null;
            value = state.CreateGoalArray();
            DisplayImage(image);
        }

        private void jumbleBtn_Click(object sender, EventArgs e)
        {
            stepField.Text = "0";
            countStep = 0;
            value = state.CreateGoalArray();
            DisplayImage(image);
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            countStep = 0;

            if (!isSolving)
            {
                    if (algorithm.Equals("BFS"))
                {
                    BFS.stop = false; // Bắt đầu thuật toán BFS
                }
                else if (algorithm.Equals("AStar"))
                {
                    AStar.stop = false; // Bắt đầu thuật toán A*
                }
                else if (algorithm.Equals("DFS"))
                {
                    DFS.stop = false;
                }
                solveThread().Start();
                solving();
            }
            else
            {
                if (algorithm.Equals("BFS"))
                {
                    BFS.stop = true; // Dừng thuật toán BFS
                }
                else
                {
                    AStar.stop = true; // Dừng thuật toán A*
                }

                notSolve(); // Gọi phương thức notSolve
            }
        }

        // Trạng thái đang tìm kiếm
        public void solving()
        {
            isSolving = true;
            solveBtn.Text = "Dừng";
            playBtn.Enabled = false;
            setDisable();
        }
        // Trạng thái không tìm kiếm
        public void notSolve()
        {
            isSolving = false;
            solveBtn.Text = "AI Giải";
            playBtn.Enabled = true;
            setEnable();
        }

        // Enable các nút
        // Enable các nút
        private void setEnable()
        {
            solveBtn.Enabled = true;
            jumbleBtn.Enabled = true;
            addImage.Enabled = true;
            addNumber.Enabled = true;
            compareBtn.Enabled = true;
            sizeMenu.Enabled = true;
            algorithmMenu.Enabled = true;
            progressBar.Visible = false;
            goal1.Enabled = true;
            goal2.Enabled = true;
        }


        // Disable các nút
        private void setDisable()
        {
            jumbleBtn.Enabled = false;
            addImage.Enabled = false;
            addNumber.Enabled = false;
            compareBtn.Enabled = false;
            sizeMenu.Enabled = false;
            algorithmMenu.Enabled = false;
            progressBar.Enabled = false;
            goal1.Enabled = false;
            goal2.Enabled = false;
        }



        // Trạng thái khởi tạo ban đầu
      

        // Luồng chạy lời giải
        public void RunSolution()
        {
            int totalStep = result.Count - 1; // Chuyển từ result.size() sang result.Count trong C#

            // Chạy luồng mới
            Task.Run(() =>
            {
                for (int i = 0; i <= totalStep; i++)
                {
                    value = result[i];
                    state.Value = value;

                    // Hiển thị hình ảnh (method displayImage cần điều chỉnh phù hợp)
                    DisplayImage(image);

                    // Cập nhật text cho stepField trên giao diện chính
                    string step = i + "/" + totalStep;
                    stepField.Invoke(new Action(() =>
                    {
                        stepField.Text = step;
                    }));

                    // Tạm dừng luồng
                    try
                    {
                        Thread.Sleep(600); // Dừng luồng 600ms
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        Console.WriteLine(ex.Message); // In ra lỗi nếu có
                    }
                }

                // Khi hoàn thành, gọi hàm notSolve (phải nằm trong giao diện chính)
                this.Invoke(new Action(() =>
                {
                    notSolve();
                }));
            });
        }

        public void solveAStar()
        {
            aStar = new AStar();
            aStar.StartNode = new Node(state, 0);
            aStar.GoalNode = new Node(goalState, 1);
            aStar.Solve();
            result = aStar.Result;
            approvedNodes = aStar.approvedNodes;
            totalNodes = aStar.totalNodes;
            solveTime = aStar.time;
            error = aStar.error;
        }

        public void solveBFS()
        {
            bFS = new BFS();
            bFS.StartNode = new Node(state, 0);
            bFS.GoalNode = new Node(goalState, 0);
            bFS.Solve();
            result = bFS.Result;
            approvedNodes = bFS.approvedNodes;
            totalNodes = bFS.totalNodes;
            solveTime = bFS.time;
            error = bFS.error;
        }

        // Luồng tìm kiếm lời giải
        private Thread solveThread()
        {
            return new Thread(() =>
            {
                if (algorithm.Equals("BFS"))
                {
                    solveBFS();
                }
                else
                {
                    solveAStar();
                }

                // Nếu tìm được lời giải
                if (result.Count > 1)
                {
                    // Gọi phương thức showAlert trên luồng UI
                    Invoke(new Action(ShowAlert));
                }
                // Nếu không tìm được lời giải
                else if (result.Count == 0 && error != null)
                {
                    // Gọi phương thức showWarning trên luồng UI
                    Invoke(new Action(ShowWarning));
                }
                // Người chơi chọn dừng tìm kiếm hoặc trạng thái ban đầu là trạng thái đích
                else
                {
                    // Gọi phương thức notSolve trên luồng UI
                    Invoke(new Action(notSolve));
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowWarning()
        {
            // Tạo thông báo lỗi
            var alert = new Form
            {
                Text = "Thông báo",
                Width = 400,
                Height = 200,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label
            {
                Text = "Không tìm được lời giải!\nNguyên nhân:\n" + error,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button closeButton = new Button
            {
                Text = "Đóng",
                DialogResult = DialogResult.Cancel,
                Dock = DockStyle.Bottom
            };

            closeButton.Click += (sender, e) => { alert.Close(); };
            alert.Controls.Add(label);
            alert.Controls.Add(closeButton);
            alert.ShowDialog();
        }

        // Phương thức hiển thị thông báo kết quả tìm kiếm
        public void ShowAlert()
        {
            // Tạo thông báo kết quả
            var alert = new Form
            {
                Text = "Thông báo",
                Width = 400,
                Height = 300,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label
            {
                Text = "Lời giải:\n" +
                       "Thuật toán sử dụng: " + (algorithm.Equals("BFS") ? "BFS" : "A* với Heuristic " + State.Heuristic) + "\n" +
                       "Số node đã duyệt: " + approvedNodes + "\n" +
                       "Tổng số node trên cây: " + totalNodes + "\n" +
                       "Tổng số bước: " + (result.Count - 1) + "\n" +
                       "Thời gian tìm kiếm: " + solveTime + "ms" + "\n" +
                       "Bạn có muốn chạy lời giải?",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button runButton = new Button
            {
                Text = "Chạy",
                DialogResult = DialogResult.OK,
                Dock = DockStyle.Bottom
            };

            Button closeButton = new Button
            {
                Text = "Đóng",
                DialogResult = DialogResult.Cancel,
                Dock = DockStyle.Bottom
            };

            runButton.Click += (sender, e) =>
            {
                solveBtn.Enabled = false;
                Thread runResult = new Thread(RunSolution);
                runResult.Start();
                alert.Close();
            };

            closeButton.Click += (sender, e) => { alert.Close(); };

            alert.Controls.Add(label);
            alert.Controls.Add(runButton);
            alert.Controls.Add(closeButton);
            alert.ShowDialog();
        }


    }
}

