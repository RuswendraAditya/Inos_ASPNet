<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Triwulan.aspx.vb" Inherits="Triwulan" title="LAPORAN TRIWULAN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 669px">
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 13pt; color: blue; text-align: center">
                MENU LAPORAN TRIWULAN</td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 20px">
            </td>
            <td style="width: 110px; height: 20px">
            </td>
            <td style="width: 470px; height: 20px">
            </td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 20px;">
            </td>
            <td style="width: 110px; height: 20px;">
                RUANG</td>
            <td style="width: 470px; height: 20px;">
                <asp:DropDownList ID="DDLRUANG" runat="server" AutoPostBack="True" Width="235px">
                </asp:DropDownList></td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 110px">
                TRIWULAN</td>
            <td style="width: 470px">
                <asp:DropDownList ID="ddlTriwulan" runat="server" AutoPostBack="True" Width="48px">
                    <asp:ListItem Value="1">I</asp:ListItem>
                    <asp:ListItem Value="2">II</asp:ListItem>
                    <asp:ListItem Value="3">III</asp:ListItem>
                    <asp:ListItem Value="4">IV</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 110px">
                TAHUN</td>
            <td style="width: 470px">
                <asp:TextBox ID="TxtTahun" runat="server" AutoPostBack="True" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 470px; background-color: gray;" colspan="2">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2">
                <asp:LinkButton ID="LBHAIs" runat="server" ForeColor="DarkBlue" Width="223px">HAIs</asp:LinkButton></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2">
                <asp:LinkButton ID="LBSSi" runat="server" ForeColor="DarkBlue" Width="223px">SSi</asp:LinkButton></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 110px">
            </td>
            <td style="width: 470px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 110px">
            </td>
            <td style="width: 470px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2">
                &nbsp;<asp:Button ID="cmdKeluar" runat="server" Text="Keluar" Width="61px" Visible="False" /></td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

