<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XmlDataSet.aspx.vb" Inherits="XmlDataSet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
      <div class="Box">
        <asp:Button ID="cmdDataSetToXml" runat="server" Text="Display DataSet as XML" Width="185px"/>
        <asp:Button ID="cmdXmlToDataSet" runat="server" Text="Read XML into DataSet" Width="184px" />
      </div>
    <div>
        <br />
        <asp:GridView ID="gridData" runat="server" EnableViewState="False" >
        </asp:GridView>
        <asp:Xml ID="XmlControl" runat="server" EnableViewState="False"></asp:Xml><br />
    </div>
    </form>
</body>
</html>

