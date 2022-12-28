<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lab01.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 38%;
            border-style: solid;
            border-width: 1px;
            height: 220px;
        }
        .auto-style2 {
            width: 71px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="20" class="auto-style1">
                <tr>
                    <td class="auto-style2">nhap so 1</td>
                    <td>
                        <asp:TextBox ID="txtso1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">nhap so 2</td>
                    <td>
                        <asp:TextBox ID="txtso2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btcong" runat="server" Text="cong" OnClick="btcong_Click" />
                        <asp:Button ID="bttru" runat="server" Text="tru" OnClick="bttru_Click" />
                        <asp:Button ID="btnhan" runat="server" Text="nhan" OnClick="btnhan_Click" />
                        <asp:Button ID="btchia" runat="server" Text="chia" OnClick="btchia_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ket qua</td>
                    <td>
                        <asp:TextBox ID="txtkq" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
