Imports System.Xml

Imports System.Data
Imports System.IO

Public Class Form1
    Private _Datafile As New FileInfo(Application.StartupPath & "\hotkey.xml")
    Private _Datafile2 As New FileInfo(Application.StartupPath & "\hotkey_mousemode.xml")
    Public mode As Integer
    Private _change As New Integer
    Public _list As DataGridView
    Private can_load As Integer = "0"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub check_mode()
        If mode = "0" Then
            _list = list_key
        Else
            _list = list_mouse
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
    Private Sub Loading()
        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create("hotkey.xml", New XmlReaderSettings())
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
        list_key.Rows(83).Visible = False
        list_key.Rows(82).Visible = False
        list_key.Rows(81).Visible = False
        list_key.Rows(80).Visible = False
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



        xmlFile.Close()
    End Sub

    Private Sub Loading_mouse()
        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create("hotkey_mousemode.xml", New XmlReaderSettings())
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

    End Sub

    Public Function conflict_check(ByVal _key As String) As String
        check_mode()
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
            _list.Rows(_list.CurrentRow.Index).Cells(4).Value = _key
        End If
 
    End Function

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles change_to.KeyDown
        'MessageBox.Show(e.KeyCode)
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
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_save.Click
        check_mode()
        If mode = "0" Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list_key.DataSource.WriteXml(_Datafile.FullName)
                    MsgBox("Saved")           ' 
            End Select
        Else
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list_mouse.DataSource.WriteXml(_Datafile2.FullName)
                    MsgBox("Saved")
            End Select
        End If


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_exit.Click

        Select Case MessageBox.Show(Me, "Are you sure?", "Exit", MessageBoxButtons.YesNo)
            Case DialogResult.No : Return           'nix tun: schließen ohne speichern
            Case DialogResult.Yes : Me.Close()          ' schließen mit speichern
        End Select
    End Sub

    'Private Sub StwagList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_key.CellClick
    '    MessageBox.Show(list_key.CurrentRow.Index)

    ' End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles change_to.Click
        check_mode()
        If _list.CurrentRow.Index = 0 Then
            changinginfo.Text = "Cant change Chat!"
        Else
            _change = "1"
            changinginfo.Text = "Press a button..."
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles b_reload_k.Click
        If can_load = "0" Then
            
            
            key_text.Visible = False
            can_load = "1"
            load_delay.Enabled = True
            Dim curFile As String = _Datafile.FullName

            If File.Exists(curFile) Then
                Loading()
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
            End If
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles b_reload_mouse.Click
        If can_load = "0" Then
            
            mouse_text.Visible = False
            can_load = "1"
            load_delay.Enabled = True
            Dim curFile_mouse As String = _Datafile2.FullName

            If File.Exists(curFile_mouse) Then
                Loading_mouse()

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
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles change_tab.Click

        conflict_check("TAB")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles change_enter.Click
        conflict_check("ENTER")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles chat_fix.Click
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

        Else
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
        check_hold_keys()
    End Sub

    Private Sub Page_key_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        mode = "0"
        check_mode()
        If list_key.Rows.Count > 1 Then
            change_to.Enabled = True
            change_tab.Enabled = True
            change_enter.Enabled = True
            b_clear.Enabled = True
            chat_fix.Enabled = True
            b_save.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False
        End If
    End Sub

    Private Sub Page_mouse_Click(sender As Object, e As EventArgs) Handles TabPage2.Enter
        mode = "1"
        check_mode()
        If list_mouse.Rows.Count > 1 Then
            change_to.Enabled = True
            change_tab.Enabled = True
            change_enter.Enabled = True
            b_clear.Enabled = True
            chat_fix.Enabled = True
            b_save.Enabled = True
        Else

            change_to.Enabled = False
            change_tab.Enabled = False
            change_enter.Enabled = False
            b_clear.Enabled = False
            chat_fix.Enabled = False
            b_save.Enabled = False
        End If

    End Sub


    Private Sub load_delay_Tick(sender As Object, e As EventArgs) Handles load_delay.Tick
        can_load = "0"
        load_delay.Enabled = False
    End Sub
End Class
