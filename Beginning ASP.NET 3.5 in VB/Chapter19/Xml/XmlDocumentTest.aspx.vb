Imports System.Xml
Imports System.Collections.Generic
Imports System.IO

Partial Class XmlDocumentTest
    Inherits System.Web.UI.Page

    Dim file As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        file = Path.Combine(Request.PhysicalApplicationPath, "App_Data\SuperProProductList1.xml")
    End Sub

    Protected Sub cmdCreateXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateXml.Click
        ' Start with a blank in memory document.
        Dim doc As New XmlDocument()

        ' Create some variables that will be useful for manipulating XML data.
        Dim RootElement, ProductElement, PriceElement As XmlElement
        Dim ProductAttribute As XmlAttribute
        Dim Comment As XmlComment

        ' Create the declaration.
        Dim Declaration As XmlDeclaration
        Declaration = doc.CreateXmlDeclaration("1.0", Nothing, "yes")

        ' Insert the declaration as the first node.
        doc.InsertBefore(Declaration, doc.DocumentElement)

        ' Add a comment.
        Comment = doc.CreateComment("Created with the XmlDocument class.")
        doc.InsertAfter(Comment, Declaration)

        ' Add the root node.
        RootElement = doc.CreateElement("SuperProProductList")
        doc.InsertAfter(RootElement, Comment)

        ' Add the first product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "1"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Chair"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "49.33"
        ProductElement.AppendChild(PriceElement)


        ' Add the second product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "2"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Car"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "43399.55"
        ProductElement.AppendChild(PriceElement)


        ' Add the third product.
        ProductElement = doc.CreateElement("Product")
        RootElement.AppendChild(ProductElement)

        ' Set and add the product attributes.
        ProductAttribute = doc.CreateAttribute("ID")
        ProductAttribute.Value = "3"
        ProductElement.SetAttributeNode(ProductAttribute)
        ProductAttribute = doc.CreateAttribute("Name")
        ProductAttribute.Value = "Fresh Fruit Basket"
        ProductElement.SetAttributeNode(ProductAttribute)

        ' Add the price node.
        PriceElement = doc.CreateElement("Price")
        PriceElement.InnerText = "49.99"
        ProductElement.AppendChild(PriceElement)

        ' Save the document.
        doc.Save(file)

        lblXml.Text = "File " & file & " written successfully."
    End Sub

    Protected Sub cmdReadXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReadXml.Click
        ' Create the document.
        Dim doc As New XmlDocument()
        doc.Load(file)

        ' Loop through all the nodes, and create the list of Product objects .
        Dim products As New List(Of Product)()

        For Each element As XmlElement In doc.DocumentElement.ChildNodes
            Dim newProduct As New Product()
            newProduct.ID = Int32.Parse(element.GetAttribute("ID"))
            newProduct.Name = element.GetAttribute("Name")

            ' If there were more than one child node, you would probably use
            ' another For Each loop here, and move through the
            ' element.ChildNodes collection.
            newProduct.Price = Val(element.ChildNodes(0).InnerText())

            products.Add(newProduct)
        Next

        ' Display the results.
        gridResults.DataSource = products
        gridResults.DataBind()

    End Sub

    Protected Sub cdmSearchXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearchXml.Click
        Dim doc As New XmlDocument()
        doc.Load(file)
        Dim Results As XmlNodeList
        Dim Result As XmlNode

        ' Find the matches.
        Results = doc.GetElementsByTagName("Price")

        ' Display the results.
        lblXml.Text = "<b>Found " & Results.Count.ToString() & " Matches "
        lblXml.Text &= " for the Price tag: </b><br /><br />"
        For Each Result In Results
            lblXml.Text &= Result.FirstChild.Value & "<br />"
        Next
    End Sub
End Class
