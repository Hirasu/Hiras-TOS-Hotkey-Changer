<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.list = New System.Windows.Forms.DataGridView()
        Me.b_save = New System.Windows.Forms.Button()
        Me.change_to = New System.Windows.Forms.Button()
        Me.b_exit = New System.Windows.Forms.Button()
        Me.change_tab = New System.Windows.Forms.Button()
        Me.change_enter = New System.Windows.Forms.Button()
        Me.b_reload_k = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.b_clear = New System.Windows.Forms.Button()
        CType(Me.list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.list.Location = New System.Drawing.Point(13, 155)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(260, 390)
        Me.list.TabIndex = 1
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(35, 15)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(74, 23)
        Me.b_save.TabIndex = 4
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'change_to
        '
        Me.change_to.Location = New System.Drawing.Point(34, 15)
        Me.change_to.Name = "change_to"
        Me.change_to.Size = New System.Drawing.Size(83, 23)
        Me.change_to.TabIndex = 5
        Me.change_to.Text = "Change to..."
        Me.change_to.UseVisualStyleBackColor = True
        '
        'b_exit
        '
        Me.b_exit.Location = New System.Drawing.Point(35, 100)
        Me.b_exit.Name = "b_exit"
        Me.b_exit.Size = New System.Drawing.Size(74, 23)
        Me.b_exit.TabIndex = 6
        Me.b_exit.Text = "Exit"
        Me.b_exit.UseVisualStyleBackColor = True
        '
        'change_tab
        '
        Me.change_tab.Location = New System.Drawing.Point(21, 44)
        Me.change_tab.Name = "change_tab"
        Me.change_tab.Size = New System.Drawing.Size(106, 23)
        Me.change_tab.TabIndex = 7
        Me.change_tab.Text = "Change to TAB"
        Me.change_tab.UseVisualStyleBackColor = True
        '
        'change_enter
        '
        Me.change_enter.Location = New System.Drawing.Point(21, 73)
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
        Me.b_reload_k.Text = "Reload Keyboard mode"
        Me.b_reload_k.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.b_clear)
        Me.GroupBox1.Controls.Add(Me.change_to)
        Me.GroupBox1.Controls.Add(Me.change_tab)
        Me.GroupBox1.Controls.Add(Me.change_enter)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 132)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_reload_mouse)
        Me.GroupBox2.Controls.Add(Me.b_exit)
        Me.GroupBox2.Controls.Add(Me.b_save)
        Me.GroupBox2.Controls.Add(Me.b_reload_k)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 131)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
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
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(287, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 66)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 17)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(106, 40)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Click on a hotkey in the list when press a ""Change to"" button"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.changinginfo)
        Me.GroupBox4.Location = New System.Drawing.Point(287, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 43)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'changinginfo
        '
        Me.changinginfo.BackColor = System.Drawing.SystemColors.Control
        Me.changinginfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.changinginfo.Location = New System.Drawing.Point(27, 17)
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
        Me.PictureBox1.Location = New System.Drawing.Point(13, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckCTRL)
        Me.GroupBox5.Controls.Add(Me.CheckSHIFT)
        Me.GroupBox5.Controls.Add(Me.CheckALT)
        Me.GroupBox5.Location = New System.Drawing.Point(288, 78)
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
        Me.GroupBox6.Controls.Add(Me.RichTextBox2)
        Me.GroupBox6.Controls.Add(Me.chat_fix)
        Me.GroupBox6.Location = New System.Drawing.Point(288, 149)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(146, 78)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 13)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(128, 27)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = "Fix the ALT/SHIFT+TAB Chat type changing"
        '
        'chat_fix
        '
        Me.chat_fix.Location = New System.Drawing.Point(34, 44)
        Me.chat_fix.Name = "chat_fix"
        Me.chat_fix.Size = New System.Drawing.Size(83, 23)
        Me.chat_fix.TabIndex = 0
        Me.chat_fix.Text = "Fix Chat Type"
        Me.chat_fix.UseVisualStyleBackColor = True
        '
        'b_clear
        '
        Me.b_clear.Location = New System.Drawing.Point(34, 102)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(83, 23)
        Me.b_clear.TabIndex = 9
        Me.b_clear.Text = "Clear"
        Me.b_clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 557)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.list)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hira's Tree of Savior Hotkey Changer v0.2@Hirasu"
        CType(Me.list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list As System.Windows.Forms.DataGridView
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

End Class
