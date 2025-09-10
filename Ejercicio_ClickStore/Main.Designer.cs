namespace Ejercicio_ClickStore
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificacionDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preparacionDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaDeEntregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;

        // Nuevos elementos para mejorar la funcionalidad
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;

        // NUEVO: Panel de bienvenida
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblInstrucciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            catalogoDeProductosToolStripMenuItem = new ToolStripMenuItem();
            detalleDeProductoToolStripMenuItem = new ToolStripMenuItem();
            carritoToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            verificacionDeStockToolStripMenuItem = new ToolStripMenuItem();
            logisticaToolStripMenuItem = new ToolStripMenuItem();
            preparacionDePedidoToolStripMenuItem = new ToolStripMenuItem();
            repartidorToolStripMenuItem = new ToolStripMenuItem();
            rutaDeEntregasToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            cerrarTodasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            lblFecha = new ToolStripStatusLabel();
            panelBienvenida = new Panel();
            lblInstrucciones = new Label();
            lblBienvenida = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panelBienvenida.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AccessibleDescription = "Menú principal de la aplicación ClickStore";
            menuStrip1.AccessibleName = "Menú principal";
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, clientesToolStripMenuItem, vendedorToolStripMenuItem, logisticaToolStripMenuItem, repartidorToolStripMenuItem, administracionToolStripMenuItem, ventanaToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = ventanaToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1350, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menú principal";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.AccessibleDescription = "Opciones de archivo y configuración general";
            archivoToolStripMenuItem.AccessibleName = "Menú Archivo";
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.AccessibleDescription = "Cerrar la aplicación";
            salirToolStripMenuItem.AccessibleName = "Salir";
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(174, 26);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.ToolTipText = "Cerrar la aplicación (Alt+F4)";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.AccessibleDescription = "Funciones para clientes: catálogo, carrito y compras";
            clientesToolStripMenuItem.AccessibleName = "Menú Clientes";
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalogoDeProductosToolStripMenuItem, detalleDeProductoToolStripMenuItem, carritoToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // catalogoDeProductosToolStripMenuItem
            // 
            catalogoDeProductosToolStripMenuItem.AccessibleDescription = "Ver catálogo completo de productos disponibles";
            catalogoDeProductosToolStripMenuItem.AccessibleName = "Catálogo de productos";
            catalogoDeProductosToolStripMenuItem.Name = "catalogoDeProductosToolStripMenuItem";
            catalogoDeProductosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            catalogoDeProductosToolStripMenuItem.Size = new Size(295, 26);
            catalogoDeProductosToolStripMenuItem.Text = "&Catálogo de Productos";
            catalogoDeProductosToolStripMenuItem.ToolTipText = "Ver productos disponibles (Ctrl+C)";
            // 
            // detalleDeProductoToolStripMenuItem
            // 
            detalleDeProductoToolStripMenuItem.AccessibleDescription = "Ver información detallada de un producto específico";
            detalleDeProductoToolStripMenuItem.AccessibleName = "Detalle de producto";
            detalleDeProductoToolStripMenuItem.Name = "detalleDeProductoToolStripMenuItem";
            detalleDeProductoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            detalleDeProductoToolStripMenuItem.Size = new Size(295, 26);
            detalleDeProductoToolStripMenuItem.Text = "&Detalle de Producto";
            detalleDeProductoToolStripMenuItem.ToolTipText = "Ver detalles del producto (Ctrl+D)";
            // 
            // carritoToolStripMenuItem
            // 
            carritoToolStripMenuItem.AccessibleDescription = "Ver y gestionar productos en el carrito de compras";
            carritoToolStripMenuItem.AccessibleName = "Carrito de compras";
            carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            carritoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            carritoToolStripMenuItem.Size = new Size(295, 26);
            carritoToolStripMenuItem.Text = "Ca&rrito y Checkout";
            carritoToolStripMenuItem.ToolTipText = "Ver carrito de compras y finalizar (Ctrl+R)";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.AccessibleDescription = "Herramientas para vendedores";
            vendedorToolStripMenuItem.AccessibleName = "Menú Vendedor";
            vendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verificacionDeStockToolStripMenuItem });
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(87, 24);
            vendedorToolStripMenuItem.Text = "&Vendedor";
            // 
            // verificacionDeStockToolStripMenuItem
            // 
            verificacionDeStockToolStripMenuItem.AccessibleDescription = "Verificar disponibilidad de productos en inventario";
            verificacionDeStockToolStripMenuItem.AccessibleName = "Verificación de stock";
            verificacionDeStockToolStripMenuItem.Name = "verificacionDeStockToolStripMenuItem";
            verificacionDeStockToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            verificacionDeStockToolStripMenuItem.Size = new Size(280, 26);
            verificacionDeStockToolStripMenuItem.Text = "&Verificación de Stock";
            verificacionDeStockToolStripMenuItem.ToolTipText = "Consultar inventario (Ctrl+S)";
            // 
            // logisticaToolStripMenuItem
            // 
            logisticaToolStripMenuItem.AccessibleDescription = "Gestión logística y preparación de pedidos";
            logisticaToolStripMenuItem.AccessibleName = "Menú Logística";
            logisticaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preparacionDePedidoToolStripMenuItem });
            logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            logisticaToolStripMenuItem.Size = new Size(82, 24);
            logisticaToolStripMenuItem.Text = "&Logística";
            // 
            // preparacionDePedidoToolStripMenuItem
            // 
            preparacionDePedidoToolStripMenuItem.AccessibleDescription = "Preparar paquetes para envío";
            preparacionDePedidoToolStripMenuItem.AccessibleName = "Preparación de pedidos";
            preparacionDePedidoToolStripMenuItem.Name = "preparacionDePedidoToolStripMenuItem";
            preparacionDePedidoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            preparacionDePedidoToolStripMenuItem.Size = new Size(292, 26);
            preparacionDePedidoToolStripMenuItem.Text = "&Preparación de Pedido";
            preparacionDePedidoToolStripMenuItem.ToolTipText = "Preparar paquetes (Ctrl+P)";
            // 
            // repartidorToolStripMenuItem
            // 
            repartidorToolStripMenuItem.AccessibleDescription = "Herramientas para repartidores y entregas";
            repartidorToolStripMenuItem.AccessibleName = "Menú Repartidor";
            repartidorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rutaDeEntregasToolStripMenuItem });
            repartidorToolStripMenuItem.Name = "repartidorToolStripMenuItem";
            repartidorToolStripMenuItem.Size = new Size(94, 24);
            repartidorToolStripMenuItem.Text = "&Repartidor";
            // 
            // rutaDeEntregasToolStripMenuItem
            // 
            rutaDeEntregasToolStripMenuItem.AccessibleDescription = "Gestionar rutas y entregas del día";
            rutaDeEntregasToolStripMenuItem.AccessibleName = "Ruta de entregas";
            rutaDeEntregasToolStripMenuItem.Name = "rutaDeEntregasToolStripMenuItem";
            rutaDeEntregasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            rutaDeEntregasToolStripMenuItem.Size = new Size(254, 26);
            rutaDeEntregasToolStripMenuItem.Text = "Ruta de &Entregas";
            rutaDeEntregasToolStripMenuItem.ToolTipText = "Gestionar entregas (Ctrl+E)";
            // 
            // administracionToolStripMenuItem
            // 
            administracionToolStripMenuItem.AccessibleDescription = "Funciones administrativas y gestión de pagos";
            administracionToolStripMenuItem.AccessibleName = "Menú Administración";
            administracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pagosToolStripMenuItem });
            administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            administracionToolStripMenuItem.Size = new Size(123, 24);
            administracionToolStripMenuItem.Text = "&Administración";
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.AccessibleDescription = "Gestionar pagos y transacciones";
            pagosToolStripMenuItem.AccessibleName = "Gestión de pagos";
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            pagosToolStripMenuItem.Size = new Size(183, 26);
            pagosToolStripMenuItem.Text = "&Pagos";
            pagosToolStripMenuItem.ToolTipText = "Gestión de pagos (Ctrl+G)";
            // 
            // ventanaToolStripMenuItem
            // 
            ventanaToolStripMenuItem.AccessibleDescription = "Gestionar ventanas de la aplicación";
            ventanaToolStripMenuItem.AccessibleName = "Menú Ventana";
            ventanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadaToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, cerrarTodasToolStripMenuItem });
            ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            ventanaToolStripMenuItem.Size = new Size(76, 24);
            ventanaToolStripMenuItem.Text = "&Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.AccessibleDescription = "Organizar ventanas en cascada";
            cascadaToolStripMenuItem.AccessibleName = "Cascada";
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.Size = new Size(271, 26);
            cascadaToolStripMenuItem.Text = "&Cascada";
            cascadaToolStripMenuItem.ToolTipText = "Organizar en cascada";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.AccessibleDescription = "Organizar ventanas horizontalmente";
            horizontalToolStripMenuItem.AccessibleName = "Mosaico horizontal";
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(271, 26);
            horizontalToolStripMenuItem.Text = "Mosaico &Horizontal";
            horizontalToolStripMenuItem.ToolTipText = "Organizar horizontalmente";
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.AccessibleDescription = "Organizar ventanas verticalmente";
            verticalToolStripMenuItem.AccessibleName = "Mosaico vertical";
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(271, 26);
            verticalToolStripMenuItem.Text = "Mosaico &Vertical";
            verticalToolStripMenuItem.ToolTipText = "Organizar verticalmente";
            // 
            // cerrarTodasToolStripMenuItem
            // 
            cerrarTodasToolStripMenuItem.AccessibleDescription = "Cerrar todas las ventanas abiertas";
            cerrarTodasToolStripMenuItem.AccessibleName = "Cerrar todas";
            cerrarTodasToolStripMenuItem.Name = "cerrarTodasToolStripMenuItem";
            cerrarTodasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.W;
            cerrarTodasToolStripMenuItem.Size = new Size(271, 26);
            cerrarTodasToolStripMenuItem.Text = "Cerrar &Todas";
            cerrarTodasToolStripMenuItem.ToolTipText = "Cerrar todas las ventanas";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.AccessibleDescription = "Ayuda e información sobre la aplicación";
            ayudaToolStripMenuItem.AccessibleName = "Menú Ayuda";
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.AccessibleDescription = "Información sobre la aplicación ClickStore";
            acercaDeToolStripMenuItem.AccessibleName = "Acerca de";
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.ShortcutKeys = Keys.F1;
            acercaDeToolStripMenuItem.Size = new Size(191, 26);
            acercaDeToolStripMenuItem.Text = "&Acerca de...";
            acercaDeToolStripMenuItem.ToolTipText = "Información de la aplicación (F1)";
            // 
            // statusStrip1
            // 
            statusStrip1.AccessibleDescription = "Barra de estado con información del sistema";
            statusStrip1.AccessibleName = "Barra de estado";
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado, lblUsuario, lblFecha });
            statusStrip1.Location = new Point(0, 668);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1350, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "Barra de estado";
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(40, 20);
            lblEstado.Text = "Listo";
            lblEstado.ToolTipText = "Estado actual del sistema";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(1205, 20);
            lblUsuario.Spring = true;
            lblUsuario.Text = "Usuario: Administrador";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            lblUsuario.ToolTipText = "Usuario actual del sistema";
            // 
            // lblFecha
            // 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(85, 20);
            lblFecha.Text = "10/09/2025";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            lblFecha.ToolTipText = "Fecha actual";
            // 
            // panelBienvenida
            // 
            panelBienvenida.AccessibleDescription = "Panel de bienvenida con instrucciones para el usuario";
            panelBienvenida.AccessibleName = "Bienvenida";
            panelBienvenida.BackColor = SystemColors.AppWorkspace;
            panelBienvenida.Controls.Add(lblInstrucciones);
            panelBienvenida.Controls.Add(lblBienvenida);
            panelBienvenida.Location = new Point(0, 30);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Padding = new Padding(50);
            panelBienvenida.Size = new Size(1350, 638);
            panelBienvenida.TabIndex = 2;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AccessibleDescription = "Instrucciones para navegar en el sistema";
            lblInstrucciones.AccessibleName = "Instrucciones de uso";
            lblInstrucciones.Anchor = AnchorStyles.None;
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 14F);
            lblInstrucciones.Location = new Point(350, 300);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(567, 32);
            lblInstrucciones.TabIndex = 1;
            lblInstrucciones.Text = "Por favor, seleccione una opción del menú superior.";
            lblInstrucciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AccessibleDescription = "Título de bienvenida al sistema";
            lblBienvenida.AccessibleName = "Título de bienvenida";
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenida.Location = new Point(450, 200);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(531, 54);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido/a a ClickStore!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AccessibleDescription = "Ventana principal de la aplicación ClickStore con menús de navegación";
            AccessibleName = "ClickStore - Aplicación principal";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 694);
            Controls.Add(statusStrip1);
            Controls.Add(panelBienvenida);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 600);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickStore - Sistema de Gestión Comercial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelBienvenida.ResumeLayout(false);
            panelBienvenida.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}