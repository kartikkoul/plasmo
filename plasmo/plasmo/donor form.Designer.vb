<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donor_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donor_form))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.gender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.city = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bgroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.antibody = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.RecieverBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DonorBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.QueueBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.HistoryBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoutBtnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.Transparent
        Me.gender.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gender.BorderRadius = 10
        Me.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gender.FocusedState.Parent = Me.gender
        Me.gender.Font = New System.Drawing.Font("Poppins", 10.2!)
        Me.gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gender.HoverState.Parent = Me.gender
        Me.gender.ItemHeight = 30
        Me.gender.Items.AddRange(New Object() {"Select Your Gender", "Male", "Female", "Other"})
        Me.gender.ItemsAppearance.Parent = Me.gender
        Me.gender.Location = New System.Drawing.Point(959, 502)
        Me.gender.Name = "gender"
        Me.gender.ShadowDecoration.Parent = Me.gender
        Me.gender.Size = New System.Drawing.Size(289, 36)
        Me.gender.StartIndex = 0
        Me.gender.TabIndex = 63
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(595, 701)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(250, 52)
        Me.Guna2Button1.TabIndex = 62
        Me.Guna2Button1.Text = "SUBMIT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(953, 447)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 36)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Gender"
        '
        'address
        '
        Me.address.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.address.BorderRadius = 10
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.DefaultText = ""
        Me.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.DisabledState.Parent = Me.address
        Me.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.FocusedState.Parent = Me.address
        Me.address.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.HoverState.Parent = Me.address
        Me.address.Location = New System.Drawing.Point(575, 490)
        Me.address.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.address.PlaceholderText = "  Address"
        Me.address.SelectedText = ""
        Me.address.ShadowDecoration.Parent = Me.address
        Me.address.Size = New System.Drawing.Size(289, 55)
        Me.address.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 36)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Address"
        '
        'city
        '
        Me.city.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.city.BorderRadius = 10
        Me.city.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.city.DefaultText = ""
        Me.city.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.city.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.city.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.city.DisabledState.Parent = Me.city
        Me.city.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.city.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.city.FocusedState.Parent = Me.city
        Me.city.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.city.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.city.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.city.HoverState.Parent = Me.city
        Me.city.Location = New System.Drawing.Point(203, 490)
        Me.city.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.city.Name = "city"
        Me.city.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.city.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.city.PlaceholderText = "  City"
        Me.city.SelectedText = ""
        Me.city.ShadowDecoration.Parent = Me.city
        Me.city.Size = New System.Drawing.Size(289, 55)
        Me.city.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 36)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "City" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(953, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 36)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Blood Group"
        '
        'bgroup
        '
        Me.bgroup.BackColor = System.Drawing.Color.Transparent
        Me.bgroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bgroup.BorderRadius = 10
        Me.bgroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.bgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bgroup.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bgroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bgroup.FocusedState.Parent = Me.bgroup
        Me.bgroup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.bgroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bgroup.HoverState.Parent = Me.bgroup
        Me.bgroup.ItemHeight = 30
        Me.bgroup.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        Me.bgroup.ItemsAppearance.Parent = Me.bgroup
        Me.bgroup.Location = New System.Drawing.Point(959, 378)
        Me.bgroup.Name = "bgroup"
        Me.bgroup.ShadowDecoration.Parent = Me.bgroup
        Me.bgroup.Size = New System.Drawing.Size(289, 36)
        Me.bgroup.StartIndex = 0
        Me.bgroup.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 36)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "E-mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 36)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(580, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 36)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Last Name"
        '
        'mail
        '
        Me.mail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mail.BorderRadius = 10
        Me.mail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mail.DefaultText = ""
        Me.mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mail.DisabledState.Parent = Me.mail
        Me.mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mail.FocusedState.Parent = Me.mail
        Me.mail.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.mail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mail.HoverState.Parent = Me.mail
        Me.mail.Location = New System.Drawing.Point(575, 366)
        Me.mail.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.mail.Name = "mail"
        Me.mail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mail.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.mail.PlaceholderText = "  E-mail"
        Me.mail.SelectedText = ""
        Me.mail.ShadowDecoration.Parent = Me.mail
        Me.mail.Size = New System.Drawing.Size(289, 55)
        Me.mail.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(953, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 36)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Age"
        '
        'pnumber
        '
        Me.pnumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnumber.BorderRadius = 10
        Me.pnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnumber.DefaultText = ""
        Me.pnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnumber.DisabledState.Parent = Me.pnumber
        Me.pnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnumber.FocusedState.Parent = Me.pnumber
        Me.pnumber.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.pnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnumber.HoverState.Parent = Me.pnumber
        Me.pnumber.Location = New System.Drawing.Point(203, 366)
        Me.pnumber.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.pnumber.Name = "pnumber"
        Me.pnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pnumber.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.pnumber.PlaceholderText = "  Phone Number"
        Me.pnumber.SelectedText = ""
        Me.pnumber.ShadowDecoration.Parent = Me.pnumber
        Me.pnumber.Size = New System.Drawing.Size(289, 55)
        Me.pnumber.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 36)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "First Name"
        '
        'age
        '
        Me.age.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.age.BorderRadius = 10
        Me.age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.age.DefaultText = ""
        Me.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.age.DisabledState.Parent = Me.age
        Me.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.age.FocusedState.Parent = Me.age
        Me.age.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.age.HoverState.Parent = Me.age
        Me.age.Location = New System.Drawing.Point(959, 242)
        Me.age.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.age.Name = "age"
        Me.age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.age.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.age.PlaceholderText = "  Age"
        Me.age.SelectedText = ""
        Me.age.ShadowDecoration.Parent = Me.age
        Me.age.Size = New System.Drawing.Size(289, 55)
        Me.age.TabIndex = 49
        '
        'lname
        '
        Me.lname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lname.BorderRadius = 10
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.DefaultText = ""
        Me.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.DisabledState.Parent = Me.lname
        Me.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.FocusedState.Parent = Me.lname
        Me.lname.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.lname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.HoverState.Parent = Me.lname
        Me.lname.Location = New System.Drawing.Point(575, 242)
        Me.lname.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.lname.PlaceholderText = "  Last Name"
        Me.lname.SelectedText = ""
        Me.lname.ShadowDecoration.Parent = Me.lname
        Me.lname.Size = New System.Drawing.Size(289, 55)
        Me.lname.TabIndex = 47
        '
        'fname
        '
        Me.fname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fname.BorderRadius = 10
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.DefaultText = ""
        Me.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.DisabledState.Parent = Me.fname
        Me.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.FocusedState.Parent = Me.fname
        Me.fname.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.fname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.HoverState.Parent = Me.fname
        Me.fname.Location = New System.Drawing.Point(203, 242)
        Me.fname.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.fname.PlaceholderText = "  First Name"
        Me.fname.SelectedText = ""
        Me.fname.ShadowDecoration.Parent = Me.fname
        Me.fname.Size = New System.Drawing.Size(289, 55)
        Me.fname.TabIndex = 45
        '
        'antibody
        '
        Me.antibody.BackColor = System.Drawing.Color.Transparent
        Me.antibody.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.antibody.BorderRadius = 10
        Me.antibody.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.antibody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.antibody.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.antibody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.antibody.FocusedState.Parent = Me.antibody
        Me.antibody.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.antibody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.antibody.HoverState.Parent = Me.antibody
        Me.antibody.ItemHeight = 30
        Me.antibody.Items.AddRange(New Object() {"Yes", "No"})
        Me.antibody.ItemsAppearance.Parent = Me.antibody
        Me.antibody.Location = New System.Drawing.Point(203, 626)
        Me.antibody.Name = "antibody"
        Me.antibody.ShadowDecoration.Parent = Me.antibody
        Me.antibody.Size = New System.Drawing.Size(289, 36)
        Me.antibody.StartIndex = 0
        Me.antibody.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(197, 577)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 36)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Did you ever get covid?"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.Controls.Add(Me.RecieverBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.DonorBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.QueueBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.HistoryBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.DashboardBtnMenu)
        Me.Guna2Panel3.Controls.Add(Me.LogoutBtnMenu)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1443, 72)
        Me.Guna2Panel3.TabIndex = 69
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.plasmo.My.Resources.Resources.log_out__1_
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1353, 25)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(26, 33)
        Me.Guna2PictureBox2.TabIndex = 90
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(280, 51)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(86, 4)
        Me.Guna2Panel4.TabIndex = 80
        '
        'RecieverBtnMenu
        '
        Me.RecieverBtnMenu.BorderRadius = 6
        Me.RecieverBtnMenu.CheckedState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.CustomImages.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RecieverBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RecieverBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RecieverBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RecieverBtnMenu.DisabledState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.RecieverBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.RecieverBtnMenu.ForeColor = System.Drawing.Color.White
        Me.RecieverBtnMenu.HoverState.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.Location = New System.Drawing.Point(409, 17)
        Me.RecieverBtnMenu.Name = "RecieverBtnMenu"
        Me.RecieverBtnMenu.ShadowDecoration.Parent = Me.RecieverBtnMenu
        Me.RecieverBtnMenu.Size = New System.Drawing.Size(167, 38)
        Me.RecieverBtnMenu.TabIndex = 84
        Me.RecieverBtnMenu.Text = "RECIEVER"
        '
        'DonorBtnMenu
        '
        Me.DonorBtnMenu.BorderRadius = 6
        Me.DonorBtnMenu.CheckedState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.CustomImages.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DonorBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DonorBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DonorBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DonorBtnMenu.DisabledState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DonorBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.DonorBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DonorBtnMenu.HoverState.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.Location = New System.Drawing.Point(243, 17)
        Me.DonorBtnMenu.Name = "DonorBtnMenu"
        Me.DonorBtnMenu.ShadowDecoration.Parent = Me.DonorBtnMenu
        Me.DonorBtnMenu.Size = New System.Drawing.Size(167, 38)
        Me.DonorBtnMenu.TabIndex = 83
        Me.DonorBtnMenu.Text = "DONOR"
        '
        'QueueBtnMenu
        '
        Me.QueueBtnMenu.BorderRadius = 6
        Me.QueueBtnMenu.CheckedState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.CustomImages.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.QueueBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.QueueBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.QueueBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.QueueBtnMenu.DisabledState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.QueueBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.QueueBtnMenu.ForeColor = System.Drawing.Color.White
        Me.QueueBtnMenu.HoverState.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.Location = New System.Drawing.Point(564, 17)
        Me.QueueBtnMenu.Name = "QueueBtnMenu"
        Me.QueueBtnMenu.ShadowDecoration.Parent = Me.QueueBtnMenu
        Me.QueueBtnMenu.Size = New System.Drawing.Size(167, 38)
        Me.QueueBtnMenu.TabIndex = 82
        Me.QueueBtnMenu.Text = "QUEUE"
        '
        'HistoryBtnMenu
        '
        Me.HistoryBtnMenu.BorderRadius = 6
        Me.HistoryBtnMenu.CheckedState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.CustomImages.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.HistoryBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.HistoryBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.HistoryBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.HistoryBtnMenu.DisabledState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.HistoryBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.HistoryBtnMenu.ForeColor = System.Drawing.Color.White
        Me.HistoryBtnMenu.HoverState.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.Location = New System.Drawing.Point(723, 17)
        Me.HistoryBtnMenu.Name = "HistoryBtnMenu"
        Me.HistoryBtnMenu.ShadowDecoration.Parent = Me.HistoryBtnMenu
        Me.HistoryBtnMenu.Size = New System.Drawing.Size(167, 38)
        Me.HistoryBtnMenu.TabIndex = 81
        Me.HistoryBtnMenu.Text = "HISTORY"
        '
        'DashboardBtnMenu
        '
        Me.DashboardBtnMenu.BorderRadius = 6
        Me.DashboardBtnMenu.CheckedState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.CustomImages.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DashboardBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DashboardBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashboardBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DashboardBtnMenu.DisabledState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DashboardBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.DashboardBtnMenu.ForeColor = System.Drawing.Color.White
        Me.DashboardBtnMenu.HoverState.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.Location = New System.Drawing.Point(32, 17)
        Me.DashboardBtnMenu.Name = "DashboardBtnMenu"
        Me.DashboardBtnMenu.ShadowDecoration.Parent = Me.DashboardBtnMenu
        Me.DashboardBtnMenu.Size = New System.Drawing.Size(217, 38)
        Me.DashboardBtnMenu.TabIndex = 11
        Me.DashboardBtnMenu.Text = "DASHBOARD"
        '
        'LogoutBtnMenu
        '
        Me.LogoutBtnMenu.BorderRadius = 6
        Me.LogoutBtnMenu.CheckedState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.CustomImages.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogoutBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogoutBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogoutBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogoutBtnMenu.DisabledState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LogoutBtnMenu.Font = New System.Drawing.Font("Poppins Medium", 13.2!, System.Drawing.FontStyle.Bold)
        Me.LogoutBtnMenu.ForeColor = System.Drawing.Color.White
        Me.LogoutBtnMenu.HoverState.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.Location = New System.Drawing.Point(1172, 13)
        Me.LogoutBtnMenu.Name = "LogoutBtnMenu"
        Me.LogoutBtnMenu.ShadowDecoration.Parent = Me.LogoutBtnMenu
        Me.LogoutBtnMenu.Size = New System.Drawing.Size(250, 52)
        Me.LogoutBtnMenu.TabIndex = 10
        Me.LogoutBtnMenu.Text = "LOGOUT"
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
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(1320, 12)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.ShadowDecoration.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(40, 40)
        Me.Guna2CircleButton2.TabIndex = 68
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
        Me.CloseButton.Location = New System.Drawing.Point(1382, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(40, 40)
        Me.CloseButton.TabIndex = 67
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.plasmo.My.Resources.Resources.Plasmo_Logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(34, 14)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(268, 71)
        Me.Guna2PictureBox1.TabIndex = 43
        Me.Guna2PictureBox1.TabStop = False
        '
        'Donor_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1440, 768)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.antibody)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bgroup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Donor_form"
        Me.Text = "Donor_form"
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents antibody As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents city As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bgroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents RecieverBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DonorBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents QueueBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HistoryBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DashboardBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogoutBtnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
