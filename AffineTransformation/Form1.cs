using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineTransformation
{
    public partial class Form1 : Form
    {
        private String filename = "lena.jpg";
        private Point ImageSize = new Point();

        public Form1()
        {
            InitializeComponent();
            this.ImageReset();
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            
            foreach (RadioButton radio in panel1.Controls)
            {
                if (radio.Checked)
                {
                    if (radio.Name == "Center") this.TransformbyCenter();
                    else this.TransformbyOrigin();
                }

            }
            // System.Draw の標準クラスを使ってやった裏技
            // Ref: https://dobon.net/vb/dotnet/graphics/transform.html
            // this.TransformBySystemMethod(trackBar1.Value, Decimal.ToInt32(TranslationX.Value), Decimal.ToInt32(TranslationY.Value));


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            String str = FileNameBox.Text;
            String filename = str + Convert.ToString(".png");
            img.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ImageReset();
        }

        private void ImageReset()
        {
            try
            {
                Bitmap image = new Bitmap(Image.FromFile(this.filename));
                Bitmap createImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                int move_x = createImage.Width / 2, move_y = createImage.Height / 2;
                // 中心点に移動
                int biasX = image.Width / 2;
                int biasY = image.Height / 2;
                this.ImageSize = new Point(image.Width, image.Height);

                // アフィンマトリックスを作成
                AffineMatrix aMatrix = new AffineMatrix();
                aMatrix.SetMatrix(0, move_x - biasX, move_y - biasY, 1.0);

                for (int y = 0; y < createImage.Height; y++)
                {
                    for (int x = 0; x < createImage.Width; x++)
                    {
                        Point nPoint = new Point(x - biasX, y - biasY);
                        Point oPoint = aMatrix.CalcInverseMatrix(nPoint);
                        if (this.IsOutOfRange(oPoint.X + biasX, oPoint.Y + biasY, image.Width, image.Height))
                            continue;
                        createImage.SetPixel(x, y, image.GetPixel(oPoint.X + biasX, oPoint.Y + biasY));
                    }
                }
                pictureBox1.Image = createImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("イメージが読み込めません", "LOAD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TransformbyOrigin()
        {
            int angle = trackBar1.Value;
            int move_x = Decimal.ToInt32(TranslationX.Value), move_y = Decimal.ToInt32(TranslationY.Value);
            double scale = ScaleBar.Value / 10.0;


            Bitmap image = new Bitmap(Image.FromFile(this.filename));
            Bitmap createImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // 原点に移動
            int biasX = createImage.Width / 2 - this.ImageSize.X / 2;
            int biasY = createImage.Height / 2 - this.ImageSize.Y / 2;

            // アフィンマトリックスを作成
            AffineMatrix aMatrix = new AffineMatrix();
            aMatrix.SetMatrix(angle, move_x + biasX, move_y + biasY, scale);

            for (int y = 0; y < createImage.Height; y++)
            {
                for (int x = 0; x < createImage.Width; x++)
                {
                    Point nPoint = new Point(x, y);
                    Point oPoint = aMatrix.CalcInverseMatrix(nPoint);
                    if (this.IsOutOfRange(oPoint.X, oPoint.Y, image.Width, image.Height))
                        continue;
                    createImage.SetPixel(x, y, image.GetPixel(oPoint.X, oPoint.Y));
                }
            }
            pictureBox1.Image = createImage;
        }

        private void TransformbyCenter()
        {
            int angle = trackBar1.Value;
            int move_x = Decimal.ToInt32(TranslationX.Value), move_y = Decimal.ToInt32(TranslationY.Value);
            double scale = ScaleBar.Value / 10.0;


            Bitmap image = new Bitmap(Image.FromFile(filename));
            Bitmap createImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // 中心点に移動
            int centerX = createImage.Width / 2;
            int centerY = createImage.Height / 2;
            int biasX = image.Width / 2;
            int biasY = image.Height / 2;

            // アフィンマトリックスを作成
            AffineMatrix aMatrix = new AffineMatrix();
            aMatrix.SetMatrix(angle, move_x + centerX - biasX, move_y + centerY - biasY, scale);

            for (int y = 0; y < createImage.Height; y++)
            {
                for (int x = 0; x < createImage.Width; x++)
                {
                    Point nPoint = new Point(x - biasX, y - biasY);
                    Point oPoint = aMatrix.CalcInverseMatrix(nPoint);
                    if (this.IsOutOfRange(oPoint.X + biasX, oPoint.Y + biasY, image.Width, image.Height))
                        continue;
                    createImage.SetPixel(x, y, image.GetPixel(oPoint.X + biasX, oPoint.Y + biasY));
                }
            }
            pictureBox1.Image = createImage;

        }
        
        private void TransformBySystemMethod(int angle, int x, int y)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //画像を読み込む
            Image img = Image.FromFile(this.filename);

            //ワールド変換行列を単位行列にリセット
            g.ResetTransform();
            //ワールド変換行列を下に10平行移動する
            g.TranslateTransform(x, y);
            /*
            //ワールド変換行列を単位行列にリセット
            g.ResetTransform();
            //ワールド変換行列にスケーリング操作を適用し、2倍に拡大する
            g.ScaleTransform(1.5F, 1.5F);
            //画像を描画
            g.DrawImage(img, new Rectangle(img.Width, 0, img.Width, img.Height));
            */
            //ワールド変換行列を45度回転する
            g.RotateTransform(angle);
            //画像を描画
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height));
            

            //リソースを解放する
            img.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        private Point MoveInArea(int x, int y, int mx, int my, AffineMatrix Matrix)
        {
            Point[] edge = new Point[4];
            //　時計回り
            edge[0].X = x; edge[0].Y = y;
            edge[1].X = mx; edge[1].Y = y;
            edge[2].X = mx; edge[2].Y = my;
            edge[3].X = x; edge[3].Y = my;

            for(int i = 0; i < edge.Length; i++)
            {
                edge[i] = Matrix.CalcMatrix(edge[i]);
            }
            
            int[] arrayX = new int[4];
            int[] arrayY = new int[4];
            for (int i = 0; i < edge.Length; i++)
            {
                arrayX[i] = edge[i].X;
                arrayY[i] = edge[i].Y;
            }

            return new Point(-1 * this.GetMin(arrayX), -1 * this.GetMin(arrayY));
        }

        private int GetMin(int[] array)
        {
            int buf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (buf > array[i])
                    buf = array[i];
            }
            return buf;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RotateValue.Text = trackBar1.Value.ToString();
        }

        private Boolean IsOutOfRange(int x, int y, int maxX, int maxY)
        {
            if (x < 0)
                return true;
            else if (x > maxX - 1)
                return true;

            if (y < 0)
                return true;
            else if (y > maxY - 1)
                return true;

            return false;
        }

        private void ScaleBar_Scroll(object sender, EventArgs e)
        {

            ScaleValue.Text = Convert.ToString(ScaleBar.Value / 10.0);
        }

        private void NearestButton_Click(object sender, EventArgs e)
        {
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);

            double scale = ScaleBar.Value / 10.0;
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);

            Bitmap image = new Bitmap(filename);
            
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(image, center.X - (int)((image.Width * scale) / 2.0), center.Y - (int)((image.Height * scale) / 2.0), (int)(image.Width * scale), (int)(image.Height * scale));
            //g.DrawImage(image, center.X - (int)((image.Width * scale) / 2.0), center.Y - (int)((image.Height * scale) / 2.0), center.X + (int)((image.Width * scale) / 2.0), center.Y + (int)((image.Height * scale) / 2.0));
            image.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        private void LinerButton_Click(object sender, EventArgs e)
        {
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);

            double scale = ScaleBar.Value / 10.0;
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);

            Bitmap image = new Bitmap(filename);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            g.DrawImage(image, center.X - (int)((image.Width * scale) / 2.0), center.Y - (int)((image.Height * scale) / 2.0), (int)(image.Width * scale), (int)(image.Height * scale));
            //g.DrawImage(image, center.X - (int)((image.Width * scale) / 2.0), center.Y - (int)((image.Height * scale) / 2.0), center.X + (int)((image.Width * scale) / 2.0), center.Y + (int)((image.Height * scale) / 2.0));
            image.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;

        }
    }
}
