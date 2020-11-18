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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pctbCarrito.BackgroundImage = global::Proyecto_Final_BD.Properties.Resources.Carrito;
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
            this.grvPrincipal.Location = new System.Drawing.Point(238, 69);
            this.grvPrincipal.Name = "grvPrincipal";
            this.grvPrincipal.Size = new System.Drawing.Size(741, 289);
            this.grvPrincipal.TabIndex = 1;
            this.grvPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPrincipal_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 289);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_Final_BD.Properties.Resources.Usuario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final_BD.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvPrincipal);
            this.Controls.Add(this.pnlBotones);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.DataGridView grvPrincipal;
        private System.Windows.Forms.PictureBox pctbCarrito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}