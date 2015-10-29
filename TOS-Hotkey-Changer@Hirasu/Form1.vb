Imports System.Xml

Imports System.Data
Imports System.IO

Public Class Form1
    Private _Datafile As New FileInfo(Application.StartupPath & "\hotkey.xml")
    Private _Datafile2 As New FileInfo(Application.StartupPath & "\hotkey_mousemode.xml")
    Public mode As Integer
    Private _change As New Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim curFile As String = _Datafile.FullName

        If File.Exists(curFile) Then
            Loading()
            mode = "0"
        Else
            MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
            Me.Close()
        End If
    End Sub
    Private Sub Loading()

        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create("hotkey.xml", New XmlReaderSettings())
        Dim ds As New DataSet
        ds.ReadXml(xmlFile)

        list.DataSource = ds.Tables(0)
        list.Columns("ID").ReadOnly = True
        list.Columns("ID").HeaderText = "Name"
        list.Columns("KEY").ReadOnly = True
        list.Columns("KEY").HeaderText = "Hotkey"
        list.Columns(1).Visible = False
        list.Columns(2).Visible = False
        list.Columns(3).Visible = False
        list.Columns(5).Visible = False
        list.Columns(6).Visible = False
        list.Columns(7).Visible = False
        list.Columns(8).Visible = False
        list.Rows(103).Visible = False
        list.Rows(101).Visible = False
        list.Rows(100).Visible = False
        list.Rows(99).Visible = False
        list.Rows(98).Visible = False
        list.Rows(83).Visible = False
        list.Rows(82).Visible = False
        list.Rows(81).Visible = False
        list.Rows(80).Visible = False
        list.Rows(59).Visible = False
        list.Rows(29).Visible = False
        list.Rows(19).Visible = False
        list.Rows(18).Visible = False
        list.Rows(17).Visible = False
        list.Rows(16).Visible = False
        list.Rows(1).Visible = False
        If list.Rows(105).Cells(4).Value = "" Then
            chat_fix.Text = "Remove Fix"
        End If



        xmlFile.Close()
    End Sub

    Private Sub Loading_mouse()

        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create("hotkey_mousemode.xml", New XmlReaderSettings())
        Dim ds As New DataSet
        ds.ReadXml(xmlFile)

        list.DataSource = ds.Tables(0)
        list.Columns("ID").ReadOnly = True
        list.Columns("ID").HeaderText = "Name"
        list.Columns("KEY").ReadOnly = True
        list.Columns("KEY").HeaderText = "Hotkey"
        list.Columns(1).Visible = False
        list.Columns(2).Visible = False
        list.Columns(3).Visible = False
        list.Columns(5).Visible = False
        list.Columns(6).Visible = False
        list.Columns(7).Visible = False
        list.Columns(8).Visible = False
        list.Rows(19).Visible = False
        list.Rows(97).Visible = False
        list.Rows(95).Visible = False
        list.Rows(94).Visible = False
        list.Rows(93).Visible = False
        list.Rows(19).Visible = False
        list.Rows(18).Visible = False
        list.Rows(17).Visible = False
        list.Rows(16).Visible = False
        list.Rows(1).Visible = False
        If list.Rows(99).Cells(4).Value = "" Then
            chat_fix.Text = "Remove Fix"
        End If



        xmlFile.Close()
    End Sub

    Public Function conflict_check(ByVal _key As String) As String
        If list.Rows(list.CurrentRow.Index).Cells(4).Value = _key Then
        Else

            Dim Max_Row As Integer
            Max_Row = list.Rows.Count
            For i As Integer = 0 To Max_Row - 1 Step +1
                If list.Rows(i).Cells(4).Value = _key Then
                    Select Case MessageBox.Show(Me, "Conflict with '" & list.Rows(i).Cells(0).Value & "' , continue?", "CONFLICT!", MessageBoxButtons.YesNo)
                        Case DialogResult.No : Return False
                        Case DialogResult.Yes
                    End Select
                End If
            Next
            If CheckSHIFT.CheckState = True Then
                list.Rows(list.CurrentRow.Index).Cells(5).Value = "YES"
            Else
                list.Rows(list.CurrentRow.Index).Cells(5).Value = "NO"
            End If
            If CheckALT.Checked = True Then
                list.Rows(list.CurrentRow.Index).Cells(6).Value = "YES"
            Else
                list.Rows(list.CurrentRow.Index).Cells(6).Value = "NO"
            End If
            If CheckCTRL.CheckState = True Then
                list.Rows(list.CurrentRow.Index).Cells(7).Value = "YES"
            Else
                list.Rows(list.CurrentRow.Index).Cells(7).Value = "NO"
            End If
            list.Rows(list.CurrentRow.Index).Cells(4).Value = _key
        End If
        CheckALT.CheckState = False
        CheckSHIFT.CheckState = False
        CheckCTRL.CheckState = False
    End Function

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles change_to.KeyDown
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
            ElseIf e.KeyCode = Keys.Enter Then
            Else
                conflict_check(Convert.ToChar(e.KeyCode))
            End If
            _change = "0"
            changinginfo.Text = "Choose a hotkey..."
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_save.Click
        If mode = "0" Then
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list.DataSource.WriteXml(_Datafile.FullName)
                    MsgBox("Saved")           ' 
            End Select
        Else
            Select Case MessageBox.Show(Me, "Are you sure?", "Saving", MessageBoxButtons.YesNo)
                Case DialogResult.No : Return
                Case DialogResult.Yes : list.DataSource.WriteXml(_Datafile2.FullName)
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

    ' Private Sub StwagList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles list.CellClick
    '    MessageBox.Show(list.CurrentRow.Index)

    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles change_to.Click
        If list.CurrentRow.Index = 0 Then
            changinginfo.Text = "Cant change Chat!"
        Else
            _change = "1"
            changinginfo.Text = "Press a button..."
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles b_reload_k.Click
        Dim curFile As String = _Datafile.FullName

        If File.Exists(curFile) Then
            Loading()
            mode = "0"
        Else
            MessageBox.Show("Can't find 'hotkey.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles change_tab.Click
        conflict_check("TAB")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles change_enter.Click
        conflict_check("ENTER")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles chat_fix.Click
        If mode = "0" Then
            If list.Rows(105).Cells(4).Value = "TAB" Then
                list.Rows(105).Cells(4).Value = ""
                MessageBox.Show("Fixed!")
                chat_fix.Text = "Remove Fix"
            Else
                list.Rows(105).Cells(4).Value = "TAB"
                MessageBox.Show("Removed!")
                chat_fix.Text = "Fix Chat Type"
            End If

        Else
            If list.Rows(99).Cells(4).Value = "TAB" Then
                list.Rows(99).Cells(4).Value = ""
                MessageBox.Show("Fixed!")
                chat_fix.Text = "Remove Fix"
            Else
                list.Rows(99).Cells(4).Value = "TAB"
                MessageBox.Show("Removed!")
                chat_fix.Text = "Fix Chat Type"
            End If
        End If

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles b_reload_mouse.Click
        Dim curFile As String = _Datafile2.FullName

        If File.Exists(curFile) Then
            Loading_mouse()
            mode = "1"
        Else
            MessageBox.Show("Can't find 'hotkey_mousemode.xml'" & vbCrLf & "Put me in the Tree of Savior folder!")
            Me.Close()
        End If

    End Sub

    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        list.Rows(list.CurrentRow.Index).Cells(4).Value = ""
    End Sub
End Class
