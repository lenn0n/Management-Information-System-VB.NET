Public Class wc_page
    Dim count As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.DimGray
        load_time.Stop()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "fict" Then
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("fictgreen")
                count = 0
                load_time.Start()

            Else
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("fictred")
            End If

        End If
        If e.KeyCode = Keys.Back Then
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("fictgray")
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("fictgray")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub load_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles load_time.Tick
        count += 1
        If count = 6 Then
            main_page.Show()
            load_time.Stop()
            TextBox1.Text = ""
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("fictgray")
            Me.Hide()
        End If
    End Sub
End Class
