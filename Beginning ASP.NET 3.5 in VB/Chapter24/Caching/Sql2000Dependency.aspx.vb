Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class Sql2000Dependency
    Inherits System.Web.UI.Page

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        lblInfo.Text &= "<br />"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then

            lblInfo.Text &= "Creating dependent item...<br />"
            Cache.Remove("CachedItem")
            ' Create a dependency for the Employees table.
            Dim dependency As New SqlCacheDependency("Northwind", "Employees")

            Dim dt As DataTable = GetEmployeeTable()
            lblInfo.Text &= "Adding dependent item<br />"
            Cache.Insert("CachedItem", dt, dependency)
        End If
    End Sub

    Private connectionString As String = _
  WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
    Private Function GetEmployeeTable() As DataTable

        Dim con As New SqlConnection(connectionString)
        Dim sql As String = "SELECT * FROM Employees"
        Dim da As New SqlDataAdapter(sql, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Employees")
        Return ds.Tables(0)
    End Function

    Protected Sub cmdGetItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGetItem.Click
        If Cache("CachedItem") Is Nothing Then
            lblInfo.Text &= "Cache item no longer exits.<br />"
        Else
            lblInfo.Text &= "Item is still present.<br />"
        End If
    End Sub

    Protected Sub cmdModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim con As New SqlConnection(connectionString)
        ' Even a change that really does do anything is still a change.
        Dim sql As String = "UPDATE Employees SET LastName='Davolio' WHERE LastName='Davolio'"
        Dim cmd As New SqlCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
        lblInfo.Text &= "Update completed (remember to wait for poll time to pass).<br />"
    End Sub
End Class
