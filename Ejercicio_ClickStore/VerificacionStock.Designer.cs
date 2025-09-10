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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            grpFiltros = new GroupBox();
            tlpFiltros = new TableLayoutPanel();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            btnBuscar = new Button();
            panelRight = new Panel();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidadSolicitada = new DataGridViewTextBoxColumn();
            colStockDisponible = new DataGridViewTextBoxColumn();
            colDeposito = new DataGridViewTextBoxColumn();
            colEstadoStock = new DataGridViewImageColumn();
            grpPedidos = new GroupBox();
            dgvPedidos = new DataGridView();
            colNumeroPedido = new DataGridViewTextBoxColumn();
            colFechaPedido = new DataGridViewTextBoxColumn();
            colClientePedido = new DataGridViewTextBoxColumn();
            colEstadoPedido = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            flowBottom = new FlowLayoutPanel();
            btnActualizarStock = new Button();
            btnRechazarPedido = new Button();
            btnConfirmarPedido = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpFiltros.SuspendLayout();
            tlpFiltros.SuspendLayout();
            panelRight.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panelBottom.SuspendLayout();
            flowBottom.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AccessibleDescription = "Barra de herramientas para verificación de stock";
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
            tsbGuardar.AccessibleDescription = "Guardar verificaciones realizadas";
            tsbGuardar.AccessibleName = "Guardar";
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar verificaciones (Ctrl+G)";
            // 
            // tsbImprimir
            // 
            tsbImprimir.AccessibleDescription = "Imprimir reporte de stock";
            tsbImprimir.AccessibleName = "Imprimir";
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir reporte (Ctrl+P)";
            // 
            // tsbAyuda
            // 
            tsbAyuda.AccessibleDescription = "Mostrar ayuda sobre verificación de stock";
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
            splitContainer1.AccessibleDescription = "Panel dividido: filtros a la izquierda, pedidos y stock a la derecha";
            splitContainer1.AccessibleName = "Panel principal";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleDescription = "Área de filtros de búsqueda";
            splitContainer1.Panel1.AccessibleName = "Filtros";
            splitContainer1.Panel1.Controls.Add(grpFiltros);
            splitContainer1.Panel1MinSize = 280;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleDescription = "Área de pedidos y verificación de stock";
            splitContainer1.Panel2.AccessibleName = "Pedidos y stock";
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Panel2MinSize = 700;
            splitContainer1.Size = new Size(1350, 647);
            splitContainer1.SplitterDistance = 320;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // grpFiltros
            // 
            grpFiltros.AccessibleDescription = "Controles para filtrar pedidos";
            grpFiltros.AccessibleName = "Filtros de búsqueda";
            grpFiltros.Controls.Add(tlpFiltros);
            grpFiltros.Dock = DockStyle.Fill;
            grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltros.Location = new Point(0, 0);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Padding = new Padding(8);
            grpFiltros.Size = new Size(320, 647);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros de Búsqueda";
            // 
            // tlpFiltros
            // 
            tlpFiltros.AccessibleDescription = "Tabla de controles de filtrado";
            tlpFiltros.AccessibleName = "Controles de filtros";
            tlpFiltros.ColumnCount = 2;
            tlpFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFiltros.Controls.Add(lblFecha, 0, 0);
            tlpFiltros.Controls.Add(dtpFecha, 1, 0);
            tlpFiltros.Controls.Add(lblEstado, 0, 1);
            tlpFiltros.Controls.Add(cboEstado, 1, 1);
            tlpFiltros.Controls.Add(lblCliente, 0, 2);
            tlpFiltros.Controls.Add(txtCliente, 1, 2);
            tlpFiltros.Controls.Add(btnBuscar, 1, 3);
            tlpFiltros.Dock = DockStyle.Top;
            tlpFiltros.Font = new Font("Segoe UI", 9F);
            tlpFiltros.Location = new Point(8, 28);
            tlpFiltros.Name = "tlpFiltros";
            tlpFiltros.RowCount = 4;
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFiltros.Size = new Size(304, 145);
            tlpFiltros.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AccessibleDescription = "Etiqueta para filtro de fecha";
            lblFecha.AccessibleName = "Fecha";
            lblFecha.Anchor = AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(3, 7);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "&Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.AccessibleDescription = "Seleccionar fecha de pedidos a verificar";
            dtpFecha.AccessibleName = "Fecha de pedidos";
            dtpFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(93, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(208, 27);
            dtpFecha.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.AccessibleDescription = "Etiqueta para filtro de estado";
            lblEstado.AccessibleName = "Estado";
            lblEstado.Anchor = AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(3, 42);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "&Estado:";
            // 
            // cboEstado
            // 
            cboEstado.AccessibleDescription = "Seleccionar estado del pedido a verificar";
            cboEstado.AccessibleName = "Estado del pedido";
            cboEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Items.AddRange(new object[] { "Todos", "Pendiente verificación", "Stock confirmado", "Stock insuficiente", "Confirmado", "Rechazado" });
            cboEstado.Location = new Point(93, 38);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(208, 28);
            cboEstado.TabIndex = 3;
            // 
            // lblCliente
            // 
            lblCliente.AccessibleDescription = "Etiqueta para filtro de cliente";
            lblCliente.AccessibleName = "Cliente";
            lblCliente.Anchor = AnchorStyles.Left;
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(3, 77);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "&Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.AccessibleDescription = "Escribir nombre del cliente para filtrar";
            txtCliente.AccessibleName = "Nombre del cliente";
            txtCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Location = new Point(93, 74);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Nombre del cliente";
            txtCliente.Size = new Size(208, 27);
            txtCliente.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.AccessibleDescription = "Aplicar filtros y buscar pedidos";
            btnBuscar.AccessibleName = "Buscar pedidos";
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.Location = new Point(93, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpDetalle);
            panelRight.Controls.Add(grpPedidos);
            panelRight.Controls.Add(panelBottom);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1024, 647);
            panelRight.TabIndex = 0;
            // 
            // grpDetalle
            // 
            grpDetalle.AccessibleDescription = "Detalle de productos y verificación de stock";
            grpDetalle.AccessibleName = "Verificación de stock";
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Dock = DockStyle.Fill;
            grpDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDetalle.Location = new Point(0, 300);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(5);
            grpDetalle.Size = new Size(1024, 290);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Verificación de Stock - Productos del Pedido";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AccessibleDescription = "Tabla de verificación de stock por producto";
            dgvDetalle.AccessibleName = "Stock de productos";
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeight = 29;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidadSolicitada, colStockDisponible, colDeposito, colEstadoStock });
            dgvDetalle.Dock = DockStyle.Fill;
            dgvDetalle.Font = new Font("Segoe UI", 9F);
            dgvDetalle.Location = new Point(5, 25);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(1014, 260);
            dgvDetalle.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "NombreProducto";
            colProducto.FillWeight = 35F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 200;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidadSolicitada
            // 
            colCantidadSolicitada.DataPropertyName = "CantidadSolicitada";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCantidadSolicitada.DefaultCellStyle = dataGridViewCellStyle1;
            colCantidadSolicitada.FillWeight = 15F;
            colCantidadSolicitada.HeaderText = "Cant. Solicitada";
            colCantidadSolicitada.MinimumWidth = 80;
            colCantidadSolicitada.Name = "colCantidadSolicitada";
            colCantidadSolicitada.ReadOnly = true;
            // 
            // colStockDisponible
            // 
            colStockDisponible.DataPropertyName = "StockDisponible";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStockDisponible.DefaultCellStyle = dataGridViewCellStyle2;
            colStockDisponible.FillWeight = 15F;
            colStockDisponible.HeaderText = "Stock Disponible";
            colStockDisponible.MinimumWidth = 80;
            colStockDisponible.Name = "colStockDisponible";
            colStockDisponible.ReadOnly = true;
            // 
            // colDeposito
            // 
            colDeposito.DataPropertyName = "Deposito";
            colDeposito.FillWeight = 20F;
            colDeposito.HeaderText = "Depósito";
            colDeposito.MinimumWidth = 100;
            colDeposito.Name = "colDeposito";
            colDeposito.ReadOnly = true;
            // 
            // colEstadoStock
            // 
            colEstadoStock.DataPropertyName = "EstadoStock";
            colEstadoStock.FillWeight = 15F;
            colEstadoStock.HeaderText = "Estado";
            colEstadoStock.MinimumWidth = 80;
            colEstadoStock.Name = "colEstadoStock";
            colEstadoStock.ReadOnly = true;
            colEstadoStock.Resizable = DataGridViewTriState.True;
            colEstadoStock.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // grpPedidos
            // 
            grpPedidos.AccessibleDescription = "Lista de pedidos pendientes de verificación";
            grpPedidos.AccessibleName = "Pedidos pendientes";
            grpPedidos.Controls.Add(dgvPedidos);
            grpPedidos.Dock = DockStyle.Top;
            grpPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPedidos.Location = new Point(0, 0);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Padding = new Padding(5);
            grpPedidos.Size = new Size(1024, 300);
            grpPedidos.TabIndex = 0;
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos Pendientes de Verificación";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AccessibleDescription = "Lista de pedidos que requieren verificación de stock";
            dgvPedidos.AccessibleName = "Pedidos a verificar";
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeight = 29;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colNumeroPedido, colFechaPedido, colClientePedido, colEstadoPedido });
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Font = new Font("Segoe UI", 9F);
            dgvPedidos.Location = new Point(5, 25);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1014, 270);
            dgvPedidos.TabIndex = 0;
            // 
            // colNumeroPedido
            // 
            colNumeroPedido.DataPropertyName = "NumeroPedido";
            colNumeroPedido.FillWeight = 15F;
            colNumeroPedido.HeaderText = "Nº Pedido";
            colNumeroPedido.MinimumWidth = 80;
            colNumeroPedido.Name = "colNumeroPedido";
            colNumeroPedido.ReadOnly = true;
            // 
            // colFechaPedido
            // 
            colFechaPedido.DataPropertyName = "FechaPedido";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm";
            colFechaPedido.DefaultCellStyle = dataGridViewCellStyle3;
            colFechaPedido.FillWeight = 20F;
            colFechaPedido.HeaderText = "Fecha";
            colFechaPedido.MinimumWidth = 120;
            colFechaPedido.Name = "colFechaPedido";
            colFechaPedido.ReadOnly = true;
            // 
            // colClientePedido
            // 
            colClientePedido.DataPropertyName = "NombreCliente";
            colClientePedido.FillWeight = 45F;
            colClientePedido.HeaderText = "Cliente";
            colClientePedido.MinimumWidth = 150;
            colClientePedido.Name = "colClientePedido";
            colClientePedido.ReadOnly = true;
            // 
            // colEstadoPedido
            // 
            colEstadoPedido.DataPropertyName = "EstadoPedido";
            colEstadoPedido.FillWeight = 20F;
            colEstadoPedido.HeaderText = "Estado";
            colEstadoPedido.MinimumWidth = 100;
            colEstadoPedido.Name = "colEstadoPedido";
            colEstadoPedido.ReadOnly = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 590);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(1024, 57);
            panelBottom.TabIndex = 2;
            // 
            // flowBottom
            // 
            flowBottom.Controls.Add(btnActualizarStock);
            flowBottom.Controls.Add(btnRechazarPedido);
            flowBottom.Controls.Add(btnConfirmarPedido);
            flowBottom.Dock = DockStyle.Right;
            flowBottom.FlowDirection = FlowDirection.RightToLeft;
            flowBottom.Location = new Point(605, 8);
            flowBottom.Name = "flowBottom";
            flowBottom.Size = new Size(411, 41);
            flowBottom.TabIndex = 0;
            flowBottom.WrapContents = false;
            // 
            // btnActualizarStock
            // 
            btnActualizarStock.AccessibleDescription = "Actualizar información de stock en el sistema";
            btnActualizarStock.AccessibleName = "Actualizar stock";
            btnActualizarStock.AutoSize = true;
            btnActualizarStock.Location = new Point(283, 3);
            btnActualizarStock.Name = "btnActualizarStock";
            btnActualizarStock.Size = new Size(125, 30);
            btnActualizarStock.TabIndex = 0;
            btnActualizarStock.Text = "&Actualizar Stock";
            btnActualizarStock.UseVisualStyleBackColor = true;
            // 
            // btnRechazarPedido
            // 
            btnRechazarPedido.AccessibleDescription = "Rechazar el pedido por stock insuficiente";
            btnRechazarPedido.AccessibleName = "Rechazar pedido";
            btnRechazarPedido.AutoSize = true;
            btnRechazarPedido.Location = new Point(148, 3);
            btnRechazarPedido.Name = "btnRechazarPedido";
            btnRechazarPedido.Size = new Size(129, 30);
            btnRechazarPedido.TabIndex = 1;
            btnRechazarPedido.Text = "&Rechazar Pedido";
            btnRechazarPedido.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.AccessibleDescription = "Confirmar el pedido con stock disponible";
            btnConfirmarPedido.AccessibleName = "Confirmar pedido";
            btnConfirmarPedido.AutoSize = true;
            btnConfirmarPedido.Location = new Point(7, 3);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(135, 30);
            btnConfirmarPedido.TabIndex = 2;
            btnConfirmarPedido.Text = "&Confirmar Pedido";
            btnConfirmarPedido.UseVisualStyleBackColor = true;
            // 
            // VerificacionStock
            // 
            AcceptButton = btnBuscar;
            AccessibleDescription = "Formulario para verificar disponibilidad de stock de pedidos";
            AccessibleName = "Verificación de Stock";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "VerificacionStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Verificación de Stock (Vendedor)";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            tlpFiltros.ResumeLayout(false);
            tlpFiltros.PerformLayout();
            panelRight.ResumeLayout(false);
            grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panelBottom.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}