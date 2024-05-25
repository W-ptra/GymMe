<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertSupplementPage.aspx.cs" Inherits="frontend.View.InsertSupplementPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_back" runat="server" Text="<=== BACK" OnClick="btn_back_Click"/>
            <h1>INSERT SUPPLEMENT</h1><br />

            <div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Name" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Expiry Date"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Date" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Price" runat="server" TextMode="Number"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Type Id"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_TypeId" runat="server" TextMode="Number"></asp:TextBox>
                </div>
            </div>
            <br />
            <div>
                <asp:Label ID="label_message" runat="server" Text=""></asp:Label>
            </div>
            <asp:Button ID="btn_insert" runat="server" Text="INSERT" OnClick="btn_insert_Click" />
        </div>
    </form>
</body>
</html>
