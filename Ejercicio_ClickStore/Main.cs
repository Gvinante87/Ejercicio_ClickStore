using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ClickStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Asegurar modo MDI (por si el Designer quedó desincronizado)
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1; // ajustar si tu MenuStrip se llama distinto

            //  Suscripción de eventos de menú (ASCII recomendados)
            // CLIENTES
            this.catalogoDeProductosToolStripMenuItem.Click += (s, e) => OpenOrActivate<CatalogoDeProductos>();
            this.detalleDeProductoToolStripMenuItem.Click += (s, e) => OpenOrActivate<DetalleProducto>();
            this.carritoToolStripMenuItem.Click += (s, e) => OpenOrActivate<Checkout>(); // Carrito y Checkout

            // VENDEDOR
            this.verificacionDeStockToolStripMenuItem.Click += (s, e) => OpenOrActivate<VerificacionStock>();

            // LOGÍSTICA
            this.preparacionDePedidoToolStripMenuItem.Click += (s, e) => OpenOrActivate<PrepararPaquete>();

            // REPARTIDOR
            this.rutaDeEntregasToolStripMenuItem.Click += (s, e) => OpenOrActivate<EntregasDeRepartidor>();

            // ADMINISTRACIÓN
            this.pagosToolStripMenuItem.Click += (s, e) => OpenOrActivate<PedidosEntregadosyPagos>();
        }

        /// <summary>
        /// Abre un formulario MDI si no está abierto; si ya existe, lo activa.
        /// También oculta el panel de bienvenida cuando se abre cualquier ventana.
        /// </summary>
        private void OpenOrActivate<TForm>() where TForm : Form, new()
        {
            // Ocultar el panel de bienvenida ANTES de buscar ventanas
            panelBienvenida.Visible = false;

            foreach (Form child in this.MdiChildren)
            {
                if (child is TForm existing)
                {
                    if (existing.WindowState == FormWindowState.Minimized)
                        existing.WindowState = FormWindowState.Normal;

                    existing.BringToFront();
                    existing.Activate();
                    return;
                }
            }

            var frm = new TForm
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent
            };

            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // El panel de bienvenida se muestra por defecto
            // Se puede agregar aquí lógica adicional de inicialización
        }

        /// <summary>
        /// Mostrar el panel de bienvenida cuando se cierren todas las ventanas
        /// </summary>
        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);

            // Si no hay ventanas MDI abiertas, mostrar el panel de bienvenida
            if (this.MdiChildren.Length == 0)
            {
                panelBienvenida.Visible = true;
            }
        }
    }
}