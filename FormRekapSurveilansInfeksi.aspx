<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="FormRekapSurveilansInfeksi.aspx.vb" Inherits="FormRekapSurveilansInfeksi" title="Rekap Surveilans" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 784px">
        <tr>
            <td style="width: 31px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 277px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 31px">
            </td>
            <td colspan="3">
             <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="Rekap Surveilans Infeksi Rumah Sakit"
                    Width="680px" Font-Size="Medium" Height="40px"></asp:Label></td>
        </tr>
    </table>
    <br />
    <br />
    <ajaxToolkit:TabContainer runat="server" ActiveTabIndex="0" Height="427px"  ID="TabContainer1"
        ScrollBars="Both" Width="920px">
        <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    CellPadding="4" CssClass="mGrid" Height="30px" ShowFooter="True" Width="328px" Font-Size="7pt" Font-Italic="True">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:TemplateField HeaderText="Periode" >
                            <ItemTemplate>
                                <asp:Label ID="lblTglMasuk" runat="server"  Text='<%# Bind("tgl_trans","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kamar">
                            <ItemTemplate>
                                <asp:Label ID="lblKamar" runat="server" Text='<%# Bind("vc_nama_kamar") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nama">
                            <ItemTemplate>
                                <asp:Label ID="lblNama" runat="server" Text='<%# Bind("vc_nama_p") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NO RM">
                            <ItemTemplate>
                                <asp:Label ID="lblNoRM" runat="server" Text='<%# Bind("vc_no_rm") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Umur">
                            <ItemTemplate>
                                <asp:Label ID="lblUmur" runat="server" Text='<%# Bind("in_umurth") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        
                            <asp:TemplateField HeaderText="Jenis Kel">
                            <ItemTemplate>
                                <asp:Label ID="lblJenisKel" runat="server"  Text='<%# Bind("vc_jenis_k") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              
                            <asp:TemplateField HeaderText="Vena Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblVenaPasang" runat="server"  Text='<%# Bind("dt_vena_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Vena Aff" >
                            <ItemTemplate>
                                <asp:Label ID="lblVenaAff" runat="server" Text='<%# Bind("dt_vena_aff","{0:dd/MM/yyyy}") %>'></asp:Label >
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              <asp:TemplateField HeaderText="Jmlh Hari(Vena)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariVena" runat="server"  Text='<%# Bind("in_hari_vena") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              
                             <asp:TemplateField HeaderText="CVP/HD Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblCVPPasang" runat="server" Text='<%# Bind("dt_cvp_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="CVP/HD Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblCVPAff" runat="server" Text='<%# Bind("dt_cvp_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(CVP)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariCVP" runat="server"  Text='<%# Bind("in_hari_CVP") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Urine Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblUrinePasang" runat="server" Text='<%# Bind("dt_urine_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Urine Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblUrinePAff" runat="server" Text='<%# Bind("dt_urine_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(Urine)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariUrine" runat="server"  Text='<%# Bind("in_hari_urine") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="ETT Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblEttPasang" runat="server" Text='<%# Bind("dt_ett_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Ett Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblEttAff" runat="server" Text='<%# Bind("dt_ett_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(ETT)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariETT" runat="server"  Text='<%# Bind("in_hari_ett") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="TT Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblttPasang" runat="server" Text='<%# Bind("dt_tt_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="TT Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblttAff" runat="server" Text='<%# Bind("dt_tt_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(TT)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTT" runat="server"  Text='<%# Bind("in_hari_tt") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Venti Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblVentiPasang" runat="server" Text='<%# Bind("dt_ventilator_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Venti Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblVentiAff" runat="server" Text='<%# Bind("dt_ventilator_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(Venti)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariVenti" runat="server"  Text='<%# Bind("in_hari_ventilator") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Tirah Pasang">
                            <ItemTemplate>
                                <asp:Label ID="lblTirahPasang" runat="server" Text='<%# Bind("dt_Tirah_pasang","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Tirah Aff">
                            <ItemTemplate>
                                <asp:Label ID="lblTirahAff" runat="server" Text='<%# Bind("dt_Tirah_aff","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Jmlh Hari(Tirah)">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTirah" runat="server"  Text='<%# Bind("in_hari_Tirah") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Operasi">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTirah" runat="server"  Text='<%# Bind("operasi","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="B">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTirah" runat="server"  Text='<%# Bind("bt_operasi_b") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="K">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTirah" runat="server"  Text='<%# Bind("bt_operasi_k") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="BT">
                            <ItemTemplate>
                                <asp:Label ID="lblJmlhHariTirah" runat="server"  Text='<%# Bind("bt_operasi_bt") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="HAP">
                            <ItemTemplate>
                                <asp:Label ID="lblHAP" runat="server"  Text='<%# Bind("dt_infeksi_HAP","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="VAP">
                            <ItemTemplate>
                                <asp:Label ID="lblVAP" runat="server"  Text='<%# Bind("dt_infeksi_VAP","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="IADP">
                            <ItemTemplate>
                                <asp:Label ID="lblIADP" runat="server"  Text='<%# Bind("dt_infeksi_IADP","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="IDO">
                            <ItemTemplate>
                                <asp:Label ID="lblIDO" runat="server"  Text='<%# Bind("dt_infeksi_IDO","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                                  <asp:TemplateField HeaderText="ISK">
                            <ItemTemplate>
                                <asp:Label ID="lblISK" runat="server"  Text='<%# Bind("dt_infeksi_ISK","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Pleb">
                            <ItemTemplate>
                                <asp:Label ID="lblPleb" runat="server"  Text='<%# Bind("dt_infeksi_plebitis","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Deku">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("dt_infeksi_dekubitus","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TBC(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblTBCYa" runat="server"  Text='<%# Bind("bt_tbc_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="TBC(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblTBcTdk" runat="server"  Text='<%# Bind("bt_tbc_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="HIV(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblHIVYa" runat="server"  Text='<%# Bind("bt_hiv_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="HIV(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblHIVTdk" runat="server"  Text='<%# Bind("bt_hiv_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Hepatitis(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblHepaYa" runat="server"  Text='<%# Bind("bt_hepa_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hepatitis(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblHepaTdk" runat="server"  Text='<%# Bind("bt_hepa_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Covid(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblCovidYa" runat="server"  Text='<%# Bind("bt_covid_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Covid(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblCovidTidak" runat="server"  Text='<%# Bind("bt_covid_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Pakai Antibiotika(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblAntibiotikaYa" runat="server"  Text='<%# Bind("bt_antibiotika_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Pakai Antibiotika(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblAntibiotikaTdk" runat="server"  Text='<%# Bind("bt_antibiotika_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Antibiotika">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("vc_antibiotika") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Diagnosa">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("vc_diagnosa") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hasil Kultur MDRO(Ya)">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_mdro_ya") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hasil Kultur MDRO(Tidak)">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_mdro_tidak") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Spesimen">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("vc_spesimen") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Bakter MRSA">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_mrsa") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Bakteri MRSE">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_mrse") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bakteri Klebsiella Pneumonia ESBL">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_klebisella") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Bakteri E.Coli Strain ESBL">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_coli") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Bakteri Psedomonas Aerogenosa ESBL">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_psedomonas") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Bakteri Acinetobacter Baumanii MDR">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_MDR") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Bakteri VRE">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_VRE") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Bakteri CRE">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_CRE") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Bakteri MDR-TB">
                            <ItemTemplate>
                                <asp:Label ID="lblDeku" runat="server"  Text='<%# Bind("bt_bakteri_MDRTB") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <EditRowStyle BackColor="Blue" />
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                </asp:GridView>
                <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Icon/excel.png" />
            </ContentTemplate>
            <HeaderTemplate>
                Data
            </HeaderTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
    <ajaxToolkit:ToolkitScriptManager id="ScriptManager1" runat="server" ScriptMode="Debug" EnableScriptGlobalization="True" CombineScripts="False">
    </ajaxToolkit:ToolkitScriptManager>
</asp:Content>

