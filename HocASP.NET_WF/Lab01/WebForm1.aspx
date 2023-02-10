<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
            height: 84px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 116px;
            color: #0033CC;
        }
        .auto-style4 {
            height: 23px;
            width: 116px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            color: #990000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style3"><strong>Chọn tập tin:</strong></td>
                    <td>
                        <asp:FileUpload ID="FUpload" runat="server" CssClass="auto-style5" Width="307px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style2"><strong>
                        <asp:Button ID="btnXuly" runat="server" Font-Bold="True" OnClick="btnXuly_Click" Text="Upload" />
                        </strong></td>
                </tr>
                <tr>
                    <td colspan="2"><strong>
                        <asp:Label ID="lbThongbao" runat="server" CssClass="auto-style6"></asp:Label>
                        </strong></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
