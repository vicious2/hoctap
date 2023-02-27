<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlPhongBan.aspx.cs" Inherits="QuanLyNhanVien.qlPhongBan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1">Quản lý phòng ban</h2>
            <div style="margin: 0 auto; with:300 px; height: 145px; width: 359px;">
                <asp:Panel ID="Panel1" runat="server" GroupingText="Phòng ban">
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </asp:Panel>
                
            </div>
        </div>
    </form>
</body>
</html>
