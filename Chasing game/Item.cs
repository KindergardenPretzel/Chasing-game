using Chasing_game.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chasing_game
{
    internal class Item
    {
        Random randomNum = new Random();
        
        public PictureBox CreateRandom(Form1 form)
        {
            int Xvalue = randomNum.Next(form.Width);
            int Yvalue = randomNum.Next(form.Height);
            PictureBox picture = new PictureBox();
            picture.Size = new Size(50, 50);
            picture.Image = Properties.Resources.red_bull;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(Xvalue, Yvalue);
            form.Controls.Add(picture);
            return picture;
        }
    }
}
