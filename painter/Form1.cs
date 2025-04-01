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
        int x, y;//�����ƹ���m
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

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gray;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Pink;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gold;
        }

        private void �e����mToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Silver;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            g.Clear(Color.White);
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void �`��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.DarkGreen;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 80;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 40;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 50;
        }

        private void �W�ť����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1000;
        }

        private void �W�Ų�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 500;
        }

        private void �W��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 250;
        }

        private void �IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void �D�`��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 150;
        }

        private void �ܲ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 100;
        }

        private void ���u��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void �ܲ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 30;
        }

        private void �D�`��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 20;
        }

        private void �W��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void �W�Ų�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void �W�ť����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;
        }

        private void ���uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void �x�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("�s�ɦ��\");
            }
            catch
            {

            }
            MessageBox.Show("�s�ɥ���");

        }

        private void �`��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.DarkBlue;
        }

        private void ����uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            p.DashPattern = new float[] { 6.0F, 3.0F };
        }

        private void �L��ToolStripMenuItem_Click(object sender, EventArgs e)
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