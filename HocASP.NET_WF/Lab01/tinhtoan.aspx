<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tinhtoan.aspx.cs" Inherits="Lab01.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 48%;
            border-style: solid;
            border-width: 1px;
            height: 311px;
        }
        .auto-style2 {
            width: 71px;
        }
        .auto-style3 {
            width: 71px;
            height: 76px;
        }
        .auto-style4 {
            height: 76px;
            width: 283px;
        }
        .auto-style5 {
            width: 283px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="20" class="auto-style1">
                <tr>
                    <td class="auto-style2">nhap so 1</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtso1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator">(*)</asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator">(*)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">nhap so 2</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtso2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator">(*)</asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator">(*)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btcong" runat="server" Text="cong" OnClick="btcong_Click" />
                        <asp:Button ID="bttru" runat="server" Text="tru" OnClick="bttru_Click" />
                        <asp:Button ID="btnhan" runat="server" Text="nhan" OnClick="btnhan_Click" />
                        <asp:Button ID="btchia" runat="server" Text="chia" OnClick="btchia_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">ket qua</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtkq" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
