using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    internal class Jogo
    {
        public Keys Direcao { get; set; }

        public Keys Flecha { get; set; }

        private Timer Frame { get; set; }
        private Label lblPontos { get; set; }
        private Panel pnTela { get; set; }

        private int pontos = 0;

        private Comida Comida;

        private Snake Snake;

        private Bitmap offScreenBitmap;

        private Graphics bitmapGraph;

        private Graphics screenGraph;

        public Jogo (ref Timer timer , ref Label label , ref Panel panel)
        {
            pnTela = panel;
            Frame = timer;
            lblPontos = label;
            offScreenBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Comida = new Comida();
            Direcao = Keys.Left;
            Flecha = Direcao;
        }

        public void StartGame()
        {
            Snake.Restarte();
            Comida.CriarComida();
            Direcao = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = pnTela.CreateGraphics();
            Frame.Enabled = true;
        }

        public void Tick()
        {
            if( ((Flecha == Keys.Left) && ( Direcao != Keys.Right)) ||
            ((Flecha == Keys.Right) && (Direcao != Keys.Left)) ||
            ((Flecha == Keys.Up) && (Direcao != Keys.Down)) ||
            ((Flecha == Keys.Down) && (Direcao != Keys.Up)))
            {
                Direcao = Flecha;
            }

            switch (Direcao)
            {
                case Keys.Left:
                    Snake.Esquerda();
                    break;
                case Keys.Right:
                    Snake.Direita();
                    break;
                case Keys.Up:
                    Snake.Cima();
                    break;
                case Keys.Down:
                    Snake.Baixo();
                    break;


            }

            bitmapGraph.Clear(Color.White);

            bitmapGraph.DrawImage(Properties.Resources.maça, (Comida.Location.X * 15), (Comida.Location.Y * 15), 15, 15);

            bool gameOver = false;

            for (int i = 0; i < Snake.Comprimento; i++)
            {
                if(i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#000000")), (Snake.Localizaçao[i].X * 15), (Snake.Localizaçao[i].Y *15),15,15);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#4F4F4F")), (Snake.Localizaçao[i].X * 15), (Snake.Localizaçao[i].Y * 15), 15, 15);
                }


                if((Snake.Localizaçao[i] == Snake.Localizaçao[0]) && (i > 0))
                {
                    gameOver = true;
                }

            }

            screenGraph.DrawImage(offScreenBitmap, 0,0);
            CheckCollision();
            if (gameOver)
            {
                GameOver();
            }
        }

        public void CheckCollision()
        {
            if (Snake.Localizaçao[0] == Comida.Location)
            {
                Snake.Comer();
                Comida.CriarComida();
                pontos += 10;
                lblPontos.Text = "PONTOS :" + pontos;
            }
        }

        
        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            lblPontos.Text = "PONTOS: 0";
            MessageBox.Show("Game Over");
        }




        
    }
}
