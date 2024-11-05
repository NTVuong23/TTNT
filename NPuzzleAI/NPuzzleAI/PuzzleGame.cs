using System;
using System.Drawing;
using System.Windows.Forms;

namespace NPuzzleAI
{
    public class PuzzleGame
    {
        private Image originalImage;
        private int pieceWidth;
        private int pieceHeight;
        private int rows;
        private int cols;
        private PictureBox pictureBox;

        public PuzzleGame(Image image, int rows, int cols, PictureBox pictureBox)
        {
            this.originalImage = image;
            this.rows = rows;
            this.cols = cols;
            this.pictureBox = pictureBox;

            pieceWidth = originalImage.Width / cols;
            pieceHeight = originalImage.Height / rows;
        }

        public void CreatePuzzle()
        {
            Bitmap puzzleImage = new Bitmap(originalImage.Width, originalImage.Height);
            Graphics g = Graphics.FromImage(puzzleImage);

            // Vẽ các mảnh ảnh
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Rectangle srcRect = new Rectangle(j * pieceWidth, i * pieceHeight, pieceWidth, pieceHeight);
                    Rectangle destRect = new Rectangle(j * pieceWidth, i * pieceHeight, pieceWidth, pieceHeight);
                    g.DrawImage(originalImage, destRect, srcRect, GraphicsUnit.Pixel);
                }
            }

            g.Dispose();
            pictureBox.Image = puzzleImage;
        }
    }
}
