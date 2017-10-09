<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FrmBRuang.aspx.vb" Inherits="FrmBRuang" title="DAFTAR RUANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table style="width: 611px">
        <tr>
            <td style="width: 286px; height: 48px">
            </td>
            <td style="height: 48px">
                <asp:Label ID="LBLpasien" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Blue"
                    Width="577px">DAFTAR RUANG</asp:Label><asp:SqlDataSource ID="SdsPasien"
                        runat="server"></asp:SqlDataSource>
            </td>
            <td style="height: 48px; width: 83px;">
            </td>
        </tr>
        <tr>
            <td style="width: 286px">
            </td>
            <td>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
        BackColor="White" BorderColor="#3366CC" BorderStyle="Double" BorderWidth="1px"
        CellPadding="4" CssClass="mGrid" Height="130px" PageSize="5" Width="456px">
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:TemplateField HeaderText="KODE">
                <ItemTemplate>
                   <asp:LinkButton ID="GetBaca" CommandName="GetBaca" CommandArgument='<%#Eval("VC_k_ruang") %>'  Font-Bold="False" ForeColor="blue" runat="server" ><%#Eval("vc_k_ruang")%> </asp:LinkButton>                           
                </ItemTemplate>
                <HeaderStyle ForeColor="White" Width="50px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nama Ruang">
                <ItemTemplate>
                    <asp:LinkButton ID="GetBaca" CommandName="GetBaca" CommandArgument='<%#Eval("VC_k_ruang") %>'  Font-Bold="False" ForeColor="blue" runat="server" ><%#Eval("vc_n_ruang")%> </asp:LinkButton>                           
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="450px" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" CssClass="alt" />
    </asp:GridView>
            </td>
            <td style="width: 83px">
            </td>
        </tr>
        <tr>
            <td style="width: 286px">
            </td>
            <td>
            </td>
            <td style="width: 83px">
            </td>
        </tr>
    </table>
</asp:Content>

