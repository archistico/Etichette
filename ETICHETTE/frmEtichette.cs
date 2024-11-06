using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using PdfSharp.Drawing.Layout;

namespace ETICHETTE
{
    public partial class frmEtichette : Form
    {
        public frmEtichette()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NuGet\Install-Package PDFsharp -Version 6.2.0-preview-1
            int iniziale = (int)nudInizio.Value;
            int numero = 1;
            int qtMax = (int)nudQT.Value;

            double hTitolo = 0.3;
            double hTesto = 0.22;
            double hDate = 0.22;
            double hInterlinea = 0.05;

            double testoMargineTopDown = 0.2;
            double testoMargineLeftRight = 0.2;

            var etichetta = (Etichetta)cbxEtichetta.SelectedItem;

            var document = new PdfDocument();
            document.Options.ColorMode = PdfColorMode.Rgb;
            document.Info.Title = "Etichette chef";
            document.Info.Author = "Emilie Rollandin";
            document.Info.Subject = "Ingredienti e scadenze";

            var page = document.AddPage();
            page.Width = XUnit.FromCentimeter(21);
            page.Height = XUnit.FromCentimeter(29.7);
            page.Orientation = PageOrientation.Portrait;

            var gfx = XGraphics.FromPdfPage(page, XGraphicsUnit.Centimeter);
            var bru = new XSolidBrush(XColor.FromArgb(255, 255, 255, 0));

            var penEtichetta = new XPen(XPens.Gray);
            penEtichetta.Width = 0.01;

            for (int riga = 0; riga < etichetta.QtVerticale && numero <= qtMax; riga++)
            {
                
                for (int col = 0; col < etichetta.QtOrizzontale && numero <= qtMax; col++)
                {
                    if (numero < (int)nudInizio.Value)
                    {
                        numero++;
                        continue;
                    }

                    double x1 = etichetta.MargineLaterale + etichetta.PassoOrizzontale * col;
                    double y1 = etichetta.MargineSuperiore + etichetta.PassoVerticale * riga;

                    if (chbBordi.Checked)
                        gfx.DrawRectangle(penEtichetta, x1, y1, etichetta.Larghezza, etichetta.Altezza);

                    var fontTitolo = new XFont("Arial", hTitolo, XFontStyleEx.Bold,
                             new XPdfFontOptions(PdfFontEmbedding.EmbedCompleteFontFile));

                    var fontTesto = new XFont("Arial", hTesto, XFontStyleEx.Regular,
                             new XPdfFontOptions(PdfFontEmbedding.EmbedCompleteFontFile));

                    var fontDate = new XFont("Arial", hDate, XFontStyleEx.Bold,
                             new XPdfFontOptions(PdfFontEmbedding.EmbedCompleteFontFile));

                    gfx.DrawString(tbxTitolo.Text, fontTitolo, XBrushes.Black,
                        new XRect(x1 + testoMargineLeftRight, y1 + testoMargineTopDown, etichetta.Larghezza - 2 * testoMargineLeftRight, hTitolo),
                        XStringFormats.Center);

                    var tf = new XTextFormatter(gfx);
                    XStringFormat format = new XStringFormat();
                    format.LineAlignment = XLineAlignment.Near;
                    format.Alignment = XStringAlignment.Near;
                    XBrush brush = XBrushes.Black;

                    tf.DrawString(tbxTesto.Text,
                                  fontTesto,
                                  brush,
                                  new XRect(x1 + testoMargineLeftRight, y1 + 2 * hTitolo, etichetta.Larghezza - 2 * testoMargineLeftRight, etichetta.Altezza - hTitolo - 2 * testoMargineTopDown),
                                  format
                                  );

                    // Scritta produzione
                    gfx.DrawString(tbxProduzione.Text + " " + dtpProduzione.Value.ToString("dd/MM/yyyy"),
                        fontDate, 
                        XBrushes.Black,
                        new XRect(
                                x1 + testoMargineLeftRight,
                                y1 + testoMargineTopDown + hTitolo + hTesto * 10 + hInterlinea,
                                etichetta.Larghezza - 2 * testoMargineLeftRight,
                                hDate
                            ),
                        XStringFormats.TopLeft);

                    // Scritta scadenza
                    gfx.DrawString(tbxScadenza.Text + " " + dtpScadenza.Value.ToString("dd/MM/yyyy"), 
                        fontDate, 
                        XBrushes.Black,
                        new XRect(
                                x1 + testoMargineLeftRight,
                                y1 + testoMargineTopDown + hTitolo + hTesto * 11 + 2* hInterlinea,
                                etichetta.Larghezza - 2 * testoMargineLeftRight,
                                hDate
                            ),
                        XStringFormats.TopLeft);

                    numero++;                    
                }
                
            }

            var filename = $"etichette_{DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss")}.pdf";
            document.Save(filename);
            PdfFileUtility.ShowDocument(filename);
        }

        private void frmEtichette_Load(object sender, EventArgs e)
        {
            CaricaCombobox();
            dtpScadenza.Value = DateTime.Now.AddDays(30);
        }

        private void CaricaCombobox()
        {
            cbxEtichetta.Items.Clear();

            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Etichetta>("etichette");

                if (col.Count() > 0)
                {
                    foreach (Etichetta f in col.FindAll())
                    {
                        cbxEtichetta.Items.Add(f);
                    }
                }

                cbxEtichetta.DisplayMember = "DenominazioneCompleta";
                cbxEtichetta.ValueMember = "Id";
            }

            if (cbxEtichetta.Items.Count > 0) cbxEtichetta.SelectedIndex = 0;
        }

        private void btnTipi_Click(object sender, EventArgs e)
        {
            var frm = new frmPrincipale();
            frm.ShowDialog();
            CaricaCombobox();
        }

        private void cbxEtichetta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var etichetta = (Etichetta)cbxEtichetta.SelectedItem;
            nudQT.Value = (int)(etichetta.QtOrizzontale * etichetta.QtVerticale);
        }
    }
}
