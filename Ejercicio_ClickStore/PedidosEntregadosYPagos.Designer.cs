namespace Ejercicio_ClickStore
{
    partial class PedidosEntregadosyPagos
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
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.RichTextBox rtbDetalle;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private System.Windows.Forms.Button btnMarcarRecibido;
        private System.Windows.Forms.Button btnExportarExcel;

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
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.rtbDetalle = new System.Windows.Forms.RichTextBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnMarcarRecibido = new System.Windows.Forms.Button();

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.flowBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = "Barra de herramientas principal";
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
            this.tsbGuardar.AccessibleDescription = "Guardar configuración de filtros";
            this.tsbGuardar.AccessibleName = "Guardar";
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 24);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.ToolTipText = "Guardar configuración (Ctrl+G)";

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.AccessibleDescription = "Imprimir reporte de pagos";
            this.tsbImprimir.AccessibleName = "Imprimir";
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(70, 24);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir reporte (Ctrl+P)";

            // 
            // tsbAyuda
            // 
            this.tsbAyuda.AccessibleDescription = "Mostrar ayuda sobre gestión de pagos";
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
            this.splitContainer1.AccessibleDescription = "Panel dividido: filtros a la izquierda, resultados a la derecha";
            this.splitContainer1.AccessibleName = "Panel principal";
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 350;
            this.splitContainer1.Panel2MinSize = 500;

            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = "Área de filtros y búsqueda";
            this.splitContainer1.Panel1.AccessibleName = "Filtros";
            this.splitContainer1.Panel1.Controls.Add(this.grpFiltros);

            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = "Área de resultados y detalles";
            this.splitContainer1.Panel2.AccessibleName = "Resultados";
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 651);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;

            // 
            // grpFiltros
            // 
            this.grpFiltros.AccessibleDescription = "Controles para filtrar pedidos por fecha, cliente y estado";
            this.grpFiltros.AccessibleName = "Filtros de búsqueda";
            this.grpFiltros.Controls.Add(this.tlpFiltros);
            this.grpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltros.Location = new System.Drawing.Point(0, 0);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.grpFiltros.Size = new System.Drawing.Size(400, 651);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de Búsqueda";

            // 
            // tlpFiltros
            // 
            this.tlpFiltros.AccessibleDescription = "Tabla de controles de filtrado";
            this.tlpFiltros.AccessibleName = "Controles de filtros";
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblDesde, 0, 0);
            this.tlpFiltros.Controls.Add(this.dtpDesde, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblHasta, 0, 1);
            this.tlpFiltros.Controls.Add(this.dtpHasta, 1, 1);
            this.tlpFiltros.Controls.Add(this.lblCliente, 0, 2);
            this.tlpFiltros.Controls.Add(this.txtCliente, 1, 2);
            this.tlpFiltros.Controls.Add(this.lblEstado, 0, 3);
            this.tlpFiltros.Controls.Add(this.cboEstado, 1, 3);
            this.tlpFiltros.Controls.Add(this.btnBuscar, 1, 4);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlpFiltros.Location = new System.Drawing.Point(8, 28);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 5;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFiltros.Size = new System.Drawing.Size(384, 180);
            this.tlpFiltros.TabIndex = 0;

            // 
            // lblDesde
            // 
            this.lblDesde.AccessibleDescription = "Etiqueta para fecha inicial";
            this.lblDesde.AccessibleName = "Desde";
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(3, 8);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "&Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dtpDesde
            // 
            this.dtpDesde.AccessibleDescription = "Seleccionar fecha inicial para el filtro";
            this.dtpDesde.AccessibleName = "Fecha desde";
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(103, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(278, 27);
            this.dtpDesde.TabIndex = 1;

            // 
            // lblHasta
            // 
            this.lblHasta.AccessibleDescription = "Etiqueta para fecha final";
            this.lblHasta.AccessibleName = "Hasta";
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(3, 43);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(49, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "&Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dtpHasta
            // 
            this.dtpHasta.AccessibleDescription = "Seleccionar fecha final para el filtro";
            this.dtpHasta.AccessibleName = "Fecha hasta";
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(103, 40);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(278, 27);
            this.dtpHasta.TabIndex = 3;

            // 
            // lblCliente
            // 
            this.lblCliente.AccessibleDescription = "Etiqueta para filtro de cliente";
            this.lblCliente.AccessibleName = "Cliente";
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "&Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtCliente
            // 
            this.txtCliente.AccessibleDescription = "Escribir nombre del cliente para filtrar";
            this.txtCliente.AccessibleName = "Nombre del cliente";
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(103, 75);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Nombre del cliente";
            this.txtCliente.Size = new System.Drawing.Size(278, 27);
            this.txtCliente.TabIndex = 5;

            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleDescription = "Etiqueta para filtro de estado";
            this.lblEstado.AccessibleName = "Estado";
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(3, 113);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "&Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cboEstado
            // 
            this.cboEstado.AccessibleDescription = "Seleccionar estado del pedido para filtrar";
            this.cboEstado.AccessibleName = "Estado del pedido";
            this.cboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Items.AddRange(new object[] {
                "Todos",
                "Pendiente",
                "Pagado",
                "Entregado",
                "Cancelado"
            });
            this.cboEstado.Location = new System.Drawing.Point(103, 109);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(278, 28);
            this.cboEstado.TabIndex = 7;

            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleDescription = "Aplicar filtros y buscar pedidos";
            this.btnBuscar.AccessibleName = "Buscar pedidos";
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Location = new System.Drawing.Point(103, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.grpDetalle);
            this.panelRight.Controls.Add(this.dgvPedidos);
            this.panelRight.Controls.Add(this.panelBottom);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(944, 651);
            this.panelRight.TabIndex = 0;

            // 
            // grpDetalle
            // 
            this.grpDetalle.AccessibleDescription = "Detalles del pedido seleccionado";
            this.grpDetalle.AccessibleName = "Detalle del pedido";
            this.grpDetalle.Controls.Add(this.rtbDetalle);
            this.grpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(0, 350);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(5);
            this.grpDetalle.Size = new System.Drawing.Size(944, 253);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Pedido / Comprobante";

            // 
            // rtbDetalle
            // 
            this.rtbDetalle.AccessibleDescription = "Información detallada del pedido y comprobante de pago";
            this.rtbDetalle.AccessibleName = "Detalle del pedido";
            this.rtbDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDetalle.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbDetalle.Location = new System.Drawing.Point(5, 25);
            this.rtbDetalle.Name = "rtbDetalle";
            this.rtbDetalle.ReadOnly = true;
            this.rtbDetalle.Size = new System.Drawing.Size(934, 223);
            this.rtbDetalle.TabIndex = 0;
            this.rtbDetalle.Text = "Seleccione un pedido para ver sus detalles y comprobante de pago.";

            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AccessibleDescription = "Lista de pedidos entregados y sus pagos";
            this.dgvPedidos.AccessibleName = "Lista de pedidos";
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeight = 29;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNumero,
                this.colCliente,
                this.colFecha,
                this.colTotal,
                this.colMedioPago,
                this.colEstado
            });
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(944, 350);
            this.dgvPedidos.TabIndex = 0;

            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "Numero";
            this.colNumero.FillWeight = 15F;
            this.colNumero.HeaderText = "Nº Pedido";
            this.colNumero.MinimumWidth = 80;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;

            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.FillWeight = 25F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 120;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;

            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.FillWeight = 15F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 90;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;

            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle.Format = "C2";
            this.colTotal.FillWeight = 15F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 80;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;

            // 
            // colMedioPago
            // 
            this.colMedioPago.DataPropertyName = "MedioPago";
            this.colMedioPago.FillWeight = 20F;
            this.colMedioPago.HeaderText = "Medio de Pago";
            this.colMedioPago.MinimumWidth = 100;
            this.colMedioPago.Name = "colMedioPago";
            this.colMedioPago.ReadOnly = true;

            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.FillWeight = 10F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 80;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.flowBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 603);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(8);
            this.panelBottom.Size = new System.Drawing.Size(944, 48);
            this.panelBottom.TabIndex = 2;

            // 
            // flowBottom
            // 
            this.flowBottom.Controls.Add(this.btnExportarExcel);
            this.flowBottom.Controls.Add(this.btnMarcarRecibido);
            this.flowBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowBottom.Location = new System.Drawing.Point(644, 8);
            this.flowBottom.Name = "flowBottom";
            this.flowBottom.Size = new System.Drawing.Size(292, 32);
            this.flowBottom.TabIndex = 0;
            this.flowBottom.WrapContents = false;

            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleDescription = "Exportar lista de pedidos a archivo Excel";
            this.btnExportarExcel.AccessibleName = "Exportar a Excel";
            this.btnExportarExcel.AutoSize = true;
            this.btnExportarExcel.Location = new System.Drawing.Point(179, 3);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(110, 30);
            this.btnExportarExcel.TabIndex = 0;
            this.btnExportarExcel.Text = "&Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;

            // 
            // btnMarcarRecibido
            // 
            this.btnMarcarRecibido.AccessibleDescription = "Marcar que se ha recibido el pago del pedido seleccionado";
            this.btnMarcarRecibido.AccessibleName = "Marcar pago recibido";
            this.btnMarcarRecibido.AutoSize = true;
            this.btnMarcarRecibido.Location = new System.Drawing.Point(38, 3);
            this.btnMarcarRecibido.Name = "btnMarcarRecibido";
            this.btnMarcarRecibido.Size = new System.Drawing.Size(135, 30);
            this.btnMarcarRecibido.TabIndex = 1;
            this.btnMarcarRecibido.Text = "&Marcar Pago Recibido";
            this.btnMarcarRecibido.UseVisualStyleBackColor = true;

            // 
            // PedidosEntregadosyPagos
            // 
            this.AcceptButton = this.btnBuscar;
            this.AccessibleDescription = "Formulario para gestionar pedidos entregados y pagos recibidos";
            this.AccessibleName = "Gestión de Pedidos y Pagos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "PedidosEntregadosyPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Gestión de Pedidos y Pagos";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.flowBottom.ResumeLayout(false);
            this.flowBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}