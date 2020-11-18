namespace Proyecto_Final_BD
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pctbCarrito = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.grvPrincipal = new System.Windows.Forms.DataGridView();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.DimGray;
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Controls.Add(this.pctbCarrito);
            this.pnlBotones.Controls.Add(this.btnRegistrar);
            this.pnlBotones.Controls.Add(this.btnIniciarSesion);
            this.pnlBotones.Location = new System.Drawing.Point(12, 12);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(970, 35);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(821, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pctbCarrito
            // 
            this.pctbCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbCarrito.Location = new System.Drawing.Point(917, 3);
            this.pctbCarrito.Name = "pctbCarrito";
            this.pctbCarrito.Size = new System.Drawing.Size(36, 30);
            this.pctbCarrito.TabIndex = 2;
            this.pctbCarrito.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(107, 9);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(3, 9);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(98, 23);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // grvPrincipal
            // 
            this.grvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPrincipal.Location = new System.Drawing.Point(119, 71);
            this.grvPrincipal.Name = "grvPrincipal";
            this.grvPrincipal.Size = new System.Drawing.Size(741, 289);
            this.grvPrincipal.TabIndex = 1;
            this.grvPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPrincipal_CellContentClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 391);
            this.Controls.Add(this.grvPrincipal);
            this.Controls.Add(this.pnlBotones);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.DataGridView grvPrincipal;
        private System.Windows.Forms.PictureBox pctbCarrito;
        private System.Windows.Forms.Button btnCerrar;
    }
}