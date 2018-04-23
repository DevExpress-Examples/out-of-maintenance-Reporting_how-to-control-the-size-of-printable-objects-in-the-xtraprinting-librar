Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports System.IO

Namespace ChartManualReport
	Partial Public Class Form1
		Inherits Form
		Private pageWidthInPixels As Integer
		Private pageHeightInPixels As Integer

		Private chartBitmap As Metafile
		Private ms As MemoryStream
		Private link As Link

		Public Sub New()
			InitializeComponent()

			ms = New MemoryStream(1000)

			chartControl1.ExportToImage(ms, ImageFormat.Wmf)
			ms.Seek(0, SeekOrigin.Begin)

			chartBitmap = New Metafile(ms)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			link = New Link(printingSystem1)

			AddHandler link.BeforeCreateAreas, AddressOf link_BeforeCreateAreas
			AddHandler link.CreateDetailArea, AddressOf link_CreateDetailArea

			link.ShowPreviewDialog()
		End Sub

		Private Sub link_BeforeCreateAreas(ByVal sender As Object, ByVal e As EventArgs)
			RecalcSize()
		End Sub

		Private Sub link_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			RecalcSize()

			If pageWidthInPixels < 100 OrElse pageHeightInPixels < 100 Then
				e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)

				e.Graph.DrawString("Very small size", Color.Red, New RectangleF(0, pageHeightInPixels\2, pageWidthInPixels, pageHeightInPixels\2), BorderSide.None)

				e.Graph.BackColor = Color.Transparent
				e.Graph.DrawLine(New PointF(0, 0), New PointF(pageWidthInPixels, pageHeightInPixels), Color.Red, 2)
				e.Graph.DrawLine(New PointF(pageWidthInPixels, 0), New PointF(0, pageHeightInPixels), Color.Red, 2)

				Return
			End If

			Dim size As SizeF = e.Graph.MeasureString(textEdit1.Text, pageWidthInPixels)

			e.Graph.DrawString(textEdit1.Text, Color.Blue, New RectangleF(0, 0, pageWidthInPixels, size.Height), BorderSide.All)

			e.Graph.DrawImage(chartBitmap, New RectangleF(0, size.Height, pageWidthInPixels, pageHeightInPixels - size.Height))
		End Sub

		Private Sub printingSystem1_AfterMarginsChange(ByVal sender As Object, ByVal e As MarginsChangeEventArgs) Handles printingSystem1.AfterMarginsChange
			RecalcSize()
			link.CreateDocument()
		End Sub

		Private Sub printingSystem1_PageSettingsChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printingSystem1.PageSettingsChanged
			RecalcSize()
			link.CreateDocument()
		End Sub

		Private Sub RecalcSize()
			printingSystem1.Graph.PageUnit = GraphicsUnit.Pixel

			pageWidthInPixels = Convert.ToInt32(Math.Floor(printingSystem1.Graph.ClientPageSize.Width))
			pageHeightInPixels = Convert.ToInt32(Math.Floor(printingSystem1.Graph.ClientPageSize.Height))
		End Sub

	End Class
End Namespace