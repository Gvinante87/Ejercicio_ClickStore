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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPageCarrito = new TabPage();
            dgvCarrito = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            tabPageEnvio = new TabPage();
            tlpEnvio = new TableLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCiudad = new Label();
            txtCiudad = new TextBox();
            lblCP = new Label();
            txtCP = new TextBox();
            lblFranja = new Label();
            cboFranja = new ComboBox();
            tabPagePago = new TabPage();
            tlpPago = new TableLayoutPanel();
            lblMetodo = new Label();
            cboMetodo = new ComboBox();
            lblNum = new Label();
            txtNum = new TextBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            lblFactura = new Label();
            cboFactura = new ComboBox();
            tabPageConfirmacion = new TabPage();
            rtbConfirmacion = new RichTextBox();
            panelBottom = new Panel();
            flowBottom = new FlowLayoutPanel();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            tabPageEnvio.SuspendLayout();
            tlpEnvio.SuspendLayout();
            tabPagePago.SuspendLayout();
            tlpPago.SuspendLayout();
            tabPageConfirmacion.SuspendLayout();
            panelBottom.SuspendLayout();
            flowBottom.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbGuardar, tsbImprimir, tsbAyuda });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1350, 27);
            toolStrip1.TabIndex = 2;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar pedido";
            // 
            // tsbImprimir
            // 
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir resumen";
            // 
            // tsbAyuda
            // 
            tsbAyuda.Name = "tsbAyuda";
            tsbAyuda.Size = new Size(55, 24);
            tsbAyuda.Text = "A&yuda";
            tsbAyuda.ToolTipText = "Mostrar ayuda";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 674);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1350, 26);
            statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 20);
            toolStripStatusLabel1.Text = "Listo";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCarrito);
            tabControl1.Controls.Add(tabPageEnvio);
            tabControl1.Controls.Add(tabPagePago);
            tabControl1.Controls.Add(tabPageConfirmacion);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 591);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCarrito
            // 
            tabPageCarrito.Controls.Add(dgvCarrito);
            tabPageCarrito.Location = new Point(4, 29);
            tabPageCarrito.Name = "tabPageCarrito";
            tabPageCarrito.Padding = new Padding(10);
            tabPageCarrito.Size = new Size(1342, 558);
            tabPageCarrito.TabIndex = 0;
            tabPageCarrito.Text = "1. Carrito";
            tabPageCarrito.UseVisualStyleBackColor = true;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeight = 29;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colProducto, colPrecio, colCantidad, colSubtotal });
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.Location = new Point(10, 10);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(1322, 538);
            dgvCarrito.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "Producto";
            colProducto.FillWeight = 50F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 200;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            colPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            colPrecio.FillWeight = 20F;
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.MinimumWidth = 100;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCantidad.DefaultCellStyle = dataGridViewCellStyle2;
            colCantidad.FillWeight = 15F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 80;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle3;
            colSubtotal.FillWeight = 20F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 100;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // tabPageEnvio
            // 
            tabPageEnvio.Controls.Add(tlpEnvio);
            tabPageEnvio.Location = new Point(4, 29);
            tabPageEnvio.Name = "tabPageEnvio";
            tabPageEnvio.Padding = new Padding(20);
            tabPageEnvio.Size = new Size(1342, 566);
            tabPageEnvio.TabIndex = 1;
            tabPageEnvio.Text = "2. Envío";
            tabPageEnvio.UseVisualStyleBackColor = true;
            // 
            // tlpEnvio
            // 
            tlpEnvio.ColumnCount = 4;
            tlpEnvio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpEnvio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpEnvio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpEnvio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpEnvio.Controls.Add(lblNombre, 0, 0);
            tlpEnvio.Controls.Add(txtNombre, 1, 0);
            tlpEnvio.Controls.Add(lblTelefono, 2, 0);
            tlpEnvio.Controls.Add(txtTelefono, 3, 0);
            tlpEnvio.Controls.Add(lblDireccion, 0, 1);
            tlpEnvio.Controls.Add(txtDireccion, 1, 1);
            tlpEnvio.Controls.Add(lblCiudad, 2, 1);
            tlpEnvio.Controls.Add(txtCiudad, 3, 1);
            tlpEnvio.Controls.Add(lblCP, 0, 2);
            tlpEnvio.Controls.Add(txtCP, 1, 2);
            tlpEnvio.Controls.Add(lblFranja, 2, 2);
            tlpEnvio.Controls.Add(cboFranja, 3, 2);
            tlpEnvio.Dock = DockStyle.Top;
            tlpEnvio.Location = new Point(20, 20);
            tlpEnvio.Name = "tlpEnvio";
            tlpEnvio.RowCount = 3;
            tlpEnvio.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpEnvio.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpEnvio.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpEnvio.Size = new Size(1302, 120);
            tlpEnvio.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(76, 40);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "&Nombre completo:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(123, 6);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Juan Pérez";
            txtNombre.Size = new Size(525, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Left;
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(654, 10);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "&Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(774, 6);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "11-1234-5678";
            txtTelefono.Size = new Size(525, 27);
            txtTelefono.TabIndex = 3;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left;
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(3, 50);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "&Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(123, 46);
            txtDireccion.MaxLength = 150;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Av. Corrientes 1234, Piso 5, Depto A";
            txtDireccion.Size = new Size(525, 27);
            txtDireccion.TabIndex = 5;
            // 
            // lblCiudad
            // 
            lblCiudad.Anchor = AnchorStyles.Left;
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(654, 50);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 6;
            lblCiudad.Text = "&Ciudad:";
            // 
            // txtCiudad
            // 
            txtCiudad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCiudad.Location = new Point(774, 46);
            txtCiudad.MaxLength = 50;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PlaceholderText = "Buenos Aires";
            txtCiudad.Size = new Size(525, 27);
            txtCiudad.TabIndex = 7;
            // 
            // lblCP
            // 
            lblCP.Anchor = AnchorStyles.Left;
            lblCP.AutoSize = true;
            lblCP.Location = new Point(3, 90);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(104, 20);
            lblCP.TabIndex = 8;
            lblCP.Text = "&Código Postal:";
            // 
            // txtCP
            // 
            txtCP.Anchor = AnchorStyles.Left;
            txtCP.Location = new Point(123, 86);
            txtCP.MaxLength = 10;
            txtCP.Name = "txtCP";
            txtCP.PlaceholderText = "C1425";
            txtCP.Size = new Size(120, 27);
            txtCP.TabIndex = 9;
            // 
            // lblFranja
            // 
            lblFranja.Anchor = AnchorStyles.Left;
            lblFranja.AutoSize = true;
            lblFranja.Location = new Point(654, 90);
            lblFranja.Name = "lblFranja";
            lblFranja.Size = new Size(103, 20);
            lblFranja.TabIndex = 10;
            lblFranja.Text = "&Franja horaria:";
            // 
            // cboFranja
            // 
            cboFranja.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboFranja.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFranja.Items.AddRange(new object[] { "Mañana (9:00 - 12:00)", "Tarde (14:00 - 18:00)", "Noche (18:00 - 21:00)" });
            cboFranja.Location = new Point(774, 86);
            cboFranja.Name = "cboFranja";
            cboFranja.Size = new Size(525, 28);
            cboFranja.TabIndex = 11;
            // 
            // tabPagePago
            // 
            tabPagePago.Controls.Add(tlpPago);
            tabPagePago.Location = new Point(4, 29);
            tabPagePago.Name = "tabPagePago";
            tabPagePago.Padding = new Padding(20);
            tabPagePago.Size = new Size(1342, 566);
            tabPagePago.TabIndex = 2;
            tabPagePago.Text = "3. Pago";
            tabPagePago.UseVisualStyleBackColor = true;
            // 
            // tlpPago
            // 
            tlpPago.ColumnCount = 4;
            tlpPago.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPago.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPago.Controls.Add(lblMetodo, 0, 0);
            tlpPago.Controls.Add(cboMetodo, 1, 0);
            tlpPago.Controls.Add(lblNum, 2, 0);
            tlpPago.Controls.Add(txtNum, 3, 0);
            tlpPago.Controls.Add(lblCuotas, 0, 1);
            tlpPago.Controls.Add(cboCuotas, 1, 1);
            tlpPago.Controls.Add(lblFactura, 2, 1);
            tlpPago.Controls.Add(cboFactura, 3, 1);
            tlpPago.Dock = DockStyle.Top;
            tlpPago.Location = new Point(20, 20);
            tlpPago.Name = "tlpPago";
            tlpPago.RowCount = 2;
            tlpPago.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPago.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPago.Size = new Size(1302, 80);
            tlpPago.TabIndex = 0;
            // 
            // lblMetodo
            // 
            lblMetodo.Anchor = AnchorStyles.Left;
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(3, 0);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(87, 40);
            lblMetodo.TabIndex = 0;
            lblMetodo.Text = "&Método de pago:";
            // 
            // cboMetodo
            // 
            cboMetodo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodo.Items.AddRange(new object[] { "Tarjeta de Crédito", "Tarjeta de Débito", "Transferencia Bancaria", "Mercado Pago", "Efectivo contra entrega" });
            cboMetodo.Location = new Point(123, 6);
            cboMetodo.Name = "cboMetodo";
            cboMetodo.Size = new Size(525, 28);
            cboMetodo.TabIndex = 1;
            // 
            // lblNum
            // 
            lblNum.Anchor = AnchorStyles.Left;
            lblNum.AutoSize = true;
            lblNum.Location = new Point(654, 10);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(97, 20);
            lblNum.TabIndex = 2;
            lblNum.Text = "&Nº de tarjeta:";
            // 
            // txtNum
            // 
            txtNum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNum.Location = new Point(774, 6);
            txtNum.MaxLength = 19;
            txtNum.Name = "txtNum";
            txtNum.PasswordChar = '*';
            txtNum.PlaceholderText = "1234 5678 9012 3456";
            txtNum.Size = new Size(525, 27);
            txtNum.TabIndex = 3;
            // 
            // lblCuotas
            // 
            lblCuotas.Anchor = AnchorStyles.Left;
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(3, 50);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(57, 20);
            lblCuotas.TabIndex = 4;
            lblCuotas.Text = "&Cuotas:";
            // 
            // cboCuotas
            // 
            cboCuotas.Anchor = AnchorStyles.Left;
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Items.AddRange(new object[] { "1 cuota sin interés", "3 cuotas sin interés", "6 cuotas con 5% interés", "12 cuotas con 15% interés", "18 cuotas con 25% interés" });
            cboCuotas.Location = new Point(123, 46);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(200, 28);
            cboCuotas.TabIndex = 5;
            // 
            // lblFactura
            // 
            lblFactura.Anchor = AnchorStyles.Left;
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(654, 50);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(113, 20);
            lblFactura.TabIndex = 6;
            lblFactura.Text = "Tipo de &factura:";
            // 
            // cboFactura
            // 
            cboFactura.Anchor = AnchorStyles.Left;
            cboFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFactura.Items.AddRange(new object[] { "Consumidor Final (Factura B)", "Responsable Inscripto (Factura A)", "Monotributista (Factura B)", "Exento (Factura C)" });
            cboFactura.Location = new Point(774, 46);
            cboFactura.Name = "cboFactura";
            cboFactura.Size = new Size(200, 28);
            cboFactura.TabIndex = 7;
            // 
            // tabPageConfirmacion
            // 
            tabPageConfirmacion.Controls.Add(rtbConfirmacion);
            tabPageConfirmacion.Location = new Point(4, 29);
            tabPageConfirmacion.Name = "tabPageConfirmacion";
            tabPageConfirmacion.Padding = new Padding(20);
            tabPageConfirmacion.Size = new Size(1342, 566);
            tabPageConfirmacion.TabIndex = 3;
            tabPageConfirmacion.Text = "4. Confirmación";
            tabPageConfirmacion.UseVisualStyleBackColor = true;
            // 
            // rtbConfirmacion
            // 
            rtbConfirmacion.Dock = DockStyle.Fill;
            rtbConfirmacion.Font = new Font("Consolas", 10F);
            rtbConfirmacion.Location = new Point(20, 20);
            rtbConfirmacion.Name = "rtbConfirmacion";
            rtbConfirmacion.ReadOnly = true;
            rtbConfirmacion.Size = new Size(1302, 526);
            rtbConfirmacion.TabIndex = 0;
            rtbConfirmacion.Text = "Aquí se mostrará el resumen completo de su pedido...";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 618);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(1350, 56);
            panelBottom.TabIndex = 1;
            // 
            // flowBottom
            // 
            flowBottom.Controls.Add(btnConfirmar);
            flowBottom.Controls.Add(btnCancelar);
            flowBottom.Dock = DockStyle.Right;
            flowBottom.FlowDirection = FlowDirection.RightToLeft;
            flowBottom.Location = new Point(1168, 10);
            flowBottom.Name = "flowBottom";
            flowBottom.Size = new Size(172, 36);
            flowBottom.TabIndex = 0;
            flowBottom.WrapContents = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = true;
            btnConfirmar.Location = new Point(84, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(85, 30);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "C&ancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1350, 700);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Finalizar Compra";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            tabPageEnvio.ResumeLayout(false);
            tlpEnvio.ResumeLayout(false);
            tlpEnvio.PerformLayout();
            tabPagePago.ResumeLayout(false);
            tlpPago.ResumeLayout(false);
            tlpPago.PerformLayout();
            tabPageConfirmacion.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}