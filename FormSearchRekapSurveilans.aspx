<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FormSearchRekapSurveilans.aspx.vb" Inherits="FormSearchRekapSurveilans" title="Laporan Surveilans Infeksi per Ruangan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 669px">
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 13pt; color: blue; text-align: center">
                MENU PENCARIAN REKAP SURVEILANS INFEKSI</td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 20px">
            </td>
            <td style="width: 122px; height: 20px">
            </td>
            <td style="width: 470px; height: 20px">
            </td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 20px;">
            </td>
            <td style="width: 122px; height: 20px;">
                RUANG</td>
            <td style="width: 470px; height: 20px;">
                <asp:DropDownList ID="DDLRUANG" runat="server" AutoPostBack="True" Width="416px">
                </asp:DropDownList></td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 122px">
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
            <td style="width: 13px; height: 29px;">
            </td>
            <td style="width: 122px; height: 29px;">
                TAHUN</td>
            <td style="width: 470px; height: 29px;">
                <asp:TextBox ID="TxtTahun" runat="server" AutoPostBack="True" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox></td>
            <td style="height: 29px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 14px;">
            </td>
            <td style="height: 14px; width: 122px;">
            </td>
        </tr>
       
    </table>
                <div align="center">
                 <asp:Button ID="BtnView" runat="server" Text="View Data" Width="112px" Height="40px" />
           </div>
</asp:Content>