<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSupplementPage.aspx.cs" Inherits="frontend.View.OrderSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:Button ID="btn_order_supplement" runat="server" Text="Order Supplement" OnClick="btn_order_supplement_Click" />
                <asp:Button ID="btn_history" runat="server" Text="History" OnClick="btn_history_Click" />
                <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
                <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />
            </nav>

            <asp:GridView ID="GV" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
