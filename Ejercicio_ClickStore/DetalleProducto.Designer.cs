namespace Ejercicio_ClickStore
{
    partial class DetalleProducto
    {
        private System.ComponentModel.IContainer components = null;

        // Infra UI
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        // Layout principal
        private System.Windows.Forms.SplitContainer splitContainer1;

        // Panel izquierdo
        private System.Windows.Forms.Button btnVolver;

        // Panel derecho: TLP 2x3
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox grpCompra;
        private System.Windows.Forms.TableLayoutPanel tlpCompra;

        // Compra: controles
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblVariante;
        private System.Windows.Forms.ComboBox cboVariante;
        private System.Windows.Forms.FlowLayoutPanel flowCompraButtons;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnComprar;

        // Ayuda visual
        private System.Windows.Forms.ToolTip toolTip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboVariante = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.grpCompra = new System.Windows.Forms.GroupBox();
            this.tlpCompra = new System.Windows.Forms.TableLayoutPanel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVariante = new System.Windows.Forms.Label();
            this.flowCompraButtons = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpDesc.SuspendLayout();
            this.grpCompra.SuspendLayout();
            this.tlpCompra.SuspendLayout();
            this.flowCompraButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;

            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleDescription = "Regresa a la pantalla del catálogo de productos";
            this.btnVolver.AccessibleName = "Volver al catálogo";
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(0, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 65);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "← &Volver al catálogo";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver al catálogo de productos (Alt+V)");

            // 
            // pnlImagen
            // 
            this.pnlImagen.AccessibleDescription = "Vista previa del producto seleccionado";
            this.pnlImagen.AccessibleName = "Imagen del producto";
            this.pnlImagen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagen.Location = new System.Drawing.Point(3, 3);
            this.pnlImagen.Name = "pnlImagen";
            this.tlpRight.SetRowSpan(this.pnlImagen, 3);
            this.pnlImagen.Size = new System.Drawing.Size(414, 641);
            this.pnlImagen.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlImagen, "Imagen del producto");

            // 
            // txtDesc
            // 
            this.txtDesc.AccessibleDescription = "Texto descriptivo del producto seleccionado";
            this.txtDesc.AccessibleName = "Descripción del producto";
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesc.Location = new System.Drawing.Point(3, 23);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PlaceholderText = "Aquí se mostrará la descripción detallada del producto...";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(712, 188);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.Text = "Descripción del producto no disponible.";
            this.toolTip1.SetToolTip(this.txtDesc, "Descripción completa del producto");

            // 
            // numCantidad
            // 
            this.numCantidad.AccessibleDescription = "Cantidad a comprar del producto";
            this.numCantidad.AccessibleName = "Cantidad";
            this.numCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCantidad.Location = new System.Drawing.Point(83, 3);
            this.numCantidad.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(270, 27);
            this.numCantidad.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numCantidad, "Cantidad a agregar al carrito (mínimo 1, máximo 99)");
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // cboVariante
            // 
            this.cboVariante.AccessibleDescription = "Variante del producto (por ejemplo, color o talla)";
            this.cboVariante.AccessibleName = "Variante";
            this.cboVariante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVariante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVariante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboVariante.Items.AddRange(new object[] {
            "Estándar",
            "Pequeño",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.cboVariante.Location = new System.Drawing.Point(439, 3);
            this.cboVariante.Name = "cboVariante";
            this.cboVariante.Size = new System.Drawing.Size(270, 28);
            this.cboVariante.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboVariante, "Seleccione una variante si está disponible");

            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleDescription = "Agrega el producto al carrito con la cantidad y variante seleccionadas";
            this.btnAgregar.AccessibleName = "Agregar al carrito";
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar al carrito (Alt+A)");

            // 
            // btnComprar
            // 
            this.btnComprar.AccessibleDescription = "Inicia el proceso de compra inmediata del producto";
            this.btnComprar.AccessibleName = "Comprar ahora";
            this.btnComprar.AutoSize = true;
            this.btnComprar.Location = new System.Drawing.Point(134, 3);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(108, 30);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "&Comprar Ahora";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.toolTip1.SetToolTip(this.btnComprar, "Comprar inmediatamente (Alt+C)");

            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir,
            this.tsbAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Barra de herramientas";

            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 24);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.ToolTipText = "Guardar información del producto (Ctrl+G)";

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(70, 24);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir ficha del producto (Ctrl+P)";

            // 
            // tsbAyuda
            // 
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(55, 24);
            this.tsbAyuda.Text = "A&yuda";
            this.tsbAyuda.ToolTipText = "Mostrar ayuda (F1)";

            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Barra de estado";

            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel1.Text = "Listo";

            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleDescription = "Panel dividido: navegación a la izquierda, detalles del producto a la derecha";
            this.splitContainer1.AccessibleName = "Panel principal";
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 200;
            this.splitContainer1.Panel2MinSize = 800;
            this.splitContainer1.Size = new System.Drawing.Size(1350, 647);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;

            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = "Panel de navegación";
            this.splitContainer1.Panel1.AccessibleName = "Navegación";
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.btnVolver);

            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = "Panel de detalles del producto";
            this.splitContainer1.Panel2.AccessibleName = "Detalles del producto";
            this.splitContainer1.Panel2.Controls.Add(this.tlpRight);

            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 2;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.pnlImagen, 0, 0);
            this.tlpRight.Controls.Add(this.grpInfo, 1, 0);
            this.tlpRight.Controls.Add(this.grpDesc, 1, 1);
            this.tlpRight.Controls.Add(this.grpCompra, 1, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRight.Size = new System.Drawing.Size(1144, 647);
            this.tlpRight.TabIndex = 0;

            // 
            // grpInfo
            // 
            this.grpInfo.AccessibleDescription = "Información básica del producto: nombre, código, precio y disponibilidad";
            this.grpInfo.AccessibleName = "Información del producto";
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(423, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(10);
            this.grpInfo.Size = new System.Drawing.Size(718, 174);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Información del Producto";

            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.Location = new System.Drawing.Point(10, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lblInfo.Size = new System.Drawing.Size(371, 33);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Producto: [Nombre] | Código: [Código] | Precio: [Precio] | Stock: [Disponible]";

            // 
            // grpDesc
            // 
            this.grpDesc.AccessibleDescription = "Descripción detallada del producto";
            this.grpDesc.AccessibleName = "Descripción";
            this.grpDesc.Controls.Add(this.txtDesc);
            this.grpDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDesc.Location = new System.Drawing.Point(423, 183);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Padding = new System.Windows.Forms.Padding(5);
            this.grpDesc.Size = new System.Drawing.Size(718, 274);
            this.grpDesc.TabIndex = 2;
            this.grpDesc.TabStop = false;
            this.grpDesc.Text = "Descripción del Producto";

            // 
            // grpCompra
            // 
            this.grpCompra.AccessibleDescription = "Opciones de compra: cantidad, variante y botones de acción";
            this.grpCompra.AccessibleName = "Opciones de compra";
            this.grpCompra.Controls.Add(this.tlpCompra);
            this.grpCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCompra.Location = new System.Drawing.Point(423, 463);
            this.grpCompra.Name = "grpCompra";
            this.grpCompra.Padding = new System.Windows.Forms.Padding(10);
            this.grpCompra.Size = new System.Drawing.Size(718, 181);
            this.grpCompra.TabIndex = 3;
            this.grpCompra.TabStop = false;
            this.grpCompra.Text = "Opciones de Compra";

            // 
            // tlpCompra
            // 
            this.tlpCompra.ColumnCount = 4;
            this.tlpCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompra.Controls.Add(this.lblCantidad, 0, 0);
            this.tlpCompra.Controls.Add(this.numCantidad, 1, 0);
            this.tlpCompra.Controls.Add(this.lblVariante, 2, 0);
            this.tlpCompra.Controls.Add(this.cboVariante, 3, 0);
            this.tlpCompra.Controls.Add(this.flowCompraButtons, 0, 1);
            this.tlpCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCompra.Location = new System.Drawing.Point(10, 29);
            this.tlpCompra.Name = "tlpCompra";
            this.tlpCompra.RowCount = 2;
            this.tlpCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompra.Size = new System.Drawing.Size(698, 142);
            this.tlpCompra.TabIndex = 0;

            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(3, 10);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "&Cantidad:";

            // 
            // lblVariante
            // 
            this.lblVariante.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVariante.AutoSize = true;
            this.lblVariante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVariante.Location = new System.Drawing.Point(352, 10);
            this.lblVariante.Name = "lblVariante";
            this.lblVariante.Size = new System.Drawing.Size(66, 20);
            this.lblVariante.TabIndex = 1;
            this.lblVariante.Text = "&Variante:";

            // 
            // flowCompraButtons
            // 
            this.tlpCompra.SetColumnSpan(this.flowCompraButtons, 4);
            this.flowCompraButtons.Controls.Add(this.btnAgregar);
            this.flowCompraButtons.Controls.Add(this.btnComprar);
            this.flowCompraButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCompraButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowCompraButtons.Location = new System.Drawing.Point(3, 43);
            this.flowCompraButtons.Name = "flowCompraButtons";
            this.flowCompraButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowCompraButtons.Size = new System.Drawing.Size(692, 96);
            this.flowCompraButtons.TabIndex = 2;

            // 
            // DetalleProducto
            // 
            this.AcceptButton = this.btnComprar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "DetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Detalle del Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            this.grpCompra.ResumeLayout(false);
            this.tlpCompra.ResumeLayout(false);
            this.tlpCompra.PerformLayout();
            this.flowCompraButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}