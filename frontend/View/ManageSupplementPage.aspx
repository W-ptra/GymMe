﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSupplementPage.aspx.cs" Inherits="frontend.View.ManageSupplementPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Cantarell:ital,wght@0,400;0,700;1,400;1,700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:Button ID="btn_to_home" runat="server" Text="Home" OnClick="btn_to_home_Click" />
                <asp:Button ID="btn_to_manage_supplement" runat="server" Text="Manage Supplement" OnClick="btn_to_manage_supplement_Click" />
                <asp:Button ID="btn_to_order_queue" runat="server" Text="Order Queue" OnClick="btn_to_queue_Click" />
                <asp:Button ID="btn_to_transaction_report" runat="server" Text="Transaction Report" OnClick="btn_to_transaction_report_Click" />
                 <asp:Button ID="btn_history" runat="server" Text="History" OnClick="btn_history_Click" />
                <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
                <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />            
            </nav>
            <h1>
                Manage Supplement
            </h1>

            <asp:GridView ID="GV" runat="server" OnRowEditing="btn_update" OnRowDeleting="btn_delete">
                <Columns>
                    <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="ACTION"></asp:CommandField>
                </Columns>
            </asp:GridView>

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btn_InsertSupplement" runat="server" Text="Insert Supplement" OnClick="btn_InsertSupplement_Click"/>
        </div>
    </form>
</body>
</html>
