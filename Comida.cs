using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Comida
    {
        public Point Location { get; private set; }

        public void CriarComida()
        {
            Random rnd = new Random();
            Location = new Point(rnd.Next(0,23), rnd.Next(0, 23));
        }
    }
}
