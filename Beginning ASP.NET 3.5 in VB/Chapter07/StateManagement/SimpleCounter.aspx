<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleCounter.aspx.vb" Inherits="SimpleCounter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdIncrement" runat="server" Text="Increment" /><br />
        <br />
        <asp:Label ID="lblCount" runat="server"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
