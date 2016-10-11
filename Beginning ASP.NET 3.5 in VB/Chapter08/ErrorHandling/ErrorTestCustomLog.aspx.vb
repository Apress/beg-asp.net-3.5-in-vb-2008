Imports System.Diagnostics
Imports System.Drawing

Partial Class ErrorTestCustomLog
    Inherits System.Web.UI.Page

    Protected Sub cmdCompute_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        Try
            Dim A, B, Result As Decimal
            A = Decimal.Parse(txtA.Text)
            B = Decimal.Parse(txtB.Text)
            Result = A / B
            lblResult.Text = Result.ToString()
            lblResult.ForeColor = Color.Black
        Catch err As Exception
            lblResult.Text = "<b>Message:</b> " & err.Message & "<br><br>"
            lblResult.Text &= "<b>Source:</b> " & err.Source & "<br><br>"
            lblResult.Text &= "<b>Stack Trace:</b> " & err.StackTrace
            lblResult.ForeColor = Color.Red

            ' Write the information to the event log.
            ' Register the event source if needed.
            If Not EventLog.SourceExists("DivideByZeroApp") Then
                ' This registers the event source and creates the custom log,
                ' if needed.
                EventLog.CreateEventSource("DivideByZeroApp", "ProseTech")
            End If

            ' Open the log. If the log does not exist, it will be created automatically.
            Dim Log As New EventLog("ProseTech")
            Log.Source = "DivideByZeroApp"
            Log.WriteEntry(err.Message, EventLogEntryType.Error)
        End Try
    End Sub
End Class
