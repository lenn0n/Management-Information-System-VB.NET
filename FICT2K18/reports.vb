Public Class reports

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main_page.RichTextBox1.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon

        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("FICT MASTER LIST")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("ID")
        main_page.RichTextBox1.AppendText(vbTab + vbTab)
        main_page.RichTextBox1.AppendText("COURSE")
        main_page.RichTextBox1.AppendText(vbTab)
        main_page.RichTextBox1.AppendText("NAME")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        sqlcmd.CommandText = "select * from members order by year"
        sqldr = sqlcmd.ExecuteReader

        While sqldr.Read
            main_page.RichTextBox1.AppendText(sqldr("ID"))
            main_page.RichTextBox1.AppendText(vbTab)
            main_page.RichTextBox1.AppendText(sqldr("course") + "/" + sqldr("year") + "/" + sqldr("section"))
            main_page.RichTextBox1.AppendText(vbTab)
            main_page.RichTextBox1.AppendText(sqldr("Name"))
            main_page.RichTextBox1.AppendText(Environment.NewLine)
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        sqlcon.Close()

        main_page.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Button4.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        main_page.RichTextBox1.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon

        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("FICT MEMBERS")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("STATUS")
        main_page.RichTextBox1.AppendText(vbTab + vbTab)
        main_page.RichTextBox1.AppendText("COURSE")
        main_page.RichTextBox1.AppendText(vbTab)
        main_page.RichTextBox1.AppendText("NAME")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        sqlcmd.CommandText = "select * from members where membersfee='Paid' order by year"
        sqldr = sqlcmd.ExecuteReader

        While sqldr.Read
            main_page.RichTextBox1.AppendText(sqldr("membersfee"))
            main_page.RichTextBox1.AppendText(vbTab + vbTab)
            main_page.RichTextBox1.AppendText(sqldr("course") + "/" + sqldr("year") + "/" + sqldr("section"))
            main_page.RichTextBox1.AppendText(vbTab)
            main_page.RichTextBox1.AppendText(sqldr("name"))
            main_page.RichTextBox1.AppendText(Environment.NewLine)
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        sqlcon.Close()

        main_page.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main_page.RichTextBox1.Clear()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon

        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("FICT MERCHANDISE")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText("STATUS")
        main_page.RichTextBox1.AppendText(vbTab + "     ")
        main_page.RichTextBox1.AppendText("SIZE")
        main_page.RichTextBox1.AppendText(vbTab + "     ")
        main_page.RichTextBox1.AppendText("COURSE")
        main_page.RichTextBox1.AppendText(vbTab)
        main_page.RichTextBox1.AppendText("NAME")
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        main_page.RichTextBox1.AppendText(Environment.NewLine)
        sqlcmd.CommandText = "SELECT * FROM members WHERE tshirtfee='Half' OR tshirtfee='Full' order by year"
        sqldr = sqlcmd.ExecuteReader

        While sqldr.Read
            main_page.RichTextBox1.AppendText(sqldr("tshirtfee"))
            main_page.RichTextBox1.AppendText(vbTab + "     ")
            main_page.RichTextBox1.AppendText(sqldr("size"))
            main_page.RichTextBox1.AppendText(vbTab + "     ")
            main_page.RichTextBox1.AppendText(sqldr("course") + "/" + sqldr("year") + "/" + sqldr("section"))
            main_page.RichTextBox1.AppendText(vbTab)
            main_page.RichTextBox1.AppendText(sqldr("name"))
            main_page.RichTextBox1.AppendText(Environment.NewLine)
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        sqlcon.Close()

        main_page.PrintPreviewDialog1.ShowDialog()
    End Sub
End Class