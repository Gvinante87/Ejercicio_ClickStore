namespace Ejercicio_ClickStore
{
    partial class EntregasDeRepartidor
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpRuta;
        private System.Windows.Forms.ListBox lstRuta;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpMapa;
        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.Label lblMapa;
        private System.Windows.Forms.GroupBox grpEntregas;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnReprogramar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbAyuda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            grpRuta = new GroupBox();
            lstRuta = new ListBox();
            panelRight = new Panel();
            grpEntregas = new GroupBox();
            dgvEntregas = new DataGridView();
            colPedido = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpMapa = new GroupBox();
            panelMapa = new Panel();
            lblMapa = new Label();
            panelBottom = new Panel();
            flowBottom = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnReprogramar = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpRuta.SuspendLayout();
            panelRight.SuspendLayout();
            grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            grpMapa.SuspendLayout();
            panelMapa.SuspendLayout();
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
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "Barra de herramientas";
            // 
            // tsbGuardar
            // 
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(66, 24);
            tsbGuardar.Text = "&Guardar";
            tsbGuardar.ToolTipText = "Guardar estado de entregas (Ctrl+G)";
            // 
            // tsbImprimir
            // 
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 24);
            tsbImprimir.Text = "&Imprimir";
            tsbImprimir.ToolTipText = "Imprimir lista de entregas (Ctrl+P)";
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
            splitContainer1.AccessibleDescription = "Panel dividido: ruta de entregas a la izquierda, mapa y detalles a la derecha";
            splitContainer1.AccessibleName = "Panel principal de entregas";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleDescription = "Lista de puntos de entrega en la ruta";
            splitContainer1.Panel1.AccessibleName = "Ruta de entregas";
            splitContainer1.Panel1.Controls.Add(grpRuta);
            splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleDescription = "Mapa y detalles de entregas";
            splitContainer1.Panel2.AccessibleName = "Información de entregas";
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Panel2MinSize = 350;
            splitContainer1.Size = new Size(1350, 647);
            splitContainer1.SplitterDistance = 948;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // grpRuta
            // 
            grpRuta.AccessibleDescription = "Lista de direcciones de entrega ordenadas por ruta";
            grpRuta.AccessibleName = "Ruta de entregas";
            grpRuta.Controls.Add(lstRuta);
            grpRuta.Dock = DockStyle.Fill;
            grpRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRuta.Location = new Point(0, 0);
            grpRuta.Name = "grpRuta";
            grpRuta.Padding = new Padding(8);
            grpRuta.Size = new Size(948, 647);
            grpRuta.TabIndex = 0;
            grpRuta.TabStop = false;
            grpRuta.Text = "Ruta de Entregas del Día";
            // 
            // lstRuta
            // 
            lstRuta.AccessibleDescription = "Lista de direcciones de entrega. Use las flechas para navegar y Enter para seleccionar";
            lstRuta.AccessibleName = "Direcciones de entrega";
            lstRuta.Dock = DockStyle.Fill;
            lstRuta.Font = new Font("Segoe UI", 9F);
            lstRuta.HorizontalScrollbar = true;
            lstRuta.Items.AddRange(new object[] { "1. Juan Pérez - Av. Corrientes 1234, CABA - Pedido #001 - Pendiente", "2. María García - San Martín 567, Vicente López - Pedido #002 - Pendiente", "3. Carlos López - Rivadavia 890, San Isidro - Pedido #003 - Pendiente", "4. Ana Rodríguez - Mitre 345, Olivos - Pedido #004 - Pendiente", "5. Luis Fernández - Belgrano 678, Martínez - Pedido #005 - Pendiente" });
            lstRuta.Location = new Point(8, 28);
            lstRuta.Name = "lstRuta";
            lstRuta.Size = new Size(932, 611);
            lstRuta.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpEntregas);
            panelRight.Controls.Add(grpMapa);
            panelRight.Controls.Add(panelBottom);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(396, 647);
            panelRight.TabIndex = 0;
            // 
            // grpEntregas
            // 
            grpEntregas.AccessibleDescription = "Detalles de las entregas seleccionadas";
            grpEntregas.AccessibleName = "Detalles de entregas";
            grpEntregas.Controls.Add(dgvEntregas);
            grpEntregas.Dock = DockStyle.Fill;
            grpEntregas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpEntregas.Location = new Point(0, 300);
            grpEntregas.Name = "grpEntregas";
            grpEntregas.Padding = new Padding(5);
            grpEntregas.Size = new Size(396, 299);
            grpEntregas.TabIndex = 1;
            grpEntregas.TabStop = false;
            grpEntregas.Text = "Detalles de Entregas";
            // 
            // dgvEntregas
            // 
            dgvEntregas.AccessibleDescription = "Tabla con detalles de pedidos, clientes, direcciones y estados";
            dgvEntregas.AccessibleName = "Información de entregas";
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntregas.ColumnHeadersHeight = 29;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEntregas.Columns.AddRange(new DataGridViewColumn[] { colPedido, colCliente, colDireccion, colEstado });
            dgvEntregas.Dock = DockStyle.Fill;
            dgvEntregas.Font = new Font("Segoe UI", 8F);
            dgvEntregas.Location = new Point(5, 25);
            dgvEntregas.MultiSelect = false;
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.RowHeadersVisible = false;
            dgvEntregas.RowHeadersWidth = 51;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.Size = new Size(386, 269);
            dgvEntregas.TabIndex = 0;
            // 
            // colPedido
            // 
            colPedido.DataPropertyName = "NumeroPedido";
            colPedido.FillWeight = 20F;
            colPedido.HeaderText = "Pedido";
            colPedido.MinimumWidth = 60;
            colPedido.Name = "colPedido";
            colPedido.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "NombreCliente";
            colCliente.FillWeight = 30F;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 80;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.DataPropertyName = "Direccion";
            colDireccion.FillWeight = 35F;
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 100;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.FillWeight = 15F;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 70;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // grpMapa
            // 
            grpMapa.AccessibleDescription = "Vista del mapa con la ubicación de las entregas";
            grpMapa.AccessibleName = "Mapa de entregas";
            grpMapa.Controls.Add(panelMapa);
            grpMapa.Dock = DockStyle.Top;
            grpMapa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpMapa.Location = new Point(0, 0);
            grpMapa.Name = "grpMapa";
            grpMapa.Padding = new Padding(5);
            grpMapa.Size = new Size(396, 300);
            grpMapa.TabIndex = 0;
            grpMapa.TabStop = false;
            grpMapa.Text = "Mapa de Zona";
            // 
            // panelMapa
            // 
            panelMapa.AccessibleDescription = "Panel donde se mostraría el mapa interactivo";
            panelMapa.AccessibleName = "Vista del mapa";
            panelMapa.BackColor = SystemColors.ControlLight;
            panelMapa.BorderStyle = BorderStyle.FixedSingle;
            panelMapa.Controls.Add(lblMapa);
            panelMapa.Dock = DockStyle.Fill;
            panelMapa.Location = new Point(5, 25);
            panelMapa.Name = "panelMapa";
            panelMapa.Size = new Size(386, 270);
            panelMapa.TabIndex = 0;
            // 
            // lblMapa
            // 
            lblMapa.Anchor = AnchorStyles.None;
            lblMapa.AutoSize = true;
            lblMapa.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblMapa.ForeColor = SystemColors.GrayText;
            lblMapa.Location = new Point(81, 125);
            lblMapa.Name = "lblMapa";
            lblMapa.Size = new Size(232, 23);
            lblMapa.TabIndex = 0;
            lblMapa.Text = "🗺️ Mapa de zona de entregas";
            lblMapa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 599);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(396, 48);
            panelBottom.TabIndex = 2;
            // 
            // flowBottom
            // 
            flowBottom.Controls.Add(btnRegistrar);
            flowBottom.Controls.Add(btnReprogramar);
            flowBottom.Dock = DockStyle.Right;
            flowBottom.FlowDirection = FlowDirection.RightToLeft;
            flowBottom.Location = new Point(152, 8);
            flowBottom.Name = "flowBottom";
            flowBottom.Size = new Size(274, 32);
            flowBottom.TabIndex = 0;
            flowBottom.WrapContents = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AccessibleDescription = "Registrar entrega como completada exitosamente";
            btnRegistrar.AccessibleName = "Registrar entrega";
            btnRegistrar.AutoSize = true;
            btnRegistrar.Location = new Point(100, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 30);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "&Registrar Entrega";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnReprogramar
            // 
            btnReprogramar.AccessibleDescription = "Reprogramar entrega para otro momento";
            btnReprogramar.AccessibleName = "Reprogramar entrega";
            btnReprogramar.AutoSize = true;
            btnReprogramar.Location = new Point(-13, 3);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(130, 30);
            btnReprogramar.TabIndex = 1;
            btnReprogramar.Text = "Re&programar";
            btnReprogramar.UseVisualStyleBackColor = true;
            // 
            // EntregasDeRepartidor
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "EntregasDeRepartidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Entregas del Repartidor";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpRuta.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            grpEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            grpMapa.ResumeLayout(false);
            panelMapa.ResumeLayout(false);
            panelMapa.PerformLayout();
            panelBottom.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}