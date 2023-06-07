
namespace _01_CapaPresentacion
{
    partial class FrmMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdministraClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministrarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministraClientes,
            this.mnuAdministrarProductos,
            this.mnuFacturar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdministraClientes
            // 
            this.mnuAdministraClientes.Name = "mnuAdministraClientes";
            this.mnuAdministraClientes.Size = new System.Drawing.Size(126, 20);
            this.mnuAdministraClientes.Text = "Administrar Clientes";
            this.mnuAdministraClientes.Click += new System.EventHandler(this.mnuAdministraClientes_Click);
            // 
            // mnuAdministrarProductos
            // 
            this.mnuAdministrarProductos.Name = "mnuAdministrarProductos";
            this.mnuAdministrarProductos.Size = new System.Drawing.Size(138, 20);
            this.mnuAdministrarProductos.Text = "Administrar Productos";
            this.mnuAdministrarProductos.Click += new System.EventHandler(this.mnuAdministrarProductos_Click);
            // 
            // mnuFacturar
            // 
            this.mnuFacturar.Name = "mnuFacturar";
            this.mnuFacturar.Size = new System.Drawing.Size(81, 20);
            this.mnuFacturar.Text = "Facturacion";
            this.mnuFacturar.Click += new System.EventHandler(this.mnuFacturar_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministraClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrarProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturar;
    }
}

