<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Laporan_Operasi.aspx.vb" Inherits="Laporan_Operasi" title="Laporan Operasi" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 669px">
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 13pt; color: blue; text-align: center">
                MENU LAPORAN OPERASI</td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 20px">
            </td>
            <td style="width: 110px; height: 20px">
            </td>
            <td style="width: 470px; height: 20px">
                <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="Server" CombineScripts="false"
                    EnableScriptGlobalization="true" EnableScriptLocalization="true" ScriptMode="Debug">
                </ajaxToolkit:ToolkitScriptManager>
            </td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 7px;">
            </td>
            <td style="width: 110px; height: 7px;">
                DARI
                TANGGAL</td>
            <td style="width: 470px; height: 7px;">
                <asp:TextBox ID="DateTglDari" runat="server" autocomplete="off" AutoPostBack="True"
                    Width="94px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender0" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateTglDari" TodaysDateFormat="dd/MM/yyyy">
                </ajaxToolkit:CalendarExtender>
                </td>
            <td style="height: 7px">
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td style="width: 110px">
                SAMPAI TANGGAL</td>
            <td style="width: 470px">
                <asp:TextBox ID="DateTglSampai" runat="server" autocomplete="off" AutoPostBack="True"
                    Width="94px"></asp:TextBox><ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server"
                        DaysModeTitleFormat="dd/MM/yyyy" Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateTglSampai"
                        TodaysDateFormat="dd/MM/yyyy">
                    </ajaxToolkit:CalendarExtender>
                </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px; height: 33px">
            </td>
            <td style="width: 110px; height: 33px">
            </td>
            <td style="width: 470px; height: 33px">
            </td>
            <td style="height: 33px">
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
                &nbsp;</td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 13px">
            </td>
            <td colspan="2">
                <asp:Button ID="CmdPreview" runat="server" Text="Preview" Width="61px" />
                <asp:Button ID="cmdKeluar" runat="server" Text="Keluar" Width="61px" Visible="False" /></td>
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
                &nbsp;</td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

