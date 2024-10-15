using System.Reflection.Metadata;

namespace Chasing_game
{
    public partial class Form1 : Form
    {
        List<PictureBox> RedBulls;
        Player player;
        Chaser chaser;
        int score = 0;
        Item item = new Item();
        bool isHit = false;

        public Form1()
        {
            InitializeComponent();
            player = new Player(play, ClientRectangle);
            chaser = new Chaser(chase, ClientRectangle);
            RedBulls = new List<PictureBox>();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            player.SetSpeed(e.KeyCode);
            chaser.SetSpeed(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                player.Stop();
            }
            else if(e.KeyCode == Keys.S || e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                chaser.Stop();
            }
                
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            player.Update();
            chaser.Update();
            for (int i = 0; i < RedBulls.Count; i++)
            {
                if (play.Bounds.IntersectsWith(RedBulls[i].Bounds))
                {
                    RedBulls[i].Hide();
                    RedBulls.RemoveAt(i);
                    player.speed++;
                }
            }
            if (play.Bounds.IntersectsWith(chase.Bounds))
            {
                player.speed -= 3;
                score--;
                isHit = true;
                if(isHit)
                {
                    score -= 0;
                }
                if(score < 0)
                {
                    Close();
                }
            }

        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            score++;
            scored.Text = $"{score}";
            PictureBox picture = item.CreateRandom(this);
            RedBulls.Add(picture);

        }

        private void ChaserMove_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
