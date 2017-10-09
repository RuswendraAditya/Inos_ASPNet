<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FrmbKamar.aspx.vb" Inherits="FrmbKamar" title="Pasien Inap Per Ruang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width: 31px">
            </td>
            <td colspan="1" style="width: 969px">
                <asp:Label ID="LBLpasien" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Blue"
                    Width="843px">PASIEN INAP PER RUANG</asp:Label></td>
        </tr>
        <tr>
            <td style="width: 31px;">
            </td>
            <td style="width: 969px;">
            </td>
        </tr>
        <tr>
            <td style="width: 31px; height: 48px;">
            </td>
            <td colspan="1" style="height: 48px; width: 969px;">
                RUANG :
                <asp:DropDownList ID="DDLRUANG" runat="server" Width="235px" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 31px">
            </td>
            <td style="width: 969px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                    BackColor="White" BorderColor="#3366CC" BorderStyle="Double" BorderWidth="1px"
                    CellPadding="4" CssClass="mGrid" Height="130px" PageSize="5" Width="959px">
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <Columns>
                        <asp:TemplateField HeaderText="Nama Kamar">
                            <ItemTemplate>
                                <asp:Label ID="lblNama" runat="server" Text='<%# Bind("VC_NAMA") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="130px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kelas">
                            <ItemTemplate>
                                <asp:Label ID="lblKelas" runat="server" Text='<%# Bind("VC_N_kelas") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="80px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="No.RM">
                            <ItemTemplate>
                                <asp:Label ID="LblNoRM" runat="server" Text='<%# Bind("vc_No_RM") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No.REG">
                            <ItemTemplate>
                                <asp:Label ID="LblNoREG" runat="server" Text='<%# Bind("vc_No_REG") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nama Pasien">
                            <ItemTemplate>
                                <asp:Label ID="LblNamaPasien" runat="server" Text='<%# Bind("vc_nama_p") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Alamat">
                            <ItemTemplate>
                                <asp:Label ID="lblAlamat" runat="server" Text='<%# Bind("vc_alamat") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tgl.Masuk">
                            <ItemTemplate>
                                <asp:Label ID="lblTglMasuk" runat="server" Text='<%# Bind("DT_Tgl_msk", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Umur">
                            <ItemTemplate>
                                <asp:Label ID="Labelumur" runat="server" Text='<%# Bind("umur") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Diagnosa">
                            <ItemTemplate>
                                <asp:Label ID="LabelDiagnosa" runat="server" Text='<%# Bind("vc_alergi") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Nama Diagnosa">
                            <ItemTemplate>
                                <asp:Label ID="LabelNamaDiagnosa" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>


                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                </asp:GridView>
                <asp:SqlDataSource ID="SdsPasien" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

