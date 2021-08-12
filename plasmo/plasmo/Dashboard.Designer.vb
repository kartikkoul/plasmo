<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.APlusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.AMinusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BMinusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BPlusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ABMinusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OMinusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.ABPlusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OPlusCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.RecieverBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.QueueBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DonorBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.HistoryBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DashboardBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoutBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'APlusCircle
        '
        Me.APlusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.APlusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.APlusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.APlusCircle.FillOffset = 5
        Me.APlusCircle.FillThickness = 4
        resources.ApplyResources(Me.APlusCircle, "APlusCircle")
        Me.APlusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.APlusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.APlusCircle.Minimum = 0
        Me.APlusCircle.Name = "APlusCircle"
        Me.APlusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.APlusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.APlusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.APlusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.APlusCircle.ProgressThickness = 9
        Me.APlusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.APlusCircle.ShadowDecoration.Parent = Me.APlusCircle
        Me.APlusCircle.ShowPercentage = True
        Me.APlusCircle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.APlusCircle.Value = 21
        '
        'AMinusCircle
        '
        Me.AMinusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.AMinusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AMinusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AMinusCircle.FillOffset = 5
        Me.AMinusCircle.FillThickness = 4
        resources.ApplyResources(Me.AMinusCircle, "AMinusCircle")
        Me.AMinusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AMinusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AMinusCircle.Minimum = 0
        Me.AMinusCircle.Name = "AMinusCircle"
        Me.AMinusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.AMinusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.AMinusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.AMinusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.AMinusCircle.ProgressThickness = 9
        Me.AMinusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AMinusCircle.ShadowDecoration.Parent = Me.AMinusCircle
        Me.AMinusCircle.ShowPercentage = True
        Me.AMinusCircle.Value = 25
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'BMinusCircle
        '
        Me.BMinusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BMinusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BMinusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BMinusCircle.FillOffset = 5
        Me.BMinusCircle.FillThickness = 4
        resources.ApplyResources(Me.BMinusCircle, "BMinusCircle")
        Me.BMinusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BMinusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BMinusCircle.Minimum = 0
        Me.BMinusCircle.Name = "BMinusCircle"
        Me.BMinusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BMinusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BMinusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.BMinusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.BMinusCircle.ProgressThickness = 9
        Me.BMinusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BMinusCircle.ShadowDecoration.Parent = Me.BMinusCircle
        Me.BMinusCircle.ShowPercentage = True
        Me.BMinusCircle.Value = 2
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'BPlusCircle
        '
        Me.BPlusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BPlusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BPlusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BPlusCircle.FillOffset = 5
        Me.BPlusCircle.FillThickness = 4
        resources.ApplyResources(Me.BPlusCircle, "BPlusCircle")
        Me.BPlusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BPlusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BPlusCircle.Minimum = 0
        Me.BPlusCircle.Name = "BPlusCircle"
        Me.BPlusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BPlusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BPlusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.BPlusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.BPlusCircle.ProgressThickness = 9
        Me.BPlusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BPlusCircle.ShadowDecoration.Parent = Me.BPlusCircle
        Me.BPlusCircle.ShowPercentage = True
        Me.BPlusCircle.Value = 75
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'ABMinusCircle
        '
        Me.ABMinusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ABMinusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ABMinusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ABMinusCircle.FillOffset = 5
        Me.ABMinusCircle.FillThickness = 4
        resources.ApplyResources(Me.ABMinusCircle, "ABMinusCircle")
        Me.ABMinusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ABMinusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ABMinusCircle.Minimum = 0
        Me.ABMinusCircle.Name = "ABMinusCircle"
        Me.ABMinusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ABMinusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ABMinusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ABMinusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ABMinusCircle.ProgressThickness = 9
        Me.ABMinusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ABMinusCircle.ShadowDecoration.Parent = Me.ABMinusCircle
        Me.ABMinusCircle.ShowPercentage = True
        Me.ABMinusCircle.Value = 37
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'OMinusCircle
        '
        Me.OMinusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.OMinusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.OMinusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OMinusCircle.FillOffset = 5
        Me.OMinusCircle.FillThickness = 4
        resources.ApplyResources(Me.OMinusCircle, "OMinusCircle")
        Me.OMinusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OMinusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OMinusCircle.Minimum = 0
        Me.OMinusCircle.Name = "OMinusCircle"
        Me.OMinusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.OMinusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.OMinusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.OMinusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.OMinusCircle.ProgressThickness = 9
        Me.OMinusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.OMinusCircle.ShadowDecoration.Parent = Me.OMinusCircle
        Me.OMinusCircle.ShowPercentage = True
        '
        'ABPlusCircle
        '
        Me.ABPlusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ABPlusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ABPlusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ABPlusCircle.FillOffset = 5
        Me.ABPlusCircle.FillThickness = 4
        resources.ApplyResources(Me.ABPlusCircle, "ABPlusCircle")
        Me.ABPlusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ABPlusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ABPlusCircle.Minimum = 0
        Me.ABPlusCircle.Name = "ABPlusCircle"
        Me.ABPlusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ABPlusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ABPlusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ABPlusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ABPlusCircle.ProgressThickness = 9
        Me.ABPlusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ABPlusCircle.ShadowDecoration.Parent = Me.ABPlusCircle
        Me.ABPlusCircle.ShowPercentage = True
        Me.ABPlusCircle.Value = 44
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Guna2Transition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'OPlusCircle
        '
        Me.OPlusCircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.OPlusCircle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.OPlusCircle.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OPlusCircle.FillOffset = 5
        Me.OPlusCircle.FillThickness = 4
        resources.ApplyResources(Me.OPlusCircle, "OPlusCircle")
        Me.OPlusCircle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OPlusCircle.InnerColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OPlusCircle.Minimum = 0
        Me.OPlusCircle.Name = "OPlusCircle"
        Me.OPlusCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.OPlusCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.OPlusCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.OPlusCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.OPlusCircle.ProgressThickness = 9
        Me.OPlusCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.OPlusCircle.ShadowDecoration.Parent = Me.OPlusCircle
        Me.OPlusCircle.ShowPercentage = True
        Me.OPlusCircle.Value = 95
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Guna2Transition1.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
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
        resources.ApplyResources(Me.Guna2CircleButton2, "Guna2CircleButton2")
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.HoverState.Image = Global.plasmo.My.Resources.Resources.Line_10
        Me.Guna2CircleButton2.HoverState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Image = Global.plasmo.My.Resources.Resources.Line_9
        Me.Guna2CircleButton2.ImageSize = New System.Drawing.Size(18, 3)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.ShadowDecoration.Parent = Me.Guna2CircleButton2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.RecieverBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.QueueBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.DonorBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.HistoryBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.DashboardBtnMenu)
        Me.Guna2Panel1.Controls.Add(Me.LogoutBtnMenu)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Guna2Panel1, "Guna2Panel1")
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Guna2HtmlLabel4, "Guna2HtmlLabel4")
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Guna2Panel2, "Guna2Panel2")
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
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
        resources.ApplyResources(Me.RecieverBtnMenu, "RecieverBtnMenu")
        Me.RecieverBtnMenu.ForeColor = System.Drawing.Color.White
        Me.RecieverBtnMenu.HoverState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.Name = "RecieverBtnMenu"
        Me.RecieverBtnMenu.ShadowDecoration.Parent = Me.RecieverBtnMenu
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
        resources.ApplyResources(Me.QueueBtnMenu, "QueueBtnMenu")
        Me.QueueBtnMenu.ForeColor = System.Drawing.Color.White
        Me.QueueBtnMenu.HoverState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.Name = "QueueBtnMenu"
        Me.QueueBtnMenu.ShadowDecoration.Parent = Me.QueueBtnMenu
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
        resources.ApplyResources(Me.DonorBtnMenu, "DonorBtnMenu")
        Me.DonorBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DonorBtnMenu.HoverState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.Name = "DonorBtnMenu"
        Me.DonorBtnMenu.ShadowDecoration.Parent = Me.DonorBtnMenu
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
        resources.ApplyResources(Me.HistoryBtnMenu, "HistoryBtnMenu")
        Me.HistoryBtnMenu.ForeColor = System.Drawing.Color.White
        Me.HistoryBtnMenu.HoverState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.Name = "HistoryBtnMenu"
        Me.HistoryBtnMenu.ShadowDecoration.Parent = Me.HistoryBtnMenu
        '
        'Guna2PictureBox2
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.plasmo.My.Resources.Resources.log_out__1_
        Me.Guna2PictureBox2.ImageRotate = 0!
        resources.ApplyResources(Me.Guna2PictureBox2, "Guna2PictureBox2")
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.TabStop = False
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
        resources.ApplyResources(Me.DashboardBtnMenu, "DashboardBtnMenu")
        Me.DashboardBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DashboardBtnMenu.HoverState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.Name = "DashboardBtnMenu"
        Me.DashboardBtnMenu.ShadowDecoration.Parent = Me.DashboardBtnMenu
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
        resources.ApplyResources(Me.LogoutBtnMenu, "LogoutBtnMenu")
        Me.LogoutBtnMenu.ForeColor = System.Drawing.Color.White
        Me.LogoutBtnMenu.HoverState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.Name = "LogoutBtnMenu"
        Me.LogoutBtnMenu.ShadowDecoration.Parent = Me.LogoutBtnMenu
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
        resources.ApplyResources(Me.CloseButton, "CloseButton")
        Me.CloseButton.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.Image = Global.plasmo.My.Resources.Resources.Component_3__1_
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Image = Global.plasmo.My.Resources.Resources.Component_21
        Me.CloseButton.ImageSize = New System.Drawing.Size(28, 28)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.plasmo.My.Resources.Resources.Plasmo_Logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        resources.ApplyResources(Me.Guna2PictureBox1, "Guna2PictureBox1")
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.ABMinusCircle)
        Me.Controls.Add(Me.BMinusCircle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OMinusCircle)
        Me.Controls.Add(Me.ABPlusCircle)
        Me.Controls.Add(Me.AMinusCircle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BPlusCircle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OPlusCircle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.APlusCircle)
        Me.Controls.Add(Me.Label5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label5 As Label
    Friend WithEvents ABMinusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents BMinusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OMinusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents ABPlusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents AMinusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents BPlusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OPlusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents APlusCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents RecieverBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents QueueBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DonorBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HistoryBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DashboardBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogoutBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
