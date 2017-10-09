<%@ Page Language="VB" MasterPageFile="~/MasterPageJP.master" AutoEventWireup="false" EnableEventValidation="false" CodeFile="FormSurveilans.aspx.vb" Inherits="FormSurveilans" title="Form Input Surveilans" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 756px">
        <tr>
            <td style="width: 18px">
            </td>
            <td style="width: 105px">
                Tgl. Entri</td>
            <td style="width: 9px">
                :</td>
            <td style="width: 185px"><asp:TextBox autocomplete="off" AutoPostBack="True" ID="DateTglEntri" runat="server" Width="94px" Enabled="False"></asp:TextBox></td>
            <td style="width: 105px">
            </td>
            <td style="width: 8px">
            </td>
            <td style="width: 85px"><ajaxToolkit:CalendarExtender DaysModeTitleFormat="dd/MM/yyyy" Enabled="True" Format="dd/MM/yyyy" ID="CalendarExtender0" runat="server" TargetControlID="DateTglEntri" TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 18px; height: 20px">
            </td>
            <td style="width: 105px; height: 20px;">
                No.RM</td>
            <td style="width: 9px; height: 20px">
                :</td>
            <td style="width: 185px; height: 20px">
                <asp:TextBox ID="TxtNoRM" runat="server" Width="93px" AutoPostBack="True"></asp:TextBox>&nbsp;</td>
            <td style="width: 105px; height: 20px">
                No.Registrasi</td>
            <td style="width: 8px; height: 20px">
                :</td>
            <td style="width: 85px; height: 20px">
                <asp:TextBox ID="TxtNoREG" runat="server" Width="84px" AutoPostBack="True"></asp:TextBox>
                <asp:LinkButton ID="LinkButton10" runat="server" Text="Riwayat Inap" Width="137px"></asp:LinkButton></td>
        </tr>
        <tr>
            <td style="width: 18px">
            </td>
            <td style="width: 105px">
                Nama</td>
            <td style="width: 9px">
                :</td>
            <td style="width: 185px">
                <asp:TextBox ID="TxtNama" runat="server" Width="203px" Enabled="False"></asp:TextBox></td>
            <td style="width: 105px">
                Alamat</td>
            <td style="width: 8px">
                :</td>
            <td style="width: 85px">
                <asp:TextBox ID="TxtAlamat" runat="server" Width="239px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 18px; height: 20px;">
            </td>
            <td style="width: 105px; height: 20px;">
                Umur</td>
            <td style="width: 9px; height: 20px;">
                :</td>
            <td style="width: 185px; height: 20px;">
                <asp:TextBox ID="TxtUmurTh" runat="server" Width="21px" Enabled="False"></asp:TextBox>
                th
                <asp:TextBox ID="TxtUmurbl" runat="server" Enabled="False" Width="26px"></asp:TextBox>
                bl&nbsp;
                <asp:TextBox ID="TxtUmurhr" runat="server" Enabled="False" Width="29px"></asp:TextBox>
                hr</td>
            <td style="width: 105px; height: 20px;">
                Jenis Kelamin</td>
            <td style="width: 8px; height: 20px;">
                :</td>
            <td style="width: 85px; height: 20px;">
                <asp:TextBox ID="TxtKelamin" runat="server" Width="115px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 18px">
            </td>
            <td style="width: 105px">
                Kamar&nbsp;
                <asp:TextBox ID="TxtKodeRuang" runat="server" Enabled="False" Width="26px"></asp:TextBox></td>
            <td style="width: 9px">
                :</td>
            <td style="width: 185px">
                <asp:TextBox ID="TxtKamar" runat="server" Width="153px" Enabled="False"></asp:TextBox></td>
            <td style="width: 105px">
                Tgl.Pulang</td>
            <td style="width: 8px">
                :</td>
            <td style="width: 85px">
                <asp:TextBox ID="dateTglPulang" runat="server" autocomplete="off" AutoPostBack="True"
                    Enabled="False" Width="94px"></asp:TextBox></td>
        </tr>
    </table>
        <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="270px"
        ScrollBars="Both" Width="750px" TabIndex="40">
        <ajaxToolkit:TabPanel ID="tbpnluser" runat="server">
            <HeaderTemplate>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;
                ALKES YANG TERPASANG &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            </HeaderTemplate>
            <ContentTemplate>
                <table style="width: 756px">
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                            IVL Pasang</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateIVLPasang" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageIVLPasang" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateIVLPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageIVLPasang">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                            IVL Aff</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateIVLAff" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageIVLAff" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateIVLAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageIVLAff">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                            CVL Pasang</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateCVLPasang" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageCVLPasang" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateCVLPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVLPasang">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                            CVL Aff</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateCVLAff" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageCVLAff" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender4" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateCVLAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVLAff">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px; height: 20px">
                            -</td>
                        <td style="width: 105px; height: 20px">
                            DC Pasang</td>
                        <td style="width: 9px; height: 20px">
                            :</td>
                        <td style="width: 158px; height: 20px">
                            <asp:TextBox ID="DateDCPasang" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageDCPasang" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px; height: 20px">
                        </td>
                        <td style="width: 8px; height: 20px">
                        </td>
                        <td style="width: 85px; height: 20px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender5" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateDCPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageDCPasang">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                            DC Aff</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateDCAff" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageDCAff" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender6" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateDCAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageDCAff">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px; height: 20px">
                            -</td>
                        <td style="width: 105px; height: 20px">
                            ETT/TT Pasang</td>
                        <td style="width: 9px; height: 20px">
                            :</td>
                        <td style="width: 158px; height: 20px">
                            <asp:TextBox ID="DateETTPasang" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageETTPasang" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px; height: 20px">
                        </td>
                        <td style="width: 8px; height: 20px">
                        </td>
                        <td style="width: 85px; height: 20px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender7" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateETTPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETTPasang">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                            ETT/TT Aff</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateETTAff" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageETTAff" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender8" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateETTAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETTAff">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                            VENTI Pasang</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateVentiPasang" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageVentiPasang" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender9" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateVentiPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentiPasang">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                            VENTI Aff</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateVentiAff" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageVentiAff" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender10" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateVentiAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentiAff">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                Tirah Baring Dari Tanggal</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateTirahDari" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageTirahDari" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender11" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateTirahDari" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahDari">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                Tirah Baring Sampai Tanggal</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="DateTirahSampai" runat="server" autocomplete="off"
                                Width="94px"></asp:TextBox>
                            <asp:ImageButton ID="ImageTirahSampai" runat="server" AlternateText="Click to show calendar"
                                ImageUrl="~/Images/Calendar.png" Width="15px" /></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender12" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateTirahSampai" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahSampai">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                Antibiotik</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="TxtAntiBiotik" runat="server" Width="203px"></asp:TextBox>
                        </td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                Catatan</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="TxtCatatan" runat="server" Width="203px"></asp:TextBox>
                        </td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
            <ajaxToolkit:ToolkitScriptManager CombineScripts="False" EnableScriptGlobalization="True" ID="ScriptManager1" runat="server" ScriptMode="Debug">
    </ajaxToolkit:ToolkitScriptManager>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                Diagnosa ICDX</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px">
                            <asp:TextBox ID="TxtDiagnosaICDX" runat="server" Width="203px"></asp:TextBox>
                        </td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                            -</td>
                        <td style="width: 105px">
                Infeksi RS</td>
                        <td style="width: 9px">
                            :</td>
                        <td style="width: 158px; vertical-align: top;">
                            <asp:DropDownList ID="ddlInfeksiRS" runat="server" Width="211px">
                            </asp:DropDownList></td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 18px">
                        </td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 9px">
                        </td>
                        <td style="width: 158px">
                        </td>
                        <td style="width: 105px">
                        </td>
                        <td style="width: 8px">
                        </td>
                        <td style="width: 85px">
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer><br />
                <asp:Button ID="cmdInput" runat="server" Text="Input" Width="97px" /><asp:Button
                    ID="Cmdbatal" runat="server" Text="Batal" Width="97px" />

        <div >
        <asp:Panel ID="Panel10" runat="server" CssClass="modalPopup" Style="display: none" BackColor="DarkKhaki" Height="433px" Width="651px">
            <br />
            <table style="width: 640px">
                <tr>
                    <td style="width: 8px; height: 366px">
                        <br />
                    </td>
                    <td style="width: 225px; height: 366px; vertical-align: top; background-color: gainsboro;">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Blue" Text="RIWAYAT RAWAT INAP"
                        Width="610px" Height="30px"></asp:Label>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                        CellPadding="4" CssClass="mGrid" Width="612px" PageSize="5">
                        <RowStyle BackColor="#E3EAEB" />
                        <Columns>
                            <asp:TemplateField HeaderText="No.Reg">
                                <ItemTemplate>
                                    <asp:Label ID="lblNoReg" runat="server" Text='<%# Bind("vc_no_reg") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" Width="50px" />
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Tgl.Msk">
                                <ItemTemplate>
                                    <asp:Label ID="lblTglMsk" runat="server" Text='<%# Bind("dt_tgl_msk", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" Width="60px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tgl.Pul">
                                <ItemTemplate>
                                    <asp:Label ID="lblTglPul" runat="server" Text='<%# Bind("dt_tgl_pul", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" Width="60px" />
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Kamar">
                                <ItemTemplate>
                                    <asp:Label ID="lblkamar" runat="server" Text='<%# Bind("vc_nama") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" Width="700px" />
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" CssClass="pgr" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="Blue" Font-Bold="True" ForeColor="Yellow" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    </asp:GridView>
                        &nbsp;<br />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 8px; height: 12px;">
                    </td>
                    <td style="width: 225px; height: 12px; background-color: gainsboro;">
                        &nbsp;<asp:Button ID="OkButton" runat="server" Text="BATAL" Width="84px" Height="25px" BackColor="Gray" /></td>
                </tr>
            </table>
            <br />
            &nbsp;<div>
                <br />
                &nbsp;</div>
        </asp:Panel>
                    <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender" runat="server" BackgroundCssClass="modalBackground"
            CancelControlID="" DropShadow="true" OkControlID="OkButton" OnOkScript="onOk()"
            PopupControlID="Panel10" PopupDragHandleControlID="Panel30" TargetControlID="LinkButton10">
        </ajaxToolkit:ModalPopupExtender>
    </div>

</asp:Content>

