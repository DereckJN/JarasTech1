using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Util;
using log4net;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace JarasTech.Layers.UI.Reportes
{
    public partial class FrmReportes : Form
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IBLLProductos _bllProductos = new BLLProductos();
        private readonly IBLLMarcas _bllMarcas = new BLLMarcas();
        private readonly IBLLModelos _bllModelos = new BLLModelos();
        private readonly IBLLTiposDispositivo _bllTipos = new BLLTiposDispositivo();
        private readonly IBLLFacturas _bllFacturas = new BLLFacturas();
        private readonly IBLLClientes _bllClientes = new BLLClientes();

        // Datos actuales del gráfico (para redibujar al redimensionar)
        private List<KeyValuePair<DateTime, decimal>> _datoGrafico =
            new List<KeyValuePair<DateTime, decimal>>();

        public FrmReportes()
        {
            InitializeComponent();
            picGrafico.Paint += new PaintEventHandler(picGrafico_Paint);
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                var marcas = _bllMarcas.GetAllMarcas().ToList();
                cboMarca.DataSource = marcas;
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "MarcaID";
                cboMarca.SelectedIndex = -1;

                var modelos = _bllModelos.GetAllModelos().ToList();
                cboModelo.DataSource = modelos;
                cboModelo.DisplayMember = "Descripcion";
                cboModelo.ValueMember = "ModeloID";
                cboModelo.SelectedIndex = -1;

                var tipos = _bllTipos.GetAllTiposDispositivo().ToList();
                cboTipo.DataSource = tipos;
                cboTipo.DisplayMember = "NombreTipo";
                cboTipo.ValueMember = "TipoDispositivoID";
                cboTipo.SelectedIndex = -1;

                var ini = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpDesde.Value = ini;
                dtpHasta.Value = DateTime.Today;
                dtpDesde3.Value = ini;
                dtpHasta3.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error Load Reportes: {0}", ex.Message);
            }
        }

        // ════════════════════════════════════════════════════════════════
        // REPORTE A — Productos
        // ════════════════════════════════════════════════════════════════
        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            try
            {
                int? marcaID = cboMarca.SelectedValue is int m ? (int?)m : null;
                int? modeloID = cboModelo.SelectedValue is int mo ? (int?)mo : null;
                int? tipoID = cboTipo.SelectedValue is int t ? (int?)t : null;

                var lista = _bllProductos.GetProductosByFiltros(marcaID, modeloID, tipoID)
                    .Where(p => p.Estado).ToList();

                if (!lista.Any())
                {
                    MessageBox.Show("No hay productos con los filtros seleccionados.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ruta = GenerarPDFProductos(lista);
                System.Diagnostics.Process.Start(ruta);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error ReporteProductos: {0}", ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarPDFProductos(List<Productos> lista)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            byte[] logoBytes = PDFHelper.ObtenerLogoBytes();
            string ruta = RutaReporte("Reporte_Productos");

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header().Column(h =>
                    {
                        h.Item().Row(row =>
                        {
                            // ── Logo ──────────────────────────────────────────────
                            if (logoBytes != null)
                                row.ConstantItem(70).Height(55).Image(logoBytes);
                            else
                                row.ConstantItem(70);

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("JarasTech").Bold().FontSize(20)
                                    .FontColor(Colors.Blue.Darken3);
                                c.Item().Text("Reporte de Productos Electrónicos")
                                    .FontSize(11).FontColor(Colors.Grey.Darken1);
                                c.Item().Text("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"))
                                    .FontSize(9);
                            });
                            row.ConstantItem(130).AlignRight().Column(c =>
                            {
                                string f = "Filtros:";
                                if (cboMarca.SelectedIndex >= 0) f += "\nMarca: " + cboMarca.Text;
                                if (cboModelo.SelectedIndex >= 0) f += "\nModelo: " + cboModelo.Text;
                                if (cboTipo.SelectedIndex >= 0) f += "\nTipo: " + cboTipo.Text;
                                c.Item().Text(f).FontSize(8).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        h.Item().PaddingTop(6).LineHorizontal(2)
                            .LineColor(Colors.Blue.Darken2);
                    });

                    page.Content().PaddingVertical(10).Column(content =>
                    {
                        foreach (var p in lista)
                        {
                            content.Item().Border(1).BorderColor(Colors.Grey.Lighten2)
                                .Padding(8).Row(row =>
                                {
                                    row.ConstantItem(90).Column(col =>
                                    {
                                        if (p.Fotografia != null && p.Fotografia.Length > 0)
                                            col.Item().Width(85).Height(85).Image(p.Fotografia);
                                        else
                                            col.Item().Width(85).Height(85)
                                                .Background(Colors.Grey.Lighten3)
                                                .AlignCenter().AlignMiddle()
                                                .Text("Sin foto").FontSize(8);
                                    });
                                    row.RelativeItem().PaddingLeft(10).Column(col =>
                                    {
                                        col.Item().Text(p.CodigoInterno + "  —  " +
                                            (p.NombreMarca ?? "") + " " + (p.NombreModelo ?? ""))
                                            .Bold().FontSize(11);
                                        col.Item().Text("Tipo: " + (p.NombreTipoDispositivo ?? "")).FontSize(9);
                                        col.Item().Text("Color: " + (p.Color ?? "")).FontSize(9);
                                        col.Item().Text("Stock: " + p.CantidadStock + " unidades").FontSize(9);
                                        col.Item().Text("Precio: ₡ " + p.PrecioColones.ToString("N2") +
                                            "  /  $ " + p.PrecioDolares.ToString("N2")).FontSize(9);
                                        if (!string.IsNullOrEmpty(p.Caracteristicas))
                                            col.Item().PaddingTop(2).Text(p.Caracteristicas)
                                                .FontSize(8).FontColor(Colors.Grey.Darken1);
                                    });
                                });
                            content.Item().Height(6);
                        }
                        content.Item().PaddingTop(10).AlignRight()
                            .Text("Total: " + lista.Count + " productos").Bold().FontSize(11);
                    });

                    page.Footer().AlignCenter()
                        .Text("JarasTech — " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(ruta);

            return ruta;
        }

        // ════════════════════════════════════════════════════════════════
        // REPORTE B — Facturas
        // ════════════════════════════════════════════════════════════════
        private void btnReporteFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde.Value > dtpHasta.Value)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la final.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var lista = _bllFacturas.GetFacturasByRangoFecha(
                    dtpDesde.Value.Date,
                    dtpHasta.Value.Date.AddDays(1).AddSeconds(-1)).ToList();

                if (!lista.Any())
                {
                    MessageBox.Show("No hay facturas en ese rango de fechas.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ruta = GenerarPDFFacturas(lista);
                System.Diagnostics.Process.Start(ruta);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error ReporteFacturas: {0}", ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarPDFFacturas(List<Facturas> lista)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            string ruta = RutaReporte("Reporte_Facturas");
            byte[] logoBytes = PDFHelper.ObtenerLogoBytes();
            decimal totC = lista.Sum(f => f.TotalColones);
            decimal totD = lista.Sum(f => f.TotalDolares);
            decimal totIVA = lista.Sum(f => f.MontoIVA);

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(9));

                    page.Header().Column(h =>
                    {
                        h.Item().Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                // ── Logo ──────────────────────────────────────────────
                                if (logoBytes != null)
                                    row.ConstantItem(70).Height(55).Image(logoBytes);
                                else
                                    row.ConstantItem(70);
                                c.Item().Text("JarasTech").Bold().FontSize(20)
                                    .FontColor(Colors.Blue.Darken3);
                                c.Item().Text("Reporte de Facturas").FontSize(11)
                                    .FontColor(Colors.Grey.Darken1);
                                c.Item().Text("Período: " + dtpDesde.Value.ToString("dd/MM/yyyy") +
                                    " al " + dtpHasta.Value.ToString("dd/MM/yyyy")).FontSize(9);
                            });
                            row.ConstantItem(130).AlignRight().Column(c =>
                            {
                                c.Item().Text("Facturas: " + lista.Count).Bold().FontSize(10);
                                c.Item().Text(DateTime.Now.ToString("dd/MM/yyyy")).FontSize(8);
                            });
                        });
                        h.Item().PaddingTop(6).LineHorizontal(2).LineColor(Colors.Blue.Darken2);
                    });

                    page.Content().PaddingVertical(10).Column(content =>
                    {
                        content.Item().Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.ConstantColumn(68);
                                c.RelativeColumn(3);
                                c.ConstantColumn(68);
                                c.ConstantColumn(88);
                                c.ConstantColumn(62);
                                c.ConstantColumn(92);
                                c.ConstantColumn(68);
                            });

                            Func<IContainer, IContainer> hdr = c =>
                                c.Background(Colors.Blue.Darken2).Padding(5)
                                 .DefaultTextStyle(t => t.Bold().FontSize(8).FontColor(Colors.White));

                            table.Header(h =>
                            {
                                h.Cell().Element(hdr).Text("Factura #");
                                h.Cell().Element(hdr).Text("Cliente");
                                h.Cell().Element(hdr).AlignCenter().Text("Fecha");
                                h.Cell().Element(hdr).AlignRight().Text("Subtotal ₡");
                                h.Cell().Element(hdr).AlignRight().Text("IVA ₡");
                                h.Cell().Element(hdr).AlignRight().Text("Total ₡");
                                h.Cell().Element(hdr).AlignRight().Text("Total $");
                            });

                            bool alt = false;
                            foreach (var f in lista)
                            {
                                bool a = alt;
                                Func<IContainer, IContainer> cel = c =>
                                {
                                    if (a) c = c.Background(Colors.Grey.Lighten5);
                                    return c.BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Padding(4).DefaultTextStyle(t => t.FontSize(8));
                                };
                                table.Cell().Element(cel).Text(f.FacturaID.ToString("D8"));
                                table.Cell().Element(cel).Text(f.NombreCliente ?? "ID " + f.ClienteID);
                                table.Cell().Element(cel).AlignCenter()
                                    .Text(f.FechaFactura.ToString("dd/MM/yy"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + f.SubtotalColones.ToString("N2"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + f.MontoIVA.ToString("N2"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + f.TotalColones.ToString("N2"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("$ " + f.TotalDolares.ToString("N2"));
                                alt = !alt;
                            }

                        });

                        content.Item().PaddingTop(15).AlignRight().Width(320).Column(tot =>
                        {
                            tot.Item().LineHorizontal(1).LineColor(Colors.Blue.Darken2);
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("Total IVA:").FontSize(10);
                                r.ConstantItem(140).AlignRight()
                                    .Text("₡ " + totIVA.ToString("N2")).FontSize(10);
                            });
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("TOTAL ₡:").Bold().FontSize(12)
                                    .FontColor(Colors.Green.Darken2);
                                r.ConstantItem(140).AlignRight()
                                    .Text("₡ " + totC.ToString("N2")).Bold().FontSize(12)
                                    .FontColor(Colors.Green.Darken2);
                            });
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("TOTAL $:").Bold().FontSize(12)
                                    .FontColor(Colors.Blue.Darken2);
                                r.ConstantItem(140).AlignRight()
                                    .Text("$ " + totD.ToString("N2")).Bold().FontSize(12)
                                    .FontColor(Colors.Blue.Darken2);
                            });
                        });

                        // ── Total en letras ────────────────────────────────────────────────
                        content.Item().PaddingTop(10)
                            .Background(Colors.Blue.Lighten5)
                            .Padding(8)
                            .Column(col =>
                            {
                                col.Item().Text("SON:").Bold().FontSize(8)
            .FontColor(Colors.Grey.Darken2);
                                col.Item().Text(PDFHelper.Capitalizar(PDFHelper.MontoALetras(totC)))
            .FontSize(10).Bold().FontColor(Colors.Blue.Darken3);
                            });

                    });
                  

                    page.Footer().AlignCenter()
                        .Text("JarasTech — " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(ruta);

            return ruta;
        }

        // ════════════════════════════════════════════════════════════════
        // REPORTE C — Clientes
        // ════════════════════════════════════════════════════════════════
        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltroCliente.Text.Trim();
                List<Clientes> lista;
                if (string.IsNullOrEmpty(filtro))
                    lista = _bllClientes.GetAllClientes().ToList();
                else
                    lista = _bllClientes.GetClientesByNombre(filtro).ToList();

                if (!lista.Any())
                {
                    MessageBox.Show("No hay clientes con ese filtro.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ruta = GenerarPDFClientes(lista);
                System.Diagnostics.Process.Start(ruta);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error ReporteClientes: {0}", ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarPDFClientes(List<Clientes> lista)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            byte[] logoBytes = PDFHelper.ObtenerLogoBytes();
            string ruta = RutaReporte("Reporte_Clientes");

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header().Column(h =>
                    {
                        h.Item().Row(row =>
                        {
                            // ── Logo ──────────────────────────────────────────────
                            if (logoBytes != null)
                                row.ConstantItem(70).Height(55).Image(logoBytes);
                            else
                                row.ConstantItem(70);

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("JarasTech").Bold().FontSize(20)
                                    .FontColor(Colors.Blue.Darken3);
                                c.Item().Text("Reporte de Clientes").FontSize(11)
                                    .FontColor(Colors.Grey.Darken1);
                                c.Item().Text("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"))
                                    .FontSize(9);
                            });
                            row.ConstantItem(100).AlignRight()
                                .Text("Total: " + lista.Count + " clientes")
                                .Bold().FontSize(9);
                        });
                        h.Item().PaddingTop(6).LineHorizontal(2).LineColor(Colors.Blue.Darken2);
                    });

                    page.Content().PaddingVertical(10).Column(content =>
                    {
                        foreach (var c in lista)
                        {
                            content.Item().Border(1).BorderColor(Colors.Grey.Lighten2)
                                .Padding(8).Row(row =>
                                {
                                    row.ConstantItem(80).Column(col =>
                                    {
                                        if (c.Fotografia != null && c.Fotografia.Length > 0)
                                            col.Item().Width(75).Height(90).Image(c.Fotografia);
                                        else
                                            col.Item().Width(75).Height(90)
                                                .Background(Colors.Grey.Lighten3)
                                                .AlignCenter().AlignMiddle()
                                                .Text("Sin foto").FontSize(8);
                                    });
                                    row.RelativeItem().PaddingLeft(12).Column(col =>
                                    {
                                        col.Item().Text(c.Nombre + " " + c.Apellidos)
                                            .Bold().FontSize(12);
                                        col.Item().Text("Cédula: " + c.NumeroIdentificacion).FontSize(9);
                                        col.Item().Text("Correo: " + c.CorreoElectronico).FontSize(9);
                                        col.Item().Text("Tel: " + c.Telefono).FontSize(9);
                                        col.Item().Text("Provincia: " + (c.Provincia ?? "")).FontSize(9);
                                        if (!string.IsNullOrEmpty(c.DireccionExacta))
                                            col.Item().Text("Dir: " + c.DireccionExacta)
                                                .FontSize(8).FontColor(Colors.Grey.Darken1);
                                    });
                                });
                            content.Item().Height(5);
                        }
                    });

                    page.Footer().AlignCenter()
                        .Text("JarasTech — " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(ruta);

            return ruta;
        }

        // ════════════════════════════════════════════════════════════════
        // REPORTE D — Gráfico con GDI+
        // ════════════════════════════════════════════════════════════════
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde3.Value > dtpHasta3.Value)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la final.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var facturas = _bllFacturas.GetFacturasByRangoFecha(
                    dtpDesde3.Value.Date,
                    dtpHasta3.Value.Date.AddDays(1).AddSeconds(-1)).ToList();

                if (!facturas.Any())
                {
                    MessageBox.Show("No hay ventas en ese rango de fechas.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _datoGrafico = facturas
                    .GroupBy(f => f.FechaFactura.Date)
                    .OrderBy(g => g.Key)
                    .Select(g => new KeyValuePair<DateTime, decimal>(
                        g.Key, g.Sum(f => f.TotalColones)))
                    .ToList();

                picGrafico.Refresh(); // dispara Paint

                decimal total = facturas.Sum(f => f.TotalColones);
                int nFac = facturas.Count;
                decimal promedio = _datoGrafico.Count > 0
                    ? total / _datoGrafico.Count : 0;

                lblGraficoTotal.Text = "Total ventas:    ₡ " + total.ToString("N2");
                lblGraficoFacturas.Text = "N° Facturas:     " + nFac;
                lblGraficoPromedio.Text = "Promedio/día:  ₡ " + promedio.ToString("N2");

                // Exportar PDF con gráfico
                string rutaImg = Path.Combine(Path.GetTempPath(), "grafico_jt.png");
                using (var bmp = new Bitmap(picGrafico.Width, picGrafico.Height))
                {
                    picGrafico.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(rutaImg, System.Drawing.Imaging.ImageFormat.Png);
                }
                string rutaPDF = GenerarPDFGrafico(rutaImg, total, nFac);
                System.Diagnostics.Process.Start(rutaPDF);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error Grafico: {0}", ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Dibuja el gráfico de barras en el PictureBox usando GDI+.</summary>
        private void picGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            int w = picGrafico.Width;
            int h = picGrafico.Height;

            // Fondo
            g.Clear(Color.White);

            if (_datoGrafico == null || _datoGrafico.Count == 0)
            {
                using (var f = new Font("Segoe UI", 11, FontStyle.Italic))
                    g.DrawString("Sin datos — presione Generar Gráfico",
                        f, Brushes.Gray, 40, h / 2 - 12);
                return;
            }

            // Márgenes
            int mx = 70, my = 20, mb = 55, mr = 20;
            int areaW = w - mx - mr;
            int areaH = h - my - mb;

            decimal maxVal = _datoGrafico.Max(kv => kv.Value);
            if (maxVal <= 0) maxVal = 1;

            int n = _datoGrafico.Count;
            int barW = Math.Max(4, (areaW / n) - 4);

            var fontPeq = new Font("Segoe UI", 7F);
            var fontTick = new Font("Segoe UI", 7.5F);
            var barColor = Color.FromArgb(0, 120, 215);
            var barBrush = new SolidBrush(barColor);

            // Líneas guía horizontales
            int lineas = 5;
            using (var penGrid = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                for (int i = 0; i <= lineas; i++)
                {
                    int y = my + areaH - (int)(areaH * i / (float)lineas);
                    g.DrawLine(penGrid, mx, y, mx + areaW, y);
                    decimal val = maxVal * i / lineas;
                    string lbl = val >= 1000000
                        ? (val / 1000000M).ToString("N1") + "M"
                        : val >= 1000
                        ? (val / 1000M).ToString("N0") + "K"
                        : val.ToString("N0");
                    g.DrawString("₡" + lbl, fontTick, Brushes.Gray,
                        mx - 68, y - 8);
                }
            }

            // Eje X e Y
            using (var penEje = new Pen(Color.FromArgb(180, 180, 180), 1))
            {
                g.DrawLine(penEje, mx, my, mx, my + areaH);
                g.DrawLine(penEje, mx, my + areaH, mx + areaW, my + areaH);
            }

            // Barras
            for (int i = 0; i < n; i++)
            {
                decimal val = _datoGrafico[i].Value;
                int barH = (int)(areaH * val / maxVal);
                int x = mx + i * (areaW / n) + (areaW / n - barW) / 2;
                int y = my + areaH - barH;

                // Sombra suave
                using (var shadow = new SolidBrush(Color.FromArgb(30, 0, 80, 160)))
                    g.FillRectangle(shadow, x + 2, y + 2, barW, barH);

                g.FillRectangle(barBrush, x, y, barW, barH);

                // Valor encima de la barra
                if (barH > 18)
                {
                    string valStr = val >= 1000000
                        ? (val / 1000000M).ToString("N1") + "M"
                        : val >= 1000
                        ? (val / 1000M).ToString("N0") + "K"
                        : val.ToString("N0");
                    using (var sfTop = new StringFormat { Alignment = StringAlignment.Center })
                        g.DrawString(valStr, fontPeq, Brushes.White, x + barW / 2f, y + 3, sfTop);
                }

                // Etiqueta fecha eje X
                string fecha = _datoGrafico[i].Key.ToString("dd/MM");
                using (var sfBot = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.DirectionVertical
                })
                    g.DrawString(fecha, fontPeq, Brushes.Gray,
                        x + barW / 2f, my + areaH + 4, sfBot);
            }

            // Título del gráfico
            using (var fTit = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (var titleBrush = new SolidBrush(Color.FromArgb(30, 30, 60)))
            {
                g.DrawString("Ventas por día (₡)", fTit, titleBrush, mx, 2);
            }

            fontPeq.Dispose();
            fontTick.Dispose();
            barBrush.Dispose();
        }

        private string GenerarPDFGrafico(string rutaImagen, decimal total, int nFac)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            string ruta = RutaReporte("Reporte_Grafico_Ventas");
            byte[] logoBytes = PDFHelper.ObtenerLogoBytes();
            byte[] imgBytes = File.ReadAllBytes(rutaImagen);

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(30);

                    page.Header().Column(h =>
                    {
                        h.Item().Row(row =>
                        {
                            // ── Logo ──────────────────────────────────────────────
                            if (logoBytes != null)
                                row.ConstantItem(70).Height(55).Image(logoBytes);
                            else
                                row.ConstantItem(70);
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("JarasTech").Bold().FontSize(20)
                                    .FontColor(Colors.Blue.Darken3);
                                c.Item().Text("Gráfico de Ventas").FontSize(11)
                                    .FontColor(Colors.Grey.Darken1);
                                c.Item().Text("Período: " + dtpDesde3.Value.ToString("dd/MM/yyyy") +
                                    " al " + dtpHasta3.Value.ToString("dd/MM/yyyy")).FontSize(9);
                            });
                            row.ConstantItem(140).AlignRight().Column(c =>
                            {
                                c.Item().Text("Total: ₡ " + total.ToString("N2"))
                                    .Bold().FontSize(9).FontColor(Colors.Green.Darken2);
                                c.Item().Text("Facturas: " + nFac).FontSize(9);
                            });
                        });
                        h.Item().PaddingTop(6).LineHorizontal(2).LineColor(Colors.Blue.Darken2);
                    });

                    page.Content().PaddingVertical(10).Column(content =>
                    {
                        content.Item().Height(300).Image(imgBytes);
                        content.Item().PaddingTop(20);
                        content.Item().Text("Detalle por día:").Bold().FontSize(10);
                        content.Item().PaddingTop(5).Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(2);
                                c.RelativeColumn(3);
                            });

                            Func<IContainer, IContainer> hdr = c =>
                                c.Background(Colors.Blue.Darken2).Padding(5)
                                 .DefaultTextStyle(t => t.Bold().FontSize(9)
                                     .FontColor(Colors.White));

                            table.Header(h =>
                            {
                                h.Cell().Element(hdr).Text("Fecha");
                                h.Cell().Element(hdr).AlignRight().Text("Ventas ₡");
                            });

                            bool alt = false;
                            foreach (var kv in _datoGrafico)
                            {
                                bool a = alt;
                                Func<IContainer, IContainer> cel = c =>
                                {
                                    if (a) c = c.Background(Colors.Grey.Lighten5);
                                    return c.BorderBottom(1)
                                            .BorderColor(Colors.Grey.Lighten2)
                                            .Padding(4)
                                            .DefaultTextStyle(t => t.FontSize(9));
                                };
                                table.Cell().Element(cel).Text(kv.Key.ToString("dd/MM/yyyy"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + kv.Value.ToString("N2"));
                                alt = !alt;
                            }
                        });
                    });

                    page.Footer().AlignCenter()
                        .Text("JarasTech — " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(ruta);

            return ruta;
        }

        // ════════════════════════════════════════════════════════════════
        // HELPER
        // ════════════════════════════════════════════════════════════════
        private string RutaReporte(string nombre)
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return Path.Combine(dir, nombre + "_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");
        }

        private void btnCerrar_Click(object sender, EventArgs e) { Close(); }
    }
}