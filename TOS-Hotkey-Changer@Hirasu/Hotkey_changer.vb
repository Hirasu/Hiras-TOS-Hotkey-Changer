Imports System.Xml

Imports System.Data
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Hotkey_changer
    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
 
    End Structure

    Dim myjoyEX As JOYINFOEX
    Public _Datafile_key As New FileInfo(Application.StartupPath & "\hotkey.xml")
    Public _Datafile_mouse As New FileInfo(Application.StartupPath & "\hotkey_mousemode.xml")
    Public _Datafile_joystick As New FileInfo(Application.StartupPath & "\hotkey_joystick.xml")
    Public _Datafile_default_key As New FileInfo(Application.StartupPath & "\hotkey_default.xml")
    Public _Datafile_default_mouse As New FileInfo(Application.StartupPath & "\hotkey_mousemode_default.xml")
    Public _Datafile_default_joystick As New FileInfo(Application.StartupPath & "\hotkey_joystick_default.xml")

    Public mode As Integer
    Public _change As New Integer
    Public _list As DataGridView
    Public can_load As Integer = "0"
    Public curColumn As Integer = 4
    Public BCodeCache As New Label
    Public JoyNumber As New Label
    Public POV As New Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF
        Me.Size = New Size(459, Me.Size.Height)
        Mode_tab.Size = New Size(260, 460)
        list_joystick.Size = New Size(252, 434)
    End Sub
    Public Sub check_mode()
        If mode = "0" Then
            _list = list_key
        ElseIf mode = "1" Then
            _list = list_mouse
        ElseIf mode = "2" Then
            _list = list_joystick
        End If
    End Sub
    Private Sub check_hold_keys()

        If _list.Rows(_list.CurrentRow.Index).Cells(5).Value = "YES" Then
            CheckSHIFT.CheckState = 1
        Else
            CheckSHIFT.CheckState = False
        End If

        If _list.Rows(_list.CurrentRow.Index).Cells(6).Value = "YES" Then
            CheckALT.CheckState = 1
        Else
            CheckALT.CheckState = False
        End If

        If _list.Rows(_list.CurrentRow.Index).Cells(7).Value = "YES" Then
            CheckCTRL.CheckState = 1
        Else
            CheckCTRL.CheckState = False
        End If
    End Sub
    Public Function Loading(ByVal _default As Integer) As Integer
        Dim xmlFile As XmlReader
        If _default < 1 Then
            xmlFile = XmlReader.Create("hotkey.xml", New XmlReaderSettings())
        Else
            xmlFile = XmlReader.Create("hotkey_default.xml", New XmlReaderSettings())
        End If

        Dim ds As New DataSet
        ds.ReadXml(xmlFile)

        list_key.DataSource = ds.Tables(0)
        list_key.Columns("ID").ReadOnly = True
        list_key.Columns("ID").HeaderText = "Name"
        list_key.Columns("KEY").ReadOnly = True
        list_key.Columns("KEY").HeaderText = "Hotkey"

        list_key.Columns(1).Visible = False
        list_key.Columns(2).Visible = False
        list_key.Columns(3).Visible = False
        list_key.Columns(5).Visible = False
        list_key.Columns(6).Visible = False
        list_key.Columns(7).Visible = False
        list_key.Columns(8).Visible = False
        list_key.Rows(103).Visible = False
        list_key.Rows(101).Visible = False
        list_key.Rows(100).Visible = False
        list_key.Rows(99).Visible = False
        list_key.Rows(98).Visible = False
        'list_key.Rows(83).Visible = False
        'list_key.Rows(82).Visible = False
        'list_key.Rows(81).Visible = False
        'list_key.Rows(80).Visible = False
        'list_key.Rows(59).Visible = False
        list_key.Rows(29).Visible = False
        list_key.Rows(19).Visible = False
        list_key.Rows(18).Visible = False
        list_key.Rows(17).Visible = False
        list_key.Rows(16).Visible = False
        list_key.Rows(1).Visible = False
        If list_key.Rows(105).Cells(4).Value = "" Then
            chat_fix.Text = "Remove Fix"
        End If
        Dim column As DataGridViewColumn = list_key.Columns(0)
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim column2 As DataGridViewColumn = list_key.Columns(4)
        column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False

        xmlFile.Close()
        Return False
    End Function



    Public Function Loading_mouse(ByVal _default As Integer) As Integer
        Dim xmlFile As XmlReader
        If _default < 1 Then
            xmlFile = XmlReader.Create("hotkey_mousemode.xml", New XmlReaderSettings())
        Else
            xmlFile = XmlReader.Create("hotkey_mousemode_default.xml", New XmlReaderSettings())
        End If
        Dim ds_mouse As New DataSet
        ds_mouse.ReadXml(xmlFile)
        xmlFile.Close()
        list_mouse.DataSource = ds_mouse.Tables(0)
        list_mouse.Columns("ID").ReadOnly = True
        list_mouse.Columns("ID").HeaderText = "Name"
        list_mouse.Columns("KEY").ReadOnly = True
        list_mouse.Columns("KEY").HeaderText = "Hotkey"
        list_mouse.Columns(1).Visible = False
        list_mouse.Columns(2).Visible = False
        list_mouse.Columns(3).Visible = False
        list_mouse.Columns(5).Visible = False
        list_mouse.Columns(6).Visible = False
        list_mouse.Columns(7).Visible = False
        list_mouse.Columns(8).Visible = False
        'list_mouse.Rows(19).Visible = False
        list_mouse.Rows(97).Visible = False
        list_mouse.Rows(95).Visible = False
        list_mouse.Rows(94).Visible = False
        list_mouse.Rows(93).Visible = False
        list_mouse.Rows(19).Visible = False
        list_mouse.Rows(18).Visible = False
        list_mouse.Rows(17).Visible = False
        list_mouse.Rows(16).Visible = False
        list_mouse.Rows(1).Visible = False
        If list_mouse.Rows(99).Cells(4).Value = "" Then
            chat_fix.Text = "Remove Fix"
        End If
        Dim column As DataGridViewColumn = list_mouse.Columns(0)
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim column2 As DataGridViewColumn = list_mouse.Columns(4)
        column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False
    End Function

    Public Function Loading_joystick(ByVal _default As Integer) As Integer
        Dim xmlFile_joy As XmlReader
        If _default < 1 Then
            xmlFile_joy = XmlReader.Create("hotkey_joystick.xml", New XmlReaderSettings())
        Else
            xmlFile_joy = XmlReader.Create("hotkey_joystick_default.xml", New XmlReaderSettings())
        End If
        Dim ds_joy As New DataSet
        ds_joy.ReadXml(xmlFile_joy)
        xmlFile_joy.Close()
        list_joystick.DataSource = ds_joy.Tables(0)
        list_joystick.Columns("ID").ReadOnly = True
        list_joystick.Columns("ID").HeaderText = "Name"
        list_joystick.Columns("KEY").ReadOnly = True
        list_joystick.Columns("KEY").HeaderText = "Hotkey"
        list_joystick.Columns(1).Visible = False
        list_joystick.Columns(2).Visible = False
        list_joystick.Columns(3).Visible = False
        list_joystick.Columns(6).Visible = False
        list_joystick.Columns(7).Visible = False
        list_joystick.Columns(8).Visible = False
        list_joystick.Columns(9).Visible = False

        list_joystick.Rows(3).Visible = False
        list_joystick.Rows(2).Visible = False
        list_joystick.Rows(1).Visible = False

        'If list_joystick.Rows(99).Cells(4).Value = "" Then
        'chat_fix.Text = "Remove Fix"
        'End If
        Dim column As DataGridViewColumn = list_joystick.Columns(0)
        column.Width = 150
        Dim column2 As DataGridViewColumn = list_joystick.Columns(4)
        column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim column3 As DataGridViewColumn = list_joystick.Columns(5)
        column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False
    End Function
    Public Function conflict_check(ByVal _key As String) As String
        check_mode()
        If mode = "2" Then
            If _list.Rows(_list.CurrentRow.Index).Cells(curColumn).Value = _key Then
            Else

                Dim Max_Row As Integer
                Max_Row = _list.Rows.Count
                For i As Integer = 0 To Max_Row - 1 Step +1
                    If _list.Rows(i).Cells(curColumn).Value = _key Then
                        _change = "0"
                        changinginfo.Text = "Choose a hotkey..."

                        Select Case MessageBox.Show(Me, "Conflict with '" & _list.Rows(i).Cells(0).Value & "' , continue?", "CONFLICT!", MessageBoxButtons.YesNo)
                            Case DialogResult.No : Return False
                            Case DialogResult.Yes
                        End Select
                    End If
                Next

                _list.Rows(_list.CurrentRow.Index).Cells(curColumn).Value = _key
            End If
        Else
            If _list.Rows(_list.CurrentRow.Index).Cells(4).Value = _key Then
            Else

                Dim Max_Row As Integer
                Max_Row = _list.Rows.Count
                For i As Integer = 0 To Max_Row - 1 Step +1
                    If _list.Rows(i).Cells(4).Value = _key Then
                        Select Case MessageBox.Show(Me, "Conflict with '" & _list.Rows(i).Cells(0).Value & "' , continue?", "CONFLICT!", MessageBoxButtons.YesNo)
                            Case DialogResult.No : Return False
                            Case DialogResult.Yes
                        End Select
                    End If
                Next

                _list.Rows(_list.CurrentRow.Index).Cells(4).Value = _key
            End If
        End If
        

        Return True
    End Function

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles change_to.KeyDown
        'MessageBox.Show(e.KeyCode)
        If Not mode = "2" Then


            If _change = "1" Then

                If e.KeyCode = Keys.F1 Then
                    conflict_check("F1")
                ElseIf e.KeyCode = Keys.F2 Then
                    conflict_check("F2")
                ElseIf e.KeyCode = Keys.F3 Then
                    conflict_check("F3")
                ElseIf e.KeyCode = Keys.F4 Then
                    conflict_check("F4")
                ElseIf e.KeyCode = Keys.F5 Then
                    conflict_check("F5")
                ElseIf e.KeyCode = Keys.F6 Then
                    conflict_check("F6")
                ElseIf e.KeyCode = Keys.F7 Then
                    conflict_check("F7")
                ElseIf e.KeyCode = Keys.F8 Then
                    conflict_check("F8")
                ElseIf e.KeyCode = Keys.F9 Then
                    conflict_check("F9")
                ElseIf e.KeyCode = Keys.F10 Then
                    conflict_check("F10")
                ElseIf e.KeyCode = Keys.F11 Then
                    conflict_check("F11")
                ElseIf e.KeyCode = Keys.F12 Then
                    conflict_check("F12")
                ElseIf e.KeyCode = Keys.NumPad0 Then
                    conflict_check("NUMPAD0")
                ElseIf e.KeyCode = Keys.NumPad1 Then
                    conflict_check("NUMPAD1")
                ElseIf e.KeyCode = Keys.NumPad2 Then
                    conflict_check("NUMPAD2")
                ElseIf e.KeyCode = Keys.NumPad3 Then
                    conflict_check("NUMPAD3")
                ElseIf e.KeyCode = Keys.NumPad4 Then
                    conflict_check("NUMPAD4")
                ElseIf e.KeyCode = Keys.NumPad5 Then
                    conflict_check("NUMPAD5")
                ElseIf e.KeyCode = Keys.NumPad6 Then
                    conflict_check("NUMPAD6")
                ElseIf e.KeyCode = Keys.NumPad7 Then
                    conflict_check("NUMPAD7")
                ElseIf e.KeyCode = Keys.NumPad8 Then
                    conflict_check("NUMPAD8")
                ElseIf e.KeyCode = Keys.NumPad9 Then
                    conflict_check("NUMPAD9")
                ElseIf e.KeyCode = Keys.Back Then
                    conflict_check("BACKSPACE")
                ElseIf e.KeyCode = Keys.PageUp Then
                    conflict_check("UP")
                ElseIf e.KeyCode = Keys.PageDown Then
                    conflict_check("DOWN")
                ElseIf e.KeyCode = Keys.Insert Then
                    conflict_check("INSERT")
                ElseIf e.KeyCode = Keys.Space Then
                    conflict_check("SPACE")
                ElseIf e.KeyCode = "188" Then
                    conflict_check(";")
                ElseIf e.KeyCode = Keys.Enter Then
                Else
                    conflict_check(Convert.ToChar(e.KeyCode))
                End If


                _change = "0"
                changinginfo.Text = "Choose a hotkey..."
            End If
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_save.Click
        check_mode()
        If mode = "0" Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list_key.DataSource.WriteXml(_Datafile_key.FullName)
                    MsgBox("Saved")           ' 
            End Select
        ElseIf mode = "1" Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list_mouse.DataSource.WriteXml(_Datafile_mouse.FullName)
                    MsgBox("Saved")
            End Select
        ElseIf mode = "2" Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list_joystick.DataSource.WriteXml(_Datafile_joystick.FullName)
                    MsgBox("Saved")
            End Select
        End If


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_exit.Click

        Select Case MessageBox.Show(Me, "Are you sure?", "Exit", MessageBoxButtons.YesNo)
            Case DialogResult.No : Return
            Case DialogResult.Yes : Me.Close()
        End Select
    End Sub

    'Private Sub StwagList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_joystick.CellClick
    'MessageBox.Show(list_joystick.CurrentRow.Index)

    'End Sub


    Private Sub changeto(sender As Object, e As EventArgs) Handles change_to.Click
        check_mode()
        If _list.CurrentRow.Index = 0 Then
            changinginfo.Text = "Cant change!"
        Else

            _change = "1"
            changinginfo.Text = "Press a button..."
        End If
    End Sub

    Private Sub Keyboard_reload(sender As Object, e As EventArgs) Handles b_reload_k.Click
        If can_load = "0" Then


            key_text.Visible = False
            can_load = "1"
            load_delay.Enabled = True
            Dim curFile As String = _Datafile_key.FullName

            If File.Exists(curFile) Then
                Loading(0)
                mode = "0"
            Else
                MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                Me.Close()
            End If
            If list_key.Rows.Count > 1 Then
                change_to.Enabled = True
                change_tab.Enabled = True
                change_enter.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_arrow.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub Mouse_reload(sender As Object, e As EventArgs) Handles b_reload_mouse.Click
        If can_load = "0" Then

            mouse_text.Visible = False
            can_load = "1"
            load_delay.Enabled = True
            Dim curFile_mouse As String = _Datafile_mouse.FullName

            If File.Exists(curFile_mouse) Then
                Loading_mouse(0)

            Else
                MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                Me.Close()
            End If
            If list_mouse.Rows.Count > 1 Then
                change_to.Enabled = True
                change_tab.Enabled = True
                change_enter.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_arrow.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub Joystick_reload(sender As Object, e As EventArgs) Handles b_reload_joystick.Click
        If can_load = "0" Then

            joystick_text.Visible = False
            can_load = "1"
            load_delay.Enabled = True
            Dim curFile_joystick As String = _Datafile_joystick.FullName

            If File.Exists(curFile_joystick) Then
                Loading_joystick(0)

            Else
                MessageBox.Show("Can't find 'hotkey_joystick.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                Me.Close()
            End If
            If list_joystick.Rows.Count > 1 Then
                change_to.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub changetab(sender As Object, e As EventArgs) Handles change_tab.Click

        conflict_check("TAB")
    End Sub

    Private Sub changeenter(sender As Object, e As EventArgs) Handles change_enter.Click
        conflict_check("ENTER")
    End Sub

    Private Sub chatfix(sender As Object, e As EventArgs) Handles chat_fix.Click
        check_mode()
        If mode = "0" Then
            If _list.Rows(105).Cells(4).Value = "TAB" Then
                _list.Rows(105).Cells(4).Value = ""
                MessageBox.Show("Fixed!")
                chat_fix.Text = "Remove Fix"
            Else
                _list.Rows(105).Cells(4).Value = "TAB"
                MessageBox.Show("Removed!")
                chat_fix.Text = "Fix Chat Type"
            End If

        ElseIf mode = "1" Then
            If _list.Rows(99).Cells(4).Value = "TAB" Then
                _list.Rows(99).Cells(4).Value = ""
                MessageBox.Show("Fixed!")
                chat_fix.Text = "Remove Fix"
            Else
                _list.Rows(99).Cells(4).Value = "TAB"
                MessageBox.Show("Removed!")
                chat_fix.Text = "Fix Chat Type"
            End If
        ElseIf mode = "2" Then
            If _list.Rows(99).Cells(4).Value = "TAB" Then
                _list.Rows(99).Cells(4).Value = ""
                MessageBox.Show("Fixed!")
                chat_fix.Text = "Remove Fix"
            Else
                _list.Rows(99).Cells(4).Value = "TAB"
                MessageBox.Show("Removed!")
                chat_fix.Text = "Fix Chat Type"
            End If
        End If

    End Sub



    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        check_mode()
        _list.Rows(_list.CurrentRow.Index).Cells(4).Value = ""
    End Sub

    Private Sub oncellclick(sender As Object, e As EventArgs) Handles list_key.CellClick
        check_mode()
        check_hold_keys()
    End Sub
    Private Sub oncellclick_mouse(sender As Object, e As EventArgs) Handles list_mouse.CellClick
        check_mode()
        check_hold_keys()
    End Sub

    Private Sub Page_key_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        mode = "0"
        check_mode()
        _change = "0"
        changinginfo.Text = "Choose a hotkey..."
        Joystick_checker.Stop()
        Me.Size = New Size(459, Me.Size.Height)
        Mode_tab.Size = New Size(260, 460)
        list_joystick.Size = New Size(252, 434)
        JoyInfoBox.Visible = False
        CheckALT.Enabled = True
        CheckSHIFT.Enabled = True
        CheckCTRL.Enabled = True
        R_Hotkey.Visible = False
        R_Pressedkey.Visible = False
        If list_key.Rows.Count > 1 Then
            change_to.Enabled = True
            change_tab.Enabled = True
            change_enter.Enabled = True
            b_clear.Enabled = True
            chat_fix.Enabled = True
            b_save.Enabled = True
            b_reset_arrow.Enabled = True
            b_reset_default.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False
            b_reset_arrow.Enabled = False
            b_reset_default.Enabled = False
        End If
    End Sub

    Private Sub Page_mouse_Click(sender As Object, e As EventArgs) Handles TabPage2.Enter
        mode = "1"

        check_mode()
        _change = "0"
        changinginfo.Text = "Choose a hotkey..."
        Joystick_checker.Stop()
        Me.Size = New Size(459, Me.Size.Height)
        Mode_tab.Size = New Size(260, 460)
        list_joystick.Size = New Size(252, 434)
        JoyInfoBox.Visible = False
        CheckALT.Enabled = True
        CheckSHIFT.Enabled = True
        CheckCTRL.Enabled = True
        R_Hotkey.Visible = False
        R_Pressedkey.Visible = False
        If list_mouse.Rows.Count > 1 Then
            change_to.Enabled = True
            change_tab.Enabled = True
            change_enter.Enabled = True
            b_clear.Enabled = True
            chat_fix.Enabled = True
            b_save.Enabled = True
            b_reset_arrow.Enabled = True
            b_reset_default.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False
            b_reset_arrow.Enabled = False
            b_reset_default.Enabled = False
        End If

    End Sub
    Private Sub Page_Joystick_Click(sender As Object, e As EventArgs) Handles TabPage3.Enter
        mode = "2"
        check_mode()
        Me.Size = New Size(643, Me.Size.Height)
        Mode_tab.Size = New Size(450, 460)
        list_joystick.Size = New Size(442, 434)
        JoyInfoBox.Visible = True
        Joystick_checker.Interval = 17
        Joystick_checker.Start()
        CheckALT.Enabled = False
        CheckSHIFT.Enabled = False
        CheckCTRL.Enabled = False
        R_Hotkey.Visible = True
        R_Pressedkey.Visible = True
        If list_joystick.Rows.Count > 1 Then
            change_to.Enabled = True
            b_clear.Enabled = True
            chat_fix.Enabled = True
            b_save.Enabled = True
            b_reset_default.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False
            b_reset_arrow.Enabled = False
            b_reset_default.Enabled = False
        End If

    End Sub


    Private Sub load_delay_Tick(sender As Object, e As EventArgs) Handles load_delay.Tick
        can_load = "0"
        load_delay.Enabled = False
    End Sub

    Private Sub b_reset_arrow_Click(sender As Object, e As EventArgs) Handles b_reset_arrow.Click
        If mode = "0" Then
            _list.Rows(83).Cells(4).Value = "RIGHT"
            _list.Rows(82).Cells(4).Value = "LEFT"
            _list.Rows(81).Cells(4).Value = "DOWN"
            _list.Rows(80).Cells(4).Value = "UP"
        ElseIf mode = "1" Then
            _list.Rows(82).Cells(4).Value = "RIGHT"
            _list.Rows(81).Cells(4).Value = "LEFT"
            _list.Rows(80).Cells(4).Value = "DOWN"
            _list.Rows(79).Cells(4).Value = "UP"
        End If
    End Sub
    Public Sub update_hold()
        If CheckSHIFT.Checked = True Then
            _list.Rows(_list.CurrentRow.Index).Cells(5).Value = "YES"
        Else
            _list.Rows(_list.CurrentRow.Index).Cells(5).Value = "NO"
        End If
        If CheckALT.Checked = True Then
            _list.Rows(_list.CurrentRow.Index).Cells(6).Value = "YES"
        Else
            _list.Rows(_list.CurrentRow.Index).Cells(6).Value = "NO"
        End If
        If CheckCTRL.Checked = True Then
            _list.Rows(_list.CurrentRow.Index).Cells(7).Value = "YES"
        Else
            _list.Rows(_list.CurrentRow.Index).Cells(7).Value = "NO"
        End If
    End Sub
    Private Sub CheckALT_CheckedChanged(sender As Object, e As EventArgs) Handles CheckALT.CheckedChanged
        update_hold()
    End Sub

    Private Sub CheckSHIFT_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSHIFT.CheckedChanged
        update_hold()
    End Sub

    Private Sub CheckCTRL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCTRL.CheckedChanged
        update_hold()
    End Sub

    Private Sub b_reset_default_Click(sender As Object, e As EventArgs) Handles b_reset_default.Click
        Select Case MessageBox.Show(Me, "Are you sure?", "Reset to default", MessageBoxButtons.YesNo)
            Case DialogResult.No : Return
            Case DialogResult.Yes
                If mode = "0" Then
                    Dim curFile As String = _Datafile_default_key.FullName

                    If File.Exists(curFile) Then
                        Loading(1)
                    Else
                        MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                        Me.Close()
                    End If

                ElseIf mode = "1" Then
                    Dim curFile_mouse As String = _Datafile_default_mouse.FullName

                    If File.Exists(curFile_mouse) Then
                        Loading_mouse(1)
                    Else
                        MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                        Me.Close()
                    End If
                ElseIf mode = "2" Then
                    Dim curFile_joystick As String = _Datafile_default_joystick.FullName

                    If File.Exists(curFile_joystick) Then
                        Loading_joystick(1)
                    Else
                        MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
                        Me.Close()
                    End If
                End If
        End Select
    End Sub


    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles JoyInfoBox.TextChanged

    End Sub

    Private Sub Joystick_checker_Tick(sender As Object, e As EventArgs) Handles Joystick_checker.Tick
        If _change = "1" Then


            ' Get the joystick information
            Call joyGetPosEx(0, myjoyEX)

            With myjoyEX
                BCodeCache.Text = .dwButtons.ToString("X")  'Print in Hex, so can see the individual bits associated with the buttons
                JoyNumber.Text = .dwButtonNumber.ToString  'number of buttons pressed at the same time
                POV.Text = (.dwPOV / 100).ToString     'POV hat (in 1/100ths of degrees, so divided by 100 to give degrees)

                If .dwZpos >= 34000 Then
                    'LKeyPressed.Text = "LT"
                    conflict_check("JOY_BTN_7")
                ElseIf .dwZpos <= 30000 Then
                    ' LKeyPressed.Text = "RT"
                    conflict_check("JOY_BTN_8")
                End If

                If BCodeCache.Text = "1" Then
                    'LKeyPressed.Text = "A"
                    conflict_check("JOY_BTN_2")
                ElseIf BCodeCache.Text = "2" Then
                    'LKeyPressed.Text = "B"
                    conflict_check("JOY_BTN_3")
                ElseIf BCodeCache.Text = "4" Then
                    'LKeyPressed.Text = "X"
                    conflict_check("JOY_BTN_1")
                ElseIf BCodeCache.Text = "8" Then
                    ' LKeyPressed.Text = "Y"
                    conflict_check("JOY_BTN_4")
                ElseIf BCodeCache.Text = "10" Then
                    ' LKeyPressed.Text = "LB"
                    conflict_check("JOY_BTN_5")
                ElseIf BCodeCache.Text = "20" Then
                    ' LKeyPressed.Text = "RB"
                    conflict_check("JOY_BTN_6")
                ElseIf BCodeCache.Text = "40" Then
                    '  LKeyPressed.Text = "NEXT_BUTTON"
                    conflict_check("JOY_BTN_9")
                ElseIf BCodeCache.Text = "80" Then
                    '  LKeyPressed.Text = "START_BUTTON"
                    conflict_check("JOY_BTN_10")
                ElseIf BCodeCache.Text = "100" Then
                    ' LKeyPressed.Text = "LSTICK_BUTTON"
                    conflict_check("JOY_BTN_11")
                ElseIf BCodeCache.Text = "200" Then
                    ' LKeyPressed.Text = "RSTICK_BUTTON"
                    conflict_check("JOY_BTN_12")
                ElseIf POV.Text = "0" Then
                    ' LKeyPressed.Text = "CROSS_UP"
                    conflict_check("JOY_CROSS_UP")
                ElseIf POV.Text = "180" Then
                    ' LKeyPressed.Text = "CROSS_DOWN"
                    conflict_check("JOY_CROSS_DOWN")
                ElseIf POV.Text = "90" Then
                    ' LKeyPressed.Text = "CROSS_RIGHT"
                    conflict_check("JOY_CROSS_RIGHT")
                ElseIf POV.Text = "270" Then
                    'LKeyPressed.Text = "CROSS_LEFT"
                    conflict_check("JOY_CROSS_LEFT")
                End If

            End With

        End If

    End Sub

    Private Sub R_Hotkey_CheckedChanged(sender As Object, e As EventArgs) Handles R_Hotkey.CheckedChanged
        If R_Hotkey.Checked = True Then
            R_Pressedkey.Checked = False
            curColumn = 4
        End If
        If R_Hotkey.Checked = False Then
            R_Pressedkey.Checked = True
            curColumn = 5
        End If
    End Sub

    Private Sub R_Pressedkey_CheckedChanged(sender As Object, e As EventArgs) Handles R_Pressedkey.CheckedChanged
        If R_Pressedkey.Checked = True Then
            R_Hotkey.Checked = False
            curColumn = 5
        End If
        If R_Pressedkey.Checked = False Then
            R_Hotkey.Checked = True
            curColumn = 4
        End If
    End Sub
End Class
