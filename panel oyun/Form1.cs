using System.Reflection.Emit;

namespace Panel_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        Random g = new Random();
        Random b = new Random();

        Random xL = new Random();
        Random yL = new Random();

        int count = 0;

        bool oyunBitdi = false;

        List<Panel> paneller = new List<Panel>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // PANEL YARAT
        private void button1_Click(object sender, EventArgs e)
        {
            if (oyunBitdi)
                return;

            count++;
            label2.Text = count.ToString();

            Panel p = new Panel();

            p.Size = new Size(60, 60);

            p.Location = new Point(
                xL.Next(0, Math.Max(1, ClientSize.Width - 60)),
                yL.Next(0, Math.Max(1, panel1.Top - 60))
            );

            p.BackColor = Color.FromArgb(
                r.Next(0, 256),
                g.Next(0, 256),
                b.Next(0, 256)
            );

            this.Controls.Add(p);

            p.BringToFront();

            pictureBox1.BringToFront();
            panel1.BringToFront();

            paneller.Add(p);

            // BOMBA İLƏ TOQQUŞMA
            if (p.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                oyunBitdi = true;

                MessageBox.Show(
                    "Oyun bitdi!",
                    "Panel oyunu",
                    MessageBoxButtons.OK
                );

                YeniOyun();
            }
        }

        // BOMBANIN YERİNİ DƏYİŞ
        private void button2_Click(object sender, EventArgs e)
        {
            if (oyunBitdi)
                return;

            pictureBox1.Location = new Point(
                xL.Next(0, Math.Max(1, ClientSize.Width - pictureBox1.Width)),
                yL.Next(0, Math.Max(1, panel1.Top - pictureBox1.Height))
            );

            pictureBox1.BringToFront();
        }

        // ÇIXIŞ
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // YENİ OYUN
        private void YeniOyun()
        {
            foreach (Panel p in paneller)
            {
                this.Controls.Remove(p);
                p.Dispose();
            }

            paneller.Clear();

            count = 0;

            label2.Text = "0";

            pictureBox1.Location = new Point(
                xL.Next(0, Math.Max(1, ClientSize.Width - pictureBox1.Width)),
                yL.Next(0, Math.Max(1, panel1.Top - pictureBox1.Height))
            );

            oyunBitdi = false;
        }
    }
}