<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thongtincanhan.aspx.cs" Inherits="Lab01.Thongtincanhan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 424px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            margin-left: 98px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style5 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="8" cellspacing="0" class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style5">Thông tin cá nhân</td>
                </tr>
                <tr>
                    <td>Họ và tên</td>
                    <td>
                        <asp:TextBox ID="txtTen" runat="server" Width="189px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Giới tính</td>
                    <td>
                        <asp:RadioButton ID="rdtNam" runat="server" Text="Nam" Checked="True" GroupName="Gioitinh" />
                        <asp:RadioButton ID="rdtNu" runat="server" Text="Nữ" GroupName="Gioitinh"/>
                    </td>
                </tr>
                <tr>
                    <td>Ngoại ngữ</td>
                    <td>
                        <asp:CheckBox ID="chkAnhvan" runat="server" Text="Anh văn" />
                        <asp:CheckBox ID="chkPhapvan" runat="server" Text="Pháp văn" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Thu nhập</td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="RdtThunhapA" runat="server" Checked="True" Text="Dưới 1 triệu" GroupName="Thunhap" />
                        <asp:RadioButton ID="RdtThunhapB" runat="server" Text="1-3 Triệu" GroupName="Thunhap" />
                        <asp:RadioButton ID="RdtThunhapC" runat="server" Text="Trên 3 triệu" GroupName="Thunhap" />
                    </td>
                </tr>
                <tr>
                    <td>Trình độ</td>
                    <td>
                        <asp:RadioButtonList ID="rdtTrinhdo" runat="server" CssClass="auto-style2" RepeatDirection="Horizontal" Width="267px">
                            <asp:ListItem Selected="True">Sau đại học</asp:ListItem>
                            <asp:ListItem>Đại học</asp:ListItem>
                            <asp:ListItem>Cao đẳng</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btDangky" runat="server" CssClass="auto-style3" Text="Đăng ký" Width="108px" OnClick="btDangky_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lbThongtin" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
