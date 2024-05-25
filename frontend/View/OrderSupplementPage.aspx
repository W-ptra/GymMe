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

            <asp:GridView ID="GV" runat="server" OnSelectedIndexChanged="GV_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="ACTION">
                        <ItemTemplate>
                            <asp:Button ID="btn_add_supplement" runat="server" Text="SELECT" CommandName="Select" UseSubmitBehavior="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

            <h2>Selected Supplement</h2>

            <div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>

                </div>
                <div>
                    <asp:TextBox ID="TB_ID" runat="server" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Name" runat="server" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Expiry Date"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Expiry" runat="server" Enabled="false"></asp:TextBox>
                </div>   
            </div>
            <div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TB_Price" runat="server" Enabled="false"></asp:TextBox>
                </div>
            </div>

            <asp:Button ID="btn_increaseQuantity" runat="server" Text="+" OnClick="btn_increaseQuantity_Click" />
            <asp:TextBox ID="TB_Quantity" runat="server" Width="30px" Text="1" TextMode="Number"></asp:TextBox>
            <asp:Button ID="btn_decressQuantity" runat="server" Text="-" OnClick="btn_decressQuantity_Click"/>
            <asp:Button ID="btn_addToCart" runat="server" Text="Add" OnClick="btn_addToCart_Click"/>

            <div>
                <asp:Label ID="label_message_add" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <h2>Shopping Cart</h2>
            <asp:GridView ID="GV_Cart" runat="server"></asp:GridView>
            <asp:Button ID="btn_clearCart" runat="server" Text="Clear Cart" OnClick="btn_clearCart_Click"/>
            <asp:Button ID="btn_checkOut" runat="server" Text="Check Out" OnClick="btn_checkOut_Click" />
        </div>
    </form>
</body>
</html>
