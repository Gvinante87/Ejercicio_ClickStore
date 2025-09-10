using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ClickStore
{
    [SupportedOSPlatform("windows")]
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Asegurar modo MDI (por si el Designer quedó desincronizado)
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1; // ajustar si tu MenuStrip se llama distinto

            // ⚓ Suscripción de eventos de menú (Names ASCII recomendados)
            // CLIENTES
            this.catalogoDeProductosToolStripMenuItem.Click += (s, e) => OpenOrActivate<CatalogoDeProductos>();
            this.detalleDeProductoToolStripMenuItem.Click += (s, e) => OpenOrActivate<DetalleProducto>();
            this.carritoToolStripMenuItem.Click += (s, e) => OpenOrActivate<Checkout>(); // Único punto de acceso al checkout

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
        /// </summary>
        private void OpenOrActivate<TForm>() where TForm : Form, new()
        {
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
        }
    }
}