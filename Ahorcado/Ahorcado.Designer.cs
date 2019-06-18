namespace Ahorcado
{
    partial class Ahorcado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flPalabras = new System.Windows.Forms.FlowLayoutPanel();
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picAhorcadoFeliz = new System.Windows.Forms.PictureBox();
            this.picAhorcadoTrizte = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcadoFeliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcadoTrizte)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPalabras
            // 
            this.flPalabras.BackColor = System.Drawing.Color.Transparent;
            this.flPalabras.Location = new System.Drawing.Point(110, 427);
            this.flPalabras.Name = "flPalabras";
            this.flPalabras.Size = new System.Drawing.Size(529, 86);
            this.flPalabras.TabIndex = 0;
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.BackColor = System.Drawing.Color.Transparent;
            this.flFichasDeJuego.Location = new System.Drawing.Point(11, 147);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(447, 300);
            this.flFichasDeJuego.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Green;
            this.lblMensaje.Location = new System.Drawing.Point(494, 163);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(188, 26);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "OPORTUNIDADES:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(678, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(464, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "----->INICIAR JUEGO<-----";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(464, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // picAhorcadoFeliz
            // 
            this.picAhorcadoFeliz.Image = global::Ahorcado.Properties.Resources.feliz;
            this.picAhorcadoFeliz.Location = new System.Drawing.Point(464, 158);
            this.picAhorcadoFeliz.Name = "picAhorcadoFeliz";
            this.picAhorcadoFeliz.Size = new System.Drawing.Size(300, 284);
            this.picAhorcadoFeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcadoFeliz.TabIndex = 6;
            this.picAhorcadoFeliz.TabStop = false;
            // 
            // picAhorcadoTrizte
            // 
            this.picAhorcadoTrizte.Image = global::Ahorcado.Properties.Resources.trizte;
            this.picAhorcadoTrizte.Location = new System.Drawing.Point(489, 205);
            this.picAhorcadoTrizte.Name = "picAhorcadoTrizte";
            this.picAhorcadoTrizte.Size = new System.Drawing.Size(234, 234);
            this.picAhorcadoTrizte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcadoTrizte.TabIndex = 5;
            this.picAhorcadoTrizte.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 6);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(416, 65);
            this.lblTexto.TabIndex = 10;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Location = new System.Drawing.Point(11, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 80);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(753, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "titulo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flPalabras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flFichasDeJuego);
            this.Controls.Add(this.picAhorcadoTrizte);
            this.Controls.Add(this.picAhorcadoFeliz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ahorcado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ahorcado_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcadoFeliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcadoTrizte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPalabras;
        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox picAhorcadoTrizte;
        private System.Windows.Forms.PictureBox picAhorcadoFeliz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

