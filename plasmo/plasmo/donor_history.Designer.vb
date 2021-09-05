<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class donor_history
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(donor_history))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.recieverBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.queueBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.donorBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.historyBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dashboardBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.logoutBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Newdataset = New plasmo.newdataset()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New plasmo.newdatasetTableAdapters.TableTableAdapter()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.plasma_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donor_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blood_group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anti_body = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donation_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.totalDonors = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.totalRecievers = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Newdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.recieverBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.queueBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.donorBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.historyBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.dashboardBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.logoutBtnMenu)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 74)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1082, 58)
        Me.Guna2Panel1.TabIndex = 58
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(567, 41)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(60, 3)
        Me.Guna2Panel2.TabIndex = 80
        '
        'recieverBtnMenu
        '
        Me.recieverBtnMenu.BorderRadius = 6
        Me.recieverBtnMenu.CheckedState.Parent = Me.recieverBtnMenu
        Me.recieverBtnMenu.CustomImages.Parent = Me.recieverBtnMenu
        Me.recieverBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.recieverBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.recieverBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.recieverBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.recieverBtnMenu.DisabledState.Parent = Me.recieverBtnMenu
        Me.recieverBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.recieverBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recieverBtnMenu.ForeColor = System.Drawing.Color.White
        Me.recieverBtnMenu.HoverState.Parent = Me.recieverBtnMenu
        Me.recieverBtnMenu.Location = New System.Drawing.Point(283, 14)
        Me.recieverBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.recieverBtnMenu.Name = "recieverBtnMenu"
        Me.recieverBtnMenu.ShadowDecoration.Parent = Me.recieverBtnMenu
        Me.recieverBtnMenu.Size = New System.Drawing.Size(147, 31)
        Me.recieverBtnMenu.TabIndex = 83
        Me.recieverBtnMenu.Text = "RECEIVER"
        '
        'queueBtnMenu
        '
        Me.queueBtnMenu.BorderRadius = 6
        Me.queueBtnMenu.CheckedState.Parent = Me.queueBtnMenu
        Me.queueBtnMenu.CustomImages.Parent = Me.queueBtnMenu
        Me.queueBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.queueBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.queueBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.queueBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.queueBtnMenu.DisabledState.Parent = Me.queueBtnMenu
        Me.queueBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.queueBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queueBtnMenu.ForeColor = System.Drawing.Color.White
        Me.queueBtnMenu.HoverState.Parent = Me.queueBtnMenu
        Me.queueBtnMenu.Location = New System.Drawing.Point(423, 14)
        Me.queueBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.queueBtnMenu.Name = "queueBtnMenu"
        Me.queueBtnMenu.ShadowDecoration.Parent = Me.queueBtnMenu
        Me.queueBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.queueBtnMenu.TabIndex = 82
        Me.queueBtnMenu.Text = "QUEUE"
        '
        'donorBtnMenu
        '
        Me.donorBtnMenu.BorderRadius = 6
        Me.donorBtnMenu.CheckedState.Parent = Me.donorBtnMenu
        Me.donorBtnMenu.CustomImages.Parent = Me.donorBtnMenu
        Me.donorBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.donorBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.donorBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.donorBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.donorBtnMenu.DisabledState.Parent = Me.donorBtnMenu
        Me.donorBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.donorBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donorBtnMenu.ForeColor = System.Drawing.Color.White
        Me.donorBtnMenu.HoverState.Parent = Me.donorBtnMenu
        Me.donorBtnMenu.Location = New System.Drawing.Point(173, 14)
        Me.donorBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.donorBtnMenu.Name = "donorBtnMenu"
        Me.donorBtnMenu.ShadowDecoration.Parent = Me.donorBtnMenu
        Me.donorBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.donorBtnMenu.TabIndex = 84
        Me.donorBtnMenu.Text = "DONOR"
        '
        'historyBtnMenu
        '
        Me.historyBtnMenu.BorderRadius = 6
        Me.historyBtnMenu.CheckedState.Parent = Me.historyBtnMenu
        Me.historyBtnMenu.CustomImages.Parent = Me.historyBtnMenu
        Me.historyBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.historyBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.historyBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.historyBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.historyBtnMenu.DisabledState.Parent = Me.historyBtnMenu
        Me.historyBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.historyBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyBtnMenu.ForeColor = System.Drawing.Color.White
        Me.historyBtnMenu.HoverState.Parent = Me.historyBtnMenu
        Me.historyBtnMenu.Location = New System.Drawing.Point(542, 14)
        Me.historyBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.historyBtnMenu.Name = "historyBtnMenu"
        Me.historyBtnMenu.ShadowDecoration.Parent = Me.historyBtnMenu
        Me.historyBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.historyBtnMenu.TabIndex = 81
        Me.historyBtnMenu.Text = "HISTORY"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.plasmo.My.Resources.Resources.log_out__1_
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1016, 20)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(21, 22)
        Me.Guna2PictureBox2.TabIndex = 80
        Me.Guna2PictureBox2.TabStop = False
        '
        'dashboardBtnMenu
        '
        Me.dashboardBtnMenu.BorderRadius = 6
        Me.dashboardBtnMenu.CheckedState.Parent = Me.dashboardBtnMenu
        Me.dashboardBtnMenu.CustomImages.Parent = Me.dashboardBtnMenu
        Me.dashboardBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dashboardBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dashboardBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dashboardBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dashboardBtnMenu.DisabledState.Parent = Me.dashboardBtnMenu
        Me.dashboardBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.dashboardBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtnMenu.ForeColor = System.Drawing.Color.White
        Me.dashboardBtnMenu.HoverState.Parent = Me.dashboardBtnMenu
        Me.dashboardBtnMenu.Location = New System.Drawing.Point(24, 14)
        Me.dashboardBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.dashboardBtnMenu.Name = "dashboardBtnMenu"
        Me.dashboardBtnMenu.ShadowDecoration.Parent = Me.dashboardBtnMenu
        Me.dashboardBtnMenu.Size = New System.Drawing.Size(163, 31)
        Me.dashboardBtnMenu.TabIndex = 11
        Me.dashboardBtnMenu.Text = "DASHBOARD"
        '
        'logoutBtnMenu
        '
        Me.logoutBtnMenu.BorderRadius = 6
        Me.logoutBtnMenu.CheckedState.Parent = Me.logoutBtnMenu
        Me.logoutBtnMenu.CustomImages.Parent = Me.logoutBtnMenu
        Me.logoutBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logoutBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logoutBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logoutBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logoutBtnMenu.DisabledState.Parent = Me.logoutBtnMenu
        Me.logoutBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.logoutBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtnMenu.ForeColor = System.Drawing.Color.White
        Me.logoutBtnMenu.HoverState.Parent = Me.logoutBtnMenu
        Me.logoutBtnMenu.Location = New System.Drawing.Point(879, 11)
        Me.logoutBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.logoutBtnMenu.Name = "logoutBtnMenu"
        Me.logoutBtnMenu.ShadowDecoration.Parent = Me.logoutBtnMenu
        Me.logoutBtnMenu.Size = New System.Drawing.Size(188, 42)
        Me.logoutBtnMenu.TabIndex = 10
        Me.logoutBtnMenu.Text = "LOGOUT"
        '
        'Newdataset
        '
        Me.Newdataset.DataSetName = "newdataset"
        Me.Newdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Newdataset
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        Me.Guna2DataGridView1.AllowUserToResizeColumns = False
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 21
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.plasma_id, Me.donor_name, Me.age, Me.blood_group, Me.anti_body, Me.donation_time})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(72, 209)
        Me.Guna2DataGridView1.MultiSelect = False
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(939, 415)
        Me.Guna2DataGridView1.TabIndex = 71
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'plasma_id
        '
        Me.plasma_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.plasma_id.Frozen = True
        Me.plasma_id.HeaderText = "PLASMA ID"
        Me.plasma_id.Name = "plasma_id"
        Me.plasma_id.ReadOnly = True
        Me.plasma_id.Width = 157
        '
        'donor_name
        '
        Me.donor_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.donor_name.Frozen = True
        Me.donor_name.HeaderText = "DONOR NAME"
        Me.donor_name.Name = "donor_name"
        Me.donor_name.ReadOnly = True
        Me.donor_name.Width = 156
        '
        'age
        '
        Me.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.age.Frozen = True
        Me.age.HeaderText = "AGE"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Width = 157
        '
        'blood_group
        '
        Me.blood_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.blood_group.Frozen = True
        Me.blood_group.HeaderText = "BLOOD GROUP"
        Me.blood_group.Name = "blood_group"
        Me.blood_group.Width = 156
        '
        'anti_body
        '
        Me.anti_body.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.anti_body.Frozen = True
        Me.anti_body.HeaderText = "ANTIBODIES"
        Me.anti_body.Name = "anti_body"
        Me.anti_body.Width = 157
        '
        'donation_time
        '
        Me.donation_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.donation_time.Frozen = True
        Me.donation_time.HeaderText = "DONATED ON"
        Me.donation_time.Name = "donation_time"
        Me.donation_time.ReadOnly = True
        Me.donation_time.Width = 156
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(567, 162)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel2.TabIndex = 88
        Me.Guna2HtmlLabel2.Text = "RECEIVERS"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(450, 162)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(69, 27)
        Me.Guna2HtmlLabel1.TabIndex = 87
        Me.Guna2HtmlLabel1.Text = "DONORS"
        '
        'totalDonors
        '
        Me.totalDonors.AutoSize = False
        Me.totalDonors.AutoSizeHeightOnly = True
        Me.totalDonors.BackColor = System.Drawing.Color.Transparent
        Me.totalDonors.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDonors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.totalDonors.Location = New System.Drawing.Point(450, 180)
        Me.totalDonors.Name = "totalDonors"
        Me.totalDonors.Size = New System.Drawing.Size(73, 23)
        Me.totalDonors.TabIndex = 90
        Me.totalDonors.Text = "(123)"
        Me.totalDonors.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'totalRecievers
        '
        Me.totalRecievers.AutoSize = False
        Me.totalRecievers.AutoSizeHeightOnly = True
        Me.totalRecievers.BackColor = System.Drawing.Color.Transparent
        Me.totalRecievers.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRecievers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.totalRecievers.Location = New System.Drawing.Point(564, 180)
        Me.totalRecievers.Name = "totalRecievers"
        Me.totalRecievers.Size = New System.Drawing.Size(73, 23)
        Me.totalRecievers.TabIndex = 91
        Me.totalRecievers.Text = "(123)"
        Me.totalRecievers.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox3.Image = Global.plasmo.My.Resources.Resources.Donor_Switch01
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(525, 162)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(36, 22)
        Me.Guna2PictureBox3.TabIndex = 89
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.Animated = True
        Me.Guna2CircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.CheckedState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.CustomImages.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton2.DisabledState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.Image = Global.plasmo.My.Resources.Resources.Line_10
        Me.Guna2CircleButton2.HoverState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Image = Global.plasmo.My.Resources.Resources.Line_9
        Me.Guna2CircleButton2.ImageSize = New System.Drawing.Size(18, 3)
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(990, 10)
        Me.Guna2CircleButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.ShadowDecoration.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(30, 32)
        Me.Guna2CircleButton2.TabIndex = 66
        '
        'CloseButton
        '
        Me.CloseButton.Animated = True
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CloseButton.DisabledState.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.Image = Global.plasmo.My.Resources.Resources.Component_3__1_
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Image = Global.plasmo.My.Resources.Resources.Component_21
        Me.CloseButton.ImageSize = New System.Drawing.Size(28, 28)
        Me.CloseButton.Location = New System.Drawing.Point(1036, 10)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(30, 32)
        Me.CloseButton.TabIndex = 65
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.plasmo.My.Resources.Resources.Plasmo_Logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 11)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(201, 58)
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        '
        'donor_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1082, 624)
        Me.Controls.Add(Me.totalRecievers)
        Me.Controls.Add(Me.totalDonors)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "donor_history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Newdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents donorBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents recieverBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents queueBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents historyBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dashboardBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logoutBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Newdataset As newdataset
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As newdatasetTableAdapters.TableTableAdapter
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents plasma_id As DataGridViewTextBoxColumn
    Friend WithEvents donor_name As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents blood_group As DataGridViewTextBoxColumn
    Friend WithEvents anti_body As DataGridViewTextBoxColumn
    Friend WithEvents donation_time As DataGridViewTextBoxColumn
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents totalRecievers As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents totalDonors As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
