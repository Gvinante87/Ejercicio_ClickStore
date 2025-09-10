namespace Ejercicio_ClickStore
{
    partial class Checkout
    {
        private System.ComponentModel.IContainer components = null;

        // Tool/Status
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        // Tabs
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCarrito;
        private System.Windows.Forms.TabPage tabPageEnvio;
        private System.Windows.Forms.TabPage tabPagePago;
        private System.Windows.Forms.TabPage tabPageConfirmacion;

        // Carrito
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;

        // Envío
        private System.Windows.Forms.TableLayoutPanel tlpEnvio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblFranja;
        private System.Windows.Forms.ComboBox cboFranja;

        // Pago
        private System.Windows.Forms.TableLayoutPanel tlpPago;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.ComboBox cboFactura;

        // Confirmación
        private System.Windows.Forms.RichTextBox rtbConfirmacion;

        // Botones
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCarrito = new System.Windows.Forms.TabPage();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageEnvio = new System.Windows.Forms.TabPage();
            this.tlpEnvio = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblFranja = new System.Windows.Forms.Label();
            this.cboFranja = new System.Windows.Forms.ComboBox();
            this.tabPagePago = new System.Windows.Forms.TabPage();
            this.tlpPago = new System.Windows.Forms.TableLayoutPanel();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.cboFactura = new System.Windows.Forms.ComboBox();
            this.tabPageConfirmacion = new System.Windows.Forms.TabPage();
            this.rtbConfirmacion = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.tabPageEnvio.SuspendLayout();
            this.tlpEnvio.SuspendLayout();
            this.tabPagePago.SuspendLayout();
            this.tlpPago.SuspendLayout();
            this.tabPageConfirmacion.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.flowBottom.SuspendLayout();
            this.SuspendLayout();

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
            this.toolStrip1.TabIndex = 2;

            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 24);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.ToolTipText = "Guardar pedido";

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(70, 24);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir resumen";

            // 
            // tsbAyuda
            // 
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(55, 24);
            this.tsbAyuda.Text = "A&yuda";
            this.tsbAyuda.ToolTipText = "Mostrar ayuda";

            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip1.TabIndex = 3;

            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel1.Text = "Listo";

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCarrito);
            this.tabControl1.Controls.Add(this.tabPageEnvio);
            this.tabControl1.Controls.Add(this.tabPagePago);
            this.tabControl1.Controls.Add(this.tabPageConfirmacion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 599);
            this.tabControl1.TabIndex = 0;

            // 
            // tabPageCarrito
            // 
            this.tabPageCarrito.Controls.Add(this.dgvCarrito);
            this.tabPageCarrito.Location = new System.Drawing.Point(4, 29);
            this.tabPageCarrito.Name = "tabPageCarrito";
            this.tabPageCarrito.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageCarrito.Size = new System.Drawing.Size(1342, 566);
            this.tabPageCarrito.TabIndex = 0;
            this.tabPageCarrito.Text = "1. Carrito";
            this.tabPageCarrito.UseVisualStyleBackColor = true;

            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeight = 29;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal});
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(10, 10);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(1322, 546);
            this.dgvCarrito.TabIndex = 0;

            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 200;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.FillWeight = 50F;

            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle.Format = "C2";
            this.colPrecio.HeaderText = "Precio Unitario";
            this.colPrecio.MinimumWidth = 100;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.FillWeight = 20F;

            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 80;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.FillWeight = 15F;

            // 
            // colSubtotal
            // 
            this.colSubtotal.DataPropertyName = "Subtotal";
            this.colSubtotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubtotal.DefaultCellStyle.Format = "C2";
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 100;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.FillWeight = 20F;

            // 
            // tabPageEnvio
            // 
            this.tabPageEnvio.Controls.Add(this.tlpEnvio);
            this.tabPageEnvio.Location = new System.Drawing.Point(4, 29);
            this.tabPageEnvio.Name = "tabPageEnvio";
            this.tabPageEnvio.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageEnvio.Size = new System.Drawing.Size(1342, 566);
            this.tabPageEnvio.TabIndex = 1;
            this.tabPageEnvio.Text = "2. Envío";
            this.tabPageEnvio.UseVisualStyleBackColor = true;

            // 
            // tlpEnvio
            // 
            this.tlpEnvio.ColumnCount = 4;
            this.tlpEnvio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpEnvio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEnvio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpEnvio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEnvio.Controls.Add(this.lblNombre, 0, 0);
            this.tlpEnvio.Controls.Add(this.txtNombre, 1, 0);
            this.tlpEnvio.Controls.Add(this.lblTelefono, 2, 0);
            this.tlpEnvio.Controls.Add(this.txtTelefono, 3, 0);
            this.tlpEnvio.Controls.Add(this.lblDireccion, 0, 1);
            this.tlpEnvio.Controls.Add(this.txtDireccion, 1, 1);
            this.tlpEnvio.Controls.Add(this.lblCiudad, 2, 1);
            this.tlpEnvio.Controls.Add(this.txtCiudad, 3, 1);
            this.tlpEnvio.Controls.Add(this.lblCP, 0, 2);
            this.tlpEnvio.Controls.Add(this.txtCP, 1, 2);
            this.tlpEnvio.Controls.Add(this.lblFranja, 2, 2);
            this.tlpEnvio.Controls.Add(this.cboFranja, 3, 2);
            this.tlpEnvio.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEnvio.Location = new System.Drawing.Point(20, 20);
            this.tlpEnvio.Name = "tlpEnvio";
            this.tlpEnvio.RowCount = 3;
            this.tlpEnvio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEnvio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEnvio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEnvio.Size = new System.Drawing.Size(1302, 120);
            this.tlpEnvio.TabIndex = 0;

            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "&Nombre completo:";

            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(123, 6);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Juan Pérez";
            this.txtNombre.Size = new System.Drawing.Size(525, 27);
            this.txtNombre.TabIndex = 1;

            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(654, 10);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 20);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "&Teléfono:";

            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(774, 6);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "11-1234-5678";
            this.txtTelefono.Size = new System.Drawing.Size(525, 27);
            this.txtTelefono.TabIndex = 3;

            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 50);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "&Dirección:";

            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(123, 46);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Av. Corrientes 1234, Piso 5, Depto A";
            this.txtDireccion.Size = new System.Drawing.Size(525, 27);
            this.txtDireccion.TabIndex = 5;

            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(654, 50);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "&Ciudad:";

            // 
            // txtCiudad
            // 
            this.txtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiudad.Location = new System.Drawing.Point(774, 46);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PlaceholderText = "Buenos Aires";
            this.txtCiudad.Size = new System.Drawing.Size(525, 27);
            this.txtCiudad.TabIndex = 7;

            // 
            // lblCP
            // 
            this.lblCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(3, 90);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(102, 20);
            this.lblCP.TabIndex = 8;
            this.lblCP.Text = "&Código Postal:";

            // 
            // txtCP
            // 
            this.txtCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCP.Location = new System.Drawing.Point(123, 86);
            this.txtCP.MaxLength = 10;
            this.txtCP.Name = "txtCP";
            this.txtCP.PlaceholderText = "C1425";
            this.txtCP.Size = new System.Drawing.Size(120, 27);
            this.txtCP.TabIndex = 9;

            // 
            // lblFranja
            // 
            this.lblFranja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFranja.AutoSize = true;
            this.lblFranja.Location = new System.Drawing.Point(654, 90);
            this.lblFranja.Name = "lblFranja";
            this.lblFranja.Size = new System.Drawing.Size(105, 20);
            this.lblFranja.TabIndex = 10;
            this.lblFranja.Text = "&Franja horaria:";

            // 
            // cboFranja
            // 
            this.cboFranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFranja.Items.AddRange(new object[] {
            "Mañana (9:00 - 12:00)",
            "Tarde (14:00 - 18:00)",
            "Noche (18:00 - 21:00)"});
            this.cboFranja.Location = new System.Drawing.Point(774, 86);
            this.cboFranja.Name = "cboFranja";
            this.cboFranja.Size = new System.Drawing.Size(525, 28);
            this.cboFranja.TabIndex = 11;

            // 
            // tabPagePago
            // 
            this.tabPagePago.Controls.Add(this.tlpPago);
            this.tabPagePago.Location = new System.Drawing.Point(4, 29);
            this.tabPagePago.Name = "tabPagePago";
            this.tabPagePago.Padding = new System.Windows.Forms.Padding(20);
            this.tabPagePago.Size = new System.Drawing.Size(1342, 566);
            this.tabPagePago.TabIndex = 2;
            this.tabPagePago.Text = "3. Pago";
            this.tabPagePago.UseVisualStyleBackColor = true;

            // 
            // tlpPago
            // 
            this.tlpPago.ColumnCount = 4;
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPago.Controls.Add(this.lblMetodo, 0, 0);
            this.tlpPago.Controls.Add(this.cboMetodo, 1, 0);
            this.tlpPago.Controls.Add(this.lblNum, 2, 0);
            this.tlpPago.Controls.Add(this.txtNum, 3, 0);
            this.tlpPago.Controls.Add(this.lblCuotas, 0, 1);
            this.tlpPago.Controls.Add(this.cboCuotas, 1, 1);
            this.tlpPago.Controls.Add(this.lblFactura, 2, 1);
            this.tlpPago.Controls.Add(this.cboFactura, 3, 1);
            this.tlpPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPago.Location = new System.Drawing.Point(20, 20);
            this.tlpPago.Name = "tlpPago";
            this.tlpPago.RowCount = 2;
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPago.Size = new System.Drawing.Size(1302, 80);
            this.tlpPago.TabIndex = 0;

            // 
            // lblMetodo
            // 
            this.lblMetodo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(3, 10);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(110, 20);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "&Método de pago:";

            // 
            // cboMetodo
            // 
            this.cboMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Items.AddRange(new object[] {
            "Tarjeta de Crédito",
            "Tarjeta de Débito",
            "Transferencia Bancaria",
            "Mercado Pago",
            "Efectivo contra entrega"});
            this.cboMetodo.Location = new System.Drawing.Point(123, 6);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(525, 28);
            this.cboMetodo.TabIndex = 1;

            // 
            // lblNum
            // 
            this.lblNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(654, 10);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(92, 20);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "&Nº de tarjeta:";

            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.Location = new System.Drawing.Point(774, 6);
            this.txtNum.MaxLength = 19;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasswordChar = '*';
            this.txtNum.PlaceholderText = "1234 5678 9012 3456";
            this.txtNum.Size = new System.Drawing.Size(525, 27);
            this.txtNum.TabIndex = 3;

            // 
            // lblCuotas
            // 
            this.lblCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(3, 50);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(54, 20);
            this.lblCuotas.TabIndex = 4;
            this.lblCuotas.Text = "&Cuotas:";

            // 
            // cboCuotas
            // 
            this.cboCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Items.AddRange(new object[] {
            "1 cuota sin interés",
            "3 cuotas sin interés",
            "6 cuotas con 5% interés",
            "12 cuotas con 15% interés",
            "18 cuotas con 25% interés"});
            this.cboCuotas.Location = new System.Drawing.Point(123, 46);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(200, 28);
            this.cboCuotas.TabIndex = 5;

            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(654, 50);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(99, 20);
            this.lblFactura.TabIndex = 6;
            this.lblFactura.Text = "Tipo de &factura:";

            // 
            // cboFactura
            // 
            this.cboFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactura.Items.AddRange(new object[] {
            "Consumidor Final (Factura B)",
            "Responsable Inscripto (Factura A)",
            "Monotributista (Factura B)",
            "Exento (Factura C)"});
            this.cboFactura.Location = new System.Drawing.Point(774, 46);
            this.cboFactura.Name = "cboFactura";
            this.cboFactura.Size = new System.Drawing.Size(200, 28);
            this.cboFactura.TabIndex = 7;

            // 
            // tabPageConfirmacion
            // 
            this.tabPageConfirmacion.Controls.Add(this.rtbConfirmacion);
            this.tabPageConfirmacion.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfirmacion.Name = "tabPageConfirmacion";
            this.tabPageConfirmacion.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageConfirmacion.Size = new System.Drawing.Size(1342, 566);
            this.tabPageConfirmacion.TabIndex = 3;
            this.tabPageConfirmacion.Text = "4. Confirmación";
            this.tabPageConfirmacion.UseVisualStyleBackColor = true;

            // 
            // rtbConfirmacion
            // 
            this.rtbConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConfirmacion.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbConfirmacion.Location = new System.Drawing.Point(20, 20);
            this.rtbConfirmacion.Name = "rtbConfirmacion";
            this.rtbConfirmacion.ReadOnly = true;
            this.rtbConfirmacion.Size = new System.Drawing.Size(1302, 526);
            this.rtbConfirmacion.TabIndex = 0;
            this.rtbConfirmacion.Text = "Aquí se mostrará el resumen completo de su pedido...";

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.flowBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 626);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(1350, 48);
            this.panelBottom.TabIndex = 1;

            // 
            // flowBottom
            // 
            this.flowBottom.Controls.Add(this.btnConfirmar);
            this.flowBottom.Controls.Add(this.btnCancelar);
            this.flowBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowBottom.Location = new System.Drawing.Point(1168, 10);
            this.flowBottom.Name = "flowBottom";
            this.flowBottom.Size = new System.Drawing.Size(172, 28);
            this.flowBottom.TabIndex = 0;
            this.flowBottom.WrapContents = false;

            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Location = new System.Drawing.Point(85, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 30);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;

            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;

            // 
            // Checkout
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Finalizar Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.tabPageEnvio.ResumeLayout(false);
            this.tlpEnvio.ResumeLayout(false);
            this.tlpEnvio.PerformLayout();
            this.tabPagePago.ResumeLayout(false);
            this.tlpPago.ResumeLayout(false);
            this.tlpPago.PerformLayout();
            this.tabPageConfirmacion.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.flowBottom.ResumeLayout(false);
            this.flowBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}