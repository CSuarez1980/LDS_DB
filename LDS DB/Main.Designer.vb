<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container
        Me.stpMainMenu = New System.Windows.Forms.MenuStrip
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.prgBar = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsTools = New System.Windows.Forms.ToolStrip
        Me.cmdBIReport = New System.Windows.Forms.ToolStripButton
        Me.cmdMyPReport = New System.Windows.Forms.ToolStripButton
        Me.cmdAccentureReport = New System.Windows.Forms.ToolStripButton
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog
        Me.DS = New System.Data.DataSet
        Me.BGW = New System.ComponentModel.BackgroundWorker
        Me.stpMainMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.tlsTools.SuspendLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stpMainMenu
        '
        Me.stpMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSystem})
        Me.stpMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.stpMainMenu.Name = "stpMainMenu"
        Me.stpMainMenu.Size = New System.Drawing.Size(343, 24)
        Me.stpMainMenu.TabIndex = 5
        Me.stpMainMenu.Text = "MenuStrip"
        '
        'mnuSystem
        '
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuSystem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(57, 20)
        Me.mnuSystem.Text = "&System"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.prgBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 238)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(343, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblStatus
        '
        Me.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(507, 17)
        Me.lblStatus.Spring = True
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prgBar
        '
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(100, 16)
        '
        'tlsTools
        '
        Me.tlsTools.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tlsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMyPReport, Me.cmdBIReport, Me.cmdAccentureReport})
        Me.tlsTools.Location = New System.Drawing.Point(0, 24)
        Me.tlsTools.Name = "tlsTools"
        Me.tlsTools.Size = New System.Drawing.Size(343, 31)
        Me.tlsTools.TabIndex = 9
        Me.tlsTools.Text = "ToolStrip1"
        '
        'cmdBIReport
        '
        Me.cmdBIReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBIReport.Image = Global.LDS_DB.My.Resources.Resources.folder_developer2
        Me.cmdBIReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBIReport.Name = "cmdBIReport"
        Me.cmdBIReport.Size = New System.Drawing.Size(28, 28)
        Me.cmdBIReport.Text = "ToolStripButton1"
        Me.cmdBIReport.ToolTipText = "Upload BI Report"
        '
        'cmdMyPReport
        '
        Me.cmdMyPReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMyPReport.Image = Global.LDS_DB.My.Resources.Resources.folder_green
        Me.cmdMyPReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMyPReport.Name = "cmdMyPReport"
        Me.cmdMyPReport.Size = New System.Drawing.Size(28, 28)
        Me.cmdMyPReport.Text = "ToolStripButton2"
        Me.cmdMyPReport.ToolTipText = "Upload MyPurch Report"
        '
        'cmdAccentureReport
        '
        Me.cmdAccentureReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAccentureReport.Image = Global.LDS_DB.My.Resources.Resources.folder_red
        Me.cmdAccentureReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAccentureReport.Name = "cmdAccentureReport"
        Me.cmdAccentureReport.Size = New System.Drawing.Size(28, 28)
        Me.cmdAccentureReport.Text = "ToolStripButton3"
        Me.cmdAccentureReport.ToolTipText = "Upload Accenture Report"
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        '
        'DS
        '
        Me.DS.DataSetName = "NewDataSet"
        '
        'BGW
        '
        Me.BGW.WorkerReportsProgress = True
        Me.BGW.WorkerSupportsCancellation = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 260)
        Me.Controls.Add(Me.tlsTools)
        Me.Controls.Add(Me.stpMainMenu)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.stpMainMenu
        Me.Name = "Main"
        Me.Text = "Main"
        Me.stpMainMenu.ResumeLayout(False)
        Me.stpMainMenu.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.tlsTools.ResumeLayout(False)
        Me.tlsTools.PerformLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stpMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tlsTools As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBIReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMyPReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAccentureReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DS As System.Data.DataSet
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents prgBar As System.Windows.Forms.ToolStripProgressBar

End Class
