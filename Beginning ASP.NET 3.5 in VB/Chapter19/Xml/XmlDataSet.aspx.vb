Imports System.Xml
Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports System.Data

Partial Class XmlDataSet
    Inherits System.Web.UI.Page

    Protected Sub cmdDataSetToXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDataSetToXml.Click
        Dim connectionString As String = _
          WebConfigurationManager.ConnectionStrings("Pubs").ConnectionString
        Dim SQL As String = "SELECT * FROM authors WHERE city='Oakland'"

        ' Create the ADO.NET objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(SQL, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet("AuthorsDataSet")

        ' Retrieve the data.
        con.Open()
        adapter.Fill(ds, "AuthorsTable")
        con.Close()

        ' Create the XmlDataDocument that wraps this DataSet.
        Dim dataDoc As New XmlDataDocument(ds)

        ' Display the XML data (with the help of an XSLT) in the XML web control.
        XmlControl.XPathNavigator = dataDoc.CreateNavigator()
        XmlControl.TransformSource = Request.PhysicalApplicationPath & "\App_Data\authors.xsl"

    End Sub

    Protected Sub cmdXmlToDataSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdXmlToDataSet.Click
        Dim dataDoc As New XmlDataDocument()

        ' Set the schema, and retrieve the data.
        dataDoc.DataSet.ReadXmlSchema(Request.PhysicalApplicationPath & _
          "\App_Data\SuperProProductList.xsd")
        dataDoc.Load(Request.PhysicalApplicationPath & "\App_Data\SuperProProductList.xml")

        ' Display the retrieved data.
        gridData.DataSource = dataDoc.DataSet
        gridData.DataBind()

    End Sub

End Class
