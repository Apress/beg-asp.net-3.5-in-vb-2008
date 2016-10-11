<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ImageTest.aspx.vb" Inherits="ImageTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
 "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>
  
      <h1>Click on the Image </h1>
      <input type="image"
             src="button.png" 
             ID="ImgButton"
             runat="server" />
      <br />
      <div ID="Result" 
            runat="server"/>

    </div>
    </form>
</body>
</html>
