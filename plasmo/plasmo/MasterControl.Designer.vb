<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterControl
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
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.QueueBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.HistoryBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoutBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.RecieverBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DonorBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2BorderlessForm2 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 131)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1082, 514)
        Me.Guna2Panel1.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.Guna2Transition1.SetDecoration(Me.CloseButton, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.CloseButton.Location = New System.Drawing.Point(1041, 10)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(30, 32)
        Me.CloseButton.TabIndex = 101
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.CheckedState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.CustomImages.Parent = Me.Guna2CircleButton2
        Me.Guna2Transition1.SetDecoration(Me.Guna2CircleButton2, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(994, 10)
        Me.Guna2CircleButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.ShadowDecoration.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(30, 32)
        Me.Guna2CircleButton2.TabIndex = 102
        '
        'QueueBtnMenu
        '
        Me.QueueBtnMenu.BorderRadius = 6
        Me.QueueBtnMenu.CheckedState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.CustomImages.Parent = Me.QueueBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.QueueBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.QueueBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.QueueBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.QueueBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.QueueBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.QueueBtnMenu.DisabledState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.QueueBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.QueueBtnMenu.ForeColor = System.Drawing.Color.White
        Me.QueueBtnMenu.HoverState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.Location = New System.Drawing.Point(423, 14)
        Me.QueueBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.QueueBtnMenu.Name = "QueueBtnMenu"
        Me.QueueBtnMenu.ShadowDecoration.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.QueueBtnMenu.TabIndex = 82
        Me.QueueBtnMenu.Text = "QUEUE"
        '
        'HistoryBtnMenu
        '
        Me.HistoryBtnMenu.BorderRadius = 6
        Me.HistoryBtnMenu.CheckedState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.CustomImages.Parent = Me.HistoryBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.HistoryBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HistoryBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.HistoryBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.HistoryBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.HistoryBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.HistoryBtnMenu.DisabledState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.HistoryBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.HistoryBtnMenu.ForeColor = System.Drawing.Color.White
        Me.HistoryBtnMenu.HoverState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.Location = New System.Drawing.Point(542, 14)
        Me.HistoryBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.HistoryBtnMenu.Name = "HistoryBtnMenu"
        Me.HistoryBtnMenu.ShadowDecoration.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.HistoryBtnMenu.TabIndex = 81
        Me.HistoryBtnMenu.Text = "HISTORY"
        Me.HistoryBtnMenu.Tile = True
        '
        'DashboardBtnMenu
        '
        Me.DashboardBtnMenu.BorderRadius = 6
        Me.DashboardBtnMenu.CheckedState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.CustomImages.Parent = Me.DashboardBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.DashboardBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DashboardBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DashboardBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashboardBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DashboardBtnMenu.DisabledState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DashboardBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DashboardBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DashboardBtnMenu.HoverState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.Location = New System.Drawing.Point(24, 14)
        Me.DashboardBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DashboardBtnMenu.Name = "DashboardBtnMenu"
        Me.DashboardBtnMenu.ShadowDecoration.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.Size = New System.Drawing.Size(163, 31)
        Me.DashboardBtnMenu.TabIndex = 11
        Me.DashboardBtnMenu.Text = "DASHBOARD"
        '
        'LogoutBtnMenu
        '
        Me.LogoutBtnMenu.BorderRadius = 6
        Me.LogoutBtnMenu.CheckedState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.CustomImages.Parent = Me.LogoutBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.LogoutBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LogoutBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogoutBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogoutBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogoutBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogoutBtnMenu.DisabledState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LogoutBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LogoutBtnMenu.ForeColor = System.Drawing.Color.White
        Me.LogoutBtnMenu.HoverState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.Location = New System.Drawing.Point(879, 11)
        Me.LogoutBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutBtnMenu.Name = "LogoutBtnMenu"
        Me.LogoutBtnMenu.ShadowDecoration.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.Size = New System.Drawing.Size(188, 42)
        Me.LogoutBtnMenu.TabIndex = 10
        Me.LogoutBtnMenu.Text = "LOGOUT"
        '
        'Guna2PictureBox2
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.plasmo.My.Resources.Resources.log_out__3_
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1017, 20)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(28, 27)
        Me.Guna2PictureBox2.TabIndex = 89
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Location = New System.Drawing.Point(47, 42)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(64, 3)
        Me.Guna2Panel2.TabIndex = 80
        '
        'RecieverBtnMenu
        '
        Me.RecieverBtnMenu.BorderRadius = 6
        Me.RecieverBtnMenu.CheckedState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.CustomImages.Parent = Me.RecieverBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.RecieverBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RecieverBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RecieverBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RecieverBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RecieverBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RecieverBtnMenu.DisabledState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.RecieverBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RecieverBtnMenu.ForeColor = System.Drawing.Color.White
        Me.RecieverBtnMenu.HoverState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.Location = New System.Drawing.Point(301, 14)
        Me.RecieverBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.RecieverBtnMenu.Name = "RecieverBtnMenu"
        Me.RecieverBtnMenu.ShadowDecoration.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.Size = New System.Drawing.Size(131, 31)
        Me.RecieverBtnMenu.TabIndex = 84
        Me.RecieverBtnMenu.Text = "RECIEVER"
        '
        'DonorBtnMenu
        '
        Me.DonorBtnMenu.BorderRadius = 6
        Me.DonorBtnMenu.CheckedState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.CustomImages.Parent = Me.DonorBtnMenu
        Me.Guna2Transition1.SetDecoration(Me.DonorBtnMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DonorBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DonorBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DonorBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DonorBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DonorBtnMenu.DisabledState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DonorBtnMenu.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DonorBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DonorBtnMenu.HoverState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.Location = New System.Drawing.Point(182, 14)
        Me.DonorBtnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorBtnMenu.Name = "DonorBtnMenu"
        Me.DonorBtnMenu.ShadowDecoration.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.Size = New System.Drawing.Size(125, 31)
        Me.DonorBtnMenu.TabIndex = 83
        Me.DonorBtnMenu.Text = "DONOR"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel3.Controls.Add(Me.RecieverBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.DonorBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.QueueBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.HistoryBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.DashboardBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.LogoutBtnMenu)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 73)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1082, 58)
        Me.Guna2Panel3.TabIndex = 85
        '
        'Guna2BorderlessForm2
        '
        Me.Guna2BorderlessForm2.ContainerControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.plasmo.My.Resources.Resources.Plasmo_Logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 11)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(201, 58)
        Me.Guna2PictureBox1.TabIndex = 103
        Me.Guna2PictureBox1.TabStop = False
        '
        'MasterControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 624)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MasterControl"
        Me.Text = "MasterControl"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents RecieverBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DonorBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents QueueBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HistoryBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DashboardBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogoutBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
