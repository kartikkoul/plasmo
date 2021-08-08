<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.UserIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.EyeButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Newdataset = New plasmo.newdataset()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New plasmo.newdatasetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New plasmo.newdatasetTableAdapters.TableAdapterManager()
        Me.Guna2BorderlessForm2 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2BorderlessForm3 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.EyeClosed = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.EyeOpen = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Newdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EyeClosed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EyeOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UserIDTextBox.BorderRadius = 10
        Me.UserIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserIDTextBox.DefaultText = ""
        Me.UserIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserIDTextBox.DisabledState.Parent = Me.UserIDTextBox
        Me.UserIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserIDTextBox.FocusedState.Parent = Me.UserIDTextBox
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UserIDTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UserIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserIDTextBox.HoverState.Parent = Me.UserIDTextBox
        Me.UserIDTextBox.Location = New System.Drawing.Point(86, 292)
        Me.UserIDTextBox.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserIDTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.UserIDTextBox.PlaceholderText = "admin@plasmo"
        Me.UserIDTextBox.SelectedText = ""
        Me.UserIDTextBox.ShadowDecoration.Parent = Me.UserIDTextBox
        Me.UserIDTextBox.Size = New System.Drawing.Size(327, 53)
        Me.UserIDTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(81, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Welcome to Plasmo!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 376)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.BorderRadius = 6
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginButton.DisabledState.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(147, 518)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(188, 42)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.Text = "LOGIN"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordTextBox.BorderRadius = 10
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.FocusedState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.HoverState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Location = New System.Drawing.Point(86, 418)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.PasswordTextBox.PlaceholderText = "  ********"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.ShadowDecoration.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Size = New System.Drawing.Size(327, 53)
        Me.PasswordTextBox.TabIndex = 10
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'EyeButton
        '
        Me.EyeButton.BackColor = System.Drawing.Color.Transparent
        Me.EyeButton.BorderColor = System.Drawing.Color.Transparent
        Me.EyeButton.CheckedState.Parent = Me.EyeButton
        Me.EyeButton.CustomImages.Parent = Me.EyeButton
        Me.EyeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EyeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EyeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EyeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EyeButton.DisabledState.Parent = Me.EyeButton
        Me.EyeButton.FillColor = System.Drawing.Color.Transparent
        Me.EyeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EyeButton.ForeColor = System.Drawing.Color.Transparent
        Me.EyeButton.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.EyeButton.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.EyeButton.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.EyeButton.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.EyeButton.HoverState.Parent = Me.EyeButton
        Me.EyeButton.Location = New System.Drawing.Point(384, 436)
        Me.EyeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EyeButton.Name = "EyeButton"
        Me.EyeButton.PressedColor = System.Drawing.Color.Transparent
        Me.EyeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.EyeButton.ShadowDecoration.Parent = Me.EyeButton
        Me.EyeButton.Size = New System.Drawing.Size(18, 20)
        Me.EyeButton.TabIndex = 16
        Me.EyeButton.Text = "Guna2CircleButton1"
        Me.EyeButton.UseTransparentBackground = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = plasmo.newdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Guna2BorderlessForm2
        '
        Me.Guna2BorderlessForm2.ContainerControl = Me
        '
        'Guna2BorderlessForm3
        '
        Me.Guna2BorderlessForm3.ContainerControl = Me
        '
        'Guna2CircleButton2
        '
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
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(994, 10)
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
        Me.CloseButton.Location = New System.Drawing.Point(1041, 10)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(30, 32)
        Me.CloseButton.TabIndex = 65
        '
        'EyeClosed
        '
        Me.EyeClosed.Image = CType(resources.GetObject("EyeClosed.Image"), System.Drawing.Image)
        Me.EyeClosed.ImageRotate = 0!
        Me.EyeClosed.Location = New System.Drawing.Point(384, 436)
        Me.EyeClosed.Margin = New System.Windows.Forms.Padding(2)
        Me.EyeClosed.Name = "EyeClosed"
        Me.EyeClosed.ShadowDecoration.Parent = Me.EyeClosed
        Me.EyeClosed.Size = New System.Drawing.Size(24, 24)
        Me.EyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.EyeClosed.TabIndex = 15
        Me.EyeClosed.TabStop = False
        '
        'EyeOpen
        '
        Me.EyeOpen.Image = CType(resources.GetObject("EyeOpen.Image"), System.Drawing.Image)
        Me.EyeOpen.ImageRotate = 0!
        Me.EyeOpen.Location = New System.Drawing.Point(384, 436)
        Me.EyeOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.EyeOpen.Name = "EyeOpen"
        Me.EyeOpen.ShadowDecoration.Parent = Me.EyeOpen
        Me.EyeOpen.Size = New System.Drawing.Size(24, 24)
        Me.EyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.EyeOpen.TabIndex = 14
        Me.EyeOpen.TabStop = False
        Me.EyeOpen.Visible = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(553, 118)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(464, 374)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.plasmo.My.Resources.Resources.Plasmo_Logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 16)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(201, 58)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1082, 624)
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.EyeButton)
        Me.Controls.Add(Me.EyeClosed)
        Me.Controls.Add(Me.EyeOpen)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Newdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EyeClosed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EyeOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UserIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents EyeClosed As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents EyeOpen As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents EyeButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents Newdataset As newdataset
    Friend WithEvents TableTableAdapter As newdatasetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As newdatasetTableAdapters.TableAdapterManager
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2BorderlessForm3 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2CircleButton
End Class
