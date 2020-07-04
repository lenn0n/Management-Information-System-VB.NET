Public Class main_page
    Dim gate1 As Integer = 1
    Dim gate2 As Integer = 1
    Dim gate3 As Integer = 1
    Dim delayclose As Integer = 0
    Dim fetch As String
    Dim checkpass As Integer


    Private Sub main_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.Green
        panel_mem.Hide()
        panel_manage.Hide()
        panel_summary.Hide()
        menu.Height = 0
        top.Top = 240
        bottom.Top = 380
        exit_btn.Hide()
        opening.Start()
        lists()
        connect()
        checker.Start()
        cb_lists.Checked = True
        CB_C.SelectedIndex = 0
        CB_S.SelectedIndex = 0
        CB_Y.SelectedIndex = 0
        fetch = "select * from members where course='BSIT' and section='A' and year='1ST'"
        loadmembers()
        newName.Enabled = False
   
    End Sub
    Sub checkID()
        checkpass = 1
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from members where ID='" + tbnewID.Text + "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            If sqldr("ID") = Val(tbnewID.Text) Then
                checkpass = 0
            End If
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        If checkpass = 0 Then
            addbtn.Hide()
            wrongbtn.Show()
            ok_new.Hide()
            newName.Enabled = False
        Else
            addbtn.Show()
            wrongbtn.Hide()
            ok_new.Show()
            newName.Enabled = True
        End If
    End Sub
    Sub loadname()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from members where name like '%" + searchname.Text + "%'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            ListBox1.Items.Add(sqldr("ID"))
            ListBox2.Items.Add(sqldr("name"))

        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub

    Sub loadmembers()
        sqlcon.Open()
        memberlist.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = fetch
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Dim member As ListViewItem
            member = memberlist.Items.Add(sqldr("ID"))
            member.SubItems.Add(sqldr("name"))
            member.SubItems.Add(sqldr("course"))
            member.SubItems.Add(sqldr("year"))
            member.SubItems.Add(sqldr("section"))
            member.SubItems.Add(sqldr("membersfee"))
            member.SubItems.Add(sqldr("size"))
            member.SubItems.Add(sqldr("tshirtfee"))
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub

    Sub lists()
        memberlist.Columns.Clear()
        memberlist.Columns.Add("ID", CInt(memberlist.Width / 9))
        memberlist.Columns.Add("Name", CInt(memberlist.Width / 2.5))
        memberlist.Columns.Add("Course", CInt(memberlist.Width / 12))
        memberlist.Columns.Add("Year", CInt(memberlist.Width / 16))
        memberlist.Columns.Add("Sec", CInt(memberlist.Width / 16))
        memberlist.Columns.Add("Member", CInt(memberlist.Width / 10))
        memberlist.Columns.Add("Size", CInt(memberlist.Width / 15))
        memberlist.Columns.Add("T-shirt", CInt(memberlist.Width / 10))


    End Sub

    Private Sub countdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opening.Tick
        'top
        If top.Top = 10 Then
            gate1 = 0
        ElseIf gate1 = 1 Then
            top.Top -= 10
        End If

        'bottom
        If bottom.Top = 650 Then
            gate2 = 0
        ElseIf gate2 = 1 Then
            bottom.Top += 10
        End If
        'menu
        If gate1 = 0 And gate2 = 0 Then
            If menu.Height = 520 Then
                gate3 = 0
                opening.Stop()
                exit_btn.Show()

            ElseIf gate3 = 1 Then
                menu.Height += 10
            End If
        End If

    End Sub


    Private Sub closing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closing.Tick
        'menu 
        If menu.Height = 0 Then
            gate3 = 0
        ElseIf gate3 = 1 Then
            menu.Height -= 10
        End If

        If gate3 = 0 Then
            If top.Top = 230 Then
                gate1 = 0
            ElseIf gate1 = 1 Then
                top.Top += 10
            End If
            If bottom.Top = 370 Then
                gate2 = 0
                delayclose += 10
                If delayclose = 500 Then
                    wc_page.Show()
                    Me.Close()
                End If

            ElseIf gate2 = 1 Then
                bottom.Top -= 10
            End If
        End If

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ic_revert.Click
        If menu.BackColor = Color.OldLace Then
            menu.BackColor = Color.FromArgb(247, 190, 22)
        Else
            menu.BackColor = Color.OldLace
        End If
    End Sub

    Private Sub btn_members_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_members.Click
        reports.Hide()
        If panel_mem.Visible = False Then
            panel_mem.Show()
            panel_manage.Hide()
            panel_summary.Hide()
        Else
            panel_mem.Hide()
            panel_manage.Hide()
            panel_summary.Hide()
        End If
        fetch = "select * from members where course='BSIT' and section='A' and year='1ST'"
        loadmembers()
        CB_C.SelectedIndex = 0
        CB_Y.SelectedIndex = 0
        CB_S.SelectedIndex = 0

    End Sub


    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ic_search.Click
        fetch = "select * from members where course='" + CB_C.Text + "' and year='" + CB_Y.Text + "' and section='" + CB_S.Text + "'"
        If cb_lists.Checked = False Then

            If cb_memfee.Checked = True Then
                fetch = fetch + " and membersfee='Paid'"
            Else
                fetch = fetch + " and membersfee='No'"
            End If
            If cb_tfee.Checked = True Then
                fetch = fetch + " and tshirtfee='Paid'"
            Else
                fetch = fetch + " and tshirtfee='No'"
            End If
        End If

        loadmembers()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_name.TextChanged
        fetch = "select * from members where name like '%" + tb_name.Text + "%'"
        loadmembers()
    End Sub

    Private Sub tb_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_id.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_id.TextChanged
        fetch = "select * from members where id like '%" + tb_id.Text + "%'"
        loadmembers()
    End Sub


    Private Sub checker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checker.Tick
   
        If cb_lists.Checked = True Then
            cb_memfee.Checked = False
            cb_memfee.Enabled = False
            cb_tfee.Checked = False
            cb_tfee.Enabled = False
        Else
            cb_memfee.Enabled = True

            cb_tfee.Enabled = True
        End If

        Label26.Text = DateTime.Now.ToString()

    End Sub



    Private Sub btn_manage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click
        If Not newName.Text = "" And Not tbnewID.Text = "" Then
            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "insert into members(ID,name,course,year,section,membersfee,size,tshirtfee)values('" & tbnewID.Text & "', '" & newName.Text & "', '" & newC.Text & "', '" & newY.Text & "', '" & newS.Text & "', '" & mf.Text & "', '" & newBS.Text & "', '" & tf.Text & "')"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            notif_txt.Text = newName.Text + " was added in database! ID: " + tbnewID.Text
            tbnewID.Text = ""
            newName.Text = ""
            notif_txt.Visible = True
            addbtn.Hide()
            ok_new.Hide()
            tbnewID.Focus()

        End If

    End Sub

    Private Sub searchname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchname.Click
        id_edit.Text = ""
        name_edit.Text = ""

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchname.TextChanged
        loadname()
        id_edit.Text = ""
        name_edit.Text = ""

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        id_edit.Text = ListBox1.SelectedItem.ToString()
        notif_txt.Text = ""

    End Sub

    Private Sub tbnewID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnewID.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub tbnewID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnewID.TextChanged
        If tbnewID.Text.Length = 9 Then
            checkID()
        Else
            addbtn.Hide()
            wrongbtn.Hide()
            ok_new.Hide()
            newName.Enabled = False
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_edit.TextChanged
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from members where ID='" + id_edit.Text + "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read

            name_edit.Text = sqldr("name")
            c_edit.SelectedItem = sqldr("course")
            y_edit.SelectedItem = sqldr("year")
            s_edit.SelectedItem = sqldr("section")
            bs_edit.SelectedItem = sqldr("size")
            mf_edit.SelectedItem = sqldr("membersfee")
            tfee_edit.SelectedItem = sqldr("tshirtfee")

        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
    End Sub


    Private Sub newName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles newName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not newName.Text = "" And Not tbnewID.Text = "" Then
                sqlcon.Open()
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "insert into members(ID,name,course,year,section,membersfee,size,tshirtfee)values('" & tbnewID.Text & "', '" & newName.Text & "', '" & newC.Text & "', '" & newY.Text & "', '" & newS.Text & "', '" & mf.Text & "', '" & newBS.Text & "', '" & tf.Text & "')"
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                sqlcon.Close()
                notif_txt.Text = newName.Text + " was added in database! ID: " + tbnewID.Text
                tbnewID.Text = ""
                newName.Text = ""
                notif_txt.Visible = True
                addbtn.Hide()
                ok_new.Hide()
                tbnewID.Focus()

            End If
        End If
    End Sub

    Private Sub newName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newName.TextChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Not id_edit.Text = "" Then

            sqlcon.Open()
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update members set name='" + name_edit.Text + "', course='" + c_edit.Text + "', year='" + y_edit.Text + "', section='" + s_edit.Text + "', membersfee='" + mf_edit.Text + "', size='" + bs_edit.Text + "', tshirtfee='" + tfee_edit.Text + "'" + " where ID='" + id_edit.Text + "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            notif_txt.Show()
            notif_txt.Text = name_edit.Text + " was updated in database!"
            id_edit.Clear()

            searchname.Clear()
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            mf_edit.SelectedIndex = -1
            tfee_edit.SelectedIndex = -1
            c_edit.SelectedIndex = -1
            y_edit.SelectedIndex = -1
            s_edit.SelectedIndex = -1
            bs_edit.SelectedIndex = -1
            searchname.Focus()

        End If

    End Sub

    Private Sub name_edit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name_edit.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Not id_edit.Text = "" Then
            Dim confirm As String = MsgBox("Are you sure you want to delete " + name_edit.Text + " ?", vbYesNo + vbExclamation)
            If confirm = vbYes Then
                sqlcon.Open()
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "delete from members where ID='" + id_edit.Text + "'"
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                sqlcon.Close()
                notif_txt.Show()
                notif_txt.Text = name_edit.Text + " was remove in database!"
                id_edit.Clear()
                searchname.Clear()
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                mf_edit.SelectedIndex = -1
                tfee_edit.SelectedIndex = -1
                c_edit.SelectedIndex = -1
                y_edit.SelectedIndex = -1
                s_edit.SelectedIndex = -1
                bs_edit.SelectedIndex = -1
                searchname.Focus()
            End If
        End If

    End Sub

    Private Sub addbtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles addbtn.MouseHover
        addbtn.Image = My.Resources.ResourceManager.GetObject("1")
    End Sub

    Private Sub addbtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles addbtn.MouseLeave
        addbtn.Image = My.Resources.ResourceManager.GetObject("add-user-icon")
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("2")
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("edit-user-icon")
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("3")
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("remove-user-icon")
    End Sub

    Private Sub ic_search_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ic_search.MouseHover
        ic_search.Image = My.Resources.ResourceManager.GetObject("sbbb2")
    End Sub

    Private Sub ic_search_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ic_search.MouseLeave
        ic_search.Image = My.Resources.ResourceManager.GetObject("sbbb")
    End Sub



    Private Sub btn_reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reports.Click
        reports.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reports.Hide()
        If panel_manage.Visible = False Then
            panel_mem.Hide()
            panel_manage.Show()
            panel_summary.Hide()
        Else
            panel_mem.Hide()
            panel_manage.Hide()
            panel_summary.Hide()
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        reports.Hide()
        checker.Stop()
        exit_btn.Hide()
        closing.Start()
        gate1 = 1
        gate2 = 1
        gate3 = 1
    End Sub

    Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontBold As New Font("Times New Roman", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, fontBold, Brushes.Black, 100, 100)
    End Sub


End Class