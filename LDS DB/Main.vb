Imports System.Windows.Forms

Public Class Main
    Public FileName As String

#Region "Form methods"
#Region "Menu Options"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub
#End Region
#Region "Toolbar methods"
    Private Sub cmdBIReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBIReport.Click
        FileName = ""
        lblStatus.Text = "Getting file..."
        prgBar.Style = ProgressBarStyle.Marquee

        ofdFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        ofdFile.Filter = "Excel 2010(*.xlsx)|*.xlsx"
        ofdFile.Title = "Searching: BI Report"

        If ofdFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = ofdFile.FileName
            If FileName.Length > 0 Then
                lblStatus.Text = "Reading file..."
                BGW.RunWorkerAsync("BI Report")
            End If
        End If
    End Sub
    Private Sub cmdMyPReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMyPReport.Click
        FileName = ""
        lblStatus.Text = "Getting file..."
        prgBar.Style = ProgressBarStyle.Marquee

        ofdFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        ofdFile.Filter = "Excel 2010(*.xlsx)|*.xlsx"
        ofdFile.Title = "Searching: My Purch. Report"


        If ofdFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = ofdFile.FileName
            If FileName.Length > 0 Then
                lblStatus.Text = "Reading file..."
                BGW.RunWorkerAsync("My Purch")
            End If
        End If
    End Sub
    Private Sub cmdAccentureReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccentureReport.Click
        FileName = ""
        lblStatus.Text = "Getting file..."
        prgBar.Style = ProgressBarStyle.Marquee
        ofdFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        ofdFile.Filter = "Excel 2010(*.xlsx)|*.xlsx"
        ofdFile.Title = "Searching: Accenture Report"
        If ofdFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = ofdFile.FileName
            If FileName.Length > 0 Then
                lblStatus.Text = "Reading file..."
                BGW.RunWorkerAsync("Accenture")
            End If
        End If
    End Sub
#End Region
#Region "Others"
    Private Sub BGW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork
        Dim XLSheet As String = ""
        Dim Table_Name As String = ""
        Dim SQLTable As String = ""
        Dim StoreProc As String = ""

        'Select the report type to be uploaded
        Select Case e.Argument
            Case "My Purch"
                XLSheet = "MyP SC report.xls"
                Table_Name = "MyPData"
                SQLTable = "TMP_My Purchases Report"
                StoreProc = "stp_Update_MyPurch_Report"
            Case "BI Report"
                XLSheet = "SAPBW_DOWNLOAD"
                Table_Name = "BIData"
                SQLTable = "TMP_BI Report"
                StoreProc = "stp_Update_BI_Report"
            Case "Accenture"
                XLSheet = "Tracking Sheet"
                Table_Name = "AccTable"
                SQLTable = "TMP_Accenture"
                StoreProc = "stp_Update_Accenture_Report"
        End Select

        'Las instrucciones del dataset estan comentadas para futuro de informnacion local,
        'se utilizará una vista ya que esta tool de un solo usuario y su BK.

        Dim XLData As New DataTable
        Dim xl As New Objects.MSExcel

        Try
            'If DS.Tables.IndexOf("BIData") > -1 Then
            '    DS.Tables.Remove("BIData")
            'End If

            XLData = xl.Read_XLSX(FileName, XLSheet, True) ' Read the Excel file
            XLData.TableName = Table_Name ' Assign the table name

            If XLData.TableName = "AccTable" Then
                'Accenture report has columns that need to be deleted
                If XLData.Columns.Count > 62 Then 'If the report has more then 62 columns
                    Do
                        XLData.Columns.RemoveAt(XLData.Columns.Count - 1) 'Remove the column
                    Loop Until XLData.Columns.Count = 62
                    XLData.AcceptChanges()
                End If

                'Some rows has blank @ Primary Key SC# or SC Line# 
                Dim RN As Integer = 0
                For Each R As DataRow In XLData.Rows
                    RN += 1
                    If (R("SC_#").ToString.Trim.Length = 0) Or (R("SC_Line").ToString.Trim.Length = 0) Then
                        R("SC_#") = -1 'This row will be deleted @ Stored procedure: stp_Update_Accenture_Report
                        R("SC_Line") = RN 'This row will be deleted @ Stored procedure: stp_Update_Accenture_Report
                    End If
                Next
            End If

            BGW.ReportProgress(0, "Uploading to server...")
            If XLData.Rows.Count > 0 Then
                'DS.Tables.Add(BIData.Copy())
                Dim cn As New Objects.Connection
                cn.Execute("DELETE FROM [" & SQLTable & "]") 'Cleaning temporary table
                If cn.AppendTableToSqlServer("[" & SQLTable & "]", XLData) Then 'Append report to temporary table
                    Dim SP As New Objects.Stored_Procedure
                    BGW.ReportProgress(0, "Uploading new records...")
                    SP.Stored_Procedure_Name = StoreProc
                    If Not SP.Execute() Then 'Excecute stored procedure
                        MsgBox("Unable to update history.", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Unable to load file to server.")
                End If
            End If

        Catch ex As Exception
            'To do control if any exception raise.
            MsgBox("Unknown error: " & ex.Message & Chr(13) & Chr(13) & "Unable to finish the process.", MsgBoxStyle.Critical, "Unknown error")

        End Try
    End Sub

    Private Sub BGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW.ProgressChanged
        lblStatus.Text = e.UserState
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW.RunWorkerCompleted
        lblStatus.Text = "Process finished."
        prgBar.Style = ProgressBarStyle.Blocks
        MsgBox("Process finished.", MsgBoxStyle.Information)
    End Sub
#End Region

#End Region
End Class