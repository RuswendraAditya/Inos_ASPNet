<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" EnableEventValidation ="true"  CodeFile="Form_Surveilans_hasil.aspx.vb" Inherits="Form_Surveilans_hasil" title="Data Surveilans PPI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width: 15px; height: 55px">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: blue; height: 55px;">
                INPUT
                HASIL SURVIELANS</td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
            </td>
            <td style="width: 568px">
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                BULAN</td>
            <td style="width: 568px">
                <asp:DropDownList ID="ddlbulan" runat="server" AutoPostBack="True" Width="48px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
                TAHUN
                <asp:TextBox ID="TxtTahun" runat="server" MaxLength="10" TabIndex="5"
                    Width="59px" AutoPostBack="True"></asp:TextBox>&nbsp;
                 <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtTahun" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>

            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 15px;">
            </td>
            <td style="width: 202px; height: 24px;">
                RUANG</td>
            <td style="width: 568px; height: 24px;">
                <asp:DropDownList ID="ddlruang" runat="server" Width="375px" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                IADP</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtVenaSentral" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA PEMASANGAN
                <asp:TextBox ID="TxtLamaIADP" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender11" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtLamaIADP" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtVenaSentral" ValidChars="." Enabled="true">
                    </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                PLEBITIS</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtVenaPerifer" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA PEMASANGAN
                <asp:TextBox ID="TxtLamaPlebitis" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtVenaPerifer" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 15px;">
            </td>
            <td style="width: 202px; height: 20px">
                CA-UTI</td>
            <td style="width: 568px; height: 20px">
                <asp:TextBox ID="TxtCatheter" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA PEMASANGAN
                <asp:TextBox ID="TxtLamaCa_uti" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtCatheter" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                OPERASI BERSIH</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtOperasiBersih" runat="server" Enabled="False" MaxLength="10"
                    TabIndex="5" Width="59px"></asp:TextBox>&nbsp; JUMLAH PASIEN OPERASI BERSIH
                <asp:TextBox ID="TxtLamaBersih" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtOperasiBersih" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                OPERASI BT</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtOperasiBT" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; JUMLAH PASIEN OPERASI BT
                <asp:TextBox ID="TxtLamaBT" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtOperasiBT" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                OPERASI KOTOR</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtOperasiKotor" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; &nbsp;JUMLAH PASIEN OPERASI KOTOR
                <asp:TextBox ID="TxtLamaKotor" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtOperasiKotor" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                HAP</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtTirahBaring" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA TIRAH BARING
                <asp:TextBox ID="TxtLamaHAP" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender8" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtTirahBaring" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                VAP</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtVen" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA PEMASANGAN
                <asp:TextBox ID="TxtLamaVAP" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender9" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtVen" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
                DEKUBITUS</td>
            <td style="width: 568px">
                <asp:TextBox ID="TxtTB" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>&nbsp; LAMA TIRAH BARING
                <asp:TextBox ID="TxtLamaDekubitus" runat="server" Enabled="False" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender10" runat="server" FilterType="Custom, Numbers"
                    TargetControlID="TxtTB" ValidChars="." Enabled="true">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 15px">
            </td>
            <td style="width: 202px">
            </td>
            <td style="width: 568px">
            </td>
        </tr>
        <tr>
            <td style="height: 34px; width: 15px;">
            </td>
            <td colspan="2" style="height: 34px">
                <asp:Button ID="CmdSimpan" runat="server" CssClass="button" Height="32px" TabIndex="1"
                    Text="Input" Width="99px" /><asp:Button ID="CmdBatal" runat="server" CssClass="button"
                        Height="32px" TabIndex="2" Text="Keluar" Width="99px" />&nbsp;<ajaxToolkit:ToolkitScriptManager
                            ID="ScriptManager1" runat="server" CombineScripts="False" EnableScriptGlobalization="True"
                            ScriptMode="Debug">
                        </ajaxToolkit:ToolkitScriptManager>
            </td>
        </tr>
    </table>

    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="427px"
        ScrollBars="Vertical" Width="1000px">
        <ajaxToolkit:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;
                Data&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4">
                    <Columns>
                        <asp:TemplateField HeaderText="RUANG">
                            <ItemTemplate>
                                <asp:Label ID="lblRUANG" runat="server" Text='<%# Bind("vc_N_RUANG") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="120px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="IADP">
                            <ItemTemplate>
                                <asp:Label ID="lblVenaSentral" runat="server" Text='<%# Bind("dc_IADP_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LAMA IADP">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaiadp" runat="server" Text='<%# Bind("In_lama_iadp") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="PLEBITIS">
                            <ItemTemplate>
                                <asp:Label ID="lblVenaPerifer" runat="server" Text='<%# Bind("dc_Plebitis_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="LAMA PLEBITIS">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaplebitis" runat="server" Text='<%# Bind("In_lama_plebitis") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="CA-UTI">
                            <ItemTemplate>
                                <asp:Label ID="lblCatheter" runat="server" Text='<%# Bind("dc_ca_uti_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="LAMA CA_UTI">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaca_uti" runat="server" Text='<%# Bind("In_lama_ca_uti") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="BERSIH">
                            <ItemTemplate>
                                <asp:Label ID="lblOperasiBersih" runat="server" Text='<%# Bind("dc_operasi_bersih_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="JUMLAH BERSIH">
                            <ItemTemplate>
                                <asp:Label ID="lblLamabersih" runat="server" Text='<%# Bind("In_lama_bersih") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="BT">
                            <ItemTemplate>
                                <asp:Label ID="lblOperasiBt" runat="server" Text='<%# Bind("dc_operasi_bt_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="JUMLAH BT">
                            <ItemTemplate>
                                <asp:Label ID="lblLamabt" runat="server" Text='<%# Bind("In_lama_bt") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="KOTOR">
                            <ItemTemplate>
                                <asp:Label ID="lblOperasiKotor" runat="server" Text='<%# Bind("dc_operasi_kotor_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="JUMLAH KOTOR">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaKotor" runat="server" Text='<%# Bind("In_lama_kotor") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="HAP">
                            <ItemTemplate>
                                <asp:Label ID="lblTirahBaring" runat="server" Text='<%# Bind("dc_HAP_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="LAMA TIRAH BARING">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaHAP" runat="server" Text='<%# Bind("In_lama_hap") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="VAP">
                            <ItemTemplate>
                                <asp:Label ID="lblVent" runat="server" Text='<%# Bind("dc_vap_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="LAMA VAP">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaVAP" runat="server" Text='<%# Bind("In_lama_Vap") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="DEKUBITUS">
                            <ItemTemplate>
                                <asp:Label ID="lblTb" runat="server" Text='<%# Bind("dc_dekubitus_hasil") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LAMA TIRAH BARING">
                            <ItemTemplate>
                                <asp:Label ID="lblLamaPlebitis" runat="server" Text='<%# Bind("in_lama_dekubitus") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        </asp:TemplateField>


                    </Columns>
                    <EditRowStyle BackColor="Blue" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666"  ForeColor="White"/>
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                </asp:GridView>
                <br />
                <br />
                <br />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>


    <br />
    <br />
    <br />
            <br />    
                <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>

</asp:Content>

