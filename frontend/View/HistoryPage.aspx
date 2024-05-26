<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryPage.aspx.cs" Inherits="frontend.View.HistoryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="stylesheet" href="./css/table.css" />
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
                    <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />
                    <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
                    <asp:Button ID="btn_history" runat="server" Text="History" OnClick="btn_history_Click" />
                    <asp:Button ID="btn_to_home" runat="server" Text="Home" OnClick="btn_to_home_Click" />
                    <asp:Button ID="btn_to_manage_supplement" runat="server" Text="Manage" OnClick="btn_to_manage_supplement_Click" />
                    <asp:Button ID="btn_to_order_queue" runat="server" Text="Queue" OnClick="btn_to_queue_Click" />
                    <asp:Button ID="btn_to_transaction_report" runat="server" Text="Report" OnClick="btn_to_transaction_report_Click" />

                    <asp:Button ID="btn_order_supplement" runat="server" Text="Order" OnClick="btn_order_supplement_Click" />
                </div>
            </nav>
            <h1 class="title">History Page</h1><br />
            <asp:GridView ID="GV" runat="server" OnSelectedIndexChanged="GV_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="ACTION">
                        <ItemTemplate>
                            <asp:Button ID="btn_select" runat="server" Text="VIEW" UseSubmitBehavior="false" CommandName="select"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
