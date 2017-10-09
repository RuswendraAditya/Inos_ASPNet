<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="DaftarPasien.aspx.vb" Inherits="DaftarPasien" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 927px">
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
            </td>
            <td style="width: 279px">
                <ajaxtoolkit:toolkitscriptmanager id="ScriptManager1" runat="Server" combinescripts="false"
                    enablescriptglobalization="true" enablescriptlocalization="true" scriptmode="Debug">
                </ajaxtoolkit:toolkitscriptmanager>
            </td>
            <td style="width: 224px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Icon/excel.png" /></td>
        </tr>
            <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
                NO RM: </td>
            <td style="width: 279px">
                <asp:TextBox ID="txtNoRM" runat="server" Width="296px"></asp:TextBox></td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
                NAMA</td>
            <td style="width: 279px">
                <asp:TextBox ID="txtBoxNama" runat="server" Width="296px"></asp:TextBox></td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
                TANGGAL LAHIR</td>
            <td style="width: 279px">
            <asp:TextBox ID="DateTglLahir"
                            runat="server" autocomplete="off" AutoPostBack="True" Width="94px"></asp:TextBox><ajaxtoolkit:calendarextender
                                id="CalendarExtender1" runat="server" daysmodetitleformat="dd/MM/yyyy" enabled="True"
                                format="dd/MM/yyyy" targetcontrolid="DateTglLahir" todaysdateformat="dd/MM/yyyy"> </ajaxtoolkit:calendarextender>
            </td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px; height: 49px">
            </td>
            <td style="width: 92px; height: 49px">
            </td>
            <td style="width: 279px; height: 49px">
            </td>
            <td style="width: 224px; height: 49px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td colspan="3" style="background-color: black">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
            </td>
            <td style="width: 279px">
                <asp:Button ID="BtnCari" runat="server" Height="32px" Text="Cari" Width="106px" /></td>
            <td style="width: 224px">
                <asp:Button ID="cmdKeluar" runat="server" Text="Keluar" Visible="False" Width="61px" /></td>
        </tr>
        <tr>
            <td style="width: 1px; height: 5px;">
            </td>
            <td style="width: 92px; height: 5px;">
            </td>
            <td style="width: 279px; height: 5px;">
            </td>
            <td style="width: 224px; height: 5px;">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td colspan="3" style="background-color: black">
            </td>
        </tr>
        <tr>
            <td style="width: 1px; height: 25px;">
            </td>
            <td colspan="3" style="height: 25px">
                <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="DAFTAR PASIEN"
                    Width="887px" Font-Size="Medium"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
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
                    CellPadding="4" CssClass="mGrid" ShowFooter="True" Width="100px">
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    <Columns>
                        <asp:TemplateField HeaderText="NO RM">
                            <ItemTemplate>
                                <asp:Label ID="lblNoRM" runat="server" Text='<%# Bind("vc_no_rm") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAMA PASIEN">
                            <ItemTemplate>
                                <asp:Label ID="lblNamaPasien" runat="server" Text='<%# Bind("vc_nama_p") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="280px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="TANGGAL LAHIR">
                            <ItemTemplate>
                                <asp:Label ID="lbltglLhr" runat="server" Text='<%# Bind("dt_tgl_lhr") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                     <asp:TemplateField HeaderText="J.KEL">
                            <ItemTemplate>
                                <asp:Label ID="lblKelamin" runat="server" Text='<%# Bind("vc_jenis_k") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="50px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="UMUR" >
                            <ItemTemplate>
                                <asp:Label ID="lblUmur" runat="server" Text='<%# Bind("in_umurth") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="AGAMA" >
                            <ItemTemplate>
                                <asp:Label ID="lblAgama" runat="server" Text='<%# Bind("vc_agama") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Alamat">
                            <ItemTemplate>
                                <asp:Label ID="lblAlamat" runat="server" Text='<%# Bind("vc_alamat") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                              <asp:TemplateField HeaderText="Kelurahan">
                            <ItemTemplate>
                                <asp:Label ID="lblKelurahan" runat="server" Text='<%# Bind("vc_kelurahan") %>'></asp:Label>
                            </ItemTemplate>
                                  </asp:TemplateField>
                         <asp:TemplateField HeaderText="Kecamatan">
                            <ItemTemplate>
                                <asp:Label ID="lblKecamatan" runat="server" Text='<%# Bind("vc_kecamatan") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Kota">
                            <ItemTemplate>
                                <asp:Label ID="lblKota" runat="server" Text='<%# Bind("vc_kota") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Provinsi">
                            <ItemTemplate>
                                <asp:Label ID="lblProv" runat="server" Text='<%# Bind("vc_propinsi") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NO BPJS">
                            <ItemTemplate>
                                <asp:Label ID="lblBPJS" runat="server" Text='<%# Bind("vc_no_peserta_bpjs") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Pekerjaan">
                            <ItemTemplate>
                                <asp:Label ID="lblPek" runat="server" Text='<%# Bind("vc_pekerjaan") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Detail Rawat Jalan">
                            <ItemTemplate>
                                <asp:HyperLink ID="HlRJ" runat="server" Text='Click Here'></asp:HyperLink>
                            </ItemTemplate> 
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                             <asp:TemplateField HeaderText="Detail Rawat Inap">
                            <ItemTemplate>
                                <asp:HyperLink ID="HlRinap" runat="server" Text='Click Here'></asp:HyperLink>
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
            <td style="width: 92px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
            </td>
        </tr>
    </table>
</asp:Content>


