Imports System.Web.Configuration

Partial Class ShowSettings
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTest.Text = "This app will look for data in the directory:<br /><b>"
        lblTest.Text &= WebConfigurationManager.AppSettings("DataFilePath")
        lblTest.Text &= "</b>"
    End Sub
End Class
