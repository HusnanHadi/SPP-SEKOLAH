<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RV_preview = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TRANSAKSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLaporan = New Pembayaran_SPP_Sekolah.DataSetLaporan()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RV_preview
        '
        Me.RV_preview.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetLaporan"
        ReportDataSource1.Value = Me.TRANSAKSIBindingSource
        Me.RV_preview.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV_preview.LocalReport.ReportEmbeddedResource = "Pembayaran_SPP_Sekolah.Laporan.rdlc"
        Me.RV_preview.Location = New System.Drawing.Point(0, 0)
        Me.RV_preview.Name = "RV_preview"
        Me.RV_preview.ServerReport.BearerToken = Nothing
        Me.RV_preview.Size = New System.Drawing.Size(578, 272)
        Me.RV_preview.TabIndex = 0
        '
        'TRANSAKSIBindingSource
        '
        Me.TRANSAKSIBindingSource.DataMember = "TRANSAKSI"
        Me.TRANSAKSIBindingSource.DataSource = Me.DataSetLaporan
        '
        'DataSetLaporan
        '
        Me.DataSetLaporan.DataSetName = "DataSetLaporan"
        Me.DataSetLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 272)
        Me.Controls.Add(Me.RV_preview)
        Me.Name = "Preview"
        Me.Text = "Preview"
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RV_preview As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TRANSAKSIBindingSource As BindingSource
    Friend WithEvents DataSetLaporan As DataSetLaporan
End Class
