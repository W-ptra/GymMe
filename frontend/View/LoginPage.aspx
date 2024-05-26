<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="frontend.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="stylesheet" href="./css/LoginRegister.css" />
    <link rel="stylesheet" href="./css/login.css" />
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
                    <asp:Button ID="btn_to_login" runat="server" Text="Login" OnClick="btn_to_login_Click"/>
                    <asp:Button ID="btn_to_logout" runat="server" Text="Register" OnClick="btn_to_register_Click" />
                </div>
            </nav>

            <section class="form">
                <h1>Login Page</h1>
            
            
                <div>
                    <div>
                        <div>
                            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="TB_Username" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div>
                    <div>
                       <div>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="TB_Password" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="remember_me">
                    <asp:CheckBox ID="CheckBox" runat="server" />
                    <asp:Label ID="Label3" runat="server" Text="Remember me"></asp:Label>
                </div>
               
                <div>
                     <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
                </div>
                <div>
                    <asp:Label ID="Label_message" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
