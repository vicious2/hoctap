<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dondathang.aspx.cs" Inherits="Lab01.Dondathang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
            height: 330px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 237px;
        }
        .auto-style5 {
            height: 23px;
            width: 237px;
        }
        .auto-style6 {
            width: 237px;
            text-align: center;
        }
        .auto-style7 {
            width: 237px;
            height: 79px;
            text-align: center;
        }
        .auto-style8 {
            height: 79px;
        }
        .auto-style10 {
            width: 237px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style12 {
            height: 23px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">ĐƠN ĐẶT HÀNG</td>
                </tr>
                <tr>
                    <td class="auto-style4">Khách hàng:</td>
                    <td>
                        <asp:TextBox ID="txtHoten" runat="server" Width="238px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Địa chỉ:</td>
                    <td>
                        <asp:TextBox ID="txtDiachi" runat="server" Width="238px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Mã số thuế:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtMasothue" runat="server" Width="236px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Chọn các loại bánh sau:</td>
                    <td class="auto-style3">Danh sách bánh được đặt</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlBanh" runat="server" Height="16px" Width="229px">
                            <asp:ListItem>Bánh ít</asp:ListItem>
                            <asp:ListItem>Bánh đa</asp:ListItem>
                            <asp:ListItem>Bánh su</asp:ListItem>
                            <asp:ListItem>Bánh bao</asp:ListItem>
                            <asp:ListItem>Bánh bắp</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:ListBox ID="lstBanh" runat="server" Width="183px"></asp:ListBox>
&nbsp;
                        <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="Button" Width="35px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Số lượng:
                        <asp:TextBox ID="txtSoLuong" runat="server" Height="16px" Width="67px"></asp:TextBox>
&nbsp;cái<br />
                        <asp:Label ID="lbLoi" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnThem" runat="server" BorderStyle="Inset" OnClick="btnThem_Click" Text="&gt;" Width="39px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="btnInhoadon" runat="server" BackColor="#009900" OnClick="btnInhoadon_Click" Text="In đơn đặt hàng" />
                        <br />
                        <asp:Label ID="lbThongtin" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
