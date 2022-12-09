using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using DevExpress.Drawing;

namespace ChartManualReport {
    public partial class Form1 : Form {
        private int pageWidthInPixels;
        private int pageHeightInPixels;

        private Metafile chartBitmap;
        MemoryStream ms;
        Link link;

        public Form1() {
            InitializeComponent();

            ms = new MemoryStream(1000);

            chartControl1.ExportToImage(ms, ImageFormat.Wmf);
            ms.Seek(0, SeekOrigin.Begin);

            chartBitmap = new Metafile(ms);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            link = new Link(printingSystem1);

            link.BeforeCreateAreas += new EventHandler(link_BeforeCreateAreas);
            link.CreateDetailArea += new CreateAreaEventHandler(link_CreateDetailArea);

            link.ShowPreviewDialog();
        }

        void link_BeforeCreateAreas(object sender, EventArgs e) {
            RecalcSize();
        }

        void link_CreateDetailArea(object sender, CreateAreaEventArgs e) {
            RecalcSize();

            if (pageWidthInPixels < 100 || pageHeightInPixels < 100) {
                e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);

                e.Graph.DrawString("Very small size", Color.Red,
                    new RectangleF(0, pageHeightInPixels / 2, pageWidthInPixels, pageHeightInPixels / 2), BorderSide.None);

                e.Graph.BackColor = Color.Transparent;
                e.Graph.DrawLine(new PointF(0, 0), new PointF(pageWidthInPixels, pageHeightInPixels), Color.Red, 2);
                e.Graph.DrawLine(new PointF(pageWidthInPixels, 0), new PointF(0, pageHeightInPixels), Color.Red, 2);

                return;
            }

            SizeF size = e.Graph.MeasureString(textEdit1.Text, pageWidthInPixels);

            e.Graph.DrawString(textEdit1.Text, Color.Blue,
                new RectangleF(0, 0, pageWidthInPixels, size.Height), BorderSide.All);

            e.Graph.DrawImage(chartBitmap,
                new RectangleF(0, size.Height, pageWidthInPixels, pageHeightInPixels - size.Height));
        }

        private void printingSystem1_AfterMarginsChange(object sender, MarginsChangeEventArgs e) {
            RecalcSize();
            link.CreateDocument();
        }

        private void printingSystem1_PageSettingsChanged(object sender, EventArgs e) {
            RecalcSize();
            link.CreateDocument();
        }

        private void RecalcSize() {
            printingSystem1.Graph.PageUnit = DXGraphicsUnit.Pixel;

            pageWidthInPixels = Convert.ToInt32(Math.Floor(printingSystem1.Graph.ClientPageSize.Width));
            pageHeightInPixels = Convert.ToInt32(Math.Floor(printingSystem1.Graph.ClientPageSize.Height));
        }

    }
}