<%@ Page Language="VB" MasterPageFile="~/MasterPageJP.master" ValidateRequest ="false" AutoEventWireup="false" CodeFile="EntriJPManual.aspx.vb"  Inherits="EntriJPManual" title="Entri JP Manual" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <asp:Label ID="Lblnamakel" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#0000C0"
        Text="ENTRI JASA PELAYANAN MANUAL" Width="672px"></asp:Label><br />
    <br />
    &nbsp;
    Bulan :
    <asp:TextBox ID="TxtBulan" runat="server" Enabled="False" Width="47px"></asp:TextBox>
    Tahun :
    <asp:TextBox ID="TxtTahun" runat="server" Enabled="False" Width="47px"></asp:TextBox>
    &nbsp; &nbsp;&nbsp;<br />
    <br />
    &nbsp;
    <asp:Label ID="lblinfo" runat="server" ForeColor="Red" Width="582px"></asp:Label><br />
    ________________________________________________________________________________________<br />
    <table style="width: 584px">
        <tr>
            <td style="width: 156px;">
            </td>
            <td style="width: 10px;">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 156px">
                NIK</td>
            <td style="width: 10px">
                :</td>
            <td>
                <asp:TextBox ID="TxtNik" runat="server" Width="114px" AutoPostBack="True" MaxLength="4" Enabled="False"></asp:TextBox>
        </tr>
        <tr>
            <td style="width: 156px; height: 26px;">
                NAMA KARYAWAN</td>
            <td style="width: 10px; height: 26px;">
                :</td>
            <td style="height: 26px">
                <asp:TextBox ID="TxtNama" runat="server" Width="272px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 156px">
                RUPIAH</td>
            <td style="width: 10px">
                :</td>
            <td>
                <asp:TextBox ID="TxtRupiah" runat="server" Width="133px" style='text-align:right' Enabled="False"></asp:TextBox>
                <ajax:FilteredTextBoxExtender ID="FilteredTextBoxRp" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtRupiah" ValidChars="." Enabled="true">
                </ajax:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                _______________________________________________________________________________________</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="cmdInput" runat="server" Text="Input" Width="97px" />
                <asp:Button ID="Cmdbatal" runat="server" Text="Batal" Width="97px" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;<asp:CheckBox ID="chkData" runat="server"
                    AutoPostBack="True" ForeColor="Red" Text="Tampilkan Data Grid" Width="205px" Checked="True" />
                &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
    </table>
    ________________________________________________________________________________________<br />
    <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;
    <br />
    <ajax:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="427px"
        ScrollBars="Both" Width="711px">
        <ajax:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                Data&nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" CssClass="mGrid" Width="677px">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:TemplateField HeaderText="NIK" SortExpression="vc_nIK">
                        <ItemTemplate>
                            <asp:Label ID="lblnik" runat="server" Text='<%# Bind("vc_nik") %>'></asp:Label>
                        </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAMA KARYAWAN" SortExpression="vc_nama_kry">
                        <ItemTemplate>
                            <asp:Label ID="lblNAMA" runat="server" Text='<%# Bind("vc_NAMA_KRY") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Width="280px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RUPIAH" SortExpression="dc_rupiah">
                            <ItemTemplate>
                                <asp:Label ID="lblRupiah" runat="server" Text='<%# Bind("dc_rupiah","{0:n}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="100px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="GUGUS TUGAS">
                        <ItemTemplate>
                            <asp:Label ID="lblGUSTU" runat="server" Text='<%# Bind("vc_n_gugus") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False" HeaderText="EDIT">
                            <ItemTemplate>
                                 <asp:ImageButton ID="ImageButton7" runat="server" OnClientClick="return confirm('Akan dilakukan pengeditan data?')" CommandName="Edit" CausesValidation="False" 
                                 CommandArgument='<%# eval("vc_NIK") %>'  ImageUrl="~/Icon/edit.GIF" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="40px" />
                        </asp:TemplateField>

                        <asp:TemplateField ShowHeader="False" HeaderText="Hapus">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton5" runat="server" OnClientClick="return confirm('Data Mau dihapus?')" CommandName="Delete" CausesValidation="False" 
                                 CommandArgument='<%# eval("vc_NIK") %>'  ImageUrl="~/Icon/Delete.GIF" />
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
                <br />
                <ajax:ToolkitScriptManager ID="scriptmanager1" runat="server">
                </ajax:ToolkitScriptManager>
                <br />
                <br />
            </ContentTemplate>
        </ajax:TabPanel>
    </ajax:TabContainer>
</asp:Content>

