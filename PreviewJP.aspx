<%@ Page Language="VB" MasterPageFile="~/MasterPage4.master" AutoEventWireup="false" EnableEventValidation ="false"  CodeFile="PreviewJP.aspx.vb" Inherits="PreviewJP" title="Preview Jasa Pelayanan" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <asp:Label ID="lblnamakel" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#0000C0"
        Text="PREVIEW JASA PELAYANAN YANG SUDAH MASUK" Width="689px"></asp:Label><br />
    <br />
    &nbsp;
    Bulan :
    <asp:TextBox ID="TxtBulan" runat="server" Enabled="False" Width="47px"></asp:TextBox>
    Tahun :
    <asp:TextBox ID="TxtTahun" runat="server" Enabled="False" Width="47px"></asp:TextBox>
    &nbsp; &nbsp;&nbsp;
    <asp:Label ID="lblgustu" runat="server" Text="Gugus Tugas"></asp:Label>
    <asp:DropDownList ID="DDLGUGUS" runat="server" Width="199px" AutoPostBack="True">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
    <br />
    <ajax:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="427px"
        ScrollBars="Vertical" Width="711px">
        <ajax:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                Data&nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                &nbsp;<br />
                <ajax:ToolkitScriptManager ID="scriptmanager1" runat="server" CombineScripts="True">
                </ajax:ToolkitScriptManager>
                <br />
                <br />
            </ContentTemplate>
        </ajax:TabPanel>
    </ajax:TabContainer>
</asp:Content>

