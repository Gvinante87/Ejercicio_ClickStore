namespace Ejercicio_ClickStore
{
    partial class VerificacionStock
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoPedido;

        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposito;
        private System.Windows.Forms.DataGridViewImageColumn colEstadoStock;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Button btnRechazarPedido;
        private System.Windows.Forms.Button btnActualizarStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoStock = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpPedidos = new System.Windows.Forms.GroupBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.btnRechazarPedido = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();

            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.flowBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = "Barra de herramientas para verificación de stock";
            this.toolStrip1.AccessibleName = "Barra de herramientas";
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbGuardar,
                this.tsbImprimir,
                this.tsbAyuda
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Barra de herramientas";

            // 
            // tsbGuardar
            // 
            this.tsbGuardar.AccessibleDescription = "Guardar verificaciones realizadas";
            this.tsbGuardar.AccessibleName = "Guardar";
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 24);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.ToolTipText = "Guardar verificaciones (Ctrl+G)";

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.AccessibleDescription = "Imprimir reporte de stock";
            this.tsbImprimir.AccessibleName = "Imprimir";
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(70, 24);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir reporte (Ctrl+P)";

            // 
            // tsbAyuda
            // 
            this.tsbAyuda.AccessibleDescription = "Mostrar ayuda sobre verificación de stock";
            this.tsbAyuda.AccessibleName = "Ayuda";
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(55, 24);
            this.tsbAyuda.Text = "A&yuda";
            this.tsbAyuda.ToolTipText = "Mostrar ayuda (F1)";

            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleDescription = "Barra de estado del sistema";
            this.statusStrip1.AccessibleName = "Barra de estado";
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Barra de estado";

            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Listo";

            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleDescription = "Panel dividido: filtros a la izquierda, pedidos y stock a la derecha";
            this.splitContainer1.AccessibleName = "Panel principal";
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 280;
            this.splitContainer1.Panel2MinSize = 700;

            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = "Área de filtros de búsqueda";
            this.splitContainer1.Panel1.AccessibleName = "Filtros";
            this.splitContainer1.Panel1.Controls.Add(this.grpFiltros);

            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = "Área de pedidos y verificación de stock";
            this.splitContainer1.Panel2.AccessibleName = "Pedidos y stock";
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 651);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;

            // 
            // grpFiltros
            // 
            this.grpFiltros.AccessibleDescription = "Controles para filtrar pedidos";
            this.grpFiltros.AccessibleName = "Filtros de búsqueda";
            this.grpFiltros.Controls.Add(this.tlpFiltros);
            this.grpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltros.Location = new System.Drawing.Point(0, 0);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.grpFiltros.Size = new System.Drawing.Size(320, 651);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de Búsqueda";

            // 
            // tlpFiltros
            // 
            this.tlpFiltros.AccessibleDescription = "Tabla de controles de filtrado";
            this.tlpFiltros.AccessibleName = "Controles de filtros";
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblFecha, 0, 0);
            this.tlpFiltros.Controls.Add(this.dtpFecha, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblEstado, 0, 1);
            this.tlpFiltros.Controls.Add(this.cboEstado, 1, 1);
            this.tlpFiltros.Controls.Add(this.lblCliente, 0, 2);
            this.tlpFiltros.Controls.Add(this.txtCliente, 1, 2);
            this.tlpFiltros.Controls.Add(this.btnBuscar, 1, 3);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlpFiltros.Location = new System.Drawing.Point(8, 28);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 4;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFiltros.Size = new System.Drawing.Size(304, 145);
            this.tlpFiltros.TabIndex = 0;

            // 
            // lblFecha
            // 
            this.lblFecha.AccessibleDescription = "Etiqueta para filtro de fecha";
            this.lblFecha.AccessibleName = "Fecha";
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "&Fecha:";

            // 
            // dtpFecha
            // 
            this.dtpFecha.AccessibleDescription = "Seleccionar fecha de pedidos a verificar";
            this.dtpFecha.AccessibleName = "Fecha de pedidos";
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(93, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(208, 27);
            this.dtpFecha.TabIndex = 1;

            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleDescription = "Etiqueta para filtro de estado";
            this.lblEstado.AccessibleName = "Estado";
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(3, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "&Estado:";

            // 
            // cboEstado
            // 
            this.cboEstado.AccessibleDescription = "Seleccionar estado del pedido a verificar";
            this.cboEstado.AccessibleName = "Estado del pedido";
            this.cboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Items.AddRange(new object[] {
                "Todos",
                "Pendiente verificación",
                "Stock confirmado",
                "Stock insuficiente",
                "Confirmado",
                "Rechazado"
            });
            this.cboEstado.Location = new System.Drawing.Point(93, 38);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(208, 28);
            this.cboEstado.TabIndex = 3;

            // 
            // lblCliente
            // 
            this.lblCliente.AccessibleDescription = "Etiqueta para filtro de cliente";
            this.lblCliente.AccessibleName = "Cliente";
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "&Cliente:";

            // 
            // txtCliente
            // 
            this.txtCliente.AccessibleDescription = "Escribir nombre del cliente para filtrar";
            this.txtCliente.AccessibleName = "Nombre del cliente";
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(93, 74);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Nombre del cliente";
            this.txtCliente.Size = new System.Drawing.Size(208, 27);
            this.txtCliente.TabIndex = 5;

            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleDescription = "Aplicar filtros y buscar pedidos";
            this.btnBuscar.AccessibleName = "Buscar pedidos";
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Location = new System.Drawing.Point(93, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.grpDetalle);
            this.panelRight.Controls.Add(this.grpPedidos);
            this.panelRight.Controls.Add(this.panelBottom);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1024, 651);
            this.panelRight.TabIndex = 0;

            // 
            // grpDetalle
            // 
            this.grpDetalle.AccessibleDescription = "Detalle de productos y verificación de stock";
            this.grpDetalle.AccessibleName = "Verificación de stock";
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(0, 300);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(5);
            this.grpDetalle.Size = new System.Drawing.Size(1024, 303);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Verificación de Stock - Productos del Pedido";

            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AccessibleDescription = "Tabla de verificación de stock por producto";
            this.dgvDetalle.AccessibleName = "Stock de productos";
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeight = 29;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProducto,
                this.colCantidadSolicitada,
                this.colStockDisponible,
                this.colDeposito,
                this.colEstadoStock
            });
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetalle.Location = new System.Drawing.Point(5, 25);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1014, 273);
            this.dgvDetalle.TabIndex = 0;

            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "NombreProducto";
            this.colProducto.FillWeight = 35F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 200;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;

            // 
            // colCantidadSolicitada
            // 
            this.colCantidadSolicitada.DataPropertyName = "CantidadSolicitada";
            this.colCantidadSolicitada.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidadSolicitada.FillWeight = 15F;
            this.colCantidadSolicitada.HeaderText = "Cant. Solicitada";
            this.colCantidadSolicitada.MinimumWidth = 80;
            this.colCantidadSolicitada.Name = "colCantidadSolicitada";
            this.colCantidadSolicitada.ReadOnly = true;

            // 
            // colStockDisponible
            // 
            this.colStockDisponible.DataPropertyName = "StockDisponible";
            this.colStockDisponible.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStockDisponible.FillWeight = 15F;
            this.colStockDisponible.HeaderText = "Stock Disponible";
            this.colStockDisponible.MinimumWidth = 80;
            this.colStockDisponible.Name = "colStockDisponible";
            this.colStockDisponible.ReadOnly = true;

            // 
            // colDeposito
            // 
            this.colDeposito.DataPropertyName = "Deposito";
            this.colDeposito.FillWeight = 20F;
            this.colDeposito.HeaderText = "Depósito";
            this.colDeposito.MinimumWidth = 100;
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.ReadOnly = true;

            // 
            // colEstadoStock
            // 
            this.colEstadoStock.DataPropertyName = "EstadoStock";
            this.colEstadoStock.FillWeight = 15F;
            this.colEstadoStock.HeaderText = "Estado";
            this.colEstadoStock.MinimumWidth = 80;
            this.colEstadoStock.Name = "colEstadoStock";
            this.colEstadoStock.ReadOnly = true;
            this.colEstadoStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstadoStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;

            // 
            // grpPedidos
            // 
            this.grpPedidos.AccessibleDescription = "Lista de pedidos pendientes de verificación";
            this.grpPedidos.AccessibleName = "Pedidos pendientes";
            this.grpPedidos.Controls.Add(this.dgvPedidos);
            this.grpPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPedidos.Location = new System.Drawing.Point(0, 0);
            this.grpPedidos.Name = "grpPedidos";
            this.grpPedidos.Padding = new System.Windows.Forms.Padding(5);
            this.grpPedidos.Size = new System.Drawing.Size(1024, 300);
            this.grpPedidos.TabIndex = 0;
            this.grpPedidos.TabStop = false;
            this.grpPedidos.Text = "Pedidos Pendientes de Verificación";

            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AccessibleDescription = "Lista de pedidos que requieren verificación de stock";
            this.dgvPedidos.AccessibleName = "Pedidos a verificar";
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeight = 29;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNumeroPedido,
                this.colFechaPedido,
                this.colClientePedido,
                this.colEstadoPedido
            });
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPedidos.Location = new System.Drawing.Point(5, 25);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1014, 270);
            this.dgvPedidos.TabIndex = 0;

            // 
            // colNumeroPedido
            // 
            this.colNumeroPedido.DataPropertyName = "NumeroPedido";
            this.colNumeroPedido.FillWeight = 15F;
            this.colNumeroPedido.HeaderText = "Nº Pedido";
            this.colNumeroPedido.MinimumWidth = 80;
            this.colNumeroPedido.Name = "colNumeroPedido";
            this.colNumeroPedido.ReadOnly = true;

            // 
            // colFechaPedido
            // 
            this.colFechaPedido.DataPropertyName = "FechaPedido";
            this.colFechaPedido.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colFechaPedido.FillWeight = 20F;
            this.colFechaPedido.HeaderText = "Fecha";
            this.colFechaPedido.MinimumWidth = 120;
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.ReadOnly = true;

            // 
            // colClientePedido
            // 
            this.colClientePedido.DataPropertyName = "NombreCliente";
            this.colClientePedido.FillWeight = 45F;
            this.colClientePedido.HeaderText = "Cliente";
            this.colClientePedido.MinimumWidth = 150;
            this.colClientePedido.Name = "colClientePedido";
            this.colClientePedido.ReadOnly = true;

            // 
            // colEstadoPedido
            // 
            this.colEstadoPedido.DataPropertyName = "EstadoPedido";
            this.colEstadoPedido.FillWeight = 20F;
            this.colEstadoPedido.HeaderText = "Estado";
            this.colEstadoPedido.MinimumWidth = 100;
            this.colEstadoPedido.Name = "colEstadoPedido";
            this.colEstadoPedido.ReadOnly = true;

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.flowBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 603);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(8);
            this.panelBottom.Size = new System.Drawing.Size(1024, 48);
            this.panelBottom.TabIndex = 2;

            // 
            // flowBottom
            // 
            this.flowBottom.Controls.Add(this.btnActualizarStock);
            this.flowBottom.Controls.Add(this.btnRechazarPedido);
            this.flowBottom.Controls.Add(this.btnConfirmarPedido);
            this.flowBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowBottom.Location = new System.Drawing.Point(614, 8);
            this.flowBottom.Name = "flowBottom";
            this.flowBottom.Size = new System.Drawing.Size(402, 32);
            this.flowBottom.TabIndex = 0;
            this.flowBottom.WrapContents = false;

            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.AccessibleDescription = "Actualizar información de stock en el sistema";
            this.btnActualizarStock.AccessibleName = "Actualizar stock";
            this.btnActualizarStock.AutoSize = true;
            this.btnActualizarStock.Location = new System.Drawing.Point(278, 3);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(121, 30);
            this.btnActualizarStock.TabIndex = 0;
            this.btnActualizarStock.Text = "&Actualizar Stock";
            this.btnActualizarStock.UseVisualStyleBackColor = true;

            // 
            // btnRechazarPedido
            // 
            this.btnRechazarPedido.AccessibleDescription = "Rechazar el pedido por stock insuficiente";
            this.btnRechazarPedido.AccessibleName = "Rechazar pedido";
            this.btnRechazarPedido.AutoSize = true;
            this.btnRechazarPedido.Location = new System.Drawing.Point(165, 3);
            this.btnRechazarPedido.Name = "btnRechazarPedido";
            this.btnRechazarPedido.Size = new System.Drawing.Size(107, 30);
            this.btnRechazarPedido.TabIndex = 1;
            this.btnRechazarPedido.Text = "&Rechazar Pedido";
            this.btnRechazarPedido.UseVisualStyleBackColor = true;

            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.AccessibleDescription = "Confirmar el pedido con stock disponible";
            this.btnConfirmarPedido.AccessibleName = "Confirmar pedido";
            this.btnConfirmarPedido.AutoSize = true;
            this.btnConfirmarPedido.Location = new System.Drawing.Point(50, 3);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(109, 30);
            this.btnConfirmarPedido.TabIndex = 2;
            this.btnConfirmarPedido.Text = "&Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;

            // 
            // VerificacionStock
            // 
            this.AcceptButton = this.btnBuscar;
            this.AccessibleDescription = "Formulario para verificar disponibilidad de stock de pedidos";
            this.AccessibleName = "Verificación de Stock";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "VerificacionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Verificación de Stock (Vendedor)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.grpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.flowBottom.ResumeLayout(false);
            this.flowBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}