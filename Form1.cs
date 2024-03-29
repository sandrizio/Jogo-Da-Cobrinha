﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        Jogo jogo;
        public Form1()
        {
            InitializeComponent();
            jogo = new Jogo(ref Frame, ref lblPontos, ref pnTela);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jogo.StartGame();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            jogo.Tick();

        }

        private void Clicado(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                jogo.Flecha = e.KeyCode;
            }
        }
    }
}
