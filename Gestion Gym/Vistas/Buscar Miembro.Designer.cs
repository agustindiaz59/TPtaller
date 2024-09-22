namespace Gestion_Gym
{
    partial class Buscar_Miembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Miembro));
            this.panelRedondo1 = new Gestion_Gym.ComponentesRJ.PanelRedondo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRedondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRedondo1
            // 
            this.panelRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.panelRedondo1.BorderColor = System.Drawing.Color.Transparent;
            this.panelRedondo1.BorderWidth = 1;
            this.panelRedondo1.Controls.Add(this.label1);
            this.panelRedondo1.Controls.Add(this.btnBuscar);
            this.panelRedondo1.Controls.Add(this.txtBuscar);
            this.panelRedondo1.Location = new System.Drawing.Point(41, 69);
            this.panelRedondo1.Name = "panelRedondo1";
            this.panelRedondo1.Radio = 25;
            this.panelRedondo1.Size = new System.Drawing.Size(276, 168);
            this.panelRedondo1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(26, 77);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(220, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Location = new System.Drawing.Point(138, 45);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(108, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 464);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar_Miembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.panelRedondo1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Buscar_Miembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Miembro";
            this.Load += new System.EventHandler(this.Buscar_Miembro_Load);
            this.panelRedondo1.ResumeLayout(false);
            this.panelRedondo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentesRJ.PanelRedondo panelRedondo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}