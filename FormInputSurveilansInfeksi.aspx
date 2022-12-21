<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false"
    EnableEventValidation="true" CodeFile="FormInputSurveilansInfeksi.aspx.vb" Inherits="FormInputSurveilansInfeksi"
    Title="Input Surveilans Infeksi Pasien" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager CombineScripts="False" EnableScriptGlobalization="True"
        ID="ScriptManager1" runat="server" ScriptMode="Debug">
    </ajaxToolkit:ToolkitScriptManager>
    <table style="width: 500px">
        <tr>
            <td style="width: 210px; height: 55px">
            </td>
            <td style="width: 105px; height: 55px;">
            </td>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: blue; height: 55px;">
                DATA DEMOGRAFI PASIEN</td>
        </tr>
        <tr>
            <td style="width: 210px; height: 16px">
            </td>
            <td style="width: 105px; height: 16px;">
                No.RM</td>
            <td style="width: 9px; height: 16px">
                :</td>
            <td style="width: 486px; height: 16px">
                <asp:TextBox ID="TxtNoRM" runat="server" Width="93px" AutoPostBack="True" Enabled="False"></asp:TextBox>&nbsp;</td>
            <td style="width: 390px; height: 16px">
                No.Registrasi</td>
            <td style="width: 390px; height: 16px">
                :</td>
            <td style="width: 85px; height: 16px">
                <asp:TextBox ID="TxtNoREG" runat="server" Width="84px" AutoPostBack="True" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 210px; height: 29px;">
            </td>
            <td style="width: 105px; height: 29px;">
                Nama</td>
            <td style="width: 9px; height: 29px;">
                :</td>
            <td style="width: 486px; height: 29px;">
                <asp:TextBox ID="TxtNama" runat="server" Width="303px" Enabled="False"></asp:TextBox></td>
            <td style="width: 390px; height: 29px;">
                Alamat</td>
            <td style="width: 390px; height: 29px;">
                :</td>
            <td style="width: 85px; height: 29px;">
                <asp:TextBox ID="TxtAlamat" runat="server" Width="350px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 210px; height: 20px;">
            </td>
            <td style="width: 105px; height: 20px;">
                Umur</td>
            <td style="width: 9px; height: 20px;">
                :</td>
            <td style="width: 486px; height: 20px;">
                <asp:TextBox ID="TxtUmur" runat="server" Width="160px" Enabled="False"></asp:TextBox>
            </td>
            <td style="width: 390px; height: 20px;">
                Jenis Kelamin</td>
            <td style="width: 390px; height: 20px;">
                :</td>
            <td style="width: 85px; height: 20px;">
                <asp:TextBox ID="TxtKelamin" runat="server" Width="88px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 210px; height: 19px;">
            </td>
            <td style="width: 105px; height: 19px;">
                Ruang</td>
            <td style="width: 9px; height: 19px;">
                :</td>
            <td style="width: 486px; height: 19px;">
                <asp:DropDownList ID="DDLRUANG" runat="server" AutoPostBack="True">
                </asp:DropDownList></td>
            <td style="width: 486px; height: 19px">
                Kamar</td>
            <td style="width: 486px; height: 19px">
                :</td>
            <td style="width: 486px; height: 19px">
                <asp:DropDownList ID="DDLKamar" AutoPostBack="True" runat="server" Width="304px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 210px; height: 19px">
            </td>
            <td style="width: 105px; height: 19px">
                Periode</td>
            <td style="width: 9px; height: 19px">
            </td>
            <td colspan="4" style="height: 19px">
                Bulan<asp:DropDownList ID="ddlbulan" runat="server" AutoPostBack="True" Width="48px">
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
                &nbsp;Tahun
                <asp:TextBox ID="TxtTahun" runat="server" AutoPostBack="True" MaxLength="10" TabIndex="5"
                    Width="59px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 210px; height: 23px">
            </td>
        </tr>
    </table>
    &nbsp; &nbsp;&nbsp;<br />
    <br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <contenttemplate>
<TABLE style="WIDTH: 900px" border=1><TBODY><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Diagnosa Masuk RS</TD><TD style="WIDTH: 32px; HEIGHT: 38px" colSpan=3><asp:TextBox id="TxtDiagnosa" runat="server" Width="632px" Height="40px"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 38px" colSpan=1></TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Jenis Infeksi</TD><TD style="FONT-WEIGHT: bold; WIDTH: 31px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">TBC&nbsp; <asp:CheckBox id="ChkBoxYaTBC" runat="server" AutoPostBack="true" Text="Ya"></asp:CheckBox><asp:CheckBox id="ChkBoxTidakTBC" runat="server" AutoPostBack="true" Text="Tidak"></asp:CheckBox></TD><TD style="FONT-WEIGHT: bold; WIDTH: 31px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">Hepatitis<asp:CheckBox id="ChkBoxYaHepatitis" runat="server" AutoPostBack="true" Text="Ya"></asp:CheckBox><asp:CheckBox id="ChkBoxTidakHepatitis" runat="server" AutoPostBack="true" Text="Tidak"></asp:CheckBox></TD><TD style="FONT-WEIGHT: bold; WIDTH: 21px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">HIV<asp:CheckBox id="ChkBoxYaHIV" runat="server" AutoPostBack="true" Text="Ya"></asp:CheckBox><asp:CheckBox id="ChkBoxTidakHIV" runat="server" AutoPostBack="true" Text="Tidak"></asp:CheckBox></TD><TD style="FONT-WEIGHT: bold; WIDTH: 32px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">Covid 19<BR /><asp:CheckBox id="chckBoxCovidYa" runat="server" AutoPostBack="true" Text="Ya" __designer:wfdid="w1" OnCheckedChanged="chckBoxCovidYa_CheckedChanged"></asp:CheckBox><asp:CheckBox id="chckBoxCovidTidak" runat="server" AutoPostBack="true" Text="Tidak" __designer:wfdid="w2" OnCheckedChanged="chckBoxCovidTidak_CheckedChanged"></asp:CheckBox></TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Faktor Risiko</TD><TD style="FONT-WEIGHT: bold; WIDTH: 31px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">TANGGAL PASANG</TD><TD style="FONT-WEIGHT: bold; WIDTH: 31px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">TANGGAL AFF</TD><TD style="FONT-WEIGHT: bold; WIDTH: 21px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">LAMA HARI</TD><TD style="FONT-WEIGHT: bold; WIDTH: 32px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00"></TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 27px; BACKGROUND-COLOR: yellow">VENA PERIFIER</TD><TD style="WIDTH: 32px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateVENAPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageVENAPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image></TD><TD style="WIDTH: 40px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateVENAAff" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageVENAAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari1" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender1" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateVENAPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVENAPasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender2" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateVENAAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVENAAff">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 30px; BACKGROUND-COLOR: yellow">CVP/HD Catater</TD><TD style="WIDTH: 32px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateCVPPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageCVPPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image></TD><TD style="WIDTH: 40px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateCVPAff" runat="server" AutoPostBack="True" Width="160px"></asp:TextBox> <asp:Image id="ImageCVPAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image></TD><TD style="WIDTH: 21px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari2" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender3" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="DateCVPPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVPPasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender4" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="DateCVPAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVPAff">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Urine Cateter</TD><TD style="WIDTH: 32px; HEIGHT: 38px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateUrinePasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageUrinePasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 40px; HEIGHT: 38px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateUrineAFF" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageUrineAFF" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 38px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari3" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 38px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender5" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateUrinePasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageUrinePasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender6" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateUrineAFF" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageUrineAFF">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 27px; BACKGROUND-COLOR: yellow">Endotracheal Tube</TD><TD style="WIDTH: 32px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateETPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageETPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 40px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateETAff" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageETAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari4" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 27px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender7" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateETPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETPasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender8" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateETAFF" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETAFF">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 27px; BACKGROUND-COLOR: yellow">Tracheal Tube</TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateTTPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageTTPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 40px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateTTAff" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageTTAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari5" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender9" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateTTPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTTPasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender10" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateTTAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTTAFF">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 27px; BACKGROUND-COLOR: yellow">Ventilator</TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateVentilatorPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageVentilatorPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 40px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateVentilatorAff" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageVentilatorAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari6" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender11" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateVentilatorPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentilatorPasang">
                            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender12" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateVentilatorAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentilatorAff">
                            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 134px; HEIGHT: 27px; BACKGROUND-COLOR: yellow">Tirah Baring</TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateTirahPasang" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageTirahPasang" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 40px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateTirahAff" runat="server" AutoPostBack="True" Width="160px" autocomplete="off"></asp:TextBox>&nbsp; <asp:Image id="ImageTirahAff" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 21px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="TextLamaHari7" runat="server" Width="32px" ReadOnly="True"></asp:TextBox></TD><TD style="WIDTH: 32px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"></TD><ajaxToolkit:CalendarExtender id="CalendarExtender13" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateTirahPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahPasang">
            </ajaxToolkit:CalendarExtender><ajaxToolkit:CalendarExtender id="CalendarExtender14" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateTirahAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahAff">
            </ajaxToolkit:CalendarExtender></TR></TBODY></TABLE><BR /><BR /><SPAN style="DISPLAY: inline-block; FONT-WEIGHT: bold; FONT-SIZE: 14pt; WIDTH: 1056px; COLOR: green; FONT-STYLE: normal; HEIGHT: 20px; FONT-VARIANT: normal" id="Span1">Tindakan Operasi</SPAN><BR /><TABLE style="WIDTH: 656px; HEIGHT: 1px" border=1><TBODY><TR><TD style="FONT-WEIGHT: bold; BACKGROUND-COLOR: #33ff00" colSpan=2>Operasi</TD><TD style="FONT-WEIGHT: bold; BACKGROUND-COLOR: #33ff00" colSpan=2>Derajat Kontaminasi</TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 66px; BACKGROUND-COLOR: yellow">TINDAKAN OPERASI</TD><TD style="WIDTH: 137px; HEIGHT: 66px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateOperasi" runat="server" Width="88px" __designer:wfdid="w153"></asp:TextBox><asp:Image id="imgOperasi" runat="server" Width="16px" Height="16px" __designer:wfdid="w154" ImageUrl="~/Images/Calendar.png"></asp:Image>&nbsp;<ajaxToolkit:CalendarExtender id="CalendarExtender22" runat="server" Enabled="True" __designer:wfdid="w155" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateOperasi" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="imgOperasi"></ajaxToolkit:CalendarExtender> </TD><TD style="WIDTH: 309px; HEIGHT: 66px; BACKGROUND-COLOR: #ffffff"><asp:CheckBox id="chckBoxBOperasi" runat="server" AutoPostBack="true" Text="B" __designer:wfdid="w156"></asp:CheckBox><asp:CheckBox id="chckBoxBTOperasi" runat="server" AutoPostBack="true" Text="BT" __designer:wfdid="w157"></asp:CheckBox><asp:CheckBox id="chckBoxKOperasi" runat="server" AutoPostBack="true" Text="K" __designer:wfdid="w158"></asp:CheckBox></TD><ajaxToolkit:CalendarExtender id="CalendarExtender23" runat="server" Enabled="True" __designer:wfdid="w15" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejIDO" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejIDO">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; BACKGROUND-COLOR: yellow" colSpan=3></TD></TR></TBODY></TABLE><BR /><SPAN style="DISPLAY: inline-block; FONT-WEIGHT: bold; FONT-SIZE: 14pt; WIDTH: 1056px; COLOR: green; FONT-STYLE: normal; HEIGHT: 40px; FONT-VARIANT: normal" id="ctl00_lblstatus">Infeksi Rumah Sakit</SPAN><BR /><TABLE style="WIDTH: 904px; HEIGHT: 440px" border=1><TBODY><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">Infeksi Rumah Sakit</TD><TD style="FONT-WEIGHT: bold; WIDTH: 183px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">Tanggal Kejadian</TD><TD style="FONT-WEIGHT: bold; WIDTH: 309px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00">Hasil Kultur</TD><TD style="FONT-WEIGHT: bold; WIDTH: 309px; HEIGHT: 38px; BACKGROUND-COLOR: #33ff00"></TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">IDO</TD><TD style="WIDTH: 123px; HEIGHT: 19px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejIDO" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejIDO" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image></TD><TD style="WIDTH: 209px; HEIGHT: 19px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturIDO" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonIDO" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender15" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejIDO" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejIDO">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">ISK</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejISK" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejISK" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image></TD><TD style="WIDTH: 309px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturISK" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 30px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonISK" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender16" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejISK" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejISK">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">VAP</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejVAP" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejVAP" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturVAP" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonVAP" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender17" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejVAP" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejVAP">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">HAP</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejHAP" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejHAP" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturHAP" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonHAP" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender18" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejHAP" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejHAP">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">IADP</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejIADP" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejIADP" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 309px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturIADP" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 28px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonIADP" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender19" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejIADP" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejIADP">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">PLEBITIS</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejPlebitis" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejPlebitis" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 309px; HEIGHT: 23px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturPlebitis" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 23px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonPLE" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender20" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejPlebitis" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejPlebitis">
            </ajaxToolkit:CalendarExtender></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 139px; HEIGHT: 29px; BACKGROUND-COLOR: yellow">DEKUBITUS</TD><TD style="WIDTH: 183px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="dateKejDekubitus" runat="server" Width="88px"></asp:TextBox>&nbsp; <asp:Image id="ImageKejDekubitus" runat="server" ImageUrl="~/Images/Calendar.png"></asp:Image> </TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:TextBox id="txtKulturDekubitus" runat="server" Width="520px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD><TD style="WIDTH: 309px; HEIGHT: 29px; BACKGROUND-COLOR: #ffffff"><asp:LinkButton id="LinkButtonDekubitus" runat="server">Monitoring</asp:LinkButton></TD><ajaxToolkit:CalendarExtender id="CalendarExtender21" runat="server" Enabled="True" DaysModeTitleFormat="dd/MM/yyyy" Format="dd/MM/yyyy" TargetControlID="dateKejDekubitus" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageKejDekubitus">
            </ajaxToolkit:CalendarExtender></TR></TBODY></TABLE><BR /><TABLE style="WIDTH: 900px" border=1><TBODY><TR><TD style="FONT-WEIGHT: bold; WIDTH: 144px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Hasil Kultur MRDO</TD><TD style="WIDTH: 32px; HEIGHT: 38px" colSpan=3><asp:CheckBox id="ChkBoxMDROYa" runat="server" AutoPostBack="true" Text="Ya"></asp:CheckBox> <asp:CheckBox id="ChkBoxMDROTidak" runat="server" AutoPostBack="true" Text="Tidak"></asp:CheckBox> </TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 54px; HEIGHT: 38px; BACKGROUND-COLOR: yellow">Spesimen/Bahan</TD><TD style="WIDTH: 32px; HEIGHT: 38px" colSpan=3><asp:DropDownList id="dropDownSpesimen" runat="server">
                <asp:ListItem Selected="True" Value="0">---------</asp:ListItem>
                    <asp:ListItem>Sputum</asp:ListItem>
                    <asp:ListItem>Urine</asp:ListItem>
                    <asp:ListItem>Pus</asp:ListItem>
                    <asp:ListItem>Darah</asp:ListItem>
                    <asp:ListItem>Sekret tenggorok </asp:ListItem>
                    <asp:ListItem>Sekret Mata</asp:ListItem>
                    <asp:ListItem>Usapan luka</asp:ListItem>
                    <asp:ListItem>Cairan pleura</asp:ListItem>
                    <asp:ListItem>Feses</asp:ListItem>
                    <asp:ListItem>LCS</asp:ListItem>
                 </asp:DropDownList> </TD></TR><TR><TD style="FONT-WEIGHT: bold; WIDTH: 54px; BACKGROUND-COLOR: yellow" rowSpan=9>Bakteri</TD><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxMRSA" runat="server" Text="Methycillin Resistant Staphylococcus Aureus (MRSA)"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxMRSE" runat="server" Text="Methycillin Resistant Staphylococcus Epidermidis (MRSE)"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxKlebsiella" runat="server" Text="Klebsiella pneumonia ESBL"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxColi" runat="server" Text="E.coli strain ESBL"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxPsedomonas" runat="server" Text="Psedomonas aerogenosa ESBL"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxMDR" runat="server" Text="Acinetobacter baumanii MDR"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxVRE" runat="server" Text="Vancomicyn Resistance  Enterococcus (VRE)"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxCRE" runat="server" Text="Carbopenem Resistence Enterobacteriaceae(CRE)"></asp:CheckBox> </TD></TR><TR><TD style="WIDTH: 152px; HEIGHT: 38px" colSpan=8><asp:CheckBox id="chckBoxMDRTB" runat="server" Text="Multi Drug Resistance Tubercolusis (MDR-TB)"></asp:CheckBox> </TD></TR></TBODY></TABLE><TABLE style="WIDTH: 904px; HEIGHT: 40px" border=1><TBODY><TR><TD style="FONT-WEIGHT: bold; WIDTH: 140px; HEIGHT: 30px; BACKGROUND-COLOR: yellow">Penggunaan Antibiotika</TD><TD style="WIDTH: 973px; HEIGHT: 30px"><asp:CheckBox id="ChkBoxAntiYa" runat="server" AutoPostBack="true" Text="Ya"></asp:CheckBox> <asp:CheckBox id="ChkBoxAntiTidak" runat="server" AutoPostBack="true" Text="Tidak"></asp:CheckBox></TD><TD style="WIDTH: 603px; HEIGHT: 30px"><asp:TextBox id="txtAntibiotika" runat="server" Width="736px" Height="48px" TextMode="MultiLine"></asp:TextBox></TD></TR></TBODY></TABLE>
</contenttemplate>
    </asp:UpdatePanel>
    
    <br />
    <br />
    <br />
    &nbsp;<br />
    <br />
    <div align="center">
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Height="48px" Width="128px" BackColor="BlueViolet" />&nbsp;
        <asp:Button ID="BtnSaveInfeksi" runat="server" Text="Save" Height="48px" Width="128px"
            BackColor="CornflowerBlue" />
        <asp:Button ID="btnKeluar" runat="server" Text="Keluar" Height="48px" Width="128px"
            BackColor="Yellow" />
        <asp:Button ID="BtnHapus" runat="server" BackColor="Red" Height="48px" Text="Hapus"
            Width="104px" /></div>
    <br />
    <br />
    <br />
</asp:Content>
