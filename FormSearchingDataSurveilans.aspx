
<%@ Page Language="VB" EnableEventValidation = "false" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="false" CodeFile="FormSearchingDataSurveilans.aspx.vb" Inherits="FormSearchingDataSurveilans" title="Data Surveilans Infeksi Pasien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 540px">
        <tr>
            <td style="width: 2px; height: 20px">
            </td>
            <td style="width: 228px; height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 2px; height: 439px">
            </td>
            <td style="vertical-align: top; width: 228px; height: 439px">
                &nbsp;
                <asp:Label ID="LBLpasien" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Blue"
                    Width="577px">Data Surveilans Infeksi Pasien</asp:Label><br />
                <br />
                <asp:SqlDataSource ID="SdsPasien" runat="server"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True"  DataKeyNames="transaction_id,vc_no_rm,vc_no_reg" OnRowDataBound="GridView1_RowDataBound"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="Double"
                    BorderWidth="1px" CellPadding="4" CssClass="mGrid" Height="130px" PageSize="5"
                    Width="907px">
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <Columns>
                    <asp:TemplateField HeaderText="Transaction_id" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblTransaction_id" runat="server" Text='<%# Bind("transaction_id") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Periode">
                            <ItemTemplate>
                                <asp:Label ID="lblPeriode" runat="server" Text='<%# Bind("period") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No.RM">
                            <ItemTemplate>
                                <asp:Label ID="lblNoRM" runat="server" Text='<%# Bind("vc_no_rm") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="No.REG">
                            <ItemTemplate>
                                <asp:Label ID="lblNoReg" runat="server" Text='<%# Bind("vc_no_reg") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nama Pasien">
                            <ItemTemplate>
                                <asp:Label ID="lblNama" runat="server" Text='<%# Bind("VC_NAMA_P") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="100px" />
                        </asp:TemplateField>
          
                       <asp:TemplateField HeaderText="Ruang">
                            <ItemTemplate>
                                <asp:Label ID="lblRuang" runat="server" Text='<%# Bind("vc_n_ruang") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="130px" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Kamar">
                            <ItemTemplate>
                                <asp:Label ID="lblKamar" runat="server" Text='<%# Bind("vc_nama_kamar") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="130px" />
                        </asp:TemplateField>
                                      
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                </asp:GridView>
                &nbsp;&nbsp;&nbsp;
                <br />
                <asp:Button ID="BtnNewInput" runat="server" Height="48px" Text="Tambah Data" Width="104px" />
                <asp:Button ID="Button1" runat="server" Height="48px" Text="Keluar" Width="88px" /></td>
        </tr>
        <tr>
            <td style="width: 2px; height: 26px">
            </td>
            <td style="width: 228px; height: 26px">
            </td>
        </tr>
    </table>
</asp:Content>

