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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            grpFiltros = new GroupBox();
            tlpFiltros = new TableLayoutPanel();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnBuscar = new Button();
            panelRight = new Panel();
            grpDetalle = new GroupBox();
            rtbDetalle = new RichTextBox();
            dgvPedidos = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colMedioPago = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            flowBottom = new FlowLayoutPanel();
            btnExportarExcel = new Button();
            btnMarcarRecibido = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panelBottom.SuspendLayout();
            flowBottom.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AccessibleDescription = "Barra de herramientas principal";
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
            tsbGuardar.AccessibleDescription = "Guardar configuración de filtros";
            tsbGuardar.AccessibleName = "Guardar";
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar configuración (Ctrl+G)";
            // 
            // tsbImprimir
            // 
            tsbImprimir.AccessibleDescription = "Imprimir reporte de pagos";
            tsbImprimir.AccessibleName = "Imprimir";
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir reporte (Ctrl+P)";
            // 
            // tsbAyuda
            // 
            tsbAyuda.AccessibleDescription = "Mostrar ayuda sobre gestión de pagos";
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
            splitContainer1.AccessibleDescription = "Panel dividido: filtros a la izquierda, resultados a la derecha";
            splitContainer1.AccessibleName = "Panel principal";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleDescription = "Área de filtros y búsqueda";
            splitContainer1.Panel1.AccessibleName = "Filtros";
            splitContainer1.Panel1.Controls.Add(grpFiltros);
            splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleDescription = "Área de resultados y detalles";
            splitContainer1.Panel2.AccessibleName = "Resultados";
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Panel2MinSize = 500;
            splitContainer1.Size = new Size(1350, 647);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // grpFiltros
            // 
            grpFiltros.AccessibleDescription = "Controles para filtrar pedidos por fecha, cliente y estado";
            grpFiltros.AccessibleName = "Filtros de búsqueda";
            grpFiltros.Controls.Add(tlpFiltros);
            grpFiltros.Dock = DockStyle.Fill;
            grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltros.Location = new Point(0, 0);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Padding = new Padding(8);
            grpFiltros.Size = new Size(400, 647);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros de Búsqueda";
            // 
            // tlpFiltros
            // 
            tlpFiltros.AccessibleDescription = "Tabla de controles de filtrado";
            tlpFiltros.AccessibleName = "Controles de filtros";
            tlpFiltros.ColumnCount = 2;
            tlpFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFiltros.Controls.Add(lblDesde, 0, 0);
            tlpFiltros.Controls.Add(dtpDesde, 1, 0);
            tlpFiltros.Controls.Add(lblHasta, 0, 1);
            tlpFiltros.Controls.Add(dtpHasta, 1, 1);
            tlpFiltros.Controls.Add(lblCliente, 0, 2);
            tlpFiltros.Controls.Add(txtCliente, 1, 2);
            tlpFiltros.Controls.Add(lblEstado, 0, 3);
            tlpFiltros.Controls.Add(cboEstado, 1, 3);
            tlpFiltros.Controls.Add(btnBuscar, 1, 4);
            tlpFiltros.Dock = DockStyle.Top;
            tlpFiltros.Font = new Font("Segoe UI", 9F);
            tlpFiltros.Location = new Point(8, 28);
            tlpFiltros.Name = "tlpFiltros";
            tlpFiltros.RowCount = 5;
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFiltros.Size = new Size(384, 180);
            tlpFiltros.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.AccessibleDescription = "Etiqueta para fecha inicial";
            lblDesde.AccessibleName = "Desde";
            lblDesde.Anchor = AnchorStyles.Left;
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(3, 7);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(54, 20);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "&Desde:";
            lblDesde.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDesde
            // 
            dtpDesde.AccessibleDescription = "Seleccionar fecha inicial para el filtro";
            dtpDesde.AccessibleName = "Fecha desde";
            dtpDesde.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(103, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(278, 27);
            dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.AccessibleDescription = "Etiqueta para fecha final";
            lblHasta.AccessibleName = "Hasta";
            lblHasta.Anchor = AnchorStyles.Left;
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(3, 42);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "&Hasta:";
            lblHasta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            dtpHasta.AccessibleDescription = "Seleccionar fecha final para el filtro";
            dtpHasta.AccessibleName = "Fecha hasta";
            dtpHasta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(103, 39);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(278, 27);
            dtpHasta.TabIndex = 3;
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
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            txtCliente.AccessibleDescription = "Escribir nombre del cliente para filtrar";
            txtCliente.AccessibleName = "Nombre del cliente";
            txtCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Location = new Point(103, 74);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Nombre del cliente";
            txtCliente.Size = new Size(278, 27);
            txtCliente.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AccessibleDescription = "Etiqueta para filtro de estado";
            lblEstado.AccessibleName = "Estado";
            lblEstado.Anchor = AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(3, 112);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "&Estado:";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboEstado
            // 
            cboEstado.AccessibleDescription = "Seleccionar estado del pedido para filtrar";
            cboEstado.AccessibleName = "Estado del pedido";
            cboEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Pagado", "Entregado", "Cancelado" });
            cboEstado.Location = new Point(103, 108);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(278, 28);
            cboEstado.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.AccessibleDescription = "Aplicar filtros y buscar pedidos";
            btnBuscar.AccessibleName = "Buscar pedidos";
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.Location = new Point(103, 145);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpDetalle);
            panelRight.Controls.Add(dgvPedidos);
            panelRight.Controls.Add(panelBottom);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(944, 647);
            panelRight.TabIndex = 0;
            // 
            // grpDetalle
            // 
            grpDetalle.AccessibleDescription = "Detalles del pedido seleccionado";
            grpDetalle.AccessibleName = "Detalle del pedido";
            grpDetalle.Controls.Add(rtbDetalle);
            grpDetalle.Dock = DockStyle.Fill;
            grpDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDetalle.Location = new Point(0, 350);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(5);
            grpDetalle.Size = new Size(944, 244);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle del Pedido / Comprobante";
            // 
            // rtbDetalle
            // 
            rtbDetalle.AccessibleDescription = "Información detallada del pedido y comprobante de pago";
            rtbDetalle.AccessibleName = "Detalle del pedido";
            rtbDetalle.Dock = DockStyle.Fill;
            rtbDetalle.Font = new Font("Consolas", 9F);
            rtbDetalle.Location = new Point(5, 25);
            rtbDetalle.Name = "rtbDetalle";
            rtbDetalle.ReadOnly = true;
            rtbDetalle.Size = new Size(934, 214);
            rtbDetalle.TabIndex = 0;
            rtbDetalle.Text = "Seleccione un pedido para ver sus detalles y comprobante de pago.";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AccessibleDescription = "Lista de pedidos entregados y sus pagos";
            dgvPedidos.AccessibleName = "Lista de pedidos";
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeight = 29;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colNumero, colCliente, colFecha, colTotal, colMedioPago, colEstado });
            dgvPedidos.Dock = DockStyle.Top;
            dgvPedidos.Location = new Point(0, 0);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(944, 350);
            dgvPedidos.TabIndex = 0;
            // 
            // colNumero
            // 
            colNumero.DataPropertyName = "Numero";
            colNumero.FillWeight = 15F;
            colNumero.HeaderText = "Nº Pedido";
            colNumero.MinimumWidth = 80;
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "Cliente";
            colCliente.FillWeight = 25F;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 120;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            colFecha.FillWeight = 15F;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 90;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            colTotal.DefaultCellStyle = dataGridViewCellStyle1;
            colTotal.FillWeight = 15F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 80;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colMedioPago
            // 
            colMedioPago.DataPropertyName = "MedioPago";
            colMedioPago.FillWeight = 20F;
            colMedioPago.HeaderText = "Medio de Pago";
            colMedioPago.MinimumWidth = 100;
            colMedioPago.Name = "colMedioPago";
            colMedioPago.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.FillWeight = 10F;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 80;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 594);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(944, 53);
            panelBottom.TabIndex = 2;
            // 
            // flowBottom
            // 
            flowBottom.Controls.Add(btnExportarExcel);
            flowBottom.Controls.Add(btnMarcarRecibido);
            flowBottom.Dock = DockStyle.Right;
            flowBottom.FlowDirection = FlowDirection.RightToLeft;
            flowBottom.Location = new Point(644, 8);
            flowBottom.Name = "flowBottom";
            flowBottom.Size = new Size(292, 37);
            flowBottom.TabIndex = 0;
            flowBottom.WrapContents = false;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.AccessibleDescription = "Exportar lista de pedidos a archivo Excel";
            btnExportarExcel.AccessibleName = "Exportar a Excel";
            btnExportarExcel.AutoSize = true;
            btnExportarExcel.Location = new Point(176, 3);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(113, 30);
            btnExportarExcel.TabIndex = 0;
            btnExportarExcel.Text = "&Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // btnMarcarRecibido
            // 
            btnMarcarRecibido.AccessibleDescription = "Marcar que se ha recibido el pago del pedido seleccionado";
            btnMarcarRecibido.AccessibleName = "Marcar pago recibido";
            btnMarcarRecibido.AutoSize = true;
            btnMarcarRecibido.Location = new Point(5, 3);
            btnMarcarRecibido.Name = "btnMarcarRecibido";
            btnMarcarRecibido.Size = new Size(165, 30);
            btnMarcarRecibido.TabIndex = 1;
            btnMarcarRecibido.Text = "&Marcar Pago Recibido";
            btnMarcarRecibido.UseVisualStyleBackColor = true;
            // 
            // PedidosEntregadosyPagos
            // 
            AcceptButton = btnBuscar;
            AccessibleDescription = "Formulario para gestionar pedidos entregados y pagos recibidos";
            AccessibleName = "Gestión de Pedidos y Pagos";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "PedidosEntregadosyPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Gestión de Pedidos y Pagos";
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
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panelBottom.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}