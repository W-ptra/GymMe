<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSupplementPage.aspx.cs" Inherits="frontend.View.OrderSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="stylesheet" href="./css/table.css" />
    <link rel="stylesheet" href="./css/orderSupplement.css" />
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
                    <asp:Button ID="btn_order_supplement" runat="server" Text="Order" OnClick="btn_order_supplement_Click" />
                    
                </div>
            </nav>

            <h1 class="title" style="font-size:x-large;font-weight:600;">
                Order Supplement Page
            </h1>

            <asp:GridView ID="GV" runat="server" OnSelectedIndexChanged="GV_SelectedIndexChanged" >
                <Columns>
                    <asp:TemplateField HeaderText="ACTION">
                        <ItemTemplate>
                            <asp:Button ID="btn_add_supplement" runat="server" Text="SELECT" CommandName="Select" UseSubmitBehavior="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

            <section class="order_supplement_lower_part">
                <div class="form">
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

                    <div style="margin-top:0.5rem;">
                        <asp:Button ID="btn_increaseQuantity" runat="server" Text="+" OnClick="btn_increaseQuantity_Click" UseSubmitBehavior="false"/>
                        <asp:TextBox ID="TB_Quantity" runat="server" Text="1" TextMode="Number"></asp:TextBox>
                        <asp:Button ID="btn_decressQuantity" runat="server" Text="-" OnClick="btn_decressQuantity_Click" UseSubmitBehavior="false"/>
                        <asp:Button ID="btn_addToCart" runat="server" Text="Add" OnClick="btn_addToCart_Click" UseSubmitBehavior="false"/>
                    </div>

                    <div>
                        <asp:Label ID="label_message_add" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                </div>

                <div class="cart">
                    <h2>Shopping Cart</h2>
                    <asp:GridView ID="GV_Cart" runat="server"></asp:GridView>
                    <div>
                        <asp:Button ID="btn_clearCart" runat="server" Text="Clear Cart" OnClick="btn_clearCart_Click"/>
                        <asp:Button ID="btn_checkOut" runat="server" Text="Check Out" OnClick="btn_checkOut_Click" />
                    </div>
                </div>
            </section>

            

        </div>
    </form>
</body>
</html>
