<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XmlValidation.aspx.vb" Inherits="XmlValidation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Xml Validation</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="Box">
		<asp:RadioButton id="optValid" runat="server" Text="Use SuperProProductList.xml" Checked="True" GroupName="Valid"></asp:RadioButton><br />
		<asp:RadioButton id="optInvalidData" runat="server" Text="Use InvalidData.xml" GroupName="Valid"></asp:RadioButton><br />
		<asp:RadioButton id="optInvalidTag" runat="server" Text="Use InvalidTag.xml" GroupName="Valid"></asp:RadioButton><br />
        <br />
		<asp:button id="cmdValidate" runat="server" Text="Validate XML"></asp:button></div>
	<div>
        <br />
		<asp:Label id="lblStatus" runat="server" EnableViewState="False"></asp:Label>
    </div>
    </form>
</body>
</html>