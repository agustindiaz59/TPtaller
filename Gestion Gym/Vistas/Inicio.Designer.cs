namespace Gestion_Gym
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRedondo1 = new System.Windows.Forms.Panel();
            this.menuvertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btmenu = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.salirbtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nuevo2btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iniciobtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nuevo1btn = new System.Windows.Forms.Button();
            this.sidebardtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuvertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmenu)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.panelRedondo1);
            this.panel1.Controls.Add(this.menuvertical);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1050);
            this.panel1.TabIndex = 2;
            // 
            // panelRedondo1
            // 
            this.panelRedondo1.BackColor = System.Drawing.Color.Black;
            this.panelRedondo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRedondo1.Location = new System.Drawing.Point(99, 0);
            this.panelRedondo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRedondo1.Name = "panelRedondo1";
            this.panelRedondo1.Size = new System.Drawing.Size(1825, 1050);
            this.panelRedondo1.TabIndex = 4;
            this.panelRedondo1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRedondo1_Paint);
            // 
            // menuvertical
            // 
            this.menuvertical.BackColor = System.Drawing.Color.White;
            this.menuvertical.Controls.Add(this.label1);
            this.menuvertical.Controls.Add(this.btmenu);
            this.menuvertical.Controls.Add(this.panel5);
            this.menuvertical.Controls.Add(this.panel7);
            this.menuvertical.Controls.Add(this.panel6);
            this.menuvertical.Controls.Add(this.panel2);
            this.menuvertical.Controls.Add(this.panel4);
            this.menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuvertical.Location = new System.Drawing.Point(0, 0);
            this.menuvertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuvertical.MaximumSize = new System.Drawing.Size(378, 0);
            this.menuvertical.MinimumSize = new System.Drawing.Size(99, 0);
            this.menuvertical.Name = "menuvertical";
            this.menuvertical.Size = new System.Drawing.Size(99, 1050);
            this.menuvertical.TabIndex = 3;
            this.menuvertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuvertical_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btmenu
            // 
            this.btmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmenu.Image = ((System.Drawing.Image)(resources.GetObject("btmenu.Image")));
            this.btmenu.Location = new System.Drawing.Point(18, 35);
            this.btmenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(66, 80);
            this.btmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmenu.TabIndex = 0;
            this.btmenu.TabStop = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.salirbtn);
            this.panel5.Location = new System.Drawing.Point(0, 517);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 91);
            this.panel5.TabIndex = 5;
            // 
            // salirbtn
            // 
            this.salirbtn.FlatAppearance.BorderSize = 0;
            this.salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salirbtn.Image = ((System.Drawing.Image)(resources.GetObject("salirbtn.Image")));
            this.salirbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirbtn.Location = new System.Drawing.Point(0, 0);
            this.salirbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.salirbtn.Size = new System.Drawing.Size(375, 91);
            this.salirbtn.TabIndex = 1;
            this.salirbtn.Text = "             Salir";
            this.salirbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirbtn.UseVisualStyleBackColor = true;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buscarbtn);
            this.panel7.Location = new System.Drawing.Point(0, 428);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 91);
            this.panel7.TabIndex = 4;
            // 
            // buscarbtn
            // 
            this.buscarbtn.FlatAppearance.BorderSize = 0;
            this.buscarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buscarbtn.Image = ((System.Drawing.Image)(resources.GetObject("buscarbtn.Image")));
            this.buscarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarbtn.Location = new System.Drawing.Point(0, 0);
            this.buscarbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buscarbtn.Size = new System.Drawing.Size(375, 91);
            this.buscarbtn.TabIndex = 1;
            this.buscarbtn.Text = "             Buscar Miembros";
            this.buscarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nuevo2btn);
            this.panel6.Location = new System.Drawing.Point(0, 338);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 91);
            this.panel6.TabIndex = 3;
            // 
            // nuevo2btn
            // 
            this.nuevo2btn.FlatAppearance.BorderSize = 0;
            this.nuevo2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo2btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nuevo2btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevo2btn.Image")));
            this.nuevo2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo2btn.Location = new System.Drawing.Point(0, 0);
            this.nuevo2btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuevo2btn.Name = "nuevo2btn";
            this.nuevo2btn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.nuevo2btn.Size = new System.Drawing.Size(375, 91);
            this.nuevo2btn.TabIndex = 1;
            this.nuevo2btn.Text = "             Nuevo Personal";
            this.nuevo2btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo2btn.UseVisualStyleBackColor = true;
            this.nuevo2btn.Click += new System.EventHandler(this.nuevo2btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iniciobtn);
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 91);
            this.panel2.TabIndex = 0;
            // 
            // iniciobtn
            // 
            this.iniciobtn.FlatAppearance.BorderSize = 0;
            this.iniciobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciobtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iniciobtn.Image = ((System.Drawing.Image)(resources.GetObject("iniciobtn.Image")));
            this.iniciobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iniciobtn.Location = new System.Drawing.Point(0, 0);
            this.iniciobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iniciobtn.Name = "iniciobtn";
            this.iniciobtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.iniciobtn.Size = new System.Drawing.Size(375, 91);
            this.iniciobtn.TabIndex = 1;
            this.iniciobtn.Text = "             Inicio";
            this.iniciobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iniciobtn.UseVisualStyleBackColor = true;
            this.iniciobtn.Click += new System.EventHandler(this.iniciobtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nuevo1btn);
            this.panel4.Location = new System.Drawing.Point(0, 249);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 91);
            this.panel4.TabIndex = 1;
            // 
            // nuevo1btn
            // 
            this.nuevo1btn.FlatAppearance.BorderSize = 0;
            this.nuevo1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo1btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nuevo1btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevo1btn.Image")));
            this.nuevo1btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo1btn.Location = new System.Drawing.Point(0, 0);
            this.nuevo1btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuevo1btn.Name = "nuevo1btn";
            this.nuevo1btn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.nuevo1btn.Size = new System.Drawing.Size(375, 91);
            this.nuevo1btn.TabIndex = 1;
            this.nuevo1btn.Text = "             Nuevo MIembro";
            this.nuevo1btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo1btn.UseVisualStyleBackColor = true;
            this.nuevo1btn.Click += new System.EventHandler(this.nuevo1btn_Click);
            // 
            // sidebardtimer
            // 
            this.sidebardtimer.Interval = 5;
            this.sidebardtimer.Tick += new System.EventHandler(this.sidebard_tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.menuvertical.ResumeLayout(false);
            this.menuvertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmenu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuvertical;
        private System.Windows.Forms.PictureBox btmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button iniciobtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button nuevo2btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button nuevo1btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button salirbtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Panel panelRedondo1;
        private System.Windows.Forms.Timer sidebardtimer;
        private System.Windows.Forms.Label label1;
    }
}

