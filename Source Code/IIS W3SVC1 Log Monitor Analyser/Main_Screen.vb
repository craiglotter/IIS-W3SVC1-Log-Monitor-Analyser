Imports Microsoft.Win32
Imports System.IO


Public Class Main_Screen
    Inherits System.Windows.Forms.Form

    Dim projectdirectory As String = ""
    Dim runprog1 As String = ""
    Dim runprog2 As String = ""


    Private splash_loader As Splash_Screen
    Public dataloaded As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


    End Sub

    Public Sub New(ByVal splash As Splash_Screen)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        splash_loader = splash

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents FullError As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtBaseFolder As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonFolderBrowse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet11 As IIS_W3SVC1_Log_Monitor_Analyser.DataSet1
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid5 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid6 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid7 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid8 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid9 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid10 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid11 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid12 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid13 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid14 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid15 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid16 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid17 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid18 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid19 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid20 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid21 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid22 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid23 As System.Windows.Forms.DataGrid
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents log_s_port As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents log_s_computername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents log_s_sitename As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents log_s_ip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents log_cs_bytes2 As System.Windows.Forms.TextBox
    Friend WithEvents log_sc_bytes2 As System.Windows.Forms.TextBox
    Friend WithEvents log_time_taken2 As System.Windows.Forms.TextBox
    Friend WithEvents log_cs_bytes As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents log_sc_bytes As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents log_time_taken As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents hour24 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents hour23 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents hour22 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents hour21 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents hour20 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents hour19 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents hour18 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents hour17 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents hour16 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents hour15 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents hour14 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents hour13 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents hour12 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents hour11 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents hour10 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents hour9 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents hour8 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents hour7 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents hour6 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents hour5 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents hour4 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents hour3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents hour2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents hour1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents peakdate2 As System.Windows.Forms.TextBox
    Friend WithEvents peakdate1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents total_hits As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents log_sc_win32_status2 As System.Windows.Forms.TextBox
    Friend WithEvents log_sc_win32_status1 As System.Windows.Forms.TextBox
    Friend WithEvents log_sc_substatus2 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents log_sc_substatus1 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents log_sc_status2 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents log_sc_status1 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents pageviews As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label





    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main_Screen))
        Me.FullError = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBaseFolder = New System.Windows.Forms.TextBox
        Me.ButtonFolderBrowse = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataSet11 = New IIS_W3SVC1_Log_Monitor_Analyser.DataSet1
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.DataGrid5 = New System.Windows.Forms.DataGrid
        Me.DataGrid6 = New System.Windows.Forms.DataGrid
        Me.DataGrid7 = New System.Windows.Forms.DataGrid
        Me.DataGrid8 = New System.Windows.Forms.DataGrid
        Me.DataGrid9 = New System.Windows.Forms.DataGrid
        Me.DataGrid10 = New System.Windows.Forms.DataGrid
        Me.DataGrid11 = New System.Windows.Forms.DataGrid
        Me.DataGrid12 = New System.Windows.Forms.DataGrid
        Me.DataGrid13 = New System.Windows.Forms.DataGrid
        Me.DataGrid14 = New System.Windows.Forms.DataGrid
        Me.DataGrid15 = New System.Windows.Forms.DataGrid
        Me.DataGrid16 = New System.Windows.Forms.DataGrid
        Me.DataGrid17 = New System.Windows.Forms.DataGrid
        Me.DataGrid18 = New System.Windows.Forms.DataGrid
        Me.DataGrid19 = New System.Windows.Forms.DataGrid
        Me.DataGrid20 = New System.Windows.Forms.DataGrid
        Me.DataGrid21 = New System.Windows.Forms.DataGrid
        Me.DataGrid22 = New System.Windows.Forms.DataGrid
        Me.DataGrid23 = New System.Windows.Forms.DataGrid
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label39 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.log_sc_win32_status2 = New System.Windows.Forms.TextBox
        Me.log_sc_win32_status1 = New System.Windows.Forms.TextBox
        Me.log_sc_substatus2 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.log_sc_substatus1 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.log_sc_status2 = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.log_sc_status1 = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.log_cs_bytes2 = New System.Windows.Forms.TextBox
        Me.log_sc_bytes2 = New System.Windows.Forms.TextBox
        Me.log_time_taken2 = New System.Windows.Forms.TextBox
        Me.log_cs_bytes = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.log_sc_bytes = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.log_time_taken = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.hour24 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.hour23 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.hour22 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.hour21 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.hour20 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.hour19 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.hour18 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.hour17 = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.hour16 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.hour15 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.hour14 = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.hour13 = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.hour12 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.hour11 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.hour10 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.hour9 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.hour8 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.hour7 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.hour6 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.hour5 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.hour4 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.hour3 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.hour2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.hour1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.peakdate2 = New System.Windows.Forms.TextBox
        Me.peakdate1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.total_hits = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.log_s_port = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.log_s_computername = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.log_s_sitename = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.log_s_ip = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pageviews = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FullError
        '
        Me.FullError.Checked = True
        Me.FullError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FullError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FullError.Location = New System.Drawing.Point(8, 600)
        Me.FullError.Name = "FullError"
        Me.FullError.Size = New System.Drawing.Size(12, 12)
        Me.FullError.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.FullError, "If Checked, Error Handling Routine enters Full Exception Mode")
        '
        'txtBaseFolder
        '
        Me.txtBaseFolder.BackColor = System.Drawing.Color.White
        Me.txtBaseFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaseFolder.ForeColor = System.Drawing.Color.Black
        Me.txtBaseFolder.Location = New System.Drawing.Point(432, 8)
        Me.txtBaseFolder.Name = "txtBaseFolder"
        Me.txtBaseFolder.ReadOnly = True
        Me.txtBaseFolder.Size = New System.Drawing.Size(272, 20)
        Me.txtBaseFolder.TabIndex = 4
        Me.txtBaseFolder.Text = "C:\Documents and Settings\Administrator\Desktop\Copy of IIS W3SVC1 Log Monitor.md" & _
        "b"
        Me.ToolTip1.SetToolTip(Me.txtBaseFolder, "The base folder containing the various work projects")
        '
        'ButtonFolderBrowse
        '
        Me.ButtonFolderBrowse.BackColor = System.Drawing.Color.DimGray
        Me.ButtonFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFolderBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFolderBrowse.ForeColor = System.Drawing.Color.White
        Me.ButtonFolderBrowse.Location = New System.Drawing.Point(712, 8)
        Me.ButtonFolderBrowse.Name = "ButtonFolderBrowse"
        Me.ButtonFolderBrowse.Size = New System.Drawing.Size(56, 20)
        Me.ButtonFolderBrowse.TabIndex = 7
        Me.ButtonFolderBrowse.Text = "BROWSE"
        Me.ToolTip1.SetToolTip(Me.ButtonFolderBrowse, "Launches the File Open Dialog")
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid1.CaptionText = "Date"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DataSet11.log_date
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid1.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid1.LinkColor = System.Drawing.Color.Black
        Me.DataGrid1.Location = New System.Drawing.Point(24, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.ParentRowsVisible = False
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.RowHeaderWidth = 30
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DataGrid1, "Displays the log data captured within the database.")
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-ZA")
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid2.CaptionText = "Date"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.DataSource = Me.DataSet11.log_date
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid2.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid2.LinkColor = System.Drawing.Color.Black
        Me.DataGrid2.Location = New System.Drawing.Point(32, 40)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid2.ParentRowsVisible = False
        Me.DataGrid2.PreferredColumnWidth = 100
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.RowHeadersVisible = False
        Me.DataGrid2.RowHeaderWidth = 30
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid2.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DataGrid2, "Displays the log data captured within the database.")
        '
        'DataGrid3
        '
        Me.DataGrid3.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid3.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid3.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid3.CaptionText = "Date"
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.DataSource = Me.DataSet11.log_date
        Me.DataGrid3.FlatMode = True
        Me.DataGrid3.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid3.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid3.LinkColor = System.Drawing.Color.Black
        Me.DataGrid3.Location = New System.Drawing.Point(40, 48)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid3.ParentRowsVisible = False
        Me.DataGrid3.PreferredColumnWidth = 100
        Me.DataGrid3.ReadOnly = True
        Me.DataGrid3.RowHeadersVisible = False
        Me.DataGrid3.RowHeaderWidth = 30
        Me.DataGrid3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid3.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid3.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DataGrid3, "Displays the log data captured within the database.")
        '
        'DataGrid4
        '
        Me.DataGrid4.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid4.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid4.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid4.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid4.CaptionText = "Date"
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.DataSource = Me.DataSet11.log_date
        Me.DataGrid4.FlatMode = True
        Me.DataGrid4.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid4.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid4.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid4.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid4.LinkColor = System.Drawing.Color.Black
        Me.DataGrid4.Location = New System.Drawing.Point(223, 25)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid4.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid4.ParentRowsVisible = False
        Me.DataGrid4.PreferredColumnWidth = 100
        Me.DataGrid4.ReadOnly = True
        Me.DataGrid4.RowHeadersVisible = False
        Me.DataGrid4.RowHeaderWidth = 30
        Me.DataGrid4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid4.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid4.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.DataGrid4, "Displays the log data captured within the database.")
        '
        'DataGrid5
        '
        Me.DataGrid5.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid5.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid5.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid5.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid5.CaptionText = "Date"
        Me.DataGrid5.DataMember = ""
        Me.DataGrid5.DataSource = Me.DataSet11.log_date
        Me.DataGrid5.FlatMode = True
        Me.DataGrid5.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid5.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid5.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid5.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid5.LinkColor = System.Drawing.Color.Black
        Me.DataGrid5.Location = New System.Drawing.Point(231, 33)
        Me.DataGrid5.Name = "DataGrid5"
        Me.DataGrid5.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid5.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid5.ParentRowsVisible = False
        Me.DataGrid5.PreferredColumnWidth = 100
        Me.DataGrid5.ReadOnly = True
        Me.DataGrid5.RowHeadersVisible = False
        Me.DataGrid5.RowHeaderWidth = 30
        Me.DataGrid5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid5.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid5.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DataGrid5, "Displays the log data captured within the database.")
        '
        'DataGrid6
        '
        Me.DataGrid6.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid6.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid6.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid6.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid6.CaptionText = "Date"
        Me.DataGrid6.DataMember = ""
        Me.DataGrid6.DataSource = Me.DataSet11.log_date
        Me.DataGrid6.FlatMode = True
        Me.DataGrid6.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid6.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid6.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid6.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid6.LinkColor = System.Drawing.Color.Black
        Me.DataGrid6.Location = New System.Drawing.Point(239, 41)
        Me.DataGrid6.Name = "DataGrid6"
        Me.DataGrid6.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid6.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid6.ParentRowsVisible = False
        Me.DataGrid6.PreferredColumnWidth = 100
        Me.DataGrid6.ReadOnly = True
        Me.DataGrid6.RowHeadersVisible = False
        Me.DataGrid6.RowHeaderWidth = 30
        Me.DataGrid6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid6.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid6.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid6.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.DataGrid6, "Displays the log data captured within the database.")
        '
        'DataGrid7
        '
        Me.DataGrid7.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid7.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid7.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid7.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid7.CaptionText = "Date"
        Me.DataGrid7.DataMember = ""
        Me.DataGrid7.DataSource = Me.DataSet11.log_date
        Me.DataGrid7.FlatMode = True
        Me.DataGrid7.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid7.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid7.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid7.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid7.LinkColor = System.Drawing.Color.Black
        Me.DataGrid7.Location = New System.Drawing.Point(247, 49)
        Me.DataGrid7.Name = "DataGrid7"
        Me.DataGrid7.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid7.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid7.ParentRowsVisible = False
        Me.DataGrid7.PreferredColumnWidth = 100
        Me.DataGrid7.ReadOnly = True
        Me.DataGrid7.RowHeadersVisible = False
        Me.DataGrid7.RowHeaderWidth = 30
        Me.DataGrid7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid7.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid7.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid7.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.DataGrid7, "Displays the log data captured within the database.")
        '
        'DataGrid8
        '
        Me.DataGrid8.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid8.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid8.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid8.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid8.CaptionText = "Date"
        Me.DataGrid8.DataMember = ""
        Me.DataGrid8.DataSource = Me.DataSet11.log_date
        Me.DataGrid8.FlatMode = True
        Me.DataGrid8.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid8.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid8.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid8.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid8.LinkColor = System.Drawing.Color.Black
        Me.DataGrid8.Location = New System.Drawing.Point(255, 57)
        Me.DataGrid8.Name = "DataGrid8"
        Me.DataGrid8.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid8.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid8.ParentRowsVisible = False
        Me.DataGrid8.PreferredColumnWidth = 100
        Me.DataGrid8.ReadOnly = True
        Me.DataGrid8.RowHeadersVisible = False
        Me.DataGrid8.RowHeaderWidth = 30
        Me.DataGrid8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid8.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid8.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.DataGrid8, "Displays the log data captured within the database.")
        '
        'DataGrid9
        '
        Me.DataGrid9.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid9.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid9.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid9.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid9.CaptionText = "Date"
        Me.DataGrid9.DataMember = ""
        Me.DataGrid9.DataSource = Me.DataSet11.log_date
        Me.DataGrid9.FlatMode = True
        Me.DataGrid9.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid9.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid9.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid9.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid9.LinkColor = System.Drawing.Color.Black
        Me.DataGrid9.Location = New System.Drawing.Point(214, 25)
        Me.DataGrid9.Name = "DataGrid9"
        Me.DataGrid9.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid9.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid9.ParentRowsVisible = False
        Me.DataGrid9.PreferredColumnWidth = 100
        Me.DataGrid9.ReadOnly = True
        Me.DataGrid9.RowHeadersVisible = False
        Me.DataGrid9.RowHeaderWidth = 30
        Me.DataGrid9.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid9.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid9.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.DataGrid9, "Displays the log data captured within the database.")
        '
        'DataGrid10
        '
        Me.DataGrid10.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid10.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid10.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid10.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid10.CaptionText = "Date"
        Me.DataGrid10.DataMember = ""
        Me.DataGrid10.DataSource = Me.DataSet11.log_date
        Me.DataGrid10.FlatMode = True
        Me.DataGrid10.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid10.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid10.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid10.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid10.LinkColor = System.Drawing.Color.Black
        Me.DataGrid10.Location = New System.Drawing.Point(222, 33)
        Me.DataGrid10.Name = "DataGrid10"
        Me.DataGrid10.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid10.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid10.ParentRowsVisible = False
        Me.DataGrid10.PreferredColumnWidth = 100
        Me.DataGrid10.ReadOnly = True
        Me.DataGrid10.RowHeadersVisible = False
        Me.DataGrid10.RowHeaderWidth = 30
        Me.DataGrid10.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid10.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid10.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.DataGrid10, "Displays the log data captured within the database.")
        '
        'DataGrid11
        '
        Me.DataGrid11.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid11.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid11.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid11.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid11.CaptionText = "Date"
        Me.DataGrid11.DataMember = ""
        Me.DataGrid11.DataSource = Me.DataSet11.log_date
        Me.DataGrid11.FlatMode = True
        Me.DataGrid11.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid11.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid11.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid11.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid11.LinkColor = System.Drawing.Color.Black
        Me.DataGrid11.Location = New System.Drawing.Point(230, 41)
        Me.DataGrid11.Name = "DataGrid11"
        Me.DataGrid11.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid11.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid11.ParentRowsVisible = False
        Me.DataGrid11.PreferredColumnWidth = 100
        Me.DataGrid11.ReadOnly = True
        Me.DataGrid11.RowHeadersVisible = False
        Me.DataGrid11.RowHeaderWidth = 30
        Me.DataGrid11.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid11.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid11.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid11.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.DataGrid11, "Displays the log data captured within the database.")
        '
        'DataGrid12
        '
        Me.DataGrid12.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid12.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid12.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid12.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid12.CaptionText = "Date"
        Me.DataGrid12.DataMember = ""
        Me.DataGrid12.DataSource = Me.DataSet11.log_date
        Me.DataGrid12.FlatMode = True
        Me.DataGrid12.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid12.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid12.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid12.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid12.LinkColor = System.Drawing.Color.Black
        Me.DataGrid12.Location = New System.Drawing.Point(238, 49)
        Me.DataGrid12.Name = "DataGrid12"
        Me.DataGrid12.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid12.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid12.ParentRowsVisible = False
        Me.DataGrid12.PreferredColumnWidth = 100
        Me.DataGrid12.ReadOnly = True
        Me.DataGrid12.RowHeadersVisible = False
        Me.DataGrid12.RowHeaderWidth = 30
        Me.DataGrid12.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid12.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid12.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.DataGrid12, "Displays the log data captured within the database.")
        '
        'DataGrid13
        '
        Me.DataGrid13.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid13.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid13.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid13.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid13.CaptionText = "Date"
        Me.DataGrid13.DataMember = ""
        Me.DataGrid13.DataSource = Me.DataSet11.log_date
        Me.DataGrid13.FlatMode = True
        Me.DataGrid13.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid13.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid13.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid13.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid13.LinkColor = System.Drawing.Color.Black
        Me.DataGrid13.Location = New System.Drawing.Point(246, 57)
        Me.DataGrid13.Name = "DataGrid13"
        Me.DataGrid13.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid13.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid13.ParentRowsVisible = False
        Me.DataGrid13.PreferredColumnWidth = 100
        Me.DataGrid13.ReadOnly = True
        Me.DataGrid13.RowHeadersVisible = False
        Me.DataGrid13.RowHeaderWidth = 30
        Me.DataGrid13.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid13.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid13.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid13.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.DataGrid13, "Displays the log data captured within the database.")
        '
        'DataGrid14
        '
        Me.DataGrid14.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid14.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid14.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid14.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid14.CaptionText = "Date"
        Me.DataGrid14.DataMember = ""
        Me.DataGrid14.DataSource = Me.DataSet11.log_date
        Me.DataGrid14.FlatMode = True
        Me.DataGrid14.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid14.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid14.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid14.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid14.LinkColor = System.Drawing.Color.Black
        Me.DataGrid14.Location = New System.Drawing.Point(254, 65)
        Me.DataGrid14.Name = "DataGrid14"
        Me.DataGrid14.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid14.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid14.ParentRowsVisible = False
        Me.DataGrid14.PreferredColumnWidth = 100
        Me.DataGrid14.ReadOnly = True
        Me.DataGrid14.RowHeadersVisible = False
        Me.DataGrid14.RowHeaderWidth = 30
        Me.DataGrid14.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid14.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid14.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid14.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.DataGrid14, "Displays the log data captured within the database.")
        '
        'DataGrid15
        '
        Me.DataGrid15.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid15.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid15.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid15.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid15.CaptionText = "Date"
        Me.DataGrid15.DataMember = ""
        Me.DataGrid15.DataSource = Me.DataSet11.log_date
        Me.DataGrid15.FlatMode = True
        Me.DataGrid15.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid15.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid15.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid15.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid15.LinkColor = System.Drawing.Color.Black
        Me.DataGrid15.Location = New System.Drawing.Point(262, 73)
        Me.DataGrid15.Name = "DataGrid15"
        Me.DataGrid15.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid15.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid15.ParentRowsVisible = False
        Me.DataGrid15.PreferredColumnWidth = 100
        Me.DataGrid15.ReadOnly = True
        Me.DataGrid15.RowHeadersVisible = False
        Me.DataGrid15.RowHeaderWidth = 30
        Me.DataGrid15.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid15.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid15.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid15.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.DataGrid15, "Displays the log data captured within the database.")
        '
        'DataGrid16
        '
        Me.DataGrid16.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid16.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid16.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid16.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid16.CaptionText = "Date"
        Me.DataGrid16.DataMember = ""
        Me.DataGrid16.DataSource = Me.DataSet11.log_date
        Me.DataGrid16.FlatMode = True
        Me.DataGrid16.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid16.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid16.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid16.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid16.LinkColor = System.Drawing.Color.Black
        Me.DataGrid16.Location = New System.Drawing.Point(270, 81)
        Me.DataGrid16.Name = "DataGrid16"
        Me.DataGrid16.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid16.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid16.ParentRowsVisible = False
        Me.DataGrid16.PreferredColumnWidth = 100
        Me.DataGrid16.ReadOnly = True
        Me.DataGrid16.RowHeadersVisible = False
        Me.DataGrid16.RowHeaderWidth = 30
        Me.DataGrid16.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid16.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid16.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid16.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.DataGrid16, "Displays the log data captured within the database.")
        '
        'DataGrid17
        '
        Me.DataGrid17.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid17.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid17.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid17.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid17.CaptionText = "Date"
        Me.DataGrid17.DataMember = ""
        Me.DataGrid17.DataSource = Me.DataSet11.log_date
        Me.DataGrid17.FlatMode = True
        Me.DataGrid17.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid17.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid17.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid17.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid17.LinkColor = System.Drawing.Color.Black
        Me.DataGrid17.Location = New System.Drawing.Point(278, 89)
        Me.DataGrid17.Name = "DataGrid17"
        Me.DataGrid17.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid17.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid17.ParentRowsVisible = False
        Me.DataGrid17.PreferredColumnWidth = 100
        Me.DataGrid17.ReadOnly = True
        Me.DataGrid17.RowHeadersVisible = False
        Me.DataGrid17.RowHeaderWidth = 30
        Me.DataGrid17.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid17.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid17.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid17.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.DataGrid17, "Displays the log data captured within the database.")
        '
        'DataGrid18
        '
        Me.DataGrid18.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid18.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid18.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid18.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid18.CaptionText = "Date"
        Me.DataGrid18.DataMember = ""
        Me.DataGrid18.DataSource = Me.DataSet11.log_date
        Me.DataGrid18.FlatMode = True
        Me.DataGrid18.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid18.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid18.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid18.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid18.LinkColor = System.Drawing.Color.Black
        Me.DataGrid18.Location = New System.Drawing.Point(286, 97)
        Me.DataGrid18.Name = "DataGrid18"
        Me.DataGrid18.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid18.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid18.ParentRowsVisible = False
        Me.DataGrid18.PreferredColumnWidth = 100
        Me.DataGrid18.ReadOnly = True
        Me.DataGrid18.RowHeadersVisible = False
        Me.DataGrid18.RowHeaderWidth = 30
        Me.DataGrid18.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid18.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid18.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid18.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.DataGrid18, "Displays the log data captured within the database.")
        '
        'DataGrid19
        '
        Me.DataGrid19.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid19.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid19.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid19.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid19.CaptionText = "Date"
        Me.DataGrid19.DataMember = ""
        Me.DataGrid19.DataSource = Me.DataSet11.log_date
        Me.DataGrid19.FlatMode = True
        Me.DataGrid19.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid19.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid19.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid19.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid19.LinkColor = System.Drawing.Color.Black
        Me.DataGrid19.Location = New System.Drawing.Point(294, 105)
        Me.DataGrid19.Name = "DataGrid19"
        Me.DataGrid19.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid19.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid19.ParentRowsVisible = False
        Me.DataGrid19.PreferredColumnWidth = 100
        Me.DataGrid19.ReadOnly = True
        Me.DataGrid19.RowHeadersVisible = False
        Me.DataGrid19.RowHeaderWidth = 30
        Me.DataGrid19.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid19.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid19.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid19.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.DataGrid19, "Displays the log data captured within the database.")
        '
        'DataGrid20
        '
        Me.DataGrid20.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid20.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid20.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid20.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid20.CaptionText = "Date"
        Me.DataGrid20.DataMember = ""
        Me.DataGrid20.DataSource = Me.DataSet11.log_date
        Me.DataGrid20.FlatMode = True
        Me.DataGrid20.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid20.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid20.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid20.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid20.LinkColor = System.Drawing.Color.Black
        Me.DataGrid20.Location = New System.Drawing.Point(302, 113)
        Me.DataGrid20.Name = "DataGrid20"
        Me.DataGrid20.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid20.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid20.ParentRowsVisible = False
        Me.DataGrid20.PreferredColumnWidth = 100
        Me.DataGrid20.ReadOnly = True
        Me.DataGrid20.RowHeadersVisible = False
        Me.DataGrid20.RowHeaderWidth = 30
        Me.DataGrid20.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid20.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid20.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid20.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.DataGrid20, "Displays the log data captured within the database.")
        '
        'DataGrid21
        '
        Me.DataGrid21.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid21.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid21.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid21.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid21.CaptionText = "Date"
        Me.DataGrid21.DataMember = ""
        Me.DataGrid21.DataSource = Me.DataSet11.log_date
        Me.DataGrid21.FlatMode = True
        Me.DataGrid21.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid21.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid21.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid21.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid21.LinkColor = System.Drawing.Color.Black
        Me.DataGrid21.Location = New System.Drawing.Point(310, 121)
        Me.DataGrid21.Name = "DataGrid21"
        Me.DataGrid21.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid21.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid21.ParentRowsVisible = False
        Me.DataGrid21.PreferredColumnWidth = 100
        Me.DataGrid21.ReadOnly = True
        Me.DataGrid21.RowHeadersVisible = False
        Me.DataGrid21.RowHeaderWidth = 30
        Me.DataGrid21.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid21.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid21.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid21.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.DataGrid21, "Displays the log data captured within the database.")
        '
        'DataGrid22
        '
        Me.DataGrid22.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid22.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid22.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid22.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid22.CaptionText = "Date"
        Me.DataGrid22.DataMember = ""
        Me.DataGrid22.DataSource = Me.DataSet11.log_date
        Me.DataGrid22.FlatMode = True
        Me.DataGrid22.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid22.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid22.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid22.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid22.LinkColor = System.Drawing.Color.Black
        Me.DataGrid22.Location = New System.Drawing.Point(318, 129)
        Me.DataGrid22.Name = "DataGrid22"
        Me.DataGrid22.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid22.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid22.ParentRowsVisible = False
        Me.DataGrid22.PreferredColumnWidth = 100
        Me.DataGrid22.ReadOnly = True
        Me.DataGrid22.RowHeadersVisible = False
        Me.DataGrid22.RowHeaderWidth = 30
        Me.DataGrid22.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid22.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid22.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid22.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.DataGrid22, "Displays the log data captured within the database.")
        '
        'DataGrid23
        '
        Me.DataGrid23.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid23.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid23.CaptionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DataGrid23.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid23.CaptionText = "Date"
        Me.DataGrid23.DataMember = ""
        Me.DataGrid23.DataSource = Me.DataSet11.log_date
        Me.DataGrid23.FlatMode = True
        Me.DataGrid23.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid23.GridLineColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid23.HeaderBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid23.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid23.LinkColor = System.Drawing.Color.Black
        Me.DataGrid23.Location = New System.Drawing.Point(326, 137)
        Me.DataGrid23.Name = "DataGrid23"
        Me.DataGrid23.ParentRowsBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid23.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid23.ParentRowsVisible = False
        Me.DataGrid23.PreferredColumnWidth = 100
        Me.DataGrid23.ReadOnly = True
        Me.DataGrid23.RowHeadersVisible = False
        Me.DataGrid23.RowHeaderWidth = 30
        Me.DataGrid23.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid23.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid23.Size = New System.Drawing.Size(258, 166)
        Me.DataGrid23.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.DataGrid23, "Displays the log data captured within the database.")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(432, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LOG SUMMARY DATABASE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 32)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "THE SUMMARY OF THE IIS LOG DATA CAPTURED AND STORED USING THE ""IIS W3SVC1 LOG MON" & _
        "ITOR"" PROGRAM IS DISPLAYED BELOW. YOU CAN CHANGE THE INPUT LOG SUMMARY DATABASE " & _
        "USING THE FILE BROWSER TO THE RIGHT."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Documents and Setting" & _
        "s\Administrator\Desktop\IIS W3SVC1 Log Monitor.mdb"";Password=;Jet OLEDB:Engine T" & _
        "ype=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Je" & _
        "t OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Den" & _
        "y None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;J" & _
        "et OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Re" & _
        "pair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "log_date", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("log_count", "log_count"), New System.Data.Common.DataColumnMapping("log_value", "log_value")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT log_count, log_value FROM log_date"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGrid23)
        Me.Panel1.Controls.Add(Me.DataGrid22)
        Me.Panel1.Controls.Add(Me.DataGrid21)
        Me.Panel1.Controls.Add(Me.DataGrid20)
        Me.Panel1.Controls.Add(Me.DataGrid19)
        Me.Panel1.Controls.Add(Me.DataGrid18)
        Me.Panel1.Controls.Add(Me.DataGrid17)
        Me.Panel1.Controls.Add(Me.DataGrid16)
        Me.Panel1.Controls.Add(Me.DataGrid15)
        Me.Panel1.Controls.Add(Me.DataGrid14)
        Me.Panel1.Controls.Add(Me.DataGrid13)
        Me.Panel1.Controls.Add(Me.DataGrid12)
        Me.Panel1.Controls.Add(Me.DataGrid11)
        Me.Panel1.Controls.Add(Me.DataGrid10)
        Me.Panel1.Controls.Add(Me.DataGrid9)
        Me.Panel1.Controls.Add(Me.DataGrid8)
        Me.Panel1.Controls.Add(Me.DataGrid7)
        Me.Panel1.Controls.Add(Me.DataGrid6)
        Me.Panel1.Controls.Add(Me.DataGrid5)
        Me.Panel1.Controls.Add(Me.DataGrid4)
        Me.Panel1.Controls.Add(Me.DataGrid3)
        Me.Panel1.Controls.Add(Me.DataGrid2)
        Me.Panel1.Controls.Add(Me.DataGrid1)
        Me.Panel1.Location = New System.Drawing.Point(16, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 212)
        Me.Panel1.TabIndex = 28
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(24, 600)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(88, 16)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "BUILD 20050930.1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "mdb"
        Me.OpenFileDialog1.Filter = "MSAccess files|*.mdb"
        Me.OpenFileDialog1.Title = "Select the IIS W3SVC1 Database"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(16, 280)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(744, 312)
        Me.Panel5.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.log_sc_win32_status2)
        Me.Panel4.Controls.Add(Me.log_sc_win32_status1)
        Me.Panel4.Controls.Add(Me.log_sc_substatus2)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.log_sc_substatus1)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Controls.Add(Me.log_sc_status2)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.log_sc_status1)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Location = New System.Drawing.Point(496, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(248, 136)
        Me.Panel4.TabIndex = 32
        '
        'log_sc_win32_status2
        '
        Me.log_sc_win32_status2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_win32_status2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_win32_status2.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_win32_status2.Location = New System.Drawing.Point(144, 112)
        Me.log_sc_win32_status2.Name = "log_sc_win32_status2"
        Me.log_sc_win32_status2.ReadOnly = True
        Me.log_sc_win32_status2.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_win32_status2.TabIndex = 11
        Me.log_sc_win32_status2.Text = ""
        '
        'log_sc_win32_status1
        '
        Me.log_sc_win32_status1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_win32_status1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_win32_status1.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_win32_status1.Location = New System.Drawing.Point(144, 96)
        Me.log_sc_win32_status1.Name = "log_sc_win32_status1"
        Me.log_sc_win32_status1.ReadOnly = True
        Me.log_sc_win32_status1.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_win32_status1.TabIndex = 10
        Me.log_sc_win32_status1.Text = ""
        '
        'log_sc_substatus2
        '
        Me.log_sc_substatus2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_substatus2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_substatus2.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_substatus2.Location = New System.Drawing.Point(144, 80)
        Me.log_sc_substatus2.Name = "log_sc_substatus2"
        Me.log_sc_substatus2.ReadOnly = True
        Me.log_sc_substatus2.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_substatus2.TabIndex = 9
        Me.log_sc_substatus2.Text = ""
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(8, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(128, 16)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Server Status Codes"
        '
        'log_sc_substatus1
        '
        Me.log_sc_substatus1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_substatus1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_substatus1.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_substatus1.Location = New System.Drawing.Point(144, 64)
        Me.log_sc_substatus1.Name = "log_sc_substatus1"
        Me.log_sc_substatus1.ReadOnly = True
        Me.log_sc_substatus1.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_substatus1.TabIndex = 7
        Me.log_sc_substatus1.Text = ""
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(136, 16)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Top Win32 Status Code :"
        '
        'log_sc_status2
        '
        Me.log_sc_status2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_status2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_status2.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_status2.Location = New System.Drawing.Point(144, 48)
        Me.log_sc_status2.Name = "log_sc_status2"
        Me.log_sc_status2.ReadOnly = True
        Me.log_sc_status2.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_status2.TabIndex = 5
        Me.log_sc_status2.Text = ""
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(8, 64)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(128, 16)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Top Sub Status Code:"
        '
        'log_sc_status1
        '
        Me.log_sc_status1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_status1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_status1.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_status1.Location = New System.Drawing.Point(144, 32)
        Me.log_sc_status1.Name = "log_sc_status1"
        Me.log_sc_status1.ReadOnly = True
        Me.log_sc_status1.Size = New System.Drawing.Size(88, 13)
        Me.log_sc_status1.TabIndex = 3
        Me.log_sc_status1.Text = ""
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(8, 32)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(128, 16)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Top Server Status Code:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.pageviews)
        Me.Panel3.Controls.Add(Me.Label40)
        Me.Panel3.Controls.Add(Me.log_cs_bytes2)
        Me.Panel3.Controls.Add(Me.log_sc_bytes2)
        Me.Panel3.Controls.Add(Me.log_time_taken2)
        Me.Panel3.Controls.Add(Me.log_cs_bytes)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.log_sc_bytes)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.log_time_taken)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.hour24)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.hour23)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.hour22)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.hour21)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.hour20)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.hour19)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.hour18)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.hour17)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.hour16)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Controls.Add(Me.hour15)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.hour14)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.hour13)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.hour12)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.hour11)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.hour10)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.hour9)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.hour8)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.hour7)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.hour6)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.hour5)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.hour4)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.hour3)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.hour2)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.hour1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.peakdate2)
        Me.Panel3.Controls.Add(Me.peakdate1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.total_hits)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(488, 288)
        Me.Panel3.TabIndex = 30
        '
        'log_cs_bytes2
        '
        Me.log_cs_bytes2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_cs_bytes2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_cs_bytes2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.log_cs_bytes2.Location = New System.Drawing.Point(224, 264)
        Me.log_cs_bytes2.Name = "log_cs_bytes2"
        Me.log_cs_bytes2.ReadOnly = True
        Me.log_cs_bytes2.Size = New System.Drawing.Size(120, 13)
        Me.log_cs_bytes2.TabIndex = 69
        Me.log_cs_bytes2.Text = ""
        '
        'log_sc_bytes2
        '
        Me.log_sc_bytes2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_bytes2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_bytes2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.log_sc_bytes2.Location = New System.Drawing.Point(224, 248)
        Me.log_sc_bytes2.Name = "log_sc_bytes2"
        Me.log_sc_bytes2.ReadOnly = True
        Me.log_sc_bytes2.Size = New System.Drawing.Size(120, 13)
        Me.log_sc_bytes2.TabIndex = 68
        Me.log_sc_bytes2.Text = ""
        '
        'log_time_taken2
        '
        Me.log_time_taken2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_time_taken2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_time_taken2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.log_time_taken2.Location = New System.Drawing.Point(224, 232)
        Me.log_time_taken2.Name = "log_time_taken2"
        Me.log_time_taken2.ReadOnly = True
        Me.log_time_taken2.Size = New System.Drawing.Size(120, 13)
        Me.log_time_taken2.TabIndex = 67
        Me.log_time_taken2.Text = ""
        '
        'log_cs_bytes
        '
        Me.log_cs_bytes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_cs_bytes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_cs_bytes.ForeColor = System.Drawing.Color.DimGray
        Me.log_cs_bytes.Location = New System.Drawing.Point(104, 264)
        Me.log_cs_bytes.Name = "log_cs_bytes"
        Me.log_cs_bytes.ReadOnly = True
        Me.log_cs_bytes.Size = New System.Drawing.Size(120, 13)
        Me.log_cs_bytes.TabIndex = 66
        Me.log_cs_bytes.Text = ""
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(8, 264)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Bytes Received:"
        '
        'log_sc_bytes
        '
        Me.log_sc_bytes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_sc_bytes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_sc_bytes.ForeColor = System.Drawing.Color.DimGray
        Me.log_sc_bytes.Location = New System.Drawing.Point(104, 248)
        Me.log_sc_bytes.Name = "log_sc_bytes"
        Me.log_sc_bytes.ReadOnly = True
        Me.log_sc_bytes.Size = New System.Drawing.Size(120, 13)
        Me.log_sc_bytes.TabIndex = 64
        Me.log_sc_bytes.Text = ""
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(8, 248)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 16)
        Me.Label37.TabIndex = 63
        Me.Label37.Text = "Bytes Sent:"
        '
        'log_time_taken
        '
        Me.log_time_taken.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_time_taken.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_time_taken.ForeColor = System.Drawing.Color.DimGray
        Me.log_time_taken.Location = New System.Drawing.Point(104, 232)
        Me.log_time_taken.Name = "log_time_taken"
        Me.log_time_taken.ReadOnly = True
        Me.log_time_taken.Size = New System.Drawing.Size(120, 13)
        Me.log_time_taken.TabIndex = 62
        Me.log_time_taken.Text = ""
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(8, 232)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 16)
        Me.Label36.TabIndex = 61
        Me.Label36.Text = "Time Taken:"
        '
        'hour24
        '
        Me.hour24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour24.ForeColor = System.Drawing.Color.DimGray
        Me.hour24.Location = New System.Drawing.Point(400, 208)
        Me.hour24.Name = "hour24"
        Me.hour24.ReadOnly = True
        Me.hour24.Size = New System.Drawing.Size(88, 13)
        Me.hour24.TabIndex = 60
        Me.hour24.Text = ""
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(168, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "12:00 - 13:00"
        '
        'hour23
        '
        Me.hour23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour23.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour23.ForeColor = System.Drawing.Color.DimGray
        Me.hour23.Location = New System.Drawing.Point(400, 192)
        Me.hour23.Name = "hour23"
        Me.hour23.ReadOnly = True
        Me.hour23.Size = New System.Drawing.Size(88, 13)
        Me.hour23.TabIndex = 58
        Me.hour23.Text = ""
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(328, 208)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "23:00 - 24:00"
        '
        'hour22
        '
        Me.hour22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour22.ForeColor = System.Drawing.Color.DimGray
        Me.hour22.Location = New System.Drawing.Point(400, 176)
        Me.hour22.Name = "hour22"
        Me.hour22.ReadOnly = True
        Me.hour22.Size = New System.Drawing.Size(88, 13)
        Me.hour22.TabIndex = 56
        Me.hour22.Text = ""
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(328, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "22:00 - 23:00"
        '
        'hour21
        '
        Me.hour21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour21.ForeColor = System.Drawing.Color.DimGray
        Me.hour21.Location = New System.Drawing.Point(400, 160)
        Me.hour21.Name = "hour21"
        Me.hour21.ReadOnly = True
        Me.hour21.Size = New System.Drawing.Size(88, 13)
        Me.hour21.TabIndex = 54
        Me.hour21.Text = ""
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(328, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "21:00 - 22:00"
        '
        'hour20
        '
        Me.hour20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour20.ForeColor = System.Drawing.Color.DimGray
        Me.hour20.Location = New System.Drawing.Point(400, 144)
        Me.hour20.Name = "hour20"
        Me.hour20.ReadOnly = True
        Me.hour20.Size = New System.Drawing.Size(88, 13)
        Me.hour20.TabIndex = 52
        Me.hour20.Text = ""
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(328, 160)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 16)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "20:00 - 21:00"
        '
        'hour19
        '
        Me.hour19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour19.ForeColor = System.Drawing.Color.DimGray
        Me.hour19.Location = New System.Drawing.Point(400, 128)
        Me.hour19.Name = "hour19"
        Me.hour19.ReadOnly = True
        Me.hour19.Size = New System.Drawing.Size(88, 13)
        Me.hour19.TabIndex = 50
        Me.hour19.Text = ""
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(328, 144)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 16)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "19:00 - 20:00"
        '
        'hour18
        '
        Me.hour18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour18.ForeColor = System.Drawing.Color.DimGray
        Me.hour18.Location = New System.Drawing.Point(400, 112)
        Me.hour18.Name = "hour18"
        Me.hour18.ReadOnly = True
        Me.hour18.Size = New System.Drawing.Size(88, 13)
        Me.hour18.TabIndex = 48
        Me.hour18.Text = ""
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(328, 128)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 16)
        Me.Label30.TabIndex = 47
        Me.Label30.Text = "18:00 - 19:00"
        '
        'hour17
        '
        Me.hour17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour17.ForeColor = System.Drawing.Color.DimGray
        Me.hour17.Location = New System.Drawing.Point(400, 96)
        Me.hour17.Name = "hour17"
        Me.hour17.ReadOnly = True
        Me.hour17.Size = New System.Drawing.Size(88, 13)
        Me.hour17.TabIndex = 46
        Me.hour17.Text = ""
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(328, 112)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 16)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "17:00 - 18:00"
        '
        'hour16
        '
        Me.hour16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour16.ForeColor = System.Drawing.Color.DimGray
        Me.hour16.Location = New System.Drawing.Point(240, 208)
        Me.hour16.Name = "hour16"
        Me.hour16.ReadOnly = True
        Me.hour16.Size = New System.Drawing.Size(88, 13)
        Me.hour16.TabIndex = 44
        Me.hour16.Text = ""
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(328, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 16)
        Me.Label32.TabIndex = 43
        Me.Label32.Text = "16:00 - 17:00"
        '
        'hour15
        '
        Me.hour15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour15.ForeColor = System.Drawing.Color.DimGray
        Me.hour15.Location = New System.Drawing.Point(240, 192)
        Me.hour15.Name = "hour15"
        Me.hour15.ReadOnly = True
        Me.hour15.Size = New System.Drawing.Size(88, 13)
        Me.hour15.TabIndex = 42
        Me.hour15.Text = ""
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(168, 208)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "15:00 - 16:00"
        '
        'hour14
        '
        Me.hour14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour14.ForeColor = System.Drawing.Color.DimGray
        Me.hour14.Location = New System.Drawing.Point(240, 176)
        Me.hour14.Name = "hour14"
        Me.hour14.ReadOnly = True
        Me.hour14.Size = New System.Drawing.Size(88, 13)
        Me.hour14.TabIndex = 40
        Me.hour14.Text = ""
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(168, 192)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 16)
        Me.Label34.TabIndex = 39
        Me.Label34.Text = "14:00 - 15:00"
        '
        'hour13
        '
        Me.hour13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour13.ForeColor = System.Drawing.Color.DimGray
        Me.hour13.Location = New System.Drawing.Point(240, 160)
        Me.hour13.Name = "hour13"
        Me.hour13.ReadOnly = True
        Me.hour13.Size = New System.Drawing.Size(88, 13)
        Me.hour13.TabIndex = 38
        Me.hour13.Text = ""
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(168, 176)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 16)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "13:00 - 14:00"
        '
        'hour12
        '
        Me.hour12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour12.ForeColor = System.Drawing.Color.DimGray
        Me.hour12.Location = New System.Drawing.Point(240, 144)
        Me.hour12.Name = "hour12"
        Me.hour12.ReadOnly = True
        Me.hour12.Size = New System.Drawing.Size(88, 13)
        Me.hour12.TabIndex = 36
        Me.hour12.Text = ""
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(168, 144)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 16)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "11:00 - 12:00"
        '
        'hour11
        '
        Me.hour11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour11.ForeColor = System.Drawing.Color.DimGray
        Me.hour11.Location = New System.Drawing.Point(240, 128)
        Me.hour11.Name = "hour11"
        Me.hour11.ReadOnly = True
        Me.hour11.Size = New System.Drawing.Size(88, 13)
        Me.hour11.TabIndex = 34
        Me.hour11.Text = ""
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(168, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 16)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "10:00 - 11:00"
        '
        'hour10
        '
        Me.hour10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour10.ForeColor = System.Drawing.Color.DimGray
        Me.hour10.Location = New System.Drawing.Point(240, 112)
        Me.hour10.Name = "hour10"
        Me.hour10.ReadOnly = True
        Me.hour10.Size = New System.Drawing.Size(88, 13)
        Me.hour10.TabIndex = 32
        Me.hour10.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(168, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "09:00 - 10:00"
        '
        'hour9
        '
        Me.hour9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour9.ForeColor = System.Drawing.Color.DimGray
        Me.hour9.Location = New System.Drawing.Point(240, 96)
        Me.hour9.Name = "hour9"
        Me.hour9.ReadOnly = True
        Me.hour9.Size = New System.Drawing.Size(88, 13)
        Me.hour9.TabIndex = 30
        Me.hour9.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(168, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "08:00 - 09:00"
        '
        'hour8
        '
        Me.hour8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour8.ForeColor = System.Drawing.Color.DimGray
        Me.hour8.Location = New System.Drawing.Point(80, 208)
        Me.hour8.Name = "hour8"
        Me.hour8.ReadOnly = True
        Me.hour8.Size = New System.Drawing.Size(88, 13)
        Me.hour8.TabIndex = 28
        Me.hour8.Text = ""
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 208)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "07:00 - 08:00"
        '
        'hour7
        '
        Me.hour7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour7.ForeColor = System.Drawing.Color.DimGray
        Me.hour7.Location = New System.Drawing.Point(80, 192)
        Me.hour7.Name = "hour7"
        Me.hour7.ReadOnly = True
        Me.hour7.Size = New System.Drawing.Size(88, 13)
        Me.hour7.TabIndex = 26
        Me.hour7.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "06:00 - 07:00"
        '
        'hour6
        '
        Me.hour6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour6.ForeColor = System.Drawing.Color.DimGray
        Me.hour6.Location = New System.Drawing.Point(80, 176)
        Me.hour6.Name = "hour6"
        Me.hour6.ReadOnly = True
        Me.hour6.Size = New System.Drawing.Size(88, 13)
        Me.hour6.TabIndex = 24
        Me.hour6.Text = ""
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "05:00 - 06:00"
        '
        'hour5
        '
        Me.hour5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour5.ForeColor = System.Drawing.Color.DimGray
        Me.hour5.Location = New System.Drawing.Point(80, 160)
        Me.hour5.Name = "hour5"
        Me.hour5.ReadOnly = True
        Me.hour5.Size = New System.Drawing.Size(88, 13)
        Me.hour5.TabIndex = 22
        Me.hour5.Text = ""
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "04:00 - 05:00"
        '
        'hour4
        '
        Me.hour4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour4.ForeColor = System.Drawing.Color.DimGray
        Me.hour4.Location = New System.Drawing.Point(80, 144)
        Me.hour4.Name = "hour4"
        Me.hour4.ReadOnly = True
        Me.hour4.Size = New System.Drawing.Size(88, 13)
        Me.hour4.TabIndex = 20
        Me.hour4.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "03:00 - 04:00"
        '
        'hour3
        '
        Me.hour3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour3.ForeColor = System.Drawing.Color.DimGray
        Me.hour3.Location = New System.Drawing.Point(80, 128)
        Me.hour3.Name = "hour3"
        Me.hour3.ReadOnly = True
        Me.hour3.Size = New System.Drawing.Size(88, 13)
        Me.hour3.TabIndex = 18
        Me.hour3.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "02:00 - 03:00"
        '
        'hour2
        '
        Me.hour2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour2.ForeColor = System.Drawing.Color.DimGray
        Me.hour2.Location = New System.Drawing.Point(80, 112)
        Me.hour2.Name = "hour2"
        Me.hour2.ReadOnly = True
        Me.hour2.Size = New System.Drawing.Size(88, 13)
        Me.hour2.TabIndex = 16
        Me.hour2.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "01:00 - 02:00"
        '
        'hour1
        '
        Me.hour1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.hour1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour1.ForeColor = System.Drawing.Color.DimGray
        Me.hour1.Location = New System.Drawing.Point(80, 96)
        Me.hour1.Name = "hour1"
        Me.hour1.ReadOnly = True
        Me.hour1.Size = New System.Drawing.Size(88, 13)
        Me.hour1.TabIndex = 14
        Me.hour1.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "00:00 - 01:00"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Hourly Breakdown:      (Adjusted for GMT+2)"
        '
        'peakdate2
        '
        Me.peakdate2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.peakdate2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.peakdate2.ForeColor = System.Drawing.Color.DimGray
        Me.peakdate2.Location = New System.Drawing.Point(104, 64)
        Me.peakdate2.Name = "peakdate2"
        Me.peakdate2.ReadOnly = True
        Me.peakdate2.Size = New System.Drawing.Size(134, 13)
        Me.peakdate2.TabIndex = 11
        Me.peakdate2.Text = ""
        '
        'peakdate1
        '
        Me.peakdate1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.peakdate1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.peakdate1.ForeColor = System.Drawing.Color.DimGray
        Me.peakdate1.Location = New System.Drawing.Point(104, 48)
        Me.peakdate1.Name = "peakdate1"
        Me.peakdate1.ReadOnly = True
        Me.peakdate1.Size = New System.Drawing.Size(134, 13)
        Me.peakdate1.TabIndex = 10
        Me.peakdate1.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Peak Activity:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Server Activity"
        '
        'total_hits
        '
        Me.total_hits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.total_hits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_hits.ForeColor = System.Drawing.Color.DimGray
        Me.total_hits.Location = New System.Drawing.Point(104, 32)
        Me.total_hits.Name = "total_hits"
        Me.total_hits.ReadOnly = True
        Me.total_hits.Size = New System.Drawing.Size(134, 13)
        Me.total_hits.TabIndex = 3
        Me.total_hits.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Total Hits:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.log_s_port)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.log_s_computername)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.log_s_sitename)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.log_s_ip)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(496, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 104)
        Me.Panel2.TabIndex = 3
        '
        'log_s_port
        '
        Me.log_s_port.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_s_port.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_s_port.ForeColor = System.Drawing.Color.DimGray
        Me.log_s_port.Location = New System.Drawing.Point(104, 80)
        Me.log_s_port.Name = "log_s_port"
        Me.log_s_port.ReadOnly = True
        Me.log_s_port.Size = New System.Drawing.Size(134, 13)
        Me.log_s_port.TabIndex = 10
        Me.log_s_port.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Server Port:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Server Details"
        '
        'log_s_computername
        '
        Me.log_s_computername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_s_computername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_s_computername.ForeColor = System.Drawing.Color.DimGray
        Me.log_s_computername.Location = New System.Drawing.Point(104, 64)
        Me.log_s_computername.Name = "log_s_computername"
        Me.log_s_computername.ReadOnly = True
        Me.log_s_computername.Size = New System.Drawing.Size(134, 13)
        Me.log_s_computername.TabIndex = 7
        Me.log_s_computername.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Server Name:"
        '
        'log_s_sitename
        '
        Me.log_s_sitename.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_s_sitename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_s_sitename.ForeColor = System.Drawing.Color.DimGray
        Me.log_s_sitename.Location = New System.Drawing.Point(104, 48)
        Me.log_s_sitename.Name = "log_s_sitename"
        Me.log_s_sitename.ReadOnly = True
        Me.log_s_sitename.Size = New System.Drawing.Size(134, 13)
        Me.log_s_sitename.TabIndex = 5
        Me.log_s_sitename.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Service Name:"
        '
        'log_s_ip
        '
        Me.log_s_ip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.log_s_ip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log_s_ip.ForeColor = System.Drawing.Color.DimGray
        Me.log_s_ip.Location = New System.Drawing.Point(104, 32)
        Me.log_s_ip.Name = "log_s_ip"
        Me.log_s_ip.ReadOnly = True
        Me.log_s_ip.Size = New System.Drawing.Size(134, 13)
        Me.log_s_ip.TabIndex = 3
        Me.log_s_ip.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP Address:"
        '
        'pageviews
        '
        Me.pageviews.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageviews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pageviews.ForeColor = System.Drawing.Color.DimGray
        Me.pageviews.Location = New System.Drawing.Point(336, 32)
        Me.pageviews.Name = "pageviews"
        Me.pageviews.ReadOnly = True
        Me.pageviews.Size = New System.Drawing.Size(134, 13)
        Me.pageviews.TabIndex = 71
        Me.pageviews.Text = ""
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(240, 32)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 16)
        Me.Label40.TabIndex = 70
        Me.Label40.Text = "Total Page Views:"
        '
        'Main_Screen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 614)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FullError)
        Me.Controls.Add(Me.ButtonFolderBrowse)
        Me.Controls.Add(Me.txtBaseFolder)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(784, 648)
        Me.MinimumSize = New System.Drawing.Size(784, 648)
        Me.Name = "Main_Screen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "IIS W3SVC1 Log Monitor Analyser"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Error_Handler(ByVal ex As Exception)
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message("The Monitoring Program encountered the following problem: " & vbCrLf & ex.ToString)
                Display_Message1.ShowDialog()
                Dim dir As DirectoryInfo = New DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                Dim filewriter As StreamWriter = New StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & ex.ToString)
                filewriter.Flush()
                filewriter.Close()
            End If
        Catch exc As Exception
            MsgBox("An error occurred in Single Level File Lister's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub






    Private Sub Main_Screen_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Save_Registry_Values()
            'Dim irunner As IEnumerator = Panel1.Controls.GetEnumerator()
            'Dim datobj As New System.Windows.Forms.DataObject
            'datobj.SetData(System.Windows.Forms.DataFormats.Text, "")
            'System.Windows.Forms.Clipboard.SetDataObject(datobj)

            'While Not irunner.MoveNext = False



            '    datobj.SetData(System.Windows.Forms.DataFormats.Text, System.Windows.Forms.Clipboard.GetDataObject.GetData(System.Windows.Forms.DataFormats.Text) & irunner.Current.ToString() & vbCrLf)
            '    System.Windows.Forms.Clipboard.SetDataObject(datobj)
            '    Select Case irunner.Current.ToString().Split(",")(0)
            '        Case "System.Windows.Forms.DataGrid"
            '            Dim temp As DataGrid
            '            temp = irunner.Current
            '            temp.Dispose()
            '        Case "System.Windows.Forms.Label"
            '            Dim temp As System.Windows.Forms.Label
            '            temp = irunner.Current
            '            temp.Dispose()
            '    End Select
            'End While
            'Dim Display_Message1 As New Display_Message(System.Windows.Forms.Clipboard.GetDataObject.GetData(System.Windows.Forms.DataFormats.Text))
            'Display_Message1.ShowDialog()

        Catch ex As Exception
            Error_Handler(ex)
        End Try

    End Sub



    Private Sub load_project_data(ByVal myrow As Integer, ByVal mycolumn As Integer, ByVal sender As Windows.Forms.DataGrid)
        Try

            sender.CurrentCell = New DataGridCell(myrow, mycolumn)
            sender.Select(myrow)
      


        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub

    Private Sub dataGrid1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp, DataGrid2.MouseUp, DataGrid3.MouseUp, DataGrid4.MouseUp, DataGrid5.MouseUp, DataGrid6.MouseUp, DataGrid7.MouseUp, DataGrid8.MouseUp, DataGrid9.MouseUp, DataGrid10.MouseUp, DataGrid11.MouseUp, DataGrid12.MouseUp, DataGrid13.MouseUp, DataGrid14.MouseUp, DataGrid15.MouseUp, DataGrid16.MouseUp, DataGrid17.MouseUp, DataGrid18.MouseUp, DataGrid19.MouseUp, DataGrid20.MouseUp, DataGrid21.MouseUp, DataGrid22.MouseUp, DataGrid23.MouseUp
        Try

            Dim pt = New Point(e.X, e.Y)
            Dim hti As DataGrid.HitTestInfo = sender.HitTest(pt)
            If hti.Type = DataGrid.HitTestType.Cell Then

                load_project_data(hti.Row, hti.Column, sender)
            End If
        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub









    Public Sub Load_Registry_Values()
        Try
            Dim configflag As Boolean
            configflag = False
            Dim str As String
            Dim keyflag1 As Boolean = False
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim keys() As String = oReg.GetSubKeyNames()
            System.Array.Sort(keys)

            For Each str In keys
                If str.Equals("Software\IIS W3SVC1 Log Monitor Analyser") = True Then
                    keyflag1 = True
                    Exit For
                End If
            Next str

            If keyflag1 = False Then
                oReg.CreateSubKey("Software\IIS W3SVC1 Log Monitor Analyser")
            End If

            keyflag1 = False

            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\IIS W3SVC1 Log Monitor Analyser", True)

            str = oKey.GetValue("projectdirectory")
            If Not IsNothing(str) And Not (str = "") Then
                projectdirectory = str
            Else
                configflag = True
                oKey.SetValue("projectdirectory", "")
                projectdirectory = ""
            End If


            oKey.Close()
            oReg.Close()

            txtBaseFolder.Text = projectdirectory

        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub

    Private Sub Save_Registry_Values()
        Try
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\IIS W3SVC1 Log Monitor Analyser", True)

            oKey.SetValue("projectdirectory", txtBaseFolder.Text)

            oKey.Close()
            oReg.Close()
        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub



    Private Sub dataunload()
        Try
            dataloaded = False
            Me.Hide()
            splash_loader.Visible = True

            OleDbConnection1.Close()
            DataSet11.Clear()

            Dim irunner As IEnumerator = Panel1.Controls.GetEnumerator()


            Dim doit As Boolean = False
            If irunner.MoveNext() = True Then
                doit = True
            Else
                doit = False
            End If

            Dim tempdatagrid As DataGrid


            Dim count As Integer = 0
            Dim labe As Label
            While doit = True
                If irunner.Current.GetType.ToString = "System.Windows.Forms.Label" Then
                    labe = irunner.Current
                    Panel1.Controls.Remove(labe)
                Else
                    Try
                        tempdatagrid = irunner.Current
                        tempdatagrid.TableStyles.Clear()
                    Catch ex As Exception
                        Error_Handler(ex)
                    End Try
                End If
                count = count + 1
                If irunner.MoveNext() = True Then
                    doit = True
                Else
                    doit = False
                End If

            End While
            Dim littledot As Label = New Label
            littledot.Name = "littledot"
            littledot.Text = ""
            littledot.Width = 0
            littledot.Height = 0
            Panel1.Controls.Add(littledot)
            littledot.Top = Top
            littledot.Left = Left
        Catch ex As Exception
            Error_Handler(ex)
        Finally

        End Try

    End Sub



    Private Sub dataload()
        Try
            dataloaded = False
            Me.Hide()
            splash_loader.Visible = True
            Dim continue As Boolean
            continue = True
            If txtBaseFolder.Text = "" Then
                continue = False
            End If
            Dim finfo As FileInfo
            If continue = True Then
                finfo = New FileInfo(txtBaseFolder.Text)
            Else
                finfo = New FileInfo((Application.StartupPath & "\hello.txt").Replace("\\", "\"))
            End If
            If finfo.Exists = True Then


                OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
                        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""" & txtBaseFolder.Text & """;Password=;Jet OLEDB:Engine T" & _
                        "ype=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Je" & _
                        "t OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Den" & _
                        "y None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;J" & _
                        "et OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Re" & _
                        "pair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"



                Dim tablelist() As String = {"log_date", "log_time", "log_s_sitename", "log_s_computername", "log_s_ip", "log_cs_method", "log_cs_uri_stem", "log_cs_uri_query", "log_s_port", "log_cs_username", "log_c_ip", "log_cs_version", "log_cs_User_Agent", "log_cs_Cookie", "log_cs_Referer", "log_cs_host", "log_sc_status", "log_sc_substatus", "log_sc_win32_status", "log_sc_bytes", "log_cs_bytes", "log_time_taken", "log_errors"}
                Dim tablelistdisplay() As String = {"Date", "Time (GMT)", "Service Name", "Server Name", "Server IP Address", "Client HTTP Method", "Client URI Stem", "Client URI Query", "Server Port", "Client User Name", "Client IP Address", "Client Protocol Version", "Client User Agent Header", "Client Cookie Header", "Client Referer Header", "Client Host Header", "Server Protocol Status", "Server Protocol Substatus", "Server Win32 Status Code", "Bytes Sent by Server", "Bytes Received from Client", "Time Taken (ms)", "Log File Errors"}
                Dim irunner As IEnumerator = Panel1.Controls.GetEnumerator()


                Dim doit As Boolean = False
                If irunner.MoveNext() = True Then
                    doit = True
                Else
                    doit = False
                End If

                Dim left As Integer = 12
                Dim top As Integer = 12
                Dim tempdatagrid As DataGrid


                Dim count As Integer = 0
                Dim labe As Label
                While doit = True
                    If irunner.Current.GetType.ToString = "System.Windows.Forms.Label" Then
                        labe = irunner.Current
                        Panel1.Controls.Remove(labe)
                    Else
                        Try


                            tempdatagrid = irunner.Current
                            tempdatagrid.Top = top
                            tempdatagrid.Left = left
                            left = left + 272


                            tempdatagrid.Name = "data_" & tablelist(count)
                            If Not tablelist(count) = "log_errors" Then
                                If Not tablelist(count) = "log_time" Then
                                    OleDbSelectCommand1.CommandText = "SELECT log_count, log_value FROM " & tablelist(count) & " order by log_count desc"
                                Else
                                    OleDbSelectCommand1.CommandText = "SELECT log_count, log_value FROM " & tablelist(count) & " order by log_value asc"
                                End If
                            Else

                                OleDbSelectCommand1.CommandText = "SELECT log_value FROM " & tablelist(count) & " order by log_value asc"
                            End If


                            OleDbSelectCommand1.Connection = Me.OleDbConnection1
                            OleDbDataAdapter1.Fill(DataSet11, tablelist(count))
                            tempdatagrid.DataSource = DataSet11.Tables(tablelist(count))
                            If Not DataSet11.Tables(tablelist(count)).Rows.Count = 1 Then
                                tempdatagrid.CaptionText = tablelistdisplay(count) & "   (" & DataSet11.Tables(tablelist(count)).Rows.Count & " items)"
                            Else
                                tempdatagrid.CaptionText = tablelistdisplay(count) & "   (" & DataSet11.Tables(tablelist(count)).Rows.Count & " item)"
                            End If



                            Dim DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
                            Dim DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
                            Dim DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
                            DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
                            DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
                            DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
                            tempdatagrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {DataGridTableStyle1})

                            DataGridTableStyle1.DataGrid = tempdatagrid
                            DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {DataGridTextBoxColumn1, DataGridTextBoxColumn2})
                            DataGridTableStyle1.HeaderForeColor = Color.Black
                            DataGridTableStyle1.MappingName = tablelist(count)
                            DataGridTableStyle1.RowHeadersVisible = False
                            DataGridTableStyle1.SelectionBackColor = Color.LightSteelBlue
                            DataGridTableStyle1.SelectionForeColor = Color.Black
                            DataGridTableStyle1.ForeColor = Color.DimGray
                            DataGridTableStyle1.BackColor = Color.WhiteSmoke
                            DataGridTableStyle1.AllowSorting = True
                            DataGridTableStyle1.AlternatingBackColor = Color.White
                            DataGridTableStyle1.HeaderBackColor = Color.Silver
                            DataGridTableStyle1.GridLineStyle = DataGridLineStyle.None


                            DataGridTextBoxColumn1.Format = ""
                            DataGridTextBoxColumn1.FormatInfo = Nothing
                            DataGridTextBoxColumn1.MappingName = "log_value"
                            DataGridTextBoxColumn1.Width = 180
                            DataGridTextBoxColumn1.HeaderText = "Value"

                            DataGridTextBoxColumn2.Format = ""
                            DataGridTextBoxColumn2.FormatInfo = Nothing
                            DataGridTextBoxColumn2.MappingName = "log_count"
                            DataGridTextBoxColumn2.Width = 56
                            DataGridTextBoxColumn2.HeaderText = "Count"
                            Select Case tablelist(count)
                                Case "log_s_ip"
                                    log_s_ip.Text = tempdatagrid.Item(0, 0).ToString
                                Case "log_s_computername"
                                    log_s_computername.Text = tempdatagrid.Item(0, 0).ToString
                                Case "log_s_sitename"
                                    log_s_sitename.Text = tempdatagrid.Item(0, 0).ToString
                                Case "log_s_port"
                                    log_s_port.Text = tempdatagrid.Item(0, 0).ToString

                                Case "log_sc_status"
                                    log_sc_status1.Text = "1. " & tempdatagrid.Item(0, 0).ToString & " - " & tempdatagrid.Item(0, 1).ToString
                                    log_sc_status2.Text = "2. " & tempdatagrid.Item(1, 0).ToString & " - " & tempdatagrid.Item(1, 1).ToString

                                Case "log_sc_substatus"
                                    log_sc_substatus1.Text = "1. " & tempdatagrid.Item(0, 0).ToString & " - " & tempdatagrid.Item(0, 1).ToString
                                    log_sc_substatus2.Text = "2. " & tempdatagrid.Item(1, 0).ToString & " - " & tempdatagrid.Item(1, 1).ToString
                                Case "log_sc_win32_status"
                                    log_sc_win32_status1.Text = "1. " & tempdatagrid.Item(0, 0).ToString & " - " & tempdatagrid.Item(0, 1).ToString
                                    log_sc_win32_status2.Text = "2. " & tempdatagrid.Item(1, 0).ToString & " - " & tempdatagrid.Item(1, 1).ToString



                                Case "log_date"
                                    Dim totalhits As Long = 0
                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_date").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        totalhits = totalhits + CLng(rw("log_count"))
                                    End While
                                    total_hits.Text = totalhits & " hits (in " & DataSet11.Tables("log_date").Rows.Count & " days)"
                                    peakdate1.Text = "1. " & tempdatagrid.Item(0, 0).ToString & " - " & tempdatagrid.Item(0, 1).ToString & " hits"
                                    peakdate2.Text = "2. " & tempdatagrid.Item(1, 0).ToString & " - " & tempdatagrid.Item(1, 1).ToString & " hits"

                                Case "log_time"

                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_time").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    Dim controllist() As TextBox = {hour1, hour2, hour3, hour4, hour5, hour6, hour7, hour8, hour9, hour10, hour11, hour12, hour13, hour14, hour15, hour16, hour17, hour18, hour19, hour20, hour21, hour22, hour23, hour24}
                                    Dim i As Integer
                                    Dim tbox As TextBox
                                    For i = 0 To controllist.Length - 1
                                        tbox = controllist.GetValue(i)
                                        tbox.Text = 0
                                    Next

                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        'makes provision for logs being in gmt. shifts values to gmt 2+
                                        Select Case (CStr(rw("log_value"))).Substring(0, 2)
                                            Case "00"
                                                hour3.Text = CLng(hour3.Text) + CLng(rw("log_count"))
                                            Case "01"
                                                hour4.Text = CLng(hour4.Text) + CLng(rw("log_count"))
                                            Case "02"
                                                hour5.Text = CLng(hour5.Text) + CLng(rw("log_count"))
                                            Case "03"
                                                hour6.Text = CLng(hour6.Text) + CLng(rw("log_count"))
                                            Case "04"
                                                hour7.Text = CLng(hour7.Text) + CLng(rw("log_count"))
                                            Case "05"
                                                hour8.Text = CLng(hour8.Text) + CLng(rw("log_count"))
                                            Case "06"
                                                hour9.Text = CLng(hour9.Text) + CLng(rw("log_count"))
                                            Case "07"
                                                hour10.Text = CLng(hour10.Text) + CLng(rw("log_count"))
                                            Case "08"
                                                hour11.Text = CLng(hour11.Text) + CLng(rw("log_count"))
                                            Case "09"
                                                hour12.Text = CLng(hour12.Text) + CLng(rw("log_count"))
                                            Case "10"
                                                hour13.Text = CLng(hour13.Text) + CLng(rw("log_count"))
                                            Case "11"
                                                hour14.Text = CLng(hour14.Text) + CLng(rw("log_count"))
                                            Case "12"
                                                hour15.Text = CLng(hour15.Text) + CLng(rw("log_count"))
                                            Case "13"
                                                hour16.Text = CLng(hour16.Text) + CLng(rw("log_count"))
                                            Case "14"
                                                hour17.Text = CLng(hour17.Text) + CLng(rw("log_count"))
                                            Case "15"
                                                hour18.Text = CLng(hour18.Text) + CLng(rw("log_count"))
                                            Case "16"
                                                hour19.Text = CLng(hour19.Text) + CLng(rw("log_count"))
                                            Case "17"
                                                hour20.Text = CLng(hour20.Text) + CLng(rw("log_count"))
                                            Case "18"
                                                hour21.Text = CLng(hour21.Text) + CLng(rw("log_count"))
                                            Case "19"
                                                hour22.Text = CLng(hour22.Text) + CLng(rw("log_count"))
                                            Case "20"
                                                hour23.Text = CLng(hour23.Text) + CLng(rw("log_count"))
                                            Case "21"
                                                hour24.Text = CLng(hour24.Text) + CLng(rw("log_count"))
                                            Case "22"
                                                hour1.Text = CLng(hour1.Text) + CLng(rw("log_count"))
                                            Case "23"
                                                hour2.Text = CLng(hour2.Text) + CLng(rw("log_count"))
                                        End Select

                                    End While
                                    hour1.Text = hour1.Text & " hits"
                                    hour2.Text = hour2.Text & " hits"
                                    hour3.Text = hour3.Text & " hits"
                                    hour4.Text = hour4.Text & " hits"
                                    hour5.Text = hour5.Text & " hits"
                                    hour6.Text = hour6.Text & " hits"
                                    hour7.Text = hour7.Text & " hits"
                                    hour8.Text = hour8.Text & " hits"
                                    hour9.Text = hour9.Text & " hits"
                                    hour10.Text = hour10.Text & " hits"
                                    hour11.Text = hour11.Text & " hits"
                                    hour12.Text = hour12.Text & " hits"
                                    hour13.Text = hour13.Text & " hits"
                                    hour14.Text = hour14.Text & " hits"
                                    hour15.Text = hour15.Text & " hits"
                                    hour16.Text = hour16.Text & " hits"
                                    hour17.Text = hour17.Text & " hits"
                                    hour18.Text = hour18.Text & " hits"
                                    hour19.Text = hour19.Text & " hits"
                                    hour20.Text = hour20.Text & " hits"
                                    hour21.Text = hour21.Text & " hits"
                                    hour22.Text = hour22.Text & " hits"
                                    hour23.Text = hour23.Text & " hits"
                                    hour24.Text = hour24.Text & " hits"
                                Case "log_time_taken"

                                    Dim totalhits As Long = 0
                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_time_taken").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        totalhits = totalhits + (CLng(rw("log_count")) * CLng(rw("log_value")))
                                    End While
                                    log_time_taken.Text = totalhits & " ms"
                                    log_time_taken2.Text = "(" & Math.Round((totalhits / 1000 / 60), 2) & " minutes)"
                                Case "log_sc_bytes"
                                    Dim totalhits As Long = 0
                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_sc_bytes").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        totalhits = totalhits + (CLng(rw("log_count")) * CLng(rw("log_value")))
                                    End While
                                    log_sc_bytes.Text = totalhits & " bytes"
                                    log_sc_bytes2.Text = "(" & Math.Round((totalhits / 1024 / 1024), 2) & " MB)"
                                Case "log_cs_bytes"
                                    Dim totalhits As Long = 0
                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_cs_bytes").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        totalhits = totalhits + (CLng(rw("log_count")) * CLng(rw("log_value")))
                                    End While
                                    log_cs_bytes.Text = totalhits & " bytes"
                                    log_cs_bytes2.Text = "(" & Math.Round((totalhits / 1024 / 1024), 2) & " MB)"
                                Case "log_cs_uri_stem"

                                    Dim rowrun As IEnumerator = DataSet11.Tables("log_cs_uri_stem").Rows.GetEnumerator()
                                    Dim rw As Data.DataRow
                                    Dim totalhits As Long = 0
                                    pageviews.Text = totalhits
                                    While Not rowrun.MoveNext = False
                                        rw = rowrun.Current
                                        Dim temp As String = CStr(rw("log_value")).ToLower
                                        Dim done As Boolean = False
                                        If temp.EndsWith("/") And done = False Then
                                            totalhits = totalhits + CLng(rw("log_count"))
                                            done = True
                                        End If
                                        If (temp.EndsWith(".htm") Or temp.EndsWith(".html") Or temp.EndsWith(".asp") Or temp.EndsWith(".php") Or temp.EndsWith(".aspx") Or temp.EndsWith(".cgi") Or temp.EndsWith(".inc")) And done = False Then
                                            totalhits = totalhits + CLng(rw("log_count"))
                                            done = True
                                        End If
                                        If temp.Substring(temp.LastIndexOf("/")).IndexOf(".") = -1 And done = False Then
                                            totalhits = totalhits + CLng(rw("log_count"))
                                            done = True
                                        End If
                                    End While
                                    pageviews.Text = totalhits & " page views"
                            End Select
                        Catch ex As Exception
                            Error_Handler(ex)
                        End Try
                    End If

                    count = count + 1
                    If irunner.MoveNext() = True Then
                        doit = True
                    Else
                        doit = False
                    End If
                End While
                Dim littledot As Label = New Label
                littledot.Name = "littledot"
                littledot.Text = ""
                littledot.Width = 0
                littledot.Height = 0
                Panel1.Controls.Add(littledot)
                littledot.Top = top
                littledot.Left = left
            Else
                Dim displ As Display_Message = New Display_Message("Unable to locate """ & finfo.FullName & """ on this system")
                If Not txtBaseFolder.Text = "" Then
                    displ.ShowDialog()
                End If

                Dim irunner As IEnumerator = Panel1.Controls.GetEnumerator()
                Dim tempdatagrid As DataGrid
                Dim left As Integer = 12
                Dim top As Integer = 12
                While Not irunner.MoveNext = False
                    tempdatagrid = irunner.Current
                    tempdatagrid.Top = top
                    tempdatagrid.Left = left
                    left = left + 272
                End While
                Dim littledot As Label = New Label
                littledot.Name = "littledot"
                littledot.Text = ""
                littledot.Width = 0
                littledot.Height = 0
                Panel1.Controls.Add(littledot)
                littledot.Top = top
                littledot.Left = left
            End If
        Catch ex As Exception
            Error_Handler(ex)
        Finally
            dataloaded = True
            splash_loader.Visible = False
            Me.Show()
        End Try


    End Sub

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Load_Registry_Values()
            dataload()

        Catch ex As Exception
            Error_Handler(ex)
        End Try


    End Sub


    Private Sub ButtonFolderBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFolderBrowse.Click
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog
            If result = DialogResult.OK Then
                txtBaseFolder.Text = OpenFileDialog1.FileName
                dataunload()
                dataload()
            End If
        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub


End Class
