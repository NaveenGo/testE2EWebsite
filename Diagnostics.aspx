<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Diagnostics.aspx.cs" Inherits="Crash"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="TraceError" runat="server" Text="Trace Error" OnClick="TraceError_Click" Width="150px" />
    
        <br />
        <br />
        <asp:Button ID="TraceWarning" runat="server" Text="Trace Warning" OnClick="TraceWarning_Click" Width="150px" />
    
        <br />
        <br />
        <asp:Button ID="TraceInfo" runat="server" Text="Trace Information" OnClick="TraceInfo_Click" Width="150px" />
        <br />
        <br />
        
        <asp:Button ID="CrashPage" runat="server" Text="Crash" OnClick="CrashPage_Click" Width="150px" />

        <br />
        
        <br />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkHomePage" runat="server" NavigateUrl="~/Default.aspx">Home Page</asp:HyperLink>
        <br />
    </div>
    </form>
</body>
</html>
