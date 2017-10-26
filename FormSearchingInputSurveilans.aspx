<%@ Page Language="VB" EnableEventValidation = "false" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="false" CodeFile="FormSearchingInputSurveilans.aspx.vb" Inherits="FormSearchingInputSurveilans" title="Pencarian Pasien Inap" %>
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
                    Width="577px">PENCARIAN DATA PASIEN INAP</asp:Label><br />
                <table style="width: 473px; color: blue">
                    <tr>
                        <td colspan="3">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 263px; color: Blue; height: 21px">
                            Nama Pasien</td>
                        <td style="width: 5px; color: Blue; height: 21px">
                            :</td>
                        <td style="width: 1389px; height: 21px">
                            <asp:TextBox ID="TxtCariNama" runat="server" MaxLength="50" TabIndex="3" Width="239px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 263px; color: Blue; height: 21px">
                            Kelurahan</td>
                        <td style="width: 5px; color: Blue; height: 21px">
                            :</td>
                        <td style="width: 1389px">
                            <asp:TextBox ID="TxtCariKelurahan" runat="server" MaxLength="50" TabIndex="3" Width="239px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 263px; color: Blue; height: 21px">
                            Kecamatan</td>
                        <td style="width: 5px; color: Blue; height: 21px">
                            :</td>
                        <td style="width: 1389px">
                            <asp:TextBox ID="TxtCariKecamatan" runat="server" MaxLength="50" TabIndex="3" Width="239px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 263px; color: Blue; height: 21px">
                            Kota</td>
                        <td style="width: 5px; color: Blue; height: 21px">
                            :</td>
                        <td style="width: 1389px">
                            <asp:TextBox ID="TxtCariKota" runat="server" MaxLength="50" TabIndex="3" Width="239px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 263px; color: Blue; height: 26px">
                            No.RM</td>
                        <td style="width: 5px; color: Blue; height: 21px">
                            :</td>
                        <td style="width: 1389px; height: 26px">
                            <asp:TextBox ID="TxtCariNoRM" runat="server" MaxLength="50" TabIndex="3" Width="120px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 263px">
                        </td>
                        <td style="width: 5px">
                        </td>
                        <td style="width: 1389px">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 34px">
                            <asp:Button ID="CmdCariPasien" runat="server" CssClass="button" Height="32px" Text="Cari"
                                Width="99px" />&nbsp;
                            <asp:Button ID="btnKeluar" runat="server" Height="32px" Text="Keluar" /></td>
                    </tr>
                </table>
                <asp:SqlDataSource ID="SdsPasien" runat="server"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" DataKeyNames="vc_no_rm,vc_no_reg" OnRowDataBound="GridView1_RowDataBound"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="Double"
                    BorderWidth="1px" CellPadding="4" CssClass="mGrid" Height="130px" PageSize="5"
                    Width="907px">
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <Columns>
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
                        <%--<asp:TemplateField HeaderText="Kelurahan">
                            <ItemTemplate>
                                <asp:Label ID="LabelKelurahan" runat="server" Text='<%# Bind("vc_kelurahan") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kecamatan">
                            <ItemTemplate>
                                <asp:Label ID="LabelKecamatan" runat="server" Text='<%# Bind("vc_kecamatan") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kota">
                            <ItemTemplate>
                                <asp:Label ID="LabelKota" runat="server" Text='<%# Bind("vc_Kota") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>--%>
                       <asp:TemplateField HeaderText="Kamar Terakhir">
                            <ItemTemplate>
                                <asp:Label ID="lblKamar" runat="server" Text='<%# Bind("kamar") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="130px" />
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
                            <HeaderStyle Width="100px" />
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
                &nbsp;&nbsp;
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 2px; height: 26px">
            </td>
            <td style="width: 228px; height: 26px">
            </td>
        </tr>
    </table>
</asp:Content>

