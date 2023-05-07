
namespace Jokenpo
{
    partial class fmrJoken
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
            this.rbPedra = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.rbTesoura = new System.Windows.Forms.RadioButton();
            this.pbxImageJogador = new System.Windows.Forms.PictureBox();
            this.pbximageCpu = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblPontoJogador = new System.Windows.Forms.Label();
            this.lblPontoCPU = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximageCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPedra
            // 
            this.rbPedra.AutoSize = true;
            this.rbPedra.BackColor = System.Drawing.Color.White;
            this.rbPedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPedra.Location = new System.Drawing.Point(10, 158);
            this.rbPedra.Name = "rbPedra";
            this.rbPedra.Size = new System.Drawing.Size(74, 24);
            this.rbPedra.TabIndex = 0;
            this.rbPedra.TabStop = true;
            this.rbPedra.Text = "Pedra";
            this.rbPedra.UseVisualStyleBackColor = false;
            this.rbPedra.CheckedChanged += new System.EventHandler(this.rbPedra_CheckedChanged);
            // 
            // rbPapel
            // 
            this.rbPapel.AutoSize = true;
            this.rbPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPapel.Location = new System.Drawing.Point(12, 222);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(72, 24);
            this.rbPapel.TabIndex = 1;
            this.rbPapel.TabStop = true;
            this.rbPapel.Text = "Papel";
            this.rbPapel.UseVisualStyleBackColor = true;
            this.rbPapel.CheckedChanged += new System.EventHandler(this.rbPapel_CheckedChanged);
            // 
            // rbTesoura
            // 
            this.rbTesoura.AutoSize = true;
            this.rbTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTesoura.Location = new System.Drawing.Point(12, 288);
            this.rbTesoura.Name = "rbTesoura";
            this.rbTesoura.Size = new System.Drawing.Size(92, 24);
            this.rbTesoura.TabIndex = 2;
            this.rbTesoura.TabStop = true;
            this.rbTesoura.Text = "Tesoura";
            this.rbTesoura.UseVisualStyleBackColor = true;
            this.rbTesoura.CheckedChanged += new System.EventHandler(this.rbTesoura_CheckedChanged);
            // 
            // pbxImageJogador
            // 
            this.pbxImageJogador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxImageJogador.ErrorImage = null;
            this.pbxImageJogador.InitialImage = global::Jokenpo.Properties.Resources.pedra1;
            this.pbxImageJogador.Location = new System.Drawing.Point(172, 93);
            this.pbxImageJogador.Name = "pbxImageJogador";
            this.pbxImageJogador.Size = new System.Drawing.Size(208, 245);
            this.pbxImageJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageJogador.TabIndex = 3;
            this.pbxImageJogador.TabStop = false;
            this.pbxImageJogador.Click += new System.EventHandler(this.pbxImageJogador_Click);
            // 
            // pbximageCpu
            // 
            this.pbximageCpu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbximageCpu.ErrorImage = global::Jokenpo.Properties.Resources.pedra1;
            this.pbximageCpu.InitialImage = global::Jokenpo.Properties.Resources.tesoura;
            this.pbximageCpu.Location = new System.Drawing.Point(572, 93);
            this.pbximageCpu.Name = "pbximageCpu";
            this.pbximageCpu.Size = new System.Drawing.Size(215, 254);
            this.pbximageCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbximageCpu.TabIndex = 4;
            this.pbximageCpu.TabStop = false;
            this.pbximageCpu.Click += new System.EventHandler(this.pbximageCpu_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.White;
            this.btnJogar.BackgroundImage = global::Jokenpo.Properties.Resources.start;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJogar.Font = new System.Drawing.Font("Geometr415 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Location = new System.Drawing.Point(395, 192);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(0);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(161, 89);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblPontoJogador
            // 
            this.lblPontoJogador.AutoSize = true;
            this.lblPontoJogador.Location = new System.Drawing.Point(259, 26);
            this.lblPontoJogador.Name = "lblPontoJogador";
            this.lblPontoJogador.Size = new System.Drawing.Size(0, 18);
            this.lblPontoJogador.TabIndex = 6;
            this.lblPontoJogador.Click += new System.EventHandler(this.lblPontoJogador_Click);
            // 
            // lblPontoCPU
            // 
            this.lblPontoCPU.AutoSize = true;
            this.lblPontoCPU.Location = new System.Drawing.Point(673, 26);
            this.lblPontoCPU.Name = "lblPontoCPU";
            this.lblPontoCPU.Size = new System.Drawing.Size(0, 18);
            this.lblPontoCPU.TabIndex = 7;
            this.lblPontoCPU.Click += new System.EventHandler(this.lblPontoCPU_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::Jokenpo.Properties.Resources.finish;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(685, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 95);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Regras : Caso de Empate Ponto vai para os Dois                \r\n                 " +
    "    E Ganha quem Não Perde !\r\n";
            // 
            // fmrJoken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jokenpo.Properties.Resources.backJoken;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblPontoCPU);
            this.Controls.Add(this.lblPontoJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pbximageCpu);
            this.Controls.Add(this.pbxImageJogador);
            this.Controls.Add(this.rbTesoura);
            this.Controls.Add(this.rbPapel);
            this.Controls.Add(this.rbPedra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrJoken";
            this.Text = "Ju Ken Poe";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximageCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPedra;
        private System.Windows.Forms.RadioButton rbPapel;
        private System.Windows.Forms.RadioButton rbTesoura;
        private System.Windows.Forms.PictureBox pbximageCpu;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblPontoJogador;
        private System.Windows.Forms.Label lblPontoCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxImageJogador;
    }
}

