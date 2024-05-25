<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="frontend.View.TransactionDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_back" runat="server" Text="<=== BACK" OnClick="btn_back_Click" />
            <h1>
                Transaction Detail Page
            </h1>

            <asp:GridView ID="GV" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
