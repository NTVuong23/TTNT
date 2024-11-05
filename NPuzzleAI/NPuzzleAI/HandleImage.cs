using System;
using System.Drawing;
using System.Windows.Forms;

namespace NPuzzleAI
{
    public class HandleImage
    {
        private int Size;
        private readonly int Length;
        protected int blank;
        protected int[] Value;
        private Image img;
        private readonly double w;
        private readonly double h;
        private double cw;
        private double ch;
        private double width, height, cw1, ch1;
        private double align = 0;
        public bool win = false;

        public HandleImage(Image img, int size, int[] val)
        {
            this.img = img;
            this.Size = size;
            Length = Size * Size;
            this.Value = val;
            if (img == null)
            {
                width = w = 400;
                height = h = 400;
            }
            else
            {
                width = w = img.Width;
                height = h = img.Height;
            }
            InitImage();
        }

        public void InitImage()
        {
            cw = w / Size;
            ch = h / Size;
            Console.WriteLine($"cw: {cw}, ch: {ch}");

            int kt = 400;
            if (w != kt || h != kt)
            {
                if (w > h)
                {
                    width = kt;
                    height = width * h / w;
                }
                else
                {
                    height = kt;
                    width = height * w / h;
                    align = (kt - width) / 2;
                }
            }
            cw1 = width / Size;
            ch1 = height / Size;
            Console.WriteLine($"cw1: {cw1}, ch1: {ch1}");

            blank = posBlank(Value);
        }


        public int posBlank(int[] Value) // Tìm vị trí phần tử blank
        {
            for (int i = 0; i < Length; i++)
                if (Value[i] == 0)
                    return i;
            return -1;
        }

        public void paint(Graphics g)
        {
            g.Clear(Color.Transparent); // Đảm bảo làm sạch trước khi vẽ

            if (img == null)
            {
                // Tạo khung số (trò chơi số) nếu không có ảnh
                g.FillRectangle(Brushes.Black, 0, 0, (float)width, (float)height);
                DrawPuzzleNumbers(g);
            }
            else
            {
                // Tạo khung ảnh nếu có ảnh
                if (!win)
                {
                    g.FillRectangle(Brushes.Gray, (float)align, 0, (float)width, (float)height);
                    DrawPuzzleImage(g);
                }
                else
                {
                    // Nếu đã chiến thắng, vẽ toàn bộ hình ảnh
                    g.DrawImage(img, (float)align, 0, (float)width, (float)height);
                }
            }
            g.DrawRectangle(Pens.Black, (float)align, 0, (float)width, (float)height);
        }

        private void DrawPuzzleNumbers(Graphics g)
        {
            for (int i = 0; i < Length; i++)
            {
                double x = (i % Size) * cw1;
                double y = (double)(i / Size) * ch1;
                if (Value[i] != 0)
                {
                    // Vẽ khung số trắng và số
                    g.FillRectangle(Brushes.White, (float)(x + 0.5), (float)(y + 0.5), (float)(cw1 - 1), (float)(ch1 - 1));
                    g.DrawString(Value[i].ToString(), new Font("Roboto", (float)(120 / Size), FontStyle.Bold), Brushes.Black,
                        (float)(x + 5 * cw1 / 12), (float)(y + (3 * ch1) / 5));
                }
                else
                {
                    // Vẽ ô trống màu nâu
                    g.FillRectangle(new SolidBrush(Color.FromArgb(156, 127, 78)), (float)(x + 0.5), (float)(y + 0.5), (float)(cw1 - 1), (float)(ch1 - 1));
                }

                // Vẽ đường viền cho mỗi ô
                g.DrawRectangle(Pens.Black, (float)(x + 0.5), (float)(y + 0.5), (float)(cw1 - 1), (float)(ch1 - 1));
            }
        }



        private void DrawPuzzleImage(Graphics g)
        {
            // Duyệt qua tất cả các ô trong khung Puzzle
            for (int i = 0; i < Length; i++)
            {
                // Tính toán tọa độ đích cho từng ô
                double dx = (i % Size) * cw1 + align; // Tọa độ X trên màn hình (destination X)
                double dy = (i / Size) * ch1;         // Tọa độ Y trên màn hình (destination Y)

                // Chỉ vẽ ảnh nếu ô không phải là ô trống
                if (Value[i] != 0)
                {
                    // Tìm giá trị của ô và sử dụng nó để tính toán tọa độ nguồn
                    int c = Value[i] - 1; // Tính toán vị trí chính xác trong hình ảnh (value của ô)

                    // Tính toán tọa độ nguồn từ ảnh gốc
                    double sx = (c % Size) * cw;  // Tọa độ nguồn X trong ảnh gốc
                    double sy = (c / Size) * ch;  // Tọa độ nguồn Y trong ảnh gốc

                    // Cắt mảnh ảnh từ ảnh gốc dựa trên tọa độ nguồn
                    Rectangle sourceRect = new Rectangle((int)sx, (int)sy, (int)cw, (int)ch);
                    // Vẽ mảnh ảnh lên tọa độ đích (màn hình)
                    Rectangle destRect = new Rectangle((int)dx, (int)dy, (int)cw1, (int)ch1);

                    // Kiểm tra và vẽ ảnh nếu không bị lỗi
                    try
                    {
                        g.DrawImage(img, destRect, sourceRect, GraphicsUnit.Pixel); // Vẽ mảnh ảnh vào đúng vị trí
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi vẽ ảnh: {ex.Message}");
                    }

                    // Vẽ số lên trên mảnh ảnh để dễ nhìn
                    g.DrawString(Value[i].ToString(), new Font("Roboto", (float)(90 / Size), FontStyle.Regular), Brushes.White,
                        (float)(dx + 5 * cw1 / 12), (float)(dy + (3 * ch1) / 5));
                }

                // Vẽ viền cho từng ô, kể cả ô trống
                g.DrawRectangle(Pens.Black, (float)(dx), (float)dy, (float)cw1, (float)ch1);
            }
        }


    }
}
