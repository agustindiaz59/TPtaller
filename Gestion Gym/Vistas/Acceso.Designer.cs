namespace Gestion_Gym.Vistas
{
    partial class Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.panelRedondo1 = new Gestion_Gym.ComponentesRJ.PanelRedondo();
            this.panelRedondo3 = new Gestion_Gym.ComponentesRJ.PanelRedondo();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRedondo2 = new Gestion_Gym.ComponentesRJ.PanelRedondo();
            this.panelRedondo1.SuspendLayout();
            this.panelRedondo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRedondo1
            // 
            this.panelRedondo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRedondo1.BackColor = System.Drawing.Color.Azure;
            this.panelRedondo1.BorderColor = System.Drawing.Color.Transparent;
            this.panelRedondo1.BorderWidth = 1;
            this.panelRedondo1.Controls.Add(this.btnIniciarSesion);
            this.panelRedondo1.Controls.Add(this.txtBoxContraseña);
            this.panelRedondo1.Controls.Add(this.txtBoxUsuario);
            this.panelRedondo1.Controls.Add(this.label2);
            this.panelRedondo1.Controls.Add(this.label1);
            this.panelRedondo1.Controls.Add(this.panelRedondo2);
            this.panelRedondo1.Location = new System.Drawing.Point(245, 51);
            this.panelRedondo1.Name = "panelRedondo1";
            this.panelRedondo1.Radio = 25;
            this.panelRedondo1.Size = new System.Drawing.Size(579, 399);
            this.panelRedondo1.TabIndex = 52;
            // 
            // panelRedondo3
            // 
            this.panelRedondo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRedondo3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelRedondo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelRedondo3.BorderColor = System.Drawing.Color.SeaGreen;
            this.panelRedondo3.BorderWidth = 5;
            this.panelRedondo3.Controls.Add(this.label11);
            this.panelRedondo3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRedondo3.Location = new System.Drawing.Point(411, 12);
            this.panelRedondo3.Name = "panelRedondo3";
            this.panelRedondo3.Radio = 20;
            this.panelRedondo3.Size = new System.Drawing.Size(201, 55);
            this.panelRedondo3.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Iniciar Sesion";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(156, 244);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(225, 46);
            this.btnIniciarSesion.TabIndex = 53;
            this.btnIniciarSesion.Text = "Iniciar";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxContraseña.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContraseña.Location = new System.Drawing.Point(156, 184);
            this.txtBoxContraseña.MaxLength = 255;
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '*';
            this.txtBoxContraseña.Size = new System.Drawing.Size(225, 22);
            this.txtBoxContraseña.TabIndex = 52;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.Location = new System.Drawing.Point(156, 96);
            this.txtBoxUsuario.MaxLength = 255;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(225, 22);
            this.txtBoxUsuario.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Usuario";
            // 
            // panelRedondo2
            // 
            this.panelRedondo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRedondo2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelRedondo2.BorderColor = System.Drawing.Color.Transparent;
            this.panelRedondo2.BorderWidth = 1;
            this.panelRedondo2.Location = new System.Drawing.Point(271, 0);
            this.panelRedondo2.Name = "panelRedondo2";
            this.panelRedondo2.Radio = 1;
            this.panelRedondo2.Size = new System.Drawing.Size(308, 399);
            this.panelRedondo2.TabIndex = 49;
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.panelRedondo3);
            this.Controls.Add(this.panelRedondo1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelRedondo1.ResumeLayout(false);
            this.panelRedondo1.PerformLayout();
            this.panelRedondo3.ResumeLayout(false);
            this.panelRedondo3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentesRJ.PanelRedondo panelRedondo1;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private ComponentesRJ.PanelRedondo panelRedondo2;
        private ComponentesRJ.PanelRedondo panelRedondo3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}