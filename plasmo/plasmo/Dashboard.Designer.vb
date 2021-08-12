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
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
End Class
