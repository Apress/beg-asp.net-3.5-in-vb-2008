<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GetAllProfiles.aspx.vb" Inherits="GetAllProfiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gridProfiles" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
