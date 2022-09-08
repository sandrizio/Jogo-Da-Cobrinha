using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Snake
    {
        public int Comprimento { get; private set; }

        public Point[] Localizaçao { get; private set; }

        public Snake()
        {
            Localizaçao = new Point[28 * 28];
            Restarte();
        }

        public void Restarte ()
        {
            Comprimento = 5;
            for(int i =0; i < Comprimento; i++)
            {
                Localizaçao[i].X = 12;
                    Localizaçao[i].Y = 12;
            }
        }

        public void Seguir()
        {
            for (int i = Comprimento -1; i > 0; i--)
            {
                Localizaçao[i] = Localizaçao[i - 1];
            }
        }

        public void Cima() 
        {
            Seguir();
            Localizaçao[0].Y--;
            if (Localizaçao[0].Y < 0)
            {
                Localizaçao[0].Y += 28;
            }
        }
        public void Baixo() 
        {
            Seguir();
            Localizaçao[0].Y++;
            if (Localizaçao[0].Y > 27)
            {
                Localizaçao[0].Y -= 28;
            }
        }
        public void Esquerda() 
        {
            Seguir();
            Localizaçao[0].X--;
            if (Localizaçao[0].X < 0)
            {
                Localizaçao[0].X += 28;
            }
        }
        public void Direita() 
        {
            Seguir();
            Localizaçao[0].X++;
            if (Localizaçao[0].X > 27)
            {
                Localizaçao[0].X -= 28;
            }
        }

        public void Comer ()
        {
            Comprimento++;
        }

    }
}
