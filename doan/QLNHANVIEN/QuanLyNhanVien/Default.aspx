<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuanLyNhanVien.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <div>
        <h2 style="text-align:center">QUẢN LÝ NHÂN VIÊN</h2>
            <hr />
            <div style="width:300px;margin: 0 auto">
                <asp:Panel ID="Panel1" GroupingText="Chức năng" Font-Bold="true" runat="server">
                    <div style="padding:20px">
                    <div>
                        <asp:Image ID="Image1" ImageUrl="~/Images/icon_users.gif" runat="server" />
                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/qlNhanVien.aspx" runat="server">Quản lý nhân viên</asp:HyperLink>
                    </div>
                    <div>
                        <asp:Image ID="Image2" ImageUrl="~/Images/User.gif" runat="server" />
                        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/qlPhongBan.aspx" runat="server">Quản lý phòng ban</asp:HyperLink>
                    </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </body>
</html>
