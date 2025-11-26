using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using PdfiumViewer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfDocument = PdfSharp.Pdf.PdfDocument;
using PdfSharp.Drawing.Layout;

namespace GestiuneCarti.Forms
{
    public partial class ImprimareForm : Form
    {
        private PdfViewer pdfViewer;
        private SQLiteConnection connection;
        private MemoryStream currentPdfStream;

        public ImprimareForm(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn ?? throw new ArgumentNullException(nameof(conn));
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            pdfPanel.Controls.Add(pdfViewer);
        }

        
        public void load_pdf_btn_Click(object sender, EventArgs e)
        {
            //string pdfPath = Path.Combine(Application.StartupPath, "registru_carti.pdf");
            string pdfPath = Path.Combine(Application.StartupPath, $"registru_carti_{Guid.NewGuid()}.pdf");


            string query = "SELECT * FROM Carti";
            using (var cmd = new SQLiteCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;

                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont fontHeader = new XFont("Arial", 10, XFontStyleEx.Bold);
                XFont fontRow = new XFont("Arial", 9, XFontStyleEx.Regular);

                // distanda de la stanga

                //int leftoffset = 60;
                int leftoffset = Convert.ToInt32(margin_tb.Text);
                double margin = 15;
                double y = margin;
                double rowHeight = 30;

                // latimile coloanelor
                double[] colWidths = {30, 100, 160, 100, 30, 50, 40, 50, 60, 40, 40};

                string[] headers = {"ID", "Autor", "Tiltu", "Locul publicarii", "Anul", "CZU", "Pret", "Mențiuni", "Însemnări","Data", "R.M.F"};

                // desenam header
                double x = margin;
                for (int i = 0; i < headers.Length; i++)
                {
                    gfx.DrawRectangle(XPens.Black, XBrushes.LightGray, x + leftoffset, y, colWidths[i], rowHeight);
                    gfx.DrawString(headers[i], fontHeader, XBrushes.Black, new XRect(x + leftoffset, y + 5, colWidths[i], rowHeight),
                                   XStringFormats.Center);
                    x += colWidths[i];
                }
                y += rowHeight;

                // desenam randurile din DB
                while (reader.Read())
                {
                    x = margin + leftoffset;
                    string[] valori = {
                    reader["ID_CARTE"].ToString(),
                    reader["AUTOR"].ToString(),
                    reader["TITLU"].ToString(),
                    reader["LOCUL_PUBLICARII"].ToString(),
                    reader["ANUL_PUBLICARII"].ToString(),
                    reader["ID_CZU"].ToString(),
                    reader["PRET"].ToString(),
                    "", "", "", ""
                };
                    for (int i = 0; i < valori.Length; i++)
                    {      
                        gfx.DrawRectangle(XPens.Black, x, y, colWidths[i], rowHeight);
                        XTextFormatter tf = new XTextFormatter(gfx);
                        tf.DrawString(valori[i], fontRow, XBrushes.Black,
                                      new XRect(x + 5, y + 2, colWidths[i] - 5, rowHeight),
                                      XStringFormats.TopLeft);

                        x += colWidths[i];
                    }

                    y += rowHeight;

                    if (y + rowHeight > page.Height - margin)
                    {
                        page = document.AddPage();
                        page.Orientation = PdfSharp.PageOrientation.Landscape;
                        gfx = XGraphics.FromPdfPage(page);
                        y = margin;
                    }
                }

                currentPdfStream?.Dispose();
                currentPdfStream = new MemoryStream();

                document.Save(currentPdfStream, false);
                currentPdfStream.Position = 0;
            }

            var pdfDoc = PdfiumViewer.PdfDocument.Load(currentPdfStream);
            pdfViewer.Document?.Dispose();
            pdfViewer.Document = pdfDoc;
        }
    }
}

