<%@ Page Language="VB" MasterPageFile="~/MasterPageJP.master" AutoEventWireup="false" CodeFile="FrmInfeksi.aspx.vb" Inherits="FrmInfeksi" title="Setup Master Infeksi" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: blue">
                MASTER INFEKSI</td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="width: 109px">
            </td>
            <td style="width: 439px">
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="width: 109px">
                KODE</td>
            <td style="width: 439px">
                <asp:TextBox ID="TxtKode" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="width: 109px">
                NAMA INFEKSI</td>
            <td style="width: 439px">
                <asp:TextBox ID="TxtNama" runat="server" MaxLength="50" TabIndex="6" Width="335px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="width: 109px">
            </td>
            <td style="width: 439px">
            </td>
        </tr>
        <tr>
            <td style="height: 34px">
            </td>
            <td colspan="2" style="height: 34px">
                <asp:Button ID="CmdSimpan" runat="server" CssClass="button" Height="32px" TabIndex="1"
                    Text="Input" Width="99px" /><asp:Button ID="CmdBatal" runat="server" CssClass="button"
                        Height="32px" TabIndex="2" Text="Keluar" Width="99px" />&nbsp;<ajaxToolkit:ToolkitScriptManager
                            ID="ScriptManager1" runat="server" CombineScripts="False" EnableScriptGlobalization="True"
                            ScriptMode="Debug">
                        </ajaxToolkit:ToolkitScriptManager>
            </td>
        </tr>
    </table>
        <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="270px"
        ScrollBars="Both" Width="562px" TabIndex="40">
        <ajaxToolkit:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;DAFTAR INFEKSI &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    CellPadding="4" CssClass="mGrid" Height="150px" Width="520px">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:TemplateField HeaderText="KODE" SortExpression="vc_kd_infeksi">
                            <ItemTemplate>
                                <asp:Label ID="lblkode" runat="server" Text='<%# Bind("vc_kd_infeksi") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAMA INFEKSI" SortExpression="vc_nm_infeksi">
                            <ItemTemplate>
                                <asp:Label ID="lblNAMA" runat="server" Text='<%# Bind("vc_nm_infeksi") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="250px" />
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False" HeaderText="EDIT">
                            <ItemTemplate>
                                 <asp:ImageButton ID="ImageButton7" runat="server" OnClientClick="return confirm('Akan dilakukan pengeditan data?')" CommandName="Edit" CausesValidation="False" 
                                 CommandArgument='<%# eval("vc_kd_infeksi") %>'  ImageUrl="~/Icon/edit.GIF" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="40px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Hapus" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton5" runat="server" CausesValidation="False" CommandArgument='<%# eval("vc_kd_infeksi") %>'
                                    CommandName="Delete" ImageUrl="~/Icon/Delete.GIF" OnClientClick="return confirm('Data Mau dihapus?')" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="40px" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="Blue" />
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                </asp:GridView>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer><br />    
</asp:Content>

