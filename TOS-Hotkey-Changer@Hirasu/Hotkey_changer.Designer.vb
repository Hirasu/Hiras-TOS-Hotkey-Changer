<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotkey_changer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotkey_changer))
		Me.list_key = New System.Windows.Forms.DataGridView()
		Me.b_save = New System.Windows.Forms.Button()
		Me.change_to = New System.Windows.Forms.Button()
		Me.b_exit = New System.Windows.Forms.Button()
		Me.change_tab = New System.Windows.Forms.Button()
		Me.change_enter = New System.Windows.Forms.Button()
		Me.b_reload_k = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.b_reset_default = New System.Windows.Forms.Button()
		Me.b_clear = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.b_reload_joystick = New System.Windows.Forms.Button()
		Me.b_reload_mouse = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.changinginfo = New System.Windows.Forms.RichTextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.CheckCTRL = New System.Windows.Forms.CheckBox()
		Me.CheckSHIFT = New System.Windows.Forms.CheckBox()
		Me.CheckALT = New System.Windows.Forms.CheckBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
		Me.chat_fix = New System.Windows.Forms.Button()
		Me.Mode_tab = New System.Windows.Forms.TabControl()
		Me.KeyPage = New System.Windows.Forms.TabPage()
		Me.key_text = New System.Windows.Forms.RichTextBox()
		Me.MousePage = New System.Windows.Forms.TabPage()
		Me.mouse_text = New System.Windows.Forms.RichTextBox()
		Me.list_mouse = New System.Windows.Forms.DataGridView()
		Me.JoystickPage = New System.Windows.Forms.TabPage()
		Me.joystick_text = New System.Windows.Forms.RichTextBox()
		Me.list_joystick = New System.Windows.Forms.DataGridView()
		Me.Joystick_checker = New System.Windows.Forms.Timer(Me.components)
		Me.R_Hotkey = New System.Windows.Forms.RadioButton()
		Me.R_Pressedkey = New System.Windows.Forms.RadioButton()
		Me.JoyInfoBox = New System.Windows.Forms.RichTextBox()
		CType(Me.list_key, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.Mode_tab.SuspendLayout()
		Me.KeyPage.SuspendLayout()
		Me.MousePage.SuspendLayout()
		CType(Me.list_mouse, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.JoystickPage.SuspendLayout()
		CType(Me.list_joystick, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'list_key
		'
		Me.list_key.AllowUserToAddRows = False
		Me.list_key.AllowUserToDeleteRows = False
		Me.list_key.AllowUserToResizeRows = False
		Me.list_key.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.list_key.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.list_key.Location = New System.Drawing.Point(0, 0)
		Me.list_key.Name = "list_key"
		Me.list_key.RowHeadersVisible = False
		Me.list_key.RowHeadersWidth = 33
		Me.list_key.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.list_key.Size = New System.Drawing.Size(252, 419)
		Me.list_key.TabIndex = 1
		'
		'b_save
		'
		Me.b_save.Enabled = False
		Me.b_save.Location = New System.Drawing.Point(35, 15)
		Me.b_save.Name = "b_save"
		Me.b_save.Size = New System.Drawing.Size(74, 23)
		Me.b_save.TabIndex = 4
		Me.b_save.Text = "Save"
		Me.b_save.UseVisualStyleBackColor = True
		'
		'change_to
		'
		Me.change_to.Enabled = False
		Me.change_to.Location = New System.Drawing.Point(34, 17)
		Me.change_to.Name = "change_to"
		Me.change_to.Size = New System.Drawing.Size(83, 23)
		Me.change_to.TabIndex = 5
		Me.change_to.Text = "Change to..."
		Me.change_to.UseVisualStyleBackColor = True
		'
		'b_exit
		'
		Me.b_exit.Location = New System.Drawing.Point(35, 131)
		Me.b_exit.Name = "b_exit"
		Me.b_exit.Size = New System.Drawing.Size(74, 23)
		Me.b_exit.TabIndex = 6
		Me.b_exit.Text = "Exit"
		Me.b_exit.UseVisualStyleBackColor = True
		'
		'change_tab
		'
		Me.change_tab.Enabled = False
		Me.change_tab.Location = New System.Drawing.Point(21, 44)
		Me.change_tab.Name = "change_tab"
		Me.change_tab.Size = New System.Drawing.Size(106, 23)
		Me.change_tab.TabIndex = 7
		Me.change_tab.Text = "Change to TAB"
		Me.change_tab.UseVisualStyleBackColor = True
		'
		'change_enter
		'
		Me.change_enter.Enabled = False
		Me.change_enter.Location = New System.Drawing.Point(21, 71)
		Me.change_enter.Name = "change_enter"
		Me.change_enter.Size = New System.Drawing.Size(106, 23)
		Me.change_enter.TabIndex = 8
		Me.change_enter.Text = "Change to ENTER"
		Me.change_enter.UseVisualStyleBackColor = True
		'
		'b_reload_k
		'
		Me.b_reload_k.Location = New System.Drawing.Point(9, 44)
		Me.b_reload_k.Name = "b_reload_k"
		Me.b_reload_k.Size = New System.Drawing.Size(128, 23)
		Me.b_reload_k.TabIndex = 9
		Me.b_reload_k.Text = "Reload Keyboard Mode"
		Me.b_reload_k.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.b_reset_default)
		Me.GroupBox1.Controls.Add(Me.b_clear)
		Me.GroupBox1.Controls.Add(Me.change_to)
		Me.GroupBox1.Controls.Add(Me.change_tab)
		Me.GroupBox1.Controls.Add(Me.change_enter)
		Me.GroupBox1.Location = New System.Drawing.Point(472, 249)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(143, 156)
		Me.GroupBox1.TabIndex = 10
		Me.GroupBox1.TabStop = False
		'
		'b_reset_default
		'
		Me.b_reset_default.Enabled = False
		Me.b_reset_default.Location = New System.Drawing.Point(21, 98)
		Me.b_reset_default.Name = "b_reset_default"
		Me.b_reset_default.Size = New System.Drawing.Size(106, 23)
		Me.b_reset_default.TabIndex = 11
		Me.b_reset_default.Text = "Reset to default"
		Me.b_reset_default.UseVisualStyleBackColor = True
		'
		'b_clear
		'
		Me.b_clear.Enabled = False
		Me.b_clear.Location = New System.Drawing.Point(34, 124)
		Me.b_clear.Name = "b_clear"
		Me.b_clear.Size = New System.Drawing.Size(83, 23)
		Me.b_clear.TabIndex = 9
		Me.b_clear.Text = "Clear hotkey"
		Me.b_clear.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.b_reload_joystick)
		Me.GroupBox2.Controls.Add(Me.b_reload_mouse)
		Me.GroupBox2.Controls.Add(Me.b_exit)
		Me.GroupBox2.Controls.Add(Me.b_save)
		Me.GroupBox2.Controls.Add(Me.b_reload_k)
		Me.GroupBox2.Location = New System.Drawing.Point(471, 437)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(143, 164)
		Me.GroupBox2.TabIndex = 11
		Me.GroupBox2.TabStop = False
		'
		'b_reload_joystick
		'
		Me.b_reload_joystick.Location = New System.Drawing.Point(9, 102)
		Me.b_reload_joystick.Name = "b_reload_joystick"
		Me.b_reload_joystick.Size = New System.Drawing.Size(128, 23)
		Me.b_reload_joystick.TabIndex = 11
		Me.b_reload_joystick.Text = "Reload Joystick Mode"
		Me.b_reload_joystick.UseVisualStyleBackColor = True
		'
		'b_reload_mouse
		'
		Me.b_reload_mouse.Location = New System.Drawing.Point(9, 73)
		Me.b_reload_mouse.Name = "b_reload_mouse"
		Me.b_reload_mouse.Size = New System.Drawing.Size(128, 23)
		Me.b_reload_mouse.TabIndex = 10
		Me.b_reload_mouse.Text = "Reload Mouse Mode"
		Me.b_reload_mouse.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.RichTextBox1)
		Me.GroupBox3.Location = New System.Drawing.Point(471, 0)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(143, 66)
		Me.GroupBox3.TabIndex = 12
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Info"
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
		Me.RichTextBox1.Location = New System.Drawing.Point(9, 17)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ReadOnly = True
		Me.RichTextBox1.Size = New System.Drawing.Size(129, 43)
		Me.RichTextBox1.TabIndex = 1
		Me.RichTextBox1.Text = "Doubleclick on a hotkey or press one of the ""Change to"" button"
		'
		'GroupBox4
		'
		Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox4.Controls.Add(Me.changinginfo)
		Me.GroupBox4.Location = New System.Drawing.Point(471, 212)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(147, 37)
		Me.GroupBox4.TabIndex = 13
		Me.GroupBox4.TabStop = False
		'
		'changinginfo
		'
		Me.changinginfo.BackColor = System.Drawing.SystemColors.Control
		Me.changinginfo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.changinginfo.Cursor = System.Windows.Forms.Cursors.Default
		Me.changinginfo.Location = New System.Drawing.Point(27, 14)
		Me.changinginfo.Name = "changinginfo"
		Me.changinginfo.Size = New System.Drawing.Size(114, 17)
		Me.changinginfo.TabIndex = 0
		Me.changinginfo.Text = "Choose a hotkey..."
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.TOS_Hotkey_Changer_Hirasu.My.Resources.Resources.photo
		Me.PictureBox1.ImageLocation = ""
		Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(18, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(245, 145)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 14
		Me.PictureBox1.TabStop = False
		'
		'GroupBox5
		'
		Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox5.Controls.Add(Me.CheckCTRL)
		Me.GroupBox5.Controls.Add(Me.CheckSHIFT)
		Me.GroupBox5.Controls.Add(Me.CheckALT)
		Me.GroupBox5.Location = New System.Drawing.Point(472, 65)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(143, 71)
		Me.GroupBox5.TabIndex = 16
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Hold to use"
		'
		'CheckCTRL
		'
		Me.CheckCTRL.AutoSize = True
		Me.CheckCTRL.Location = New System.Drawing.Point(12, 50)
		Me.CheckCTRL.Name = "CheckCTRL"
		Me.CheckCTRL.Size = New System.Drawing.Size(79, 17)
		Me.CheckCTRL.TabIndex = 2
		Me.CheckCTRL.Text = "Hold CTRL"
		Me.CheckCTRL.UseVisualStyleBackColor = True
		'
		'CheckSHIFT
		'
		Me.CheckSHIFT.AutoSize = True
		Me.CheckSHIFT.Location = New System.Drawing.Point(12, 34)
		Me.CheckSHIFT.Name = "CheckSHIFT"
		Me.CheckSHIFT.Size = New System.Drawing.Size(82, 17)
		Me.CheckSHIFT.TabIndex = 1
		Me.CheckSHIFT.Text = "Hold SHIFT"
		Me.CheckSHIFT.UseVisualStyleBackColor = True
		'
		'CheckALT
		'
		Me.CheckALT.AutoSize = True
		Me.CheckALT.Location = New System.Drawing.Point(12, 18)
		Me.CheckALT.Name = "CheckALT"
		Me.CheckALT.Size = New System.Drawing.Size(71, 17)
		Me.CheckALT.TabIndex = 0
		Me.CheckALT.Text = "Hold ALT"
		Me.CheckALT.UseVisualStyleBackColor = True
		'
		'GroupBox6
		'
		Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox6.Controls.Add(Me.RichTextBox2)
		Me.GroupBox6.Controls.Add(Me.chat_fix)
		Me.GroupBox6.Location = New System.Drawing.Point(472, 134)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(146, 78)
		Me.GroupBox6.TabIndex = 17
		Me.GroupBox6.TabStop = False
		'
		'RichTextBox2
		'
		Me.RichTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
		Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox2.Cursor = System.Windows.Forms.Cursors.Default
		Me.RichTextBox2.Location = New System.Drawing.Point(12, 13)
		Me.RichTextBox2.Name = "RichTextBox2"
		Me.RichTextBox2.ReadOnly = True
		Me.RichTextBox2.Size = New System.Drawing.Size(128, 27)
		Me.RichTextBox2.TabIndex = 2
		Me.RichTextBox2.Text = "Fix the ALT/SHIFT+TAB Chat type changing"
		'
		'chat_fix
		'
		Me.chat_fix.Enabled = False
		Me.chat_fix.Location = New System.Drawing.Point(34, 44)
		Me.chat_fix.Name = "chat_fix"
		Me.chat_fix.Size = New System.Drawing.Size(83, 23)
		Me.chat_fix.TabIndex = 0
		Me.chat_fix.Text = "Fix Chat Type"
		Me.chat_fix.UseVisualStyleBackColor = True
		'
		'Mode_tab
		'
		Me.Mode_tab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Mode_tab.Controls.Add(Me.KeyPage)
		Me.Mode_tab.Controls.Add(Me.MousePage)
		Me.Mode_tab.Controls.Add(Me.JoystickPage)
		Me.Mode_tab.Location = New System.Drawing.Point(13, 156)
		Me.Mode_tab.Name = "Mode_tab"
		Me.Mode_tab.SelectedIndex = 0
		Me.Mode_tab.Size = New System.Drawing.Size(450, 445)
		Me.Mode_tab.TabIndex = 18
		'
		'KeyPage
		'
		Me.KeyPage.Controls.Add(Me.key_text)
		Me.KeyPage.Controls.Add(Me.list_key)
		Me.KeyPage.Location = New System.Drawing.Point(4, 22)
		Me.KeyPage.Name = "KeyPage"
		Me.KeyPage.Padding = New System.Windows.Forms.Padding(3)
		Me.KeyPage.Size = New System.Drawing.Size(442, 419)
		Me.KeyPage.TabIndex = 0
		Me.KeyPage.Text = "Keyboard Mode"
		Me.KeyPage.UseVisualStyleBackColor = True
		'
		'key_text
		'
		Me.key_text.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.key_text.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.key_text.Cursor = System.Windows.Forms.Cursors.Default
		Me.key_text.Location = New System.Drawing.Point(19, 313)
		Me.key_text.Name = "key_text"
		Me.key_text.Size = New System.Drawing.Size(227, 19)
		Me.key_text.TabIndex = 4
		Me.key_text.Text = "Click on the ""Reload Keyboard Mode"" button"
		'
		'MousePage
		'
		Me.MousePage.Controls.Add(Me.mouse_text)
		Me.MousePage.Controls.Add(Me.list_mouse)
		Me.MousePage.Location = New System.Drawing.Point(4, 22)
		Me.MousePage.Name = "MousePage"
		Me.MousePage.Padding = New System.Windows.Forms.Padding(3)
		Me.MousePage.Size = New System.Drawing.Size(442, 419)
		Me.MousePage.TabIndex = 1
		Me.MousePage.Text = "Mouse Mode"
		Me.MousePage.UseVisualStyleBackColor = True
		'
		'mouse_text
		'
		Me.mouse_text.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.mouse_text.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.mouse_text.Cursor = System.Windows.Forms.Cursors.Default
		Me.mouse_text.Location = New System.Drawing.Point(19, 313)
		Me.mouse_text.Name = "mouse_text"
		Me.mouse_text.Size = New System.Drawing.Size(208, 15)
		Me.mouse_text.TabIndex = 3
		Me.mouse_text.Text = "Click on the ""Reload Mouse Mode"" button"
		'
		'list_mouse
		'
		Me.list_mouse.AllowUserToAddRows = False
		Me.list_mouse.AllowUserToDeleteRows = False
		Me.list_mouse.AllowUserToOrderColumns = True
		Me.list_mouse.AllowUserToResizeRows = False
		Me.list_mouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.list_mouse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.list_mouse.Location = New System.Drawing.Point(0, 0)
		Me.list_mouse.Name = "list_mouse"
		Me.list_mouse.RowHeadersVisible = False
		Me.list_mouse.RowHeadersWidth = 33
		Me.list_mouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.list_mouse.Size = New System.Drawing.Size(252, 419)
		Me.list_mouse.TabIndex = 2
		'
		'JoystickPage
		'
		Me.JoystickPage.Controls.Add(Me.joystick_text)
		Me.JoystickPage.Controls.Add(Me.list_joystick)
		Me.JoystickPage.Location = New System.Drawing.Point(4, 22)
		Me.JoystickPage.Name = "JoystickPage"
		Me.JoystickPage.Padding = New System.Windows.Forms.Padding(3)
		Me.JoystickPage.Size = New System.Drawing.Size(442, 419)
		Me.JoystickPage.TabIndex = 2
		Me.JoystickPage.Text = "Joystick Mode*"
		Me.JoystickPage.UseVisualStyleBackColor = True
		'
		'joystick_text
		'
		Me.joystick_text.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.joystick_text.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.joystick_text.Cursor = System.Windows.Forms.Cursors.Default
		Me.joystick_text.Location = New System.Drawing.Point(19, 313)
		Me.joystick_text.Name = "joystick_text"
		Me.joystick_text.Size = New System.Drawing.Size(227, 19)
		Me.joystick_text.TabIndex = 5
		Me.joystick_text.Text = "Click on the ""Reload Joystick Mode"" button"
		'
		'list_joystick
		'
		Me.list_joystick.AllowUserToAddRows = False
		Me.list_joystick.AllowUserToDeleteRows = False
		Me.list_joystick.AllowUserToResizeRows = False
		Me.list_joystick.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.list_joystick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.list_joystick.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.list_joystick.Location = New System.Drawing.Point(0, 0)
		Me.list_joystick.Name = "list_joystick"
		Me.list_joystick.RowHeadersVisible = False
		Me.list_joystick.RowHeadersWidth = 33
		Me.list_joystick.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.list_joystick.Size = New System.Drawing.Size(252, 419)
		Me.list_joystick.TabIndex = 3
		'
		'Joystick_checker
		'
		Me.Joystick_checker.Interval = 17
		'
		'R_Hotkey
		'
		Me.R_Hotkey.AutoSize = True
		Me.R_Hotkey.Checked = True
		Me.R_Hotkey.Location = New System.Drawing.Point(274, 147)
		Me.R_Hotkey.Name = "R_Hotkey"
		Me.R_Hotkey.Size = New System.Drawing.Size(59, 17)
		Me.R_Hotkey.TabIndex = 5
		Me.R_Hotkey.TabStop = True
		Me.R_Hotkey.Text = "Hotkey"
		Me.R_Hotkey.UseVisualStyleBackColor = True
		Me.R_Hotkey.Visible = False
		'
		'R_Pressedkey
		'
		Me.R_Pressedkey.AutoSize = True
		Me.R_Pressedkey.Location = New System.Drawing.Point(368, 147)
		Me.R_Pressedkey.Name = "R_Pressedkey"
		Me.R_Pressedkey.Size = New System.Drawing.Size(80, 17)
		Me.R_Pressedkey.TabIndex = 20
		Me.R_Pressedkey.Text = "Pressedkey"
		Me.R_Pressedkey.UseVisualStyleBackColor = True
		Me.R_Pressedkey.Visible = False
		'
		'JoyInfoBox
		'
		Me.JoyInfoBox.BackColor = System.Drawing.SystemColors.Control
		Me.JoyInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.JoyInfoBox.Location = New System.Drawing.Point(276, 9)
		Me.JoyInfoBox.Name = "JoyInfoBox"
		Me.JoyInfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.JoyInfoBox.Size = New System.Drawing.Size(187, 133)
		Me.JoyInfoBox.TabIndex = 19
		Me.JoyInfoBox.Text = resources.GetString("JoyInfoBox.Text")
		Me.JoyInfoBox.Visible = False
		'
		'Hotkey_changer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(627, 612)
		Me.Controls.Add(Me.R_Pressedkey)
		Me.Controls.Add(Me.R_Hotkey)
		Me.Controls.Add(Me.JoyInfoBox)
		Me.Controls.Add(Me.Mode_tab)
		Me.Controls.Add(Me.GroupBox6)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.DoubleBuffered = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Name = "Hotkey_changer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hira's Tree of Savior Hotkey Changer v0.5.2 for iTOS@Hirasu | TOSbase.com"
		CType(Me.list_key, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.Mode_tab.ResumeLayout(False)
		Me.KeyPage.ResumeLayout(False)
		Me.MousePage.ResumeLayout(False)
		CType(Me.list_mouse, System.ComponentModel.ISupportInitialize).EndInit()
		Me.JoystickPage.ResumeLayout(False)
		CType(Me.list_joystick, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

End Sub
    Friend WithEvents list_key As System.Windows.Forms.DataGridView
    Friend WithEvents b_save As System.Windows.Forms.Button
    Friend WithEvents change_to As System.Windows.Forms.Button
    Friend WithEvents b_exit As System.Windows.Forms.Button
    Friend WithEvents change_tab As System.Windows.Forms.Button
    Friend WithEvents change_enter As System.Windows.Forms.Button
    Friend WithEvents b_reload_k As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents changinginfo As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckCTRL As System.Windows.Forms.CheckBox
    Friend WithEvents CheckSHIFT As System.Windows.Forms.CheckBox
    Friend WithEvents CheckALT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents chat_fix As System.Windows.Forms.Button
    Friend WithEvents b_reload_mouse As System.Windows.Forms.Button
    Friend WithEvents b_clear As System.Windows.Forms.Button
    Friend WithEvents Mode_tab As System.Windows.Forms.TabControl
    Friend WithEvents KeyPage As System.Windows.Forms.TabPage
    Friend WithEvents MousePage As System.Windows.Forms.TabPage
    Friend WithEvents list_mouse As System.Windows.Forms.DataGridView
    Friend WithEvents mouse_text As System.Windows.Forms.RichTextBox
    Friend WithEvents key_text As System.Windows.Forms.RichTextBox
    Friend WithEvents b_reset_default As System.Windows.Forms.Button
    Friend WithEvents JoystickPage As System.Windows.Forms.TabPage
    Friend WithEvents list_joystick As System.Windows.Forms.DataGridView
    Friend WithEvents b_reload_joystick As System.Windows.Forms.Button
    Friend WithEvents joystick_text As System.Windows.Forms.RichTextBox
    Friend WithEvents Joystick_checker As System.Windows.Forms.Timer
    Friend WithEvents R_Pressedkey As System.Windows.Forms.RadioButton
    Friend WithEvents R_Hotkey As System.Windows.Forms.RadioButton
    Friend WithEvents JoyInfoBox As System.Windows.Forms.RichTextBox

End Class
