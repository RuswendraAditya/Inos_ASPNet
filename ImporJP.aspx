<%@ Page Language="VB" MasterPageFile="~/MasterPageJP.master" AutoEventWireup="false" ValidateRequest="false" CodeFile="ImporJP.aspx.vb" EnableEventValidation = "false" Inherits="ImporJP" title="Import Data Jasa Pelayanan" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        function ShowProgress() {
            setTimeout(function () {
                var modal = $('<div />');
                modal.addClass("modal");
                $('body').append(modal);
                var loading = $(".loading");
                loading.show();
                var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
                var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
                loading.css({ top: top, left: left });
            }, 200);
        }
        $('form').live("submit", function () {
            ShowProgress();
        });

    </script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        function ShowProgress() {
            setTimeout(function () {
                var modal = $('<div />');
                modal.addClass("modal");
                $('body').append(modal);
                var loading = $(".loading");
                loading.show();
                var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
                var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
                loading.css({ top: top, left: left });
            }, 200);
        }
        $('form').live("submit", function () {
            ShowProgress();
        });

    </script>

    <table bgcolor="#66ccff" style="width: 721px">
        <tr>
            <td style="width: 223px; height: 36px">
                Bulan :
                <asp:TextBox ID="TxtBulan" runat="server" Enabled="False" Width="47px"></asp:TextBox>
                Tahun :
                <asp:TextBox ID="TxtTahun" runat="server" Enabled="False" Width="47px"></asp:TextBox></td>
            <td style="width: 360px; height: 36px">


        <asp:FileUpload ID="FileUpload1" runat="server" Width="310px" ForeColor="Red" /></td>
            <td style="height: 36px; text-align: right">
        <asp:Button ID="btnSubmit" runat="server"
            OnClick="btnSubmit_Click" Text="Upload" BackColor="Yellow" /></td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblnamakel" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#0000C0"
        Text="IMPORT JASA PELAYANAN EXCEL" Width="710px"></asp:Label><br />
    <br />
    <ajax:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="339px"
        ScrollBars="Both" Width="727px">
        <ajax:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                Data&nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                <asp:Label ID="lblinfo" runat="server" ForeColor="Red" Width="658px"></asp:Label>&nbsp;<br />
                <table style="width: 695px" border="1">
                    <tr>
                        <td style="width: 309px; vertical-align: top;" bordercolor="#000000">

        <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging = "PageIndexChanging" Height="1px" Width="470px" CssClass="mGrid"  >
        <RowStyle BackColor="#E3EAEB" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="Blue" />
        <AlternatingRowStyle BackColor="White" CssClass="alt" />

        </asp:GridView>
                        </td>
                        <td style="width: 184px; vertical-align: top;">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Maroon" Text=" Data Missing"
                                Width="207px"></asp:Label><br />
                            <asp:TextBox ID="TxtCatatan" runat="server" Height="285px" Width="209px" TextMode="MultiLine" Visible="False" ForeColor="Blue"></asp:TextBox>
    <ajax:htmleditorextender id="htmlEditorExtender1" runat="server" enabled="True"
        enablesanitization="False" enableviewstate="False" targetcontrolid="TxtCatatan">
        <Toolbar>
            <ajax:Bold />
            <ajax:Italic />
            <ajax:Underline />
        </Toolbar>
                        </ajax:htmleditorextender>
    </td>
                    </tr>
                </table>
            </ContentTemplate>
        </ajax:TabPanel>
    </ajax:TabContainer>
    <table style="width: 487px">
        <tr>
            <td style="width: 193px; height: 20px">
    <asp:Button ID="Button1" runat="server" Text="Kirim Data Ke SDM" Width="182px" BackColor="Red" Font-Bold="True" ForeColor="White" /></td>
            <td style="height: 20px; width: 174px;">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Maroon" Text="T O T A L  :"
                    Width="128px"></asp:Label></td>
            <td style="height: 20px">
                <asp:TextBox ID="TxtTotal" runat="server" Width="87px"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    &nbsp;<br />
    <ajax:ToolkitScriptManager ID="scriptmanager1" runat="server">
    </ajax:ToolkitScriptManager>
    <div class="loading" align="center">
        Sedang proses,silahkan tunggu...<br />
        <br />
        <img src="loader.gif" alt="" />
    </div>
    <div class="col3" style="width: 244px; height: 75px; left: 479px; position: relative; top: -56px;">
        &nbsp;<img src="images/hdbullet.gif" /><span class="midtitle">DATA MISSING&nbsp;<br />
            1. Nik Salah<br />
            2. Nik (karyawan sudah tidak aktif)<br />
            3. Rupiah tidak boleh 0</span><br />
        <br />
    </div>
    &nbsp; &nbsp;&nbsp;&nbsp;
    <br />
    <br />
</asp:Content>

