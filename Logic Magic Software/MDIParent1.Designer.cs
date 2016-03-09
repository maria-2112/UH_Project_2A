namespace Logic_Magic_Software
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarArticuloToolStripMenuItem,
            this.presupuestoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArticuloToolStripMenuItem,
            this.calculoToolStripMenuItem,
            this.registrosDeComprasToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // ingresarArticuloToolStripMenuItem
            // 
            this.ingresarArticuloToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.icon_shopping_english;
            this.ingresarArticuloToolStripMenuItem.Name = "ingresarArticuloToolStripMenuItem";
            this.ingresarArticuloToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ingresarArticuloToolStripMenuItem.Text = "Ingresar Articulo";
            this.ingresarArticuloToolStripMenuItem.Click += new System.EventHandler(this.ingresarArticuloToolStripMenuItem_Click);
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.psd_moneda_de_oro_de_icono_30_1703;
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.presupuestoToolStripMenuItem.Text = "Presupuesto";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.images1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // listaDeArticuloToolStripMenuItem
            // 
            this.listaDeArticuloToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.índice12;
            this.listaDeArticuloToolStripMenuItem.Name = "listaDeArticuloToolStripMenuItem";
            this.listaDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listaDeArticuloToolStripMenuItem.Text = "Lista de Articulo";
            // 
            // calculoToolStripMenuItem
            // 
            this.calculoToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.calculo;
            this.calculoToolStripMenuItem.Name = "calculoToolStripMenuItem";
            this.calculoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.calculoToolStripMenuItem.Text = "Calculo de Costo";
            // 
            // registrosDeComprasToolStripMenuItem
            // 
            this.registrosDeComprasToolStripMenuItem.Image = global::Logic_Magic_Software.Properties.Resources.documents_1_;
            this.registrosDeComprasToolStripMenuItem.Name = "registrosDeComprasToolStripMenuItem";
            this.registrosDeComprasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registrosDeComprasToolStripMenuItem.Text = "Registros de Compras";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Logic Magic Software";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeComprasToolStripMenuItem;
    }
}



