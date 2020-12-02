namespace Votaciones
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.votarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votarToolStripMenuItem,
            this.eleccionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // votarToolStripMenuItem
            // 
            this.votarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVotacionToolStripMenuItem});
            this.votarToolStripMenuItem.Name = "votarToolStripMenuItem";
            this.votarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.votarToolStripMenuItem.Text = "Votar";
            this.votarToolStripMenuItem.Click += new System.EventHandler(this.votarToolStripMenuItem_Click);
            // 
            // realizarVotacionToolStripMenuItem
            // 
            this.realizarVotacionToolStripMenuItem.Name = "realizarVotacionToolStripMenuItem";
            this.realizarVotacionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.realizarVotacionToolStripMenuItem.Text = "Realizar Votacion";
            this.realizarVotacionToolStripMenuItem.Click += new System.EventHandler(this.realizarVotacionToolStripMenuItem_Click);
            // 
            // eleccionesToolStripMenuItem
            // 
            this.eleccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasToolStripMenuItem});
            this.eleccionesToolStripMenuItem.Name = "eleccionesToolStripMenuItem";
            this.eleccionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.eleccionesToolStripMenuItem.Text = "Fin Elecciones";
            this.eleccionesToolStripMenuItem.Click += new System.EventHandler(this.eleccionesToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 368);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem votarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}

