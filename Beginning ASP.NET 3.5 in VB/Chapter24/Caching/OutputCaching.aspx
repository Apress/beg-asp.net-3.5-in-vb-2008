<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OutputCaching.aspx.vb" Inherits="OutputCaching" %>
<%@ OutputCache Duration="20" VaryByParam="None" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblDate" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="X-Large"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>

