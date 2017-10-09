<%@ Page Language="VB" MasterPageFile="~/MasterPageBlankViewOperasi.master" AutoEventWireup="false" CodeFile="ViewOperasi.aspx.vb" Inherits="ViewOperasi" title="Informasi Operasi" %>
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
                DARI TANGGAL</td>
            <td style="width: 279px">
                <asp:TextBox ID="DateTglDari" runat="server" autocomplete="off" AutoPostBack="True"
                    Width="94px"></asp:TextBox><ajaxtoolkit:calendarextender id="CalendarExtender0" runat="server"
                        daysmodetitleformat="dd/MM/yyyy" enabled="True" format="dd/MM/yyyy" targetcontrolid="DateTglDari"
                        todaysdateformat="dd/MM/yyyy"> </ajaxtoolkit:calendarextender></td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td style="width: 92px">
                SAMPAI TANGGAL</td>
            <td style="width: 279px">
            <asp:TextBox ID="DateTglSampai"
                            runat="server" autocomplete="off" AutoPostBack="True" Width="94px"></asp:TextBox><ajaxtoolkit:calendarextender
                                id="CalendarExtender1" runat="server" daysmodetitleformat="dd/MM/yyyy" enabled="True"
                                format="dd/MM/yyyy" targetcontrolid="DateTglSampai" todaysdateformat="dd/MM/yyyy"> </ajaxtoolkit:calendarextender>
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
                <asp:Button ID="CmdPreview" runat="server" Height="32px" Text="Cari" Width="106px" /></td>
            <td style="width: 224px">
                <asp:Button ID="cmdKeluar" runat="server" Text="Keluar" Visible="False" Width="61px" /></td>
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
            <td colspan="3" style="background-color: black">
            </td>
        </tr>
        <tr>
            <td style="width: 1px">
            </td>
            <td colspan="3">
                <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="DAFTAR TINDAKAN DAN PEMBEDAHAN"
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
                    CellPadding="4" CssClass="mGrid" ShowFooter="True" Width="920px">
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    <Columns>
                        <asp:TemplateField HeaderText="JAM">
                            <ItemTemplate>
                                <asp:Label ID="lbljamOperasi" runat="server" Text='<%# Bind("dt_jam_operasi") %>'></asp:Label>
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

                        <asp:TemplateField HeaderText="NO.RM">
                            <ItemTemplate>
                                <asp:Label ID="lblNoRM" runat="server" Text='<%# Bind("VC_No_RM") %>'></asp:Label>
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
                        <asp:TemplateField HeaderText="RUANG RAWAT">
                            <ItemTemplate>
                                <asp:Label ID="lblRuang" runat="server" Text='<%# Bind("vc_n_ruang") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="180px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="OPERASI">
                            <ItemTemplate>
                                <asp:Label ID="lblTindakan" runat="server" Text='<%# Bind("vc_tindakan") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="180px" />
                        </asp:TemplateField>
                    
                        <asp:TemplateField HeaderText="DOKTER">
                            <ItemTemplate>
                                <asp:Label ID="lblDokter" runat="server" Text='<%# Bind("vc_nama_kry") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="180px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NO.OK">
                            <ItemTemplate>
                                <asp:Label ID="lblNoOK" runat="server" Text='<%# Bind("vc_no_ok") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="KET.">
                            <ItemTemplate>
                                <asp:Label ID="lblKet" runat="server" Text='<%# Bind("vc_ket_lain") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
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

