<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HtmlEncodeTest.aspx.vb" Inherits="HtmlEncodeTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
 "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>    
        <h1>Properly encoded:</h1> 
        <div ID="ctrl2" runat="server"/>
        <br /><hr /><br />
        <h1>Incorrectly encoded:</h1> 
        <div ID="ctrl1" runat="server"/>
    </div>
    </form>
</body>
</html>
