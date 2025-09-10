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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            btnVolver = new Button();
            pnlImagen = new Panel();
            txtDesc = new TextBox();
            numCantidad = new NumericUpDown();
            cboVariante = new ComboBox();
            btnAgregar = new Button();
            btnComprar = new Button();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tlpRight = new TableLayoutPanel();
            grpInfo = new GroupBox();
            lblInfo = new Label();
            grpDesc = new GroupBox();
            grpCompra = new GroupBox();
            tlpCompra = new TableLayoutPanel();
            lblCantidad = new Label();
            lblVariante = new Label();
            flowCompraButtons = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tlpRight.SuspendLayout();
            grpInfo.SuspendLayout();
            grpDesc.SuspendLayout();
            grpCompra.SuspendLayout();
            tlpCompra.SuspendLayout();
            flowCompraButtons.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // btnVolver
            // 
            btnVolver.AccessibleDescription = "Regresa a la pantalla del catálogo de productos";
            btnVolver.AccessibleName = "Volver al catálogo";
            btnVolver.Dock = DockStyle.Top;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 65);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "← &Volver al catálogo";
            toolTip1.SetToolTip(btnVolver, "Volver al catálogo de productos (Alt+V)");
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // pnlImagen
            // 
            pnlImagen.AccessibleDescription = "Vista previa del producto seleccionado";
            pnlImagen.AccessibleName = "Imagen del producto";
            pnlImagen.BackColor = SystemColors.ControlLight;
            pnlImagen.BorderStyle = BorderStyle.FixedSingle;
            pnlImagen.Dock = DockStyle.Fill;
            pnlImagen.Location = new Point(3, 3);
            pnlImagen.Name = "pnlImagen";
            tlpRight.SetRowSpan(pnlImagen, 3);
            pnlImagen.Size = new Size(414, 641);
            pnlImagen.TabIndex = 0;
            toolTip1.SetToolTip(pnlImagen, "Imagen del producto");
            // 
            // txtDesc
            // 
            txtDesc.AccessibleDescription = "Texto descriptivo del producto seleccionado";
            txtDesc.AccessibleName = "Descripción del producto";
            txtDesc.Dock = DockStyle.Fill;
            txtDesc.Font = new Font("Segoe UI", 9F);
            txtDesc.Location = new Point(5, 25);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Aquí se mostrará la descripción detallada del producto...";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(708, 244);
            txtDesc.TabIndex = 0;
            txtDesc.Text = "Descripción del producto no disponible.";
            toolTip1.SetToolTip(txtDesc, "Descripción completa del producto");
            // 
            // numCantidad
            // 
            numCantidad.AccessibleDescription = "Cantidad a comprar del producto";
            numCantidad.AccessibleName = "Cantidad";
            numCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numCantidad.Font = new Font("Segoe UI", 9F);
            numCantidad.Location = new Point(83, 6);
            numCantidad.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(263, 27);
            numCantidad.TabIndex = 0;
            toolTip1.SetToolTip(numCantidad, "Cantidad a agregar al carrito (mínimo 1, máximo 99)");
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboVariante
            // 
            cboVariante.AccessibleDescription = "Variante del producto (por ejemplo, color o talla)";
            cboVariante.AccessibleName = "Variante";
            cboVariante.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboVariante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVariante.Font = new Font("Segoe UI", 9F);
            cboVariante.Items.AddRange(new object[] { "Estándar", "Pequeño", "Mediano", "Grande", "Extra Grande" });
            cboVariante.Location = new Point(432, 6);
            cboVariante.Name = "cboVariante";
            cboVariante.Size = new Size(263, 28);
            cboVariante.TabIndex = 1;
            toolTip1.SetToolTip(cboVariante, "Seleccione una variante si está disponible");
            // 
            // btnAgregar
            // 
            btnAgregar.AccessibleDescription = "Agrega el producto al carrito con la cantidad y variante seleccionadas";
            btnAgregar.AccessibleName = "Agregar al carrito";
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 53);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar al Carrito";
            toolTip1.SetToolTip(btnAgregar, "Agregar al carrito (Alt+A)");
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            btnComprar.AccessibleDescription = "Inicia el proceso de compra inmediata del producto";
            btnComprar.AccessibleName = "Comprar ahora";
            btnComprar.AutoSize = true;
            btnComprar.Location = new Point(134, 3);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(108, 53);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "&Comprar Ahora";
            toolTip1.SetToolTip(btnComprar, "Comprar inmediatamente (Alt+C)");
            btnComprar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbGuardar, tsbImprimir, tsbAyuda });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1350, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "Barra de herramientas";
            // 
            // tsbGuardar
            // 
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar información del producto (Ctrl+G)";
            // 
            // tsbImprimir
            // 
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir ficha del producto (Ctrl+P)";
            // 
            // tsbAyuda
            // 
            tsbAyuda.Name = "tsbAyuda";
            tsbAyuda.Size = new Size(55, 24);
            tsbAyuda.Text = "A&yuda";
            tsbAyuda.ToolTipText = "Mostrar ayuda (F1)";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 674);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1350, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "Barra de estado";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 20);
            toolStripStatusLabel1.Text = "Listo";
            // 
            // splitContainer1
            // 
            splitContainer1.AccessibleDescription = "Panel dividido: navegación a la izquierda, detalles del producto a la derecha";
            splitContainer1.AccessibleName = "Panel principal";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleDescription = "Panel de navegación";
            splitContainer1.Panel1.AccessibleName = "Navegación";
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(btnVolver);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleDescription = "Panel de detalles del producto";
            splitContainer1.Panel2.AccessibleName = "Detalles del producto";
            splitContainer1.Panel2.Controls.Add(tlpRight);
            splitContainer1.Panel2MinSize = 800;
            splitContainer1.Size = new Size(1350, 647);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tlpRight
            // 
            tlpRight.ColumnCount = 2;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRight.Controls.Add(pnlImagen, 0, 0);
            tlpRight.Controls.Add(grpInfo, 1, 0);
            tlpRight.Controls.Add(grpDesc, 1, 1);
            tlpRight.Controls.Add(grpCompra, 1, 2);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(0, 0);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 3;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpRight.Size = new Size(1144, 647);
            tlpRight.TabIndex = 0;
            // 
            // grpInfo
            // 
            grpInfo.AccessibleDescription = "Información básica del producto: nombre, código, precio y disponibilidad";
            grpInfo.AccessibleName = "Información del producto";
            grpInfo.Controls.Add(lblInfo);
            grpInfo.Dock = DockStyle.Fill;
            grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInfo.Location = new Point(423, 3);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(10);
            grpInfo.Size = new Size(718, 174);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Información del Producto";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Dock = DockStyle.Top;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.Location = new Point(10, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(5);
            lblInfo.Size = new Size(595, 33);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Producto: [Nombre] | Código: [Código] | Precio: [Precio] | Stock: [Disponible]";
            // 
            // grpDesc
            // 
            grpDesc.AccessibleDescription = "Descripción detallada del producto";
            grpDesc.AccessibleName = "Descripción";
            grpDesc.Controls.Add(txtDesc);
            grpDesc.Dock = DockStyle.Fill;
            grpDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDesc.Location = new Point(423, 183);
            grpDesc.Name = "grpDesc";
            grpDesc.Padding = new Padding(5);
            grpDesc.Size = new Size(718, 274);
            grpDesc.TabIndex = 2;
            grpDesc.TabStop = false;
            grpDesc.Text = "Descripción del Producto";
            // 
            // grpCompra
            // 
            grpCompra.AccessibleDescription = "Opciones de compra: cantidad, variante y botones de acción";
            grpCompra.AccessibleName = "Opciones de compra";
            grpCompra.Controls.Add(tlpCompra);
            grpCompra.Dock = DockStyle.Fill;
            grpCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpCompra.Location = new Point(423, 463);
            grpCompra.Name = "grpCompra";
            grpCompra.Padding = new Padding(10);
            grpCompra.Size = new Size(718, 181);
            grpCompra.TabIndex = 3;
            grpCompra.TabStop = false;
            grpCompra.Text = "Opciones de Compra";
            // 
            // tlpCompra
            // 
            tlpCompra.ColumnCount = 4;
            tlpCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCompra.Controls.Add(lblCantidad, 0, 0);
            tlpCompra.Controls.Add(numCantidad, 1, 0);
            tlpCompra.Controls.Add(lblVariante, 2, 0);
            tlpCompra.Controls.Add(cboVariante, 3, 0);
            tlpCompra.Controls.Add(flowCompraButtons, 0, 1);
            tlpCompra.Dock = DockStyle.Fill;
            tlpCompra.Location = new Point(10, 30);
            tlpCompra.Name = "tlpCompra";
            tlpCompra.RowCount = 2;
            tlpCompra.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCompra.Size = new Size(698, 141);
            tlpCompra.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Left;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.Location = new Point(3, 10);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "&Cantidad:";
            // 
            // lblVariante
            // 
            lblVariante.Anchor = AnchorStyles.Left;
            lblVariante.AutoSize = true;
            lblVariante.Font = new Font("Segoe UI", 9F);
            lblVariante.Location = new Point(352, 10);
            lblVariante.Name = "lblVariante";
            lblVariante.Size = new Size(66, 20);
            lblVariante.TabIndex = 1;
            lblVariante.Text = "&Variante:";
            // 
            // flowCompraButtons
            // 
            tlpCompra.SetColumnSpan(flowCompraButtons, 4);
            flowCompraButtons.Controls.Add(btnAgregar);
            flowCompraButtons.Controls.Add(btnComprar);
            flowCompraButtons.Dock = DockStyle.Fill;
            flowCompraButtons.Location = new Point(3, 43);
            flowCompraButtons.Name = "flowCompraButtons";
            flowCompraButtons.Padding = new Padding(0, 10, 0, 0);
            flowCompraButtons.Size = new Size(692, 95);
            flowCompraButtons.TabIndex = 2;
            // 
            // DetalleProducto
            // 
            AcceptButton = btnComprar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVolver;
            ClientSize = new Size(1350, 700);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 700);
            Name = "DetalleProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Detalle del Producto";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tlpRight.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            grpDesc.ResumeLayout(false);
            grpDesc.PerformLayout();
            grpCompra.ResumeLayout(false);
            tlpCompra.ResumeLayout(false);
            tlpCompra.PerformLayout();
            flowCompraButtons.ResumeLayout(false);
            flowCompraButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}