Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Preview
    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lap As New ReportDocument
        Lap.Load("..\..\CRV.rpt")
        If Form_Laporan.rb_bulan.Checked = True Then
            Lap.SetParameterValue("tgl1", Form_Laporan.dtp1.Text)
            Lap.SetParameterValue("tgl2", Form_Laporan.dtp2.Text)

        ElseIf Form_Laporan.rb_tahun.Checked = True Then
            CrystalReportViewer1.SelectionFormula = "Year({tbspp1.Tanggal_Bayar})=" & Format(Form_Laporan.dtp_tahun.Value, "yyyy") & ""
        End If
        CrystalReportViewer1.ReportSource = Lap

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class