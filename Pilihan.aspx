<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Pilihan.aspx.vb" Inherits="Pilihan"  EnableEventValidation ="false" title="DAFTAR JENIS PELAYANAN" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
    <table style="width: auto">
        <tr>
            <td colspan="3" style="font-weight: bold; font-size: 14pt; color: blue; text-align: center">
                PILIH JENIS PELAYANAN ANDA</td>
        </tr>
        <tr>
            <td style="width: 1589px; text-align: center">
            </td>
            <td style="width: 922px; text-align: center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" Width="424px">
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    <Columns>
                        <asp:TemplateField HeaderText="KODE">
                            <ItemTemplate>
                                <asp:Label ID="lblKode" runat="server" Text='<%# Bind("vc_kd_kel") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="JENIS PELAYANAN (JP)">
                            <ItemTemplate>
                                <asp:Label ID="lblNAMA" runat="server" Text='<%# Bind("vc_NAMA_KEL") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="200px" />
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="Blue" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                </asp:GridView>
            </td>
            <td style="width: 981px; text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <br />
                <asp:Button ID="cmdkeluar" runat="server" Font-Bold="True" Font-Underline="True" Text="Keluar"
                    Width="112px" /></td>
        </tr>
    </table>
</asp:Content>

