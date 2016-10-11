<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CustomParameters.aspx.vb" Inherits="CustomParameters" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Custom Parameters</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:SqlDataSource ID="sourceCustomers" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT CustomerID, ContactName FROM Customers"
/>
        <asp:DropDownList ID="lstCustomers" runat="server" DataSourceID="sourceCustomers" DataTextField="ContactName" DataValueField="CustomerID" AutoPostBack="True">
        </asp:DropDownList>
          <br />
          <br />
          <asp:SqlDataSource ID="sourceOrders" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT OrderID,OrderDate,ShippedDate FROM Orders WHERE CustomerID=@CustomerID AND OrderDate>=@EarliestOrderDate"
 >
<SelectParameters>
    <asp:ControlParameter Name="CustomerID" ControlID="lstCustomers" PropertyName="SelectedValue" />
    <asp:Parameter Name="EarliestOrderDate" DefaultValue="1900/01/01" />
  </SelectParameters>

      </asp:SqlDataSource>
  
       <asp:GridView ID="gridOrders" runat="server" DataSourceID="sourceOrders" >			
        </asp:GridView>
    </div>
    </form>
</body>
</html>
