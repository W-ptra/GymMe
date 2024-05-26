<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="frontend.View.TransactionDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="stylesheet" href="./css/table.css" />
    <link rel="stylesheet" href="./css/backButton.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Cantarell:ital,wght@0,400;0,700;1,400;1,700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="main_content">
            <nav>
                <div class="nav-left">
                    <h1>GymMe</h1>
                </div>
                <div class="nav-right">

                </div>
            </nav>

            <div class="back-button">
                <asp:Button ID="btn_back" runat="server" Text="BACK" OnClick="btn_back_Click" Width="100px" />
            </div>
            <h1 class="title">
                Transaction Detail Page
            </h1>

            <asp:GridView ID="GV" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
