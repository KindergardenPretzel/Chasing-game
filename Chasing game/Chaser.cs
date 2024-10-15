using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chasing_game
{
    internal class Chaser
    {
        PictureBox box = new PictureBox();
        Rectangle Form;
        int speedX = 0;
        int speedY = 0;
        public Chaser(PictureBox box, Rectangle Form)
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
                if (KeyDown == Keys.S)
                {
                    speedY = 15;
                }
            }
            if (box.Location.Y > 0)
            {
                if (KeyDown == Keys.W)
                {
                    speedY = -15;
                }
            }
            if (box.Location.X > 0)
            {
                if (KeyDown == Keys.A)
                {
                    speedX = -15;
                }
            }
            if (box.Location.X + box.Width < Form.Width)
            {
                if (KeyDown == Keys.D)
                {
                    speedX = 15;
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
