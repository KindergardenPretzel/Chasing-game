using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chasing_game
{
    internal class Player
    {
        public uint speed = 0;
        PictureBox box = new PictureBox();
        Rectangle Form;
        int speedX = 0;
        int speedY = 0;
        public Player(PictureBox box, Rectangle Form)
        {
            this.box = box;
            this.Form = Form;
        }
        public void Stop()
        {
            speedX = 0;
            speedY = 0;
        }
        public void SetSpeed(Keys KeyDown)
        {
            if (box.Location.Y + box.Height < Form.Height)
            {
                if (KeyDown == Keys.Down)
                {
                    speedY = 15 + (int)speed;
                }
            }
            if (box.Location.Y > 0)
            {
                if (KeyDown == Keys.Up)
                {
                    speedY = -15 - (int)speed;
                }
            }
            if (box.Location.X > 0)
            {
                if (KeyDown == Keys.Left)
                {
                    speedX = -15 - (int)speed;
                }
            }
            if (box.Location.X + box.Width < Form.Width)
            {
                if (KeyDown == Keys.Right)
                {
                    speedX = 15 + (int)speed;
                }
            }
        }
        public void Update()
        {
            box.Location = new Point(box.Location.X + speedX, box.Location.Y + speedY);
            if (box.Location.Y <= 0)
            {

                Stop();
       

            }
            if (box.Location.X <= 0)
            {
                Stop();
            }
            if (box.Location.Y + box.Height >= Form.Height)
            {
                Stop();

            }
            if (box.Location.X + box.Width >= Form.Width)
            {
                Stop();
            }
        }
    }
}
