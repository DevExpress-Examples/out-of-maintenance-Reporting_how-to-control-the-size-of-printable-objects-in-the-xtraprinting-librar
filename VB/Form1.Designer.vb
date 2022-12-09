Namespace ChartManualReport

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {(CObj((1)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {(CObj((2)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {(CObj((3)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {(CObj((4)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {(CObj((2)))})
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartManualReport.Form1))
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.printingSystem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Location = New System.Drawing.Point(12, 38)
            Me.chartControl1.Name = "chartControl1"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.Size = New System.Drawing.Size(599, 294)
            Me.chartControl1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(264, 344)
            Me.simpleButton1.MinimumSize = New System.Drawing.Size(50, 0)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(94, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Report"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' printingSystem1
            ' 
            AddHandler Me.printingSystem1.PageSettingsChanged, New System.EventHandler(AddressOf Me.printingSystem1_PageSettingsChanged)
            AddHandler Me.printingSystem1.AfterMarginsChange, New DevExpress.XtraPrinting.MarginsChangeEventHandler(AddressOf Me.printingSystem1_AfterMarginsChange)
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.textEdit1.EditValue = resources.GetString("textEdit1.EditValue")
            Me.textEdit1.Location = New System.Drawing.Point(12, 12)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(599, 20)
            Me.textEdit1.TabIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(623, 378)
            Me.Controls.Add(Me.textEdit1)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.printingSystem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem

        Private textEdit1 As DevExpress.XtraEditors.TextEdit
    End Class
End Namespace
