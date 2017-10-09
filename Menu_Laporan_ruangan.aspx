<%@ Page Language="VB" MasterPageFile="~/MasterPageRuangan.master" AutoEventWireup="false" CodeFile="Menu_Laporan_ruangan.aspx.vb" Inherits="Menu_Laporan_ruangan" title="Laporan Ruangan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 669px">
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 13pt; color: blue; text-align: center">
                MENU LAPORAN BULANAN PPI</td>
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
                BULAN</td>
            <td style="width: 470px">
                <asp:DropDownList ID="ddlbulan" runat="server" AutoPostBack="True" Width="48px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
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

