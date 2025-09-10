namespace Ejercicio_ClickStore
{
    partial class CatalogoDeProductos
    {
        private System.ComponentModel.IContainer components = null;

        // Tool/Status
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        // Layout principal (3 columnas: 220 | % | 300)
        private System.Windows.Forms.TableLayoutPanel tlpMain;

        // Columna izquierda
        private System.Windows.Forms.TreeView tvCategorias;

        // Columna central (búsqueda arriba, grilla centro, botones abajo)
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.DataGridView dgvProductos;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAgregarCarrito;

        // Columna derecha (carrito + resumen)
        private System.Windows.Forms.Panel rightSide;
        private System.Windows.Forms.GroupBox grpCarrito;
        private System.Windows.Forms.ListView lvCarrito;
        private System.Windows.Forms.ColumnHeader chProducto;
        private System.Windows.Forms.ColumnHeader chCant;
        private System.Windows.Forms.ColumnHeader chSubtotal;

        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblEnvioVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnIrCheckout;

        private System.Windows.Forms.FlowLayoutPanel pnlResumenStack;

        // Columnas del DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Todas las Categorías");
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tvCategorias = new System.Windows.Forms.TreeView();
            this.rightSide = new System.Windows.Forms.Panel();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.pnlResumenStack = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblEnvioVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.btnIrCheckout = new System.Windows.Forms.Button();
            this.grpCarrito = new System.Windows.Forms.GroupBox();
            this.lvCarrito = new System.Windows.Forms.ListView();
            this.chProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.rightSide.SuspendLayout();
            this.grpResumen.SuspendLayout();
            this.pnlResumenStack.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            this.grpCarrito.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.tlpBottom.SuspendLayout();
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
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Barra de herramientas principal";

            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 24);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.ToolTipText = "Guardar configuración actual (Ctrl+G)";

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(70, 24);
            this.tsbImprimir.Text = "&Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir catálogo de productos (Ctrl+P)";

            // 
            // tsbAyuda
            // 
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(55, 24);
            this.tsbAyuda.Text = "A&yuda";
            this.tsbAyuda.ToolTipText = "Mostrar ayuda del sistema (F1)";

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
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.Controls.Add(this.tvCategorias, 0, 0);
            this.tlpMain.Controls.Add(this.rightSide, 2, 0);
            this.tlpMain.Controls.Add(this.grpBusqueda, 1, 0);
            this.tlpMain.Controls.Add(this.dgvProductos, 1, 1);
            this.tlpMain.Controls.Add(this.panelBottom, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 27);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpMain.Size = new System.Drawing.Size(1350, 647);
            this.tlpMain.TabIndex = 0;

            // 
            // tvCategorias
            // 
            this.tvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategorias.Location = new System.Drawing.Point(3, 3);
            this.tvCategorias.Name = "tvCategorias";
            treeNode1.Name = "RootNode";
            treeNode1.Text = "Todas las Categorías";
            this.tvCategorias.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tlpMain.SetRowSpan(this.tvCategorias, 3);
            this.tvCategorias.Size = new System.Drawing.Size(214, 641);
            this.tvCategorias.TabIndex = 0;
            this.tvCategorias.ShowLines = true;
            this.tvCategorias.ShowPlusMinus = true;
            this.tvCategorias.HideSelection = false;

            // 
            // rightSide
            // 
            this.rightSide.Controls.Add(this.grpResumen);
            this.rightSide.Controls.Add(this.grpCarrito);
            this.rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSide.Location = new System.Drawing.Point(1053, 3);
            this.rightSide.Name = "rightSide";
            this.tlpMain.SetRowSpan(this.rightSide, 3);
            this.rightSide.Size = new System.Drawing.Size(294, 641);
            this.rightSide.TabIndex = 1;

            // 
            // grpResumen
            // 
            this.grpResumen.Controls.Add(this.pnlResumenStack);
            this.grpResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpResumen.Location = new System.Drawing.Point(0, 240);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(294, 160);
            this.grpResumen.TabIndex = 0;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen del Pedido";

            // 
            // pnlResumenStack
            // 
            this.pnlResumenStack.AutoSize = true;
            this.pnlResumenStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlResumenStack.Controls.Add(this.tlpResumen);
            this.pnlResumenStack.Controls.Add(this.btnIrCheckout);
            this.pnlResumenStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResumenStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlResumenStack.Location = new System.Drawing.Point(3, 23);
            this.pnlResumenStack.Name = "pnlResumenStack";
            this.pnlResumenStack.Size = new System.Drawing.Size(288, 120);
            this.pnlResumenStack.TabIndex = 0;
            this.pnlResumenStack.WrapContents = false;

            // 
            // tlpResumen
            // 
            this.tlpResumen.AutoSize = true;
            this.tlpResumen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpResumen.ColumnCount = 2;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Controls.Add(this.lblSubtotal, 0, 0);
            this.tlpResumen.Controls.Add(this.lblSubtotalVal, 1, 0);
            this.tlpResumen.Controls.Add(this.lblEnvio, 0, 1);
            this.tlpResumen.Controls.Add(this.lblEnvioVal, 1, 1);
            this.tlpResumen.Controls.Add(this.lblTotal, 0, 2);
            this.tlpResumen.Controls.Add(this.lblTotalVal, 1, 2);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpResumen.Location = new System.Drawing.Point(3, 3);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 3;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpResumen.Size = new System.Drawing.Size(186, 72);
            this.tlpResumen.TabIndex = 0;

            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(3, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(74, 23);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblSubtotalVal
            // 
            this.lblSubtotalVal.Location = new System.Drawing.Point(83, 0);
            this.lblSubtotalVal.Name = "lblSubtotalVal";
            this.lblSubtotalVal.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalVal.TabIndex = 1;
            this.lblSubtotalVal.Text = "$0.00";
            this.lblSubtotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblEnvio
            // 
            this.lblEnvio.Location = new System.Drawing.Point(3, 24);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(74, 23);
            this.lblEnvio.TabIndex = 2;
            this.lblEnvio.Text = "Envío:";
            this.lblEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblEnvioVal
            // 
            this.lblEnvioVal.Location = new System.Drawing.Point(83, 24);
            this.lblEnvioVal.Name = "lblEnvioVal";
            this.lblEnvioVal.Size = new System.Drawing.Size(100, 23);
            this.lblEnvioVal.TabIndex = 3;
            this.lblEnvioVal.Text = "$0.00";
            this.lblEnvioVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(3, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.Location = new System.Drawing.Point(83, 48);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(100, 23);
            this.lblTotalVal.TabIndex = 5;
            this.lblTotalVal.Text = "$0.00";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnIrCheckout
            // 
            this.btnIrCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIrCheckout.AutoSize = true;
            this.btnIrCheckout.Location = new System.Drawing.Point(57, 93);
            this.btnIrCheckout.Margin = new System.Windows.Forms.Padding(6);
            this.btnIrCheckout.Name = "btnIrCheckout";
            this.btnIrCheckout.Size = new System.Drawing.Size(168, 30);
            this.btnIrCheckout.TabIndex = 1;
            this.btnIrCheckout.Text = "&Finalizar Compra";
            this.btnIrCheckout.UseVisualStyleBackColor = true;

            // 
            // grpCarrito
            // 
            this.grpCarrito.Controls.Add(this.lvCarrito);
            this.grpCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCarrito.Location = new System.Drawing.Point(0, 0);
            this.grpCarrito.Name = "grpCarrito";
            this.grpCarrito.Size = new System.Drawing.Size(294, 240);
            this.grpCarrito.TabIndex = 1;
            this.grpCarrito.TabStop = false;
            this.grpCarrito.Text = "Carrito de Compras";

            // 
            // lvCarrito
            // 
            this.lvCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProducto,
            this.chCant,
            this.chSubtotal});
            this.lvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCarrito.FullRowSelect = true;
            this.lvCarrito.GridLines = true;
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(3, 23);
            this.lvCarrito.MultiSelect = false;
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(288, 214);
            this.lvCarrito.TabIndex = 0;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            this.lvCarrito.View = System.Windows.Forms.View.Details;
            this.lvCarrito.SelectedIndexChanged += new System.EventHandler(this.lvCarrito_SelectedIndexChanged);

            // 
            // chProducto
            // 
            this.chProducto.Text = "Producto";
            this.chProducto.Width = 150;

            // 
            // chCant
            // 
            this.chCant.Text = "Cant.";
            this.chCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCant.Width = 50;

            // 
            // chSubtotal
            // 
            this.chSubtotal.Text = "Subtotal";
            this.chSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSubtotal.Width = 88;

            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.tlpBusqueda);
            this.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBusqueda.Location = new System.Drawing.Point(223, 3);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(824, 74);
            this.grpBusqueda.TabIndex = 2;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Búsqueda de Productos";

            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.ColumnCount = 10;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda.Controls.Add(this.lblBuscar, 0, 0);
            this.tlpBusqueda.Controls.Add(this.txtBuscar, 1, 0);
            this.tlpBusqueda.Controls.Add(this.lblCategoria, 5, 0);
            this.tlpBusqueda.Controls.Add(this.cboCategoria, 6, 0);
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 9, 0);
            this.tlpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBusqueda.Location = new System.Drawing.Point(3, 23);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 1;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpBusqueda.Size = new System.Drawing.Size(818, 48);
            this.tlpBusqueda.TabIndex = 0;

            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(3, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "&Buscar:";

            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.SetColumnSpan(this.txtBuscar, 4);
            this.txtBuscar.Location = new System.Drawing.Point(84, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Ingrese nombre o código del producto...";
            this.txtBuscar.Size = new System.Drawing.Size(318, 27);
            this.txtBuscar.TabIndex = 1;

            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(408, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "&Categoría:";

            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.SetColumnSpan(this.cboCategoria, 3);
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(489, 14);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(237, 28);
            this.cboCategoria.TabIndex = 3;

            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(753, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "B&uscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPrecio,
            this.colStock});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(223, 83);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(824, 505);
            this.dgvProductos.TabIndex = 3;

            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 80;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.FillWeight = 20F;

            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre del Producto";
            this.colNombre.MinimumWidth = 150;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.FillWeight = 50F;

            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle.Format = "C2";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 80;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.FillWeight = 15F;

            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "Stock";
            this.colStock.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 60;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.FillWeight = 15F;

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tlpBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(223, 594);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(824, 50);
            this.panelBottom.TabIndex = 4;

            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 3;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBottom.Controls.Add(this.btnAnterior, 0, 0);
            this.tlpBottom.Controls.Add(this.btnSiguiente, 1, 0);
            this.tlpBottom.Controls.Add(this.btnAgregarCarrito, 2, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(824, 50);
            this.tlpBottom.TabIndex = 0;

            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(100, 10);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(73, 30);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;

            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(370, 10);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(81, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "&Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;

            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarCarrito.AutoSize = true;
            this.btnAgregarCarrito.Enabled = false;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(618, 10);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(136, 30);
            this.btnAgregarCarrito.TabIndex = 2;
            this.btnAgregarCarrito.Text = "Agregar al &Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;

            // 
            // CatalogoDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CatalogoDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Catálogo de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.rightSide.ResumeLayout(false);
            this.grpResumen.ResumeLayout(false);
            this.pnlResumenStack.ResumeLayout(false);
            this.pnlResumenStack.PerformLayout();
            this.tlpResumen.ResumeLayout(false);
            this.tlpResumen.PerformLayout();
            this.grpCarrito.ResumeLayout(false);
            this.grpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.tlpBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}