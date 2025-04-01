using System.Drawing.Imaging;

namespace painter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            g.Clear(Color.White);

        }

        bool wipe = false;
        Pen p = new Pen(Color.Black, 3);
        int x, y;//紀錄滑鼠位置
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (wipe)
                {
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    p.Color = pictureBox1.BackColor;

                    g.DrawLine(p, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Refresh();
                }
                else
                {
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    p.Color = Color.Black;

                    g.DrawLine(p, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Refresh();
                }


            }
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void 灰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gray;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void 黃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void 粉紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Pink;
        }

        private void 金ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gold;
        }

        private void 畫筆色彩ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 銀ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Silver;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            g.Clear(Color.White);
        }

        private void 白ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void 紫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void 橘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void 深綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.DarkGreen;
        }

        private void 粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 80;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 40;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 50;
        }

        private void 超級平方粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1000;
        }

        private void 超級粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 500;
        }

        private void 超粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 250;
        }

        private void 點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 非常粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 150;
        }

        private void 很粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 100;
        }

        private void 長短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 很細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 30;
        }

        private void 非常細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 20;
        }

        private void 超細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void 超級細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void 超級平方細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("存檔成功");
            }
            catch
            {

            }
            MessageBox.Show("存檔失敗");

        }

        private void 深藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.DarkBlue;
        }

        private void 長虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            p.DashPattern = new float[] { 6.0F, 3.0F };
        }

        private void 淺藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Brown;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            wipe = true;



        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            p.Width = 10000;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            p.Width = 5000;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            p.Width = 7500;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            p.Width = 2500;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            p.Width = 50000;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            p.Width = 100000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wipe = false;
        }
    }
}