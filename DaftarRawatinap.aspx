<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="DaftarRawatinap.aspx.vb" Inherits="DaftarRawatinap" title="Daftar Rawat Inap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 927px">
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Icon/excel.png" /></td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td colspan="3">
                <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="DAFTAR RAWAT INAP PASIEN"
                    Width="887px" Font-Size="Medium"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    CellPadding="4" CssClass="mGrid" ShowFooter="True" Width="920px">
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    <Columns>
                        <asp:TemplateField HeaderText="NO RM">
                            <ItemTemplate>
                                <asp:Label ID="lblNORM" runat="server" Text='<%# Bind("vc_no_rm") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAMA PASIEN">
                            <ItemTemplate>
                                <asp:Label ID="lblNamapasien" runat="server" Text='<%# Bind("vc_nama_p") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="280px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="NO.REG">
                            <ItemTemplate>
                                <asp:Label ID="lblNoReg" runat="server" Text='<%# Bind("vc_no_reg") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="TANGGAL MASUK">
                            <ItemTemplate>
                                <asp:Label ID="lbltglmasuk" runat="server" Text='<%# Bind("dt_tgl_msk") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="TANGGAL KELUAR">
                            <ItemTemplate>
                                <asp:Label ID="lbltglkeluar" runat="server" Text='<%# Bind("dt_tgl_pul") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="50px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="KAMAR" >
                            <ItemTemplate>
                                <asp:Label ID="lblKamar" runat="server" Text='<%# Bind("vc_nama") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="KELAS" >
                            <ItemTemplate>
                                <asp:Label ID="lblKelas" runat="server" Text='<%# Bind("vc_n_kelas") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Dokter" >
                            <ItemTemplate>
                                <asp:Label ID="lblDokter" runat="server" Text='<%# Bind("vc_nama_kry") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    
                    <EditRowStyle BackColor="Blue" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                </asp:GridView>
                <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
            </td>
        </tr>
    </table>
</asp:Content>
