namespace Ejercicio_ClickStore
{
    partial class PrepararPaquete
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.ListBox lstPedidos;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpRecoleccion;
        private System.Windows.Forms.DataGridView dgvRecoleccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRecolectado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;

        private System.Windows.Forms.GroupBox grpPaquete;
        private System.Windows.Forms.TableLayoutPanel tlpPaquete;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblDim;
        private System.Windows.Forms.TextBox txtDim;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;

        private System.Windows.Forms.GroupBox grpEtiqueta;
        private System.Windows.Forms.Panel panelEtiqueta;
        private System.Windows.Forms.Label lblEtiqueta;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private System.Windows.Forms.Button btnImprimirEtiqueta;
        private System.Windows.Forms.Button btnMarcarPreparado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            grpPedidos = new GroupBox();
            lstPedidos = new ListBox();
            panelRight = new Panel();
            grpEtiqueta = new GroupBox();
            panelEtiqueta = new Panel();
            lblEtiqueta = new Label();
            grpPaquete = new GroupBox();
            tlpPaquete = new TableLayoutPanel();
            lblNro = new Label();
            txtNro = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblDim = new Label();
            txtDim = new TextBox();
            lblObs = new Label();
            txtObs = new TextBox();
            grpRecoleccion = new GroupBox();
            dgvRecoleccion = new DataGridView();
            colRecolectado = new DataGridViewCheckBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            flowBottom = new FlowLayoutPanel();
            btnImprimirEtiqueta = new Button();
            btnMarcarPreparado = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpPedidos.SuspendLayout();
            panelRight.SuspendLayout();
            grpEtiqueta.SuspendLayout();
            panelEtiqueta.SuspendLayout();
            grpPaquete.SuspendLayout();
            tlpPaquete.SuspendLayout();
            grpRecoleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecoleccion).BeginInit();
            panelBottom.SuspendLayout();
            flowBottom.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AccessibleDescription = "Barra de herramientas para preparación de paquetes";
            toolStrip1.AccessibleName = "Barra de herramientas";
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbGuardar, tsbImprimir, tsbAyuda });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1350, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "Barra de herramientas";
            // 
            // tsbGuardar
            // 
            tsbGuardar.AccessibleDescription = "Guardar progreso de preparación";
            tsbGuardar.AccessibleName = "Guardar";
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar progreso (Ctrl+G)";
            // 
            // tsbImprimir
            // 
            tsbImprimir.AccessibleDescription = "Imprimir lista de recolección";
            tsbImprimir.AccessibleName = "Imprimir";
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir lista (Ctrl+P)";
            // 
            // tsbAyuda
            // 
            tsbAyuda.AccessibleDescription = "Mostrar ayuda sobre preparación de paquetes";
            tsbAyuda.AccessibleName = "Ayuda";
            tsbAyuda.Name = "tsbAyuda";
            tsbAyuda.Size = new Size(55, 24);
            tsbAyuda.Text = "A&yuda";
            tsbAyuda.ToolTipText = "Mostrar ayuda (F1)";
            // 
            // statusStrip1
            // 
            statusStrip1.AccessibleDescription = "Barra de estado del sistema";
            statusStrip1.AccessibleName = "Barra de estado";
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
            splitContainer1.AccessibleDescription = "Panel dividido: pedidos a preparar a la izquierda, detalles a la derecha";
            splitContainer1.AccessibleName = "Panel principal";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleDescription = "Lista de pedidos pendientes de preparación";
            splitContainer1.Panel1.AccessibleName = "Pedidos pendientes";
            splitContainer1.Panel1.Controls.Add(grpPedidos);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleDescription = "Área de trabajo para preparar el pedido seleccionado";
            splitContainer1.Panel2.AccessibleName = "Área de preparación";
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Panel2MinSize = 600;
            splitContainer1.Size = new Size(1350, 647);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // grpPedidos
            // 
            grpPedidos.AccessibleDescription = "Lista de pedidos que necesitan ser preparados";
            grpPedidos.AccessibleName = "Pedidos a preparar";
            grpPedidos.Controls.Add(lstPedidos);
            grpPedidos.Dock = DockStyle.Fill;
            grpPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPedidos.Location = new Point(0, 0);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Padding = new Padding(8);
            grpPedidos.Size = new Size(350, 647);
            grpPedidos.TabIndex = 0;
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos Pendientes de Preparación";
            // 
            // lstPedidos
            // 
            lstPedidos.AccessibleDescription = "Lista de pedidos confirmados esperando preparación";
            lstPedidos.AccessibleName = "Pedidos pendientes";
            lstPedidos.Dock = DockStyle.Fill;
            lstPedidos.Font = new Font("Segoe UI", 9F);
            lstPedidos.HorizontalScrollbar = true;
            lstPedidos.Items.AddRange(new object[] { "Pedido #001 - Juan Pérez - 3 productos", "Pedido #002 - María García - 2 productos", "Pedido #003 - Carlos López - 5 productos", "Pedido #004 - Ana Rodríguez - 1 producto", "Pedido #005 - Luis Fernández - 4 productos" });
            lstPedidos.Location = new Point(8, 28);
            lstPedidos.Name = "lstPedidos";
            lstPedidos.Size = new Size(334, 611);
            lstPedidos.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpEtiqueta);
            panelRight.Controls.Add(grpPaquete);
            panelRight.Controls.Add(grpRecoleccion);
            panelRight.Controls.Add(panelBottom);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(994, 647);
            panelRight.TabIndex = 0;
            // 
            // grpEtiqueta
            // 
            grpEtiqueta.AccessibleDescription = "Vista previa de la etiqueta de envío";
            grpEtiqueta.AccessibleName = "Etiqueta de envío";
            grpEtiqueta.Controls.Add(panelEtiqueta);
            grpEtiqueta.Dock = DockStyle.Fill;
            grpEtiqueta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpEtiqueta.Location = new Point(0, 423);
            grpEtiqueta.Name = "grpEtiqueta";
            grpEtiqueta.Padding = new Padding(5);
            grpEtiqueta.Size = new Size(994, 170);
            grpEtiqueta.TabIndex = 2;
            grpEtiqueta.TabStop = false;
            grpEtiqueta.Text = "Vista Previa - Etiqueta de Envío";
            // 
            // panelEtiqueta
            // 
            panelEtiqueta.AccessibleDescription = "Panel donde se muestra la vista previa de la etiqueta";
            panelEtiqueta.AccessibleName = "Vista previa etiqueta";
            panelEtiqueta.BackColor = Color.White;
            panelEtiqueta.BorderStyle = BorderStyle.FixedSingle;
            panelEtiqueta.Controls.Add(lblEtiqueta);
            panelEtiqueta.Dock = DockStyle.Fill;
            panelEtiqueta.Location = new Point(5, 25);
            panelEtiqueta.Name = "panelEtiqueta";
            panelEtiqueta.Size = new Size(984, 140);
            panelEtiqueta.TabIndex = 0;
            // 
            // lblEtiqueta
            // 
            lblEtiqueta.AccessibleDescription = "Contenido de la etiqueta de envío";
            lblEtiqueta.AccessibleName = "Datos de la etiqueta";
            lblEtiqueta.Dock = DockStyle.Fill;
            lblEtiqueta.Font = new Font("Courier New", 9F);
            lblEtiqueta.Location = new Point(0, 0);
            lblEtiqueta.Name = "lblEtiqueta";
            lblEtiqueta.Padding = new Padding(10);
            lblEtiqueta.Size = new Size(982, 138);
            lblEtiqueta.TabIndex = 0;
            lblEtiqueta.Text = "Seleccione un pedido para generar la etiqueta de envío.\r\n\r\nLa etiqueta incluirá:\r\n• Datos del destinatario\r\n• Dirección de entrega\r\n• Número de paquete\r\n• Código de barras";
            // 
            // grpPaquete
            // 
            grpPaquete.AccessibleDescription = "Información del paquete: número, peso, dimensiones y observaciones";
            grpPaquete.AccessibleName = "Datos del paquete";
            grpPaquete.Controls.Add(tlpPaquete);
            grpPaquete.Dock = DockStyle.Top;
            grpPaquete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPaquete.Location = new Point(0, 320);
            grpPaquete.Name = "grpPaquete";
            grpPaquete.Padding = new Padding(5);
            grpPaquete.Size = new Size(994, 103);
            grpPaquete.TabIndex = 1;
            grpPaquete.TabStop = false;
            grpPaquete.Text = "Información del Paquete";
            // 
            // tlpPaquete
            // 
            tlpPaquete.AccessibleDescription = "Campos para ingresar datos del paquete";
            tlpPaquete.AccessibleName = "Formulario de paquete";
            tlpPaquete.ColumnCount = 6;
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpPaquete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaquete.Controls.Add(lblNro, 0, 0);
            tlpPaquete.Controls.Add(txtNro, 1, 0);
            tlpPaquete.Controls.Add(lblPeso, 2, 0);
            tlpPaquete.Controls.Add(txtPeso, 3, 0);
            tlpPaquete.Controls.Add(lblDim, 4, 0);
            tlpPaquete.Controls.Add(txtDim, 5, 0);
            tlpPaquete.Controls.Add(lblObs, 0, 1);
            tlpPaquete.Controls.Add(txtObs, 1, 1);
            tlpPaquete.Dock = DockStyle.Fill;
            tlpPaquete.Font = new Font("Segoe UI", 9F);
            tlpPaquete.Location = new Point(5, 25);
            tlpPaquete.Name = "tlpPaquete";
            tlpPaquete.RowCount = 2;
            tlpPaquete.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpPaquete.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpPaquete.Size = new Size(984, 73);
            tlpPaquete.TabIndex = 0;
            // 
            // lblNro
            // 
            lblNro.AccessibleDescription = "Etiqueta para número de paquete";
            lblNro.AccessibleName = "Número de paquete";
            lblNro.Anchor = AnchorStyles.Left;
            lblNro.AutoSize = true;
            lblNro.Location = new Point(3, 5);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(86, 20);
            lblNro.TabIndex = 0;
            lblNro.Text = "&Nº Paquete:";
            // 
            // txtNro
            // 
            txtNro.AccessibleDescription = "Número único del paquete";
            txtNro.AccessibleName = "Número de paquete";
            txtNro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNro.Location = new Point(123, 3);
            txtNro.Name = "txtNro";
            txtNro.PlaceholderText = "PKG001";
            txtNro.Size = new Size(144, 27);
            txtNro.TabIndex = 1;
            // 
            // lblPeso
            // 
            lblPeso.AccessibleDescription = "Etiqueta para peso del paquete";
            lblPeso.AccessibleName = "Peso";
            lblPeso.Anchor = AnchorStyles.Left;
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(273, 5);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(42, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "&Peso:";
            // 
            // txtPeso
            // 
            txtPeso.AccessibleDescription = "Peso del paquete en kilogramos";
            txtPeso.AccessibleName = "Peso del paquete";
            txtPeso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPeso.Location = new Point(343, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "0.00 kg";
            txtPeso.Size = new Size(114, 27);
            txtPeso.TabIndex = 3;
            // 
            // lblDim
            // 
            lblDim.AccessibleDescription = "Etiqueta para dimensiones del paquete";
            lblDim.AccessibleName = "Dimensiones";
            lblDim.Anchor = AnchorStyles.Left;
            lblDim.AutoSize = true;
            lblDim.Location = new Point(463, 0);
            lblDim.Name = "lblDim";
            lblDim.Size = new Size(94, 30);
            lblDim.TabIndex = 4;
            lblDim.Text = "&Dimensiones:";
            // 
            // txtDim
            // 
            txtDim.AccessibleDescription = "Dimensiones del paquete en centímetros";
            txtDim.AccessibleName = "Dimensiones del paquete";
            txtDim.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDim.Location = new Point(563, 3);
            txtDim.Name = "txtDim";
            txtDim.PlaceholderText = "30x20x15 cm";
            txtDim.Size = new Size(418, 27);
            txtDim.TabIndex = 5;
            // 
            // lblObs
            // 
            lblObs.AccessibleDescription = "Etiqueta para observaciones del paquete";
            lblObs.AccessibleName = "Observaciones";
            lblObs.Anchor = AnchorStyles.Left;
            lblObs.AutoSize = true;
            lblObs.Location = new Point(3, 41);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(108, 20);
            lblObs.TabIndex = 6;
            lblObs.Text = "&Observaciones:";
            // 
            // txtObs
            // 
            txtObs.AccessibleDescription = "Observaciones especiales sobre el empaque";
            txtObs.AccessibleName = "Observaciones del paquete";
            txtObs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpPaquete.SetColumnSpan(txtObs, 5);
            txtObs.Location = new Point(123, 38);
            txtObs.Name = "txtObs";
            txtObs.PlaceholderText = "Instrucciones especiales de empaque";
            txtObs.Size = new Size(858, 27);
            txtObs.TabIndex = 7;
            // 
            // grpRecoleccion
            // 
            grpRecoleccion.AccessibleDescription = "Lista de productos a recolectar para el pedido";
            grpRecoleccion.AccessibleName = "Lista de recolección";
            grpRecoleccion.Controls.Add(dgvRecoleccion);
            grpRecoleccion.Dock = DockStyle.Top;
            grpRecoleccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRecoleccion.Location = new Point(0, 0);
            grpRecoleccion.Name = "grpRecoleccion";
            grpRecoleccion.Padding = new Padding(5);
            grpRecoleccion.Size = new Size(994, 320);
            grpRecoleccion.TabIndex = 0;
            grpRecoleccion.TabStop = false;
            grpRecoleccion.Text = "Lista de Recolección - Productos a Buscar";
            // 
            // dgvRecoleccion
            // 
            dgvRecoleccion.AccessibleDescription = "Tabla de productos con ubicaciones para recolección";
            dgvRecoleccion.AccessibleName = "Productos a recolectar";
            dgvRecoleccion.AllowUserToAddRows = false;
            dgvRecoleccion.AllowUserToDeleteRows = false;
            dgvRecoleccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecoleccion.ColumnHeadersHeight = 29;
            dgvRecoleccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecoleccion.Columns.AddRange(new DataGridViewColumn[] { colRecolectado, colProducto, colUbicacion, colCantidad });
            dgvRecoleccion.Dock = DockStyle.Fill;
            dgvRecoleccion.Font = new Font("Segoe UI", 9F);
            dgvRecoleccion.Location = new Point(5, 25);
            dgvRecoleccion.MultiSelect = false;
            dgvRecoleccion.Name = "dgvRecoleccion";
            dgvRecoleccion.RowHeadersVisible = false;
            dgvRecoleccion.RowHeadersWidth = 51;
            dgvRecoleccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecoleccion.Size = new Size(984, 290);
            dgvRecoleccion.TabIndex = 0;
            // 
            // colRecolectado
            // 
            colRecolectado.DataPropertyName = "Recolectado";
            colRecolectado.FillWeight = 15F;
            colRecolectado.HeaderText = "Recolectado";
            colRecolectado.MinimumWidth = 80;
            colRecolectado.Name = "colRecolectado";
            colRecolectado.ToolTipText = "Marcar como recolectado";
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "Producto";
            colProducto.FillWeight = 45F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 200;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colUbicacion
            // 
            colUbicacion.DataPropertyName = "Ubicacion";
            colUbicacion.FillWeight = 25F;
            colUbicacion.HeaderText = "Ubicación";
            colUbicacion.MinimumWidth = 120;
            colUbicacion.Name = "colUbicacion";
            colUbicacion.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            colCantidad.FillWeight = 15F;
            colCantidad.HeaderText = "Cant.";
            colCantidad.MinimumWidth = 60;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 593);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(994, 54);
            panelBottom.TabIndex = 3;
            // 
            // flowBottom
            // 
            flowBottom.Controls.Add(btnImprimirEtiqueta);
            flowBottom.Controls.Add(btnMarcarPreparado);
            flowBottom.Dock = DockStyle.Right;
            flowBottom.FlowDirection = FlowDirection.RightToLeft;
            flowBottom.Location = new Point(666, 8);
            flowBottom.Name = "flowBottom";
            flowBottom.Size = new Size(320, 38);
            flowBottom.TabIndex = 0;
            flowBottom.WrapContents = false;
            // 
            // btnImprimirEtiqueta
            // 
            btnImprimirEtiqueta.AccessibleDescription = "Imprimir etiqueta de envío del paquete";
            btnImprimirEtiqueta.AccessibleName = "Imprimir etiqueta";
            btnImprimirEtiqueta.AutoSize = true;
            btnImprimirEtiqueta.Location = new Point(182, 3);
            btnImprimirEtiqueta.Name = "btnImprimirEtiqueta";
            btnImprimirEtiqueta.Size = new Size(135, 30);
            btnImprimirEtiqueta.TabIndex = 0;
            btnImprimirEtiqueta.Text = "&Imprimir Etiqueta";
            btnImprimirEtiqueta.UseVisualStyleBackColor = true;
            // 
            // btnMarcarPreparado
            // 
            btnMarcarPreparado.AccessibleDescription = "Marcar el paquete como preparado y listo para envío";
            btnMarcarPreparado.AccessibleName = "Marcar como preparado";
            btnMarcarPreparado.AutoSize = true;
            btnMarcarPreparado.Location = new Point(38, 3);
            btnMarcarPreparado.Name = "btnMarcarPreparado";
            btnMarcarPreparado.Size = new Size(138, 30);
            btnMarcarPreparado.TabIndex = 1;
            btnMarcarPreparado.Text = "&Marcar Preparado";
            btnMarcarPreparado.UseVisualStyleBackColor = true;
            // 
            // PrepararPaquete
            // 
            AcceptButton = btnMarcarPreparado;
            AccessibleDescription = "Formulario para preparar paquetes de pedidos confirmados";
            AccessibleName = "Preparación de Paquetes";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "PrepararPaquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Preparación de Paquetes (Logística)";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpPedidos.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            grpEtiqueta.ResumeLayout(false);
            panelEtiqueta.ResumeLayout(false);
            grpPaquete.ResumeLayout(false);
            tlpPaquete.ResumeLayout(false);
            tlpPaquete.PerformLayout();
            grpRecoleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecoleccion).EndInit();
            panelBottom.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}