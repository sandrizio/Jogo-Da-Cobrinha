namespace Snake_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnTela = new System.Windows.Forms.Panel();
            this.lblPontos = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTela
            // 
            this.pnTela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTela.Location = new System.Drawing.Point(7, 66);
            this.pnTela.Name = "pnTela";
            this.pnTela.Size = new System.Drawing.Size(428, 428);
            this.pnTela.TabIndex = 0;
            // 
            // lblPontos
            // 
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(8, 26);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(427, 37);
            this.lblPontos.TabIndex = 0;
            this.lblPontos.Text = "Pontos : 0";
            this.lblPontos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(441, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarJogoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // iniciarJogoToolStripMenuItem
            // 
            this.iniciarJogoToolStripMenuItem.Name = "iniciarJogoToolStripMenuItem";
            this.iniciarJogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarJogoToolStripMenuItem.Text = "Iniciar Jogo";
            this.iniciarJogoToolStripMenuItem.Click += new System.EventHandler(this.iniciarJogoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 498);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.pnTela);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicado);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTela;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer Frame;
    }
}

