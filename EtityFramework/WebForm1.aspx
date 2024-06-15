<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EtityFramework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <center>
             <asp:Label ID="Label1" runat="server" Text="Entity Framework"></asp:Label>
            <br />
            
            </center>
            <asp:Label ID="Label2" runat="server" Text="Enter Roll Number :"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtRollno" runat="server"></asp:TextBox>
            &nbsp;<br />

            <asp:Label ID="Label3" runat="server" Text="Enter Name :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Enter Address"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
             <br />
            <br />
             <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" PageSize="2" AllowPaging="True">
             </asp:GridView>
            <br />
            <br />
             &nbsp;&nbsp;
           
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" Width="54px" />
            <asp:Button ID="btnPrevious" runat="server" OnClick="btnPrevious_Click" style="margin-left: 44px" Text="Previous" />
           
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />
&nbsp;
            
              <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />







        </div>
    </form>

</body>
</html>
