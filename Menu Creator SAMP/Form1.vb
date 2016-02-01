Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SAMPHomepageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPHomepageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("www.sa-mp.com")
    End Sub

    Private Sub SAMPForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPForumsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("forum.sa-mp.com")
    End Sub

    Private Sub SAMPWikiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPWikiToolStripMenuItem.Click
        System.Diagnostics.Process.Start("wiki.sa-mp.com")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("SA:MP Menu Creator is a simple project made out of boredom by [HK]Ryder[AN] to help newbs in scripting")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox2.AppendText("//Out of Any Callback")
        RichTextBox2.AppendText(Environment.NewLine & "new Menu:" + TextBox1.Text + ";")
        RichTextBox2.AppendText(Environment.NewLine & "//Under OnGameModeInit / OnFilterScriptInit")
        RichTextBox2.AppendText(Environment.NewLine & TextBox1.Text + " = CreateMenu(" + TextBox2.Text + """, " + TextBox6.Text + ", " + TextBox3.Text + ", " + TextBox4.Text + ", " + TextBox5.Text + ", " + TextBox7.Text + ");")
        For Each line In RichTextBox1.Lines
            RichTextBox2.AppendText(Environment.NewLine & String.Format("AddMenuItem(" + TextBox1.Text + ", 0, ""{0}"");", line))
        Next
        If RichTextBox3.Enabled = True Then
            For Each line In RichTextBox3.Lines
                RichTextBox2.AppendText(Environment.NewLine & String.Format("AddMenuItem(" + TextBox1.Text + ", 1, ""{0}"");", line))
            Next
        End If
        RichTextBox2.AppendText(Environment.NewLine & "//Under OnPlayerSelectedMenuRow(playerid, row) callback")
        RichTextBox2.AppendText(Environment.NewLine & "new Menu:CurrentMenu = GetPlayerMenu(playerid);")
        RichTextBox2.AppendText(Environment.NewLine & "if (CurrentMenu == " + TextBox1.Text + ")")
        RichTextBox2.AppendText(Environment.NewLine & "{")
        RichTextBox2.AppendText(Environment.NewLine & "//Now add your code here")
        RichTextBox2.AppendText(Environment.NewLine & "}")
        RichTextBox2.AppendText(Environment.NewLine & "//Thank you for using HKMenu Maker made by [HK]Ryder[AN]")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RadioButton2.Checked = True Then
            RichTextBox3.Enabled = True
            TextBox6.Text = "1"
        Else
            RichTextBox3.Enabled = False
            TextBox6.Text = "0"
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        If CType(sender, RichTextBox).Lines.Length > 6 Then
            Array.Resize(RichTextBox1.Lines, 6)
        End If
    End Sub

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox3.TextChanged
        If CType(sender, RichTextBox).Lines.Length > 6 Then
            Array.Resize(RichTextBox3.Lines, 6)
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
