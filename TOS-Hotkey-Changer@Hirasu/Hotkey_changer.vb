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
    Private _Datafile_key As New FileInfo(Application.StartupPath & "\hotkey.xml")
    Private _Datafile_mouse As New FileInfo(Application.StartupPath & "\hotkey_mousemode.xml")
	Private _Datafile_joystick As New FileInfo(Application.StartupPath & "\hotkey_joystick.xml")
	Private _Datafile_key_User As New FileInfo(Application.StartupPath & "\hotkey_user.xml")
	Private _Datafile_mouse_User As New FileInfo(Application.StartupPath & "\hotkey_mousemode_user.xml")
	Private _Datafile_joystick_User As New FileInfo(Application.StartupPath & "\hotkey_joystick_user.xml")
    Private _Datafile_default_key As New FileInfo(Application.StartupPath & "\hotkey_default.xml")
    Private _Datafile_default_mouse As New FileInfo(Application.StartupPath & "\hotkey_mousemode_default.xml")
    Private _Datafile_default_joystick As New FileInfo(Application.StartupPath & "\hotkey_joystick_default.xml")
	Private _CurDataFile_Key As String
	Private _CurDataFile_Mouse As String
	Private _CurDataFile_Joystick As String

    Private mode As Integer
    Private _change As New Integer
    Private _list As DataGridView
    Private can_load As Integer = 0
    Private curColumn As Integer = 4
    Private BCodeCache As New Label
    Private JoyNumber As New Label
    Private POV As New Label


    Dim myList As ArrayList
    Private Sub Initialize(sender As Object, e As EventArgs) Handles MyBase.Load
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF
        resize_default()
        list_key.RowHeadersVisible = False
        list_mouse.RowHeadersVisible = False
        list_joystick.RowHeadersVisible = False
        _list = list_key
    End Sub

    Private Sub resize_default()
        Me.Size = New Size(459, Me.Size.Height)
        Mode_tab.Size = New Size(260, Mode_tab.Height)
        list_joystick.Size = New Size(252, list_joystick.Height)
    End Sub
    Private Sub resize_joystick()
        Me.Size = New Size(643, Me.Size.Height)
        Mode_tab.Size = New Size(450, Mode_tab.Height)
        list_joystick.Size = New Size(442, list_joystick.Height)
    End Sub

    Private Sub check_mode()
        If mode = 0 Then
            _list = list_key
        ElseIf mode = 1 Then
            _list = list_mouse
        ElseIf mode = 2 Then
            _list = list_joystick
        End If
    End Sub
    Private Sub Stop_Edit()
        _change = 0
        changinginfo.Text = "Choose a hotkey..."
    End Sub
    Private Sub Start_Edit()
        check_mode()
        If _list.CurrentRow.Index = 0 Then
            changinginfo.Text = "Cant change!"
        Else
            _change = 1
            changinginfo.Text = "Press a button..."
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

    Private Sub Check_ChatFix()
        Dim Max_Row As Integer
        Max_Row = _list.Rows.Count
        For i As Integer = 0 To Max_Row - 1 Step +1
            If _list.Rows(i).Cells(0).Value = "ChatType" Then
                If _list.Rows(i).Cells(4).Value = "TAB" Then
                    chat_fix.Text = "Fix Chat Type"
                Else
                    chat_fix.Text = "Remove Fix"
                End If
            End If
            
        Next
    End Sub

    Private Function Loading(ByVal _default As Integer) As Integer
        Dim xmlFile As XmlReader
        If _default < 1 Then
			xmlFile = XmlReader.Create(_CurDataFile_Key, New XmlReaderSettings())
        Else
			xmlFile = XmlReader.Create(_Datafile_default_key.FullName, New XmlReaderSettings())
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
        list_key.Columns(9).Visible = False



        Check_ChatFix()
        Dim columnName As DataGridViewColumn = list_key.Columns(0)
        columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim columnHotkey As DataGridViewColumn = list_key.Columns(4)
        columnHotkey.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False

        xmlFile.Close()
        Return False
    End Function



    Private Function Loading_mouse(ByVal _default As Integer) As Integer
        Dim xmlFile_mouse As XmlReader
        If _default < 1 Then
			xmlFile_mouse = XmlReader.Create(_CurDataFile_Mouse, New XmlReaderSettings())
        Else
			xmlFile_mouse = XmlReader.Create(_Datafile_default_mouse.FullName, New XmlReaderSettings())
        End If
        Dim ds_mouse As New DataSet
        ds_mouse.ReadXml(xmlFile_mouse)
        xmlFile_mouse.Close()
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
        list_mouse.Columns(9).Visible = False

        If list_mouse.Rows(99).Cells(4).Value = "" Then
            chat_fix.Text = "Remove Fix"
        End If
        Dim columnName As DataGridViewColumn = list_mouse.Columns(0)
        columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim columnHotkey As DataGridViewColumn = list_mouse.Columns(4)
        columnHotkey.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False
    End Function

    Private Function Loading_joystick(ByVal _default As Integer) As Integer
        Dim xmlFile_joy As XmlReader
        If _default < 1 Then
			xmlFile_joy = XmlReader.Create(_CurDataFile_Joystick, New XmlReaderSettings())
        Else
			xmlFile_joy = XmlReader.Create(_Datafile_default_joystick.FullName, New XmlReaderSettings())
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
        list_joystick.Columns(10).Visible = False
        list_joystick.Columns(11).Visible = False

        Dim columnName As DataGridViewColumn = list_joystick.Columns(0)
        columnName.Width = 150
        Dim columnHotkey As DataGridViewColumn = list_joystick.Columns(4)
        columnHotkey.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dim columnPressedKey As DataGridViewColumn = list_joystick.Columns(5)
        columnPressedKey.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Return False
    End Function
    Private Function conflict_check(ByVal _key As String) As String
        check_mode()
        If mode = 2 Then
            If _list.Rows(_list.CurrentRow.Index).Cells(curColumn).Value = _key Then
                Stop_Edit()
            Else
                Stop_Edit()
                Dim Conflict_List As New ArrayList
                Dim Max_Row As Integer
                Max_Row = _list.Rows.Count
                For i As Integer = 0 To Max_Row - 1 Step +1
                    If _list.Rows(i).Cells(curColumn).Value Is _key Then

                        Conflict_List.Add(_list.Rows(i).Cells(0).Value)


                    End If
                Next
                If Conflict_List.Count > 0 Then
                    Dim Conflict_Message = String.Join(Environment.NewLine, Conflict_List.ToArray())
                    Select Case MessageBox.Show(Me, "Conflict with:" & vbCrLf & vbCrLf & Conflict_Message & vbCrLf & vbCrLf & "Continue?", "CONFLICT!", MessageBoxButtons.YesNo)
                        Case DialogResult.No : Return False
                        Case DialogResult.Yes
                    End Select
                End If

                _list.Rows(_list.CurrentRow.Index).Cells(curColumn).Value = _key

            End If
        Else
            If _list.Rows(_list.CurrentRow.Index).Cells(4).Value = _key Then
            Else

                Dim Conflict_List As New ArrayList
                Dim Max_Row As Integer
                Max_Row = _list.Rows.Count
                For i As Integer = 0 To Max_Row - 1 Step +1
                    If _list.Rows(i).Cells(curColumn).Value = _key Then
                        Conflict_List.Add(_list.Rows(i).Cells(0).Value.ToString)
                    End If
                Next
                If Conflict_List IsNot Nothing Then
                    Dim Conflict_Message = String.Join(Environment.NewLine, Conflict_List.ToArray())
                    Select Case MessageBox.Show(Me, "Conflict with:" & vbCrLf & vbCrLf & Conflict_Message & vbCrLf & vbCrLf & "Continue?", "CONFLICT!", MessageBoxButtons.YesNo)
                        Case DialogResult.No : Return False
                        Case DialogResult.Yes
                    End Select
                End If

                _list.Rows(_list.CurrentRow.Index).Cells(4).Value = _key
            End If
        End If


        Return True
    End Function





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_save.Click
        check_mode()
        If mode = 0 Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
				Case DialogResult.Yes : list_key.DataSource.WriteXml(_CurDataFile_Key)
					MsgBox("Saved")			  ' 
			End Select
        ElseIf mode = 1 Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
				Case DialogResult.Yes : list_mouse.DataSource.WriteXml(_CurDataFile_Mouse)
					MsgBox("Saved")
			End Select
        ElseIf mode = 2 Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
				Case DialogResult.Yes : list_joystick.DataSource.WriteXml(_CurDataFile_Joystick)
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


    Private Sub changeto(sender As Object, e As EventArgs) Handles change_to.Click
        Start_Edit()
    End Sub

    Private Sub Keyboard_reload(sender As Object, e As EventArgs) Handles b_reload_k.Click
        If _list Is list_key Then
            key_text.Visible = False

			If File.Exists(_Datafile_key_User.FullName) Then
				_CurDataFile_Key = _Datafile_key_User.FullName
				Loading(0)
				mode = 0
			Else
				If File.Exists(_Datafile_key.FullName) Then
					_CurDataFile_Key = _Datafile_key.FullName
					Loading(0)
					mode = 0
				Else
					MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
					Me.Close()
				End If
			End If
            If list_key.Rows.Count > 1 And _list Is list_key Then
                change_to.Enabled = True
                change_tab.Enabled = True
                change_enter.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub Mouse_reload(sender As Object, e As EventArgs) Handles b_reload_mouse.Click
        If _list Is list_mouse Then

            mouse_text.Visible = False
			If File.Exists(_Datafile_mouse_User.FullName) Then
				_CurDataFile_Mouse = _Datafile_mouse_User.FullName
				Loading_mouse(0)
				mode = 0
			Else
				If File.Exists(_Datafile_mouse.FullName) Then
					_CurDataFile_Mouse = _Datafile_mouse.FullName
					Loading_mouse(0)
					mode = 0
				Else
					MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
					Me.Close()
				End If
			End If
            If list_mouse.Rows.Count > 1 And _list Is list_mouse Then
                change_to.Enabled = True
                change_tab.Enabled = True
                change_enter.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub Joystick_reload(sender As Object, e As EventArgs) Handles b_reload_joystick.Click
        If _list Is list_joystick Then

            joystick_text.Visible = False
			If File.Exists(_Datafile_joystick_User.FullName) Then
				_CurDataFile_Joystick = _Datafile_joystick_User.FullName
				Loading_joystick(0)
				mode = 0
			Else
				If File.Exists(_Datafile_joystick.FullName) Then
					_CurDataFile_Joystick = _Datafile_joystick.FullName
					Loading_joystick(0)
					mode = 0
				Else
					MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
					Me.Close()
				End If
			End If
            If list_joystick.Rows.Count > 1 And _list Is list_joystick Then
                change_tab.Enabled = True
                change_enter.Enabled = True
                change_to.Enabled = True
                b_clear.Enabled = True
                chat_fix.Enabled = True
                b_save.Enabled = True
                b_reset_default.Enabled = True
            End If
        End If
    End Sub

    Private Sub changetab(sender As Object, e As EventArgs) Handles change_tab.Click
        If _change = 0 Then

        End If
        conflict_check("TAB")
    End Sub

    Private Sub changeenter(sender As Object, e As EventArgs) Handles change_enter.Click
        conflict_check("ENTER")
    End Sub

    Private Sub chatfix(sender As Object, e As EventArgs) Handles chat_fix.Click
        check_mode()
        If mode = 0 Then
            Dim Max_Row As Integer
            Max_Row = _list.Rows.Count
            For i As Integer = 0 To Max_Row - 1 Step +1
                If _list.Rows(i).Cells(0).Value = "ChatType" Then
                    If _list.Rows(i).Cells(4).Value = "TAB" Then
                        _list.Rows(i).Cells(4).Value = ""
                    Else
                        _list.Rows(i).Cells(4).Value = "TAB"
                    End If
                End If
                If _list.Rows(i).Cells(0).Value = "ChatFrameType" Then
                    If _list.Rows(i).Cells(4).Value = "TAB" Then
                        _list.Rows(i).Cells(4).Value = ""
                    Else
                        _list.Rows(i).Cells(4).Value = "TAB"
                    End If
                End If
                If _list.Rows(i).Cells(0).Value = "ChatFrameType2" Then
                    If _list.Rows(i).Cells(4).Value = "TAB" Then
                        _list.Rows(i).Cells(4).Value = ""
                        MessageBox.Show("Fixed!")
                        chat_fix.Text = "Remove Fix"
                    Else
                        _list.Rows(i).Cells(4).Value = "TAB"
                        MessageBox.Show("Removed!")
                        chat_fix.Text = "Fix Chat Type"
                    End If
                End If
            Next

        Else
            Dim Max_Row As Integer
            Max_Row = _list.Rows.Count
            For i As Integer = 0 To Max_Row - 1 Step +1
                If _list.Rows(i).Cells(0).Value = "ChatType" Then
                    If _list.Rows(i).Cells(4).Value = "TAB" Then
                        _list.Rows(i).Cells(4).Value = ""
                        MessageBox.Show("Fixed!")
                        chat_fix.Text = "Remove Fix"
                    Else
                        _list.Rows(i).Cells(4).Value = "TAB"
                        MessageBox.Show("Removed!")
                        chat_fix.Text = "Fix Chat Type"
                    End If
                End If
            Next
        End If

    End Sub



    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        check_mode()
        _list.Rows(_list.CurrentRow.Index).Cells(4).Value = ""
        If mode = 2 Then
            _list.Rows(_list.CurrentRow.Index).Cells(5).Value = ""
        End If
    End Sub

    Private Sub oncellclick(sender As Object, e As EventArgs) Handles list_key.CellClick
        check_mode()
        check_hold_keys()
        Stop_Edit()
    End Sub
    Private Sub oncellclick_mouse(sender As Object, e As EventArgs) Handles list_mouse.CellClick
        check_mode()
        check_hold_keys()
        Stop_Edit()
    End Sub

    Private Sub oncellclick_joystick(sender As Object, e As EventArgs) Handles list_joystick.CellClick
        If list_joystick.CurrentCell.ColumnIndex = 4 Then
            R_Hotkey.Checked = True
            R_Pressedkey.Checked = False
        Else
            R_Pressedkey.Checked = True
            R_Hotkey.Checked = False
        End If

        Stop_Edit()
    End Sub
    Private Sub oncelldoubleclick(sender As Object, e As EventArgs) Handles list_key.CellMouseDoubleClick
        Start_Edit()
    End Sub
    Private Sub oncelldoubleclick_mouse(sender As Object, e As EventArgs) Handles list_mouse.CellMouseDoubleClick
        Start_Edit()
    End Sub
    Private Sub oncelldoubleclick_joystick(sender As Object, e As EventArgs) Handles list_joystick.CellMouseDoubleClick

        Start_Edit()
    End Sub

    Private Sub Page_key_Click(sender As Object, e As EventArgs) Handles KeyPage.Enter
        mode = 0
        check_mode()
        resize_default()
        Check_ChatFix()
        Joystick_checker.Stop()
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

            b_reset_default.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False

            b_reset_default.Enabled = False
        End If
    End Sub

    Private Sub Page_mouse_Click(sender As Object, e As EventArgs) Handles MousePage.Enter
        mode = 1
        check_mode()
        resize_default()
        Check_ChatFix()
        Joystick_checker.Stop()
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

            b_reset_default.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False

            b_reset_default.Enabled = False
        End If

    End Sub
    Private Sub Page_Joystick_Click(sender As Object, e As EventArgs) Handles JoystickPage.Enter
        mode = 2
        check_mode()
        resize_joystick()
        Check_ChatFix()
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
            change_tab.Enabled = True
            change_enter.Enabled = True
            b_clear.Enabled = True

        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False

            b_reset_default.Enabled = False
        End If

    End Sub




    Private Sub update_hold()
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
				If mode = 0 Then
					If File.Exists(_Datafile_default_key.FullName) Then
						Loading(1)
					Else
						MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
						Me.Close()
					End If

				ElseIf mode = 1 Then
					If File.Exists(_Datafile_default_mouse.FullName) Then
						Loading_mouse(1)
					Else
						MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
						Me.Close()
					End If
				ElseIf mode = 2 Then
					If File.Exists(_Datafile_default_joystick.FullName) Then
						Loading_joystick(1)
					Else
						MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
						Me.Close()
					End If
				End If
        End Select
    End Sub

    Private Sub Joystick_checker_Tick(sender As Object, e As EventArgs) Handles Joystick_checker.Tick
        If _change = 1 Then



            Call joyGetPosEx(0, myjoyEX)

            With myjoyEX 'Source https://social.msdn.microsoft.com/Forums/vstudio/en-US/af28b35b-d756-4d87-94c6-ced882ab20a5/reading-input-data-from-joystick-in-visual-basic?forum=vbgeneral
                BCodeCache.Text = .dwButtons.ToString("X")
                JoyNumber.Text = .dwButtonNumber.ToString
                POV.Text = (.dwPOV / 100).ToString

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

    Private Sub Hotkeychanger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Not mode = 2 Then
            If _change = 1 Then
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
                ElseIf e.KeyCode = Keys.Up Then
                    conflict_check("UP")
                ElseIf e.KeyCode = Keys.Down Then
                    conflict_check("DOWN")
                ElseIf e.KeyCode = Keys.Left Then
                    conflict_check("LEFT")
                ElseIf e.KeyCode = Keys.Down Then
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
                Stop_Edit()
            End If
        End If
    End Sub


End Class
