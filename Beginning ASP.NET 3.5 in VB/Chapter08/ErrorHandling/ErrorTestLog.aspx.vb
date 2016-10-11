Imports System.Diagnostics
Imports System.Drawing

Partial Class ErrorTestLog
    Inherits System.Web.UI.Page

    Protected Sub cmdCompute_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles cmdCompute.Click

        Try
            Dim A, B, Result As Decimal
            A = Val(txtA.Text)
            B = Val(txtB.Text)
            Result = A / B
            lblResult.Text = Result.ToString()
            lblResult.ForeColor = Color.Black
        Catch err As Exception
            lblResult.Text = "<b>Message:</b> " & err.Message & "<br><br>"
            lblResult.Text &= "<b>Source:</b> " & err.Source & "<br><br>"
            lblResult.Text &= "<b>Stack Trace:</b> " & err.StackTrace
            lblResult.ForeColor = Color.Red

            ' Write the information to the event log.
            Dim Log As New EventLog()
            Log.Source = "DivisionPage"
            Log.WriteEntry(err.Message, EventLogEntryType.Error)
        End Try
    End Sub

End Class
