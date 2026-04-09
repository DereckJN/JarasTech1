using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Procesos
{
    public partial class FrmFirmaDigital : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Point _puntoAnterior = Point.Empty;
        private bool _dibujando = false;

        /// <summary>
        /// Obtiene la firma como arreglo de bytes en formato PNG.
        /// </summary>
        public byte[] FirmaBytes { get; private set; }

        public FrmFirmaDigital()
        {
            InitializeComponent();
            InicializarLienzo();
        }

        private void InicializarLienzo()
        {
            _bitmap = new Bitmap(panelFirma.Width, panelFirma.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            panelFirma.BackgroundImage = _bitmap;
        }

        private void panelFirma_MouseDown(object sender, MouseEventArgs e)
        {
            _dibujando = true;
            _puntoAnterior = e.Location;
        }

        private void panelFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dibujando && _puntoAnterior != Point.Empty)
            {
                using (Pen pen = new Pen(Color.Black, 3))
                {
                    _graphics.DrawLine(pen, _puntoAnterior, e.Location);
                }
                panelFirma.Invalidate();
                _puntoAnterior = e.Location;
            }
        }

        private void panelFirma_MouseUp(object sender, MouseEventArgs e)
        {
            _dibujando = false;
            _puntoAnterior = Point.Empty;
        }

        private void panelFirma_Paint(object sender, PaintEventArgs e)
        {
            if (_bitmap != null)
                e.Graphics.DrawImage(_bitmap, Point.Empty);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            panelFirma.Invalidate();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Guardar la imagen como PNG en un MemoryStream
            using (MemoryStream ms = new MemoryStream())
            {
                _bitmap.Save(ms, ImageFormat.Png);
                FirmaBytes = ms.ToArray();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FirmaBytes = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _graphics?.Dispose();
            _bitmap?.Dispose();
            base.OnFormClosing(e);
        }
    }
}