using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    partial class DashboardModerno
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelListas = new System.Windows.Forms.TableLayoutPanel();
            this.lblActivosTitulo = new System.Windows.Forms.Label();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.lblInactivosTitulo = new System.Windows.Forms.Label();
            this.dgvInactivos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.lblValor4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.panelTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactivos)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTarjetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTarjetas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelListas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelListas
            // 
            this.panelListas.ColumnCount = 1;
            this.panelListas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelListas.Controls.Add(this.lblActivosTitulo, 0, 0);
            this.panelListas.Controls.Add(this.dgvActivos, 0, 1);
            this.panelListas.Controls.Add(this.lblInactivosTitulo, 0, 2);
            this.panelListas.Controls.Add(this.dgvInactivos, 0, 3);
            this.panelListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListas.Location = new System.Drawing.Point(3, 253);
            this.panelListas.Name = "panelListas";
            this.panelListas.RowCount = 4;
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelListas.Size = new System.Drawing.Size(1178, 505);
            this.panelListas.TabIndex = 1;
            // 
            // lblActivosTitulo
            // 
            this.lblActivosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblActivosTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivosTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblActivosTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblActivosTitulo.Name = "lblActivosTitulo";
            this.lblActivosTitulo.Size = new System.Drawing.Size(1172, 40);
            this.lblActivosTitulo.TabIndex = 0;
            this.lblActivosTitulo.Text = "Miembros Activos";
            this.lblActivosTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvActivos
            // 
            this.dgvActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivos.Location = new System.Drawing.Point(3, 43);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.RowHeadersVisible = false;
            this.dgvActivos.Size = new System.Drawing.Size(1172, 206);
            this.dgvActivos.TabIndex = 1;
            // 
            // lblInactivosTitulo
            // 
            this.lblInactivosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInactivosTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInactivosTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInactivosTitulo.Location = new System.Drawing.Point(3, 252);
            this.lblInactivosTitulo.Name = "lblInactivosTitulo";
            this.lblInactivosTitulo.Size = new System.Drawing.Size(1172, 40);
            this.lblInactivosTitulo.TabIndex = 2;
            this.lblInactivosTitulo.Text = "Miembros Inactivos";
            this.lblInactivosTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInactivos
            // 
            this.dgvInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInactivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInactivos.Location = new System.Drawing.Point(3, 295);
            this.dgvInactivos.Name = "dgvInactivos";
            this.dgvInactivos.RowHeadersVisible = false;
            this.dgvInactivos.Size = new System.Drawing.Size(1172, 207);
            this.dgvInactivos.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel4.Controls.Add(this.lblValor4);
            this.panel4.Controls.Add(this.lblTitulo4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(892, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 224);
            this.panel4.TabIndex = 3;
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.BackColor = System.Drawing.Color.Salmon;
            this.lblTitulo4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblTitulo4.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(276, 23);
            this.lblTitulo4.TabIndex = 1;
            this.lblTitulo4.Text = "Nuevos del Mes";
            this.lblTitulo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor4
            // 
            this.lblValor4.BackColor = System.Drawing.Color.MistyRose;
            this.lblValor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor4.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblValor4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblValor4.Location = new System.Drawing.Point(0, 23);
            this.lblValor4.Name = "lblValor4";
            this.lblValor4.Size = new System.Drawing.Size(276, 201);
            this.lblValor4.TabIndex = 0;
            this.lblValor4.Text = "3";
            this.lblValor4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.lblValor3);
            this.panel3.Controls.Add(this.lblTitulo3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(598, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 224);
            this.panel3.TabIndex = 2;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblTitulo3.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(274, 23);
            this.lblTitulo3.TabIndex = 1;
            this.lblTitulo3.Text = "Miembros Totales";
            this.lblTitulo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor3
            // 
            this.lblValor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblValor3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblValor3.Location = new System.Drawing.Point(0, 23);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(274, 201);
            this.lblValor3.TabIndex = 0;
            this.lblValor3.Text = "12";
            this.lblValor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.lblValor2);
            this.panel2.Controls.Add(this.lblTitulo2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(304, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 224);
            this.panel2.TabIndex = 1;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblTitulo2.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(274, 23);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Miembros Inactivos";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor2
            // 
            this.lblValor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblValor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblValor2.Location = new System.Drawing.Point(0, 23);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(274, 201);
            this.lblValor2.TabIndex = 0;
            this.lblValor2.Text = "30";
            this.lblValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblValor1);
            this.panel1.Controls.Add(this.lblTitulo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 224);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTitulo1.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(274, 23);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Miembros Activos";
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor1
            // 
            this.lblValor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblValor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblValor1.Location = new System.Drawing.Point(0, 23);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(274, 201);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "120";
            this.lblValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTarjetas
            // 
            this.panelTarjetas.ColumnCount = 4;
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.panelTarjetas.Controls.Add(this.panel1, 0, 0);
            this.panelTarjetas.Controls.Add(this.panel2, 1, 0);
            this.panelTarjetas.Controls.Add(this.panel3, 2, 0);
            this.panelTarjetas.Controls.Add(this.panel4, 3, 0);
            this.panelTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTarjetas.Location = new System.Drawing.Point(3, 3);
            this.panelTarjetas.Name = "panelTarjetas";
            this.panelTarjetas.RowCount = 1;
            this.panelTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTarjetas.Size = new System.Drawing.Size(1178, 244);
            this.panelTarjetas.TabIndex = 0;
            // 
            // DashboardModerno
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardModerno";
            this.Text = "Dashboard Moderno";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelListas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactivos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTarjetas.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel panelListas;
        private Label lblActivosTitulo;
        private DataGridView dgvActivos;
        private Label lblInactivosTitulo;
        private DataGridView dgvInactivos;
        private TableLayoutPanel panelTarjetas;
        private Panel panel1;
        private Label lblValor1;
        private Label lblTitulo1;
        private Panel panel2;
        private Label lblValor2;
        private Label lblTitulo2;
        private Panel panel3;
        private Label lblValor3;
        private Label lblTitulo3;
        private Panel panel4;
        private Label lblValor4;
        private Label lblTitulo4;
    }
}