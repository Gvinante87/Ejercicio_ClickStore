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
        // ELIMINADO: private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // ELIMINADO: this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificacionDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preparacionDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaDeEntregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "Menú principal de la aplicación ClickStore";
            this.menuStrip1.AccessibleName = "Menú principal";
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.clientesToolStripMenuItem,
                this.vendedorToolStripMenuItem,
                this.logisticaToolStripMenuItem,
                this.repartidorToolStripMenuItem,
                this.administracionToolStripMenuItem,
                this.ventanaToolStripMenuItem,
                this.ayudaToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menú principal";

            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.AccessibleDescription = "Opciones de archivo y configuración general";
            this.archivoToolStripMenuItem.AccessibleName = "Menú Archivo";
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.salirToolStripMenuItem
            });
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "&Archivo";

            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AccessibleDescription = "Cerrar la aplicación";
            this.salirToolStripMenuItem.AccessibleName = "Salir";
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.ToolTipText = "Cerrar la aplicación (Alt+F4)";

            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.AccessibleDescription = "Funciones para clientes: catálogo, carrito y compras";
            this.clientesToolStripMenuItem.AccessibleName = "Menú Clientes";
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.catalogoDeProductosToolStripMenuItem,
                this.detalleDeProductoToolStripMenuItem,
                this.carritoToolStripMenuItem
                // ELIMINADO: this.checkoutToolStripMenuItem
            });
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.clientesToolStripMenuItem.Text = "&Clientes";

            // 
            // catalogoDeProductosToolStripMenuItem
            // 
            this.catalogoDeProductosToolStripMenuItem.AccessibleDescription = "Ver catálogo completo de productos disponibles";
            this.catalogoDeProductosToolStripMenuItem.AccessibleName = "Catálogo de productos";
            this.catalogoDeProductosToolStripMenuItem.Name = "catalogoDeProductosToolStripMenuItem";
            this.catalogoDeProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.catalogoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.catalogoDeProductosToolStripMenuItem.Text = "&Catálogo de Productos";
            this.catalogoDeProductosToolStripMenuItem.ToolTipText = "Ver productos disponibles (Ctrl+C)";

            // 
            // detalleDeProductoToolStripMenuItem
            // 
            this.detalleDeProductoToolStripMenuItem.AccessibleDescription = "Ver información detallada de un producto específico";
            this.detalleDeProductoToolStripMenuItem.AccessibleName = "Detalle de producto";
            this.detalleDeProductoToolStripMenuItem.Name = "detalleDeProductoToolStripMenuItem";
            this.detalleDeProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detalleDeProductoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.detalleDeProductoToolStripMenuItem.Text = "&Detalle de Producto";
            this.detalleDeProductoToolStripMenuItem.ToolTipText = "Ver detalles del producto (Ctrl+D)";

            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.AccessibleDescription = "Ver y gestionar carrito de compras, y finalizar compra";
            this.carritoToolStripMenuItem.AccessibleName = "Carrito y checkout";
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.carritoToolStripMenuItem.Text = "Ca&rrito y Checkout";
            this.carritoToolStripMenuItem.ToolTipText = "Ver carrito y finalizar compra (Ctrl+R)";

            // ELIMINADO: Toda la configuración de checkoutToolStripMenuItem
            // 
            // checkoutToolStripMenuItem
            // 
            //this.checkoutToolStripMenuItem.AccessibleDescription = "Finalizar compra y procesar pago";
            //this.checkoutToolStripMenuItem.AccessibleName = "Finalizar compra";
            //this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            //this.checkoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            //this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            //this.checkoutToolStripMenuItem.Text = "&Finalizar Compra";
            //this.checkoutToolStripMenuItem.ToolTipText = "Procesar pago y finalizar (Ctrl+F)";

            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.AccessibleDescription = "Herramientas para vendedores";
            this.vendedorToolStripMenuItem.AccessibleName = "Menú Vendedor";
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.verificacionDeStockToolStripMenuItem
            });
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.vendedorToolStripMenuItem.Text = "&Vendedor";

            // 
            // verificacionDeStockToolStripMenuItem
            // 
            this.verificacionDeStockToolStripMenuItem.AccessibleDescription = "Verificar disponibilidad de productos en inventario";
            this.verificacionDeStockToolStripMenuItem.AccessibleName = "Verificación de stock";
            this.verificacionDeStockToolStripMenuItem.Name = "verificacionDeStockToolStripMenuItem";
            this.verificacionDeStockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.verificacionDeStockToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.verificacionDeStockToolStripMenuItem.Text = "&Verificación de Stock";
            this.verificacionDeStockToolStripMenuItem.ToolTipText = "Consultar inventario (Ctrl+S)";

            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.AccessibleDescription = "Gestión logística y preparación de pedidos";
            this.logisticaToolStripMenuItem.AccessibleName = "Menú Logística";
            this.logisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.preparacionDePedidoToolStripMenuItem
            });
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.logisticaToolStripMenuItem.Text = "&Logística";

            // 
            // preparacionDePedidoToolStripMenuItem
            // 
            this.preparacionDePedidoToolStripMenuItem.AccessibleDescription = "Preparar paquetes para envío";
            this.preparacionDePedidoToolStripMenuItem.AccessibleName = "Preparación de pedidos";
            this.preparacionDePedidoToolStripMenuItem.Name = "preparacionDePedidoToolStripMenuItem";
            this.preparacionDePedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preparacionDePedidoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.preparacionDePedidoToolStripMenuItem.Text = "&Preparación de Pedido";
            this.preparacionDePedidoToolStripMenuItem.ToolTipText = "Preparar paquetes (Ctrl+P)";

            // 
            // repartidorToolStripMenuItem
            // 
            this.repartidorToolStripMenuItem.AccessibleDescription = "Herramientas para repartidores y entregas";
            this.repartidorToolStripMenuItem.AccessibleName = "Menú Repartidor";
            this.repartidorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.rutaDeEntregasToolStripMenuItem
            });
            this.repartidorToolStripMenuItem.Name = "repartidorToolStripMenuItem";
            this.repartidorToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.repartidorToolStripMenuItem.Text = "&Repartidor";

            // 
            // rutaDeEntregasToolStripMenuItem
            // 
            this.rutaDeEntregasToolStripMenuItem.AccessibleDescription = "Gestionar rutas y entregas del día";
            this.rutaDeEntregasToolStripMenuItem.AccessibleName = "Ruta de entregas";
            this.rutaDeEntregasToolStripMenuItem.Name = "rutaDeEntregasToolStripMenuItem";
            this.rutaDeEntregasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.rutaDeEntregasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.rutaDeEntregasToolStripMenuItem.Text = "Ruta de &Entregas";
            this.rutaDeEntregasToolStripMenuItem.ToolTipText = "Gestionar entregas (Ctrl+E)";

            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.AccessibleDescription = "Funciones administrativas y gestión de pagos";
            this.administracionToolStripMenuItem.AccessibleName = "Menú Administración";
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.pagosToolStripMenuItem
            });
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.administracionToolStripMenuItem.Text = "&Administración";

            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.AccessibleDescription = "Gestionar pagos y transacciones";
            this.pagosToolStripMenuItem.AccessibleName = "Gestión de pagos";
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.pagosToolStripMenuItem.Text = "&Pagos";
            this.pagosToolStripMenuItem.ToolTipText = "Gestión de pagos (Ctrl+G)";

            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.AccessibleDescription = "Gestionar ventanas de la aplicación";
            this.ventanaToolStripMenuItem.AccessibleName = "Menú Ventana";
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cascadaToolStripMenuItem,
                this.horizontalToolStripMenuItem,
                this.verticalToolStripMenuItem,
                this.cerrarTodasToolStripMenuItem
            });
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.ventanaToolStripMenuItem.Text = "&Ventana";

            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.AccessibleDescription = "Organizar ventanas en cascada";
            this.cascadaToolStripMenuItem.AccessibleName = "Cascada";
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.cascadaToolStripMenuItem.Text = "&Cascada";
            this.cascadaToolStripMenuItem.ToolTipText = "Organizar en cascada";

            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.AccessibleDescription = "Organizar ventanas horizontalmente";
            this.horizontalToolStripMenuItem.AccessibleName = "Mosaico horizontal";
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.horizontalToolStripMenuItem.Text = "Mosaico &Horizontal";
            this.horizontalToolStripMenuItem.ToolTipText = "Organizar horizontalmente";

            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.AccessibleDescription = "Organizar ventanas verticalmente";
            this.verticalToolStripMenuItem.AccessibleName = "Mosaico vertical";
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.verticalToolStripMenuItem.Text = "Mosaico &Vertical";
            this.verticalToolStripMenuItem.ToolTipText = "Organizar verticalmente";

            // 
            // cerrarTodasToolStripMenuItem
            // 
            this.cerrarTodasToolStripMenuItem.AccessibleDescription = "Cerrar todas las ventanas abiertas";
            this.cerrarTodasToolStripMenuItem.AccessibleName = "Cerrar todas";
            this.cerrarTodasToolStripMenuItem.Name = "cerrarTodasToolStripMenuItem";
            this.cerrarTodasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.W)));
            this.cerrarTodasToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.cerrarTodasToolStripMenuItem.Text = "Cerrar &Todas";
            this.cerrarTodasToolStripMenuItem.ToolTipText = "Cerrar todas las ventanas";

            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.AccessibleDescription = "Ayuda e información sobre la aplicación";
            this.ayudaToolStripMenuItem.AccessibleName = "Menú Ayuda";
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.acercaDeToolStripMenuItem
            });
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";

            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.AccessibleDescription = "Información sobre la aplicación ClickStore";
            this.acercaDeToolStripMenuItem.AccessibleName = "Acerca de";
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.ToolTipText = "Información de la aplicación (F1)";

            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleDescription = "Barra de estado con información del sistema";
            this.statusStrip1.AccessibleName = "Barra de estado";
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblEstado,
                this.lblUsuario,
                this.lblFecha
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Barra de estado";

            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 20);
            this.lblEstado.Text = "Listo";
            this.lblEstado.ToolTipText = "Estado actual del sistema";

            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(1225, 20);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuario: Administrador";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.ToolTipText = "Usuario actual del sistema";

            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 20);
            this.lblFecha.Text = "10/09/2025";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.ToolTipText = "Fecha actual";

            // 
            // Main
            // 
            this.AccessibleDescription = "Ventana principal de la aplicación ClickStore con menús de navegación";
            this.AccessibleName = "ClickStore - Aplicación principal";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 694);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickStore - Sistema de Gestión Comercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}