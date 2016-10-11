Imports System.Diagnostics

Partial Class EventReviewPage
    Inherits System.Web.UI.Page

    Protected Sub cmdGet_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles cmdGet.Click

        lblResult.Text = ""

        ' Check if the log exists.
        If Not EventLog.Exists(txtLog.Text) Then
            lblResult.Text = "The event log " & txtLog.Text & _
              " does not exist."
        Else
            ' For maximum performance, join all the event
            ' information into one large string using the
            ' StringBuilder.
            Dim sb As New System.Text.StringBuilder()

            Dim log As New EventLog(txtLog.Text)

            For Each entry As EventLogEntry In log.Entries
                ' Write the event entries to the StringBuilder.
                If chkAll.Checked Or entry.Source = txtSource.Text Then
                    sb.Append("<b>Entry Type:</b> ")
                    sb.Append(entry.EntryType.ToString())
                    sb.Append("<br /><b>Message:</b> ")
                    sb.Append(entry.Message)
                    sb.Append("<br /><b>Time Generated:</b> ")
                    sb.Append(entry.TimeGenerated.ToString())
                    sb.Append("<br /><br />")
                End If
            Next

            ' Copy the complete text to the web page.
            lblResult.Text = sb.ToString()

        End If
    End Sub

    Protected Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
      Handles chkAll.CheckedChanged

        ' The chkAll control has AutoPostback = True.
        If chkAll.Checked Then
            txtSource.Text = ""
            txtSource.Enabled = False
        Else
            txtSource.Enabled = True
        End If
    End Sub

End Class
