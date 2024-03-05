<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListenToCalls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListenToCalls))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.RecordingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCalledParty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetupTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRingTimeSeconds = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConnectedTimeSeconds = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileSize = New DevExpress.XtraGrid.Columns.GridColumn()
        '   Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.DataSource = Me.RecordingBindingSource
        Me.Grid.Location = New System.Drawing.Point(12, 72)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(709, 565)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RecordingBindingSource
        '
        Me.RecordingBindingSource.DataSource = GetType(CallRecorder.Recording)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCalledParty, Me.colSetupTime, Me.colRingTimeSeconds, Me.colConnectedTimeSeconds, Me.colFileSize})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCalledParty
        '
        Me.colCalledParty.Caption = "Telephone No."
        Me.colCalledParty.FieldName = "CalledParty"
        Me.colCalledParty.Name = "colCalledParty"
        Me.colCalledParty.Visible = True
        Me.colCalledParty.VisibleIndex = 0
        '
        'colSetupTime
        '
        Me.colSetupTime.DisplayFormat.FormatString = "dd MMM yy hh:mm:ss"
        Me.colSetupTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSetupTime.FieldName = "SetupTime"
        Me.colSetupTime.Name = "colSetupTime"
        Me.colSetupTime.Visible = True
        Me.colSetupTime.VisibleIndex = 1
        '
        'colRingTimeSeconds
        '
        Me.colRingTimeSeconds.Caption = "Ringing Time"
        Me.colRingTimeSeconds.DisplayFormat.FormatString = "hh:mm:ss"
        Me.colRingTimeSeconds.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colRingTimeSeconds.FieldName = "RingTimeSeconds"
        Me.colRingTimeSeconds.Name = "colRingTimeSeconds"
        Me.colRingTimeSeconds.Visible = True
        Me.colRingTimeSeconds.VisibleIndex = 2
        '
        'colConnectedTimeSeconds
        '
        Me.colConnectedTimeSeconds.Caption = "Connected Time"
        Me.colConnectedTimeSeconds.DisplayFormat.FormatString = "hh:mm:ss"
        Me.colConnectedTimeSeconds.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colConnectedTimeSeconds.FieldName = "ConnectedTimeSeconds"
        Me.colConnectedTimeSeconds.Name = "colConnectedTimeSeconds"
        Me.colConnectedTimeSeconds.Visible = True
        Me.colConnectedTimeSeconds.VisibleIndex = 3
        '
        'colFileSize
        '
        Me.colFileSize.DisplayFormat.FormatString = "n0"
        Me.colFileSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFileSize.FieldName = "FileSize"
        Me.colFileSize.Name = "colFileSize"
        Me.colFileSize.Visible = True
        Me.colFileSize.VisibleIndex = 4
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(608, 45)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(627, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 45)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'SFD
        '
        Me.SFD.DefaultExt = "wav"
        Me.SFD.FileName = "Recording"
        '
        'FrmListenToCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 644)
        Me.Controls.Add(Me.btnSave)
        '  Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmListenToCalls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listen"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        '    CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RecordingBindingSource As BindingSource
    Friend WithEvents colCalledParty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetupTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRingTimeSeconds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConnectedTimeSeconds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileSize As DevExpress.XtraGrid.Columns.GridColumn
    '  Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SFD As SaveFileDialog
End Class
