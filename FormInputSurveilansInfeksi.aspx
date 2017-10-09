<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" EnableEventValidation ="true"  CodeFile="FormInputSurveilansInfeksi.aspx.vb" Inherits="FormInputSurveilansInfeksi" title="Input Surveilans Infeksi Pasien" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 756px">
     <tr>
            <td style="width: 18px; height: 20px">
            </td>
            <td style="width: 105px; height: 20px;">
               </td>
            <td colspan="2" style="font-weight: bold; font-size: 14pt; color: blue; height: 55px;">
                DATA DEMOGRAFI PASIEN</td>
        </tr>
        <tr>
        
            <td style="width: 18px; height: 20px">
            </td>
            <td style="width: 105px; height: 20px;">
                No.RM</td>
            <td style="width: 9px; height: 20px">
                :</td>
            <td style="width: 486px; height: 20px">
                <asp:TextBox ID="TxtNoRM" runat="server" Width="93px" AutoPostBack="True" Enabled="False"></asp:TextBox>&nbsp;</td>
            <td style="width: 390px; height: 20px">
                No.Registrasi</td>
            <td style="width: 390px; height: 20px">
                :</td>
            <td style="width: 85px; height: 20px">
                <asp:TextBox ID="TxtNoREG" runat="server" Width="84px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 18px; height: 29px;">
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
                <asp:TextBox ID="TxtAlamat" runat="server" Width="568px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 18px; height: 20px;">
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
            <td style="width: 18px; height: 19px;">
            </td>
            <td style="width: 105px; height: 19px;">
                Ruang</td>
            <td style="width: 9px; height: 19px;">
                :</td>
            <td style="width: 486px; height: 19px;">
                <asp:TextBox ID="TxtRuang" runat="server" Width="288px" Enabled="False"></asp:TextBox></td>
            <td style="width: 486px; height: 19px">
                Kamar</td>
            <td style="width: 486px; height: 19px">
                :</td>
            <td style="width: 486px; height: 19px">
                <asp:TextBox ID="txtKamar" runat="server" Enabled="False" Height="24px" Width="448px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 18px; height: 23px">
            </td>
            <td style="width: 105px; height: 23px">
            </td>
            <td style="width: 9px; height: 23px">
            </td>
            <td style="width: 486px; height: 23px">
            </td>
        </tr>
    </table>
    &nbsp;<br />
    <br />
    <table style="width: 900px" border="1px">
    <tr>
            <td style="width: 134px; height: 38px; font-weight: bold; background-color: yellow;">
                Diagnosa Masuk RS</td>
            <td style="width: 32px; height: 38px" colspan="3">
                <asp:TextBox ID="TxtDiagnosa" runat="server" Height="40px" Width="632px"></asp:TextBox></td>
            
        </tr>
   
        <tr>
            <td style="width: 134px; height: 38px; font-weight: bold; background-color: yellow;">
                Faktor Risiko</td>
            <td style="width: 31px; height: 38px; font-weight: bold; background-color: #33ff00;">
                TANGGAL PASANG</td>
            <td style="width: 31px; height: 38px; font-weight: bold; background-color: #33ff00;">
                TANGGAL AFF</td>
            <td style="width: 31px; height: 38px; font-weight: bold; background-color: #33ff00;">
                LAMA HARI</td>
        </tr>
        <tr>
            <td style="width: 134px; height: 27px; font-weight: bold; background-color: yellow;">
                VENA PERIFIER</td>
            <td style="width: 32px; height: 27px; background-color: #ffffff;">
                <asp:TextBox ID="dateVENAPasang" runat="server" autocomplete="off"  AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageVENAPasang" runat="server" ImageUrl="~/Images/Calendar.png" /></td>
            <td style="width: 40px; height: 27px; background-color: #ffffff;">
              <asp:TextBox ID="dateVENAAff" runat="server" autocomplete="off"  AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageVENAAff" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; height: 27px; background-color: #ffffff;">
                <asp:TextBox ID="TextLamaHari1" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateVENAPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVENAPasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateVENAAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVENAAff">
                            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="width: 134px; height: 30px; font-weight: bold; background-color: yellow;">
                CVP/HD Catater</td>
            <td style="width: 32px; height: 30px; background-color: #ffffff;">
              <asp:TextBox ID="dateCVPPasang" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageCVPPasang" runat="server" ImageUrl="~/Images/Calendar.png" /></td>
            <td style="width: 40px; height: 30px; background-color: #ffffff;">
                <asp:TextBox ID="dateCVPAff" runat="server" Width="160px" AutoPostBack="True"></asp:TextBox>
                   <asp:Image ID="ImageCVPAff" runat="server" ImageUrl="~/Images/Calendar.png" /></td>
            <td style="width: 31px; height: 30px; background-color: #ffffff;">
                <asp:TextBox ID="TextLamaHari2" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateCVPPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVPPasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender4" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="DateCVPAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageCVPAff">
                            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="width: 134px; font-weight: bold; background-color: yellow;">
                Urine Cateter</td>
            <td style="width: 32px; background-color: #ffffff">
                 <asp:TextBox ID="dateUrinePasang" runat="server" autocomplete="off"  AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageUrinePasang" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 40px; background-color: #ffffff">
              <asp:TextBox ID="dateUrineAFF" runat="server" autocomplete="off" AutoPostBack="True" 
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageUrineAFF" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; background-color: #ffffff">
                <asp:TextBox ID="TextLamaHari3" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
               <ajaxToolkit:CalendarExtender ID="CalendarExtender5" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateUrinePasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageUrinePasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender6" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateUrineAFF" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageUrineAFF">
                            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="width: 134px; height: 27px; font-weight: bold; background-color: yellow;">
                Endotracheal Tube</td>
            <td style="width: 32px; height: 27px; background-color: #ffffff">
              <asp:TextBox ID="dateETPasang" runat="server" autocomplete="off"  AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageETPasang" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 40px; height: 27px; background-color: #ffffff">
              <asp:TextBox ID="dateETAff" runat="server" autocomplete="off"  AutoPostBack="True"
                                 Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageETAff" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; height: 27px; background-color: #ffffff">
                <asp:TextBox ID="TextLamaHari4" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender7" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateETPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETPasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender8" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateETAFF" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageETAFF">
                            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="width: 134px; height: 27px; font-weight: bold; background-color: yellow;">
                Tracheal Tube</td>
            <td style="width: 32px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateTTPasang" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageTTPasang" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 40px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateTTAff" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageTTAff" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; height: 28px; background-color: #ffffff">
            <asp:TextBox ID="TextLamaHari5" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
                      <ajaxToolkit:CalendarExtender ID="CalendarExtender9" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateTTPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTTPasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender10" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateTTAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTTAFF">
                            </ajaxToolkit:CalendarExtender>
        </tr>
       <tr>
            <td style="width: 134px; height: 27px; font-weight: bold; background-color: yellow;">
                Ventilator</td>
            <td style="width: 32px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateVentilatorPasang" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageVentilatorPasang" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 40px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateVentilatorAff" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageVentilatorAff" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; height: 28px; background-color: #ffffff">
                <asp:TextBox ID="TextLamaHari6" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
                      <ajaxToolkit:CalendarExtender ID="CalendarExtender11" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateVentilatorPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentilatorPasang">
                            </ajaxToolkit:CalendarExtender>
           <ajaxToolkit:CalendarExtender ID="CalendarExtender12" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateVentilatorAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageVentilatorAff">
                            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="width: 134px; height: 27px; font-weight: bold; background-color: yellow;">
                Tirah Baring</td>
            <td style="width: 32px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateTirahPasang" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageTirahPasang" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 40px; height: 28px; background-color: #ffffff">
              <asp:TextBox ID="dateTirahAff" runat="server" autocomplete="off" AutoPostBack="True"
                                Width="160px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageTirahAff" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 31px; height: 28px; background-color: #ffffff">
            <asp:TextBox ID="TextLamaHari7" runat="server" ReadOnly="True" Width="32px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender13" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateTirahPasang" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahPasang">
            </ajaxToolkit:CalendarExtender>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender14" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="dateTirahAff" TodaysDateFormat="dd/MM/yyyy" PopupButtonID="ImageTirahAff">
            </ajaxToolkit:CalendarExtender>
        </tr>
    </table>
    <br />
    <table border="1" style="border-left-color: black; border-bottom-color: black; width: 900px;
        border-top-color: black; height: 288px; border-right-color: black">
        <tr>
            <td style="font-weight: bold; width: 84px; height: 17px; background-color: yellow">
                Faktor Penyakit:
            </td>
            <td style="width: 323px; height: 17px">
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                HBSag</td>
            <td style="width: 323px; height: 29px">
                <asp:TextBox ID="TxtHBSag" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                Anti HCV</td>
            <td style="width: 323px; height: 20px">
                <asp:TextBox ID="TxtAntiHCV" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                Anti HIV</td>
            <td style="width: 323px; height: 19px">
                <asp:TextBox ID="TxtAntiHiv" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                Lekosit</td>
            <td style="width: 323px; height: 19px">
                <asp:TextBox ID="TxtLekosit" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                GDS</td>
            <td style="width: 323px; height: 19px">
                <asp:TextBox ID="TxtGDS" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 84px; height: 23px; background-color: yellow">
                Hasil Thorax</td>
            <td style="width: 323px; height: 19px">
                <asp:TextBox ID="TxtHasilThorax" runat="server" Width="400px"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    &nbsp;<span id="ctl00_lblstatus" style="display: inline-block; font-weight: bold;
        font-size: 14pt; width: 1056px; color: green; font-style: normal; height: 40px;
        font-variant: normal">Infeksi Rumah Sakit</span><br />
    <table border="1" style="width: 1020px">
        <tr>
            <td style="font-weight: bold; width: 139px; height: 38px; background-color: #33ff00">
                Infeksi Rumah Sakit</td>
            <td style="font-weight: bold; width: 183px; height: 38px; background-color: #33ff00">
                Tanggal Kejadian</td>
            <td style="font-weight: bold; width: 205px; height: 38px; background-color: #33ff00">
                Hasil Kultur</td>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                IDO</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejIDO" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejIDO" runat="server" ImageUrl="~/Images/Calendar.png" /></td>
            <td style="width: 545px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturIDO" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender15" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejIDO" TargetControlID="dateKejIDO"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                ISK</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejISK" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejISK" runat="server" ImageUrl="~/Images/Calendar.png" /></td>
            <td style="width: 545px; height: 30px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturISK" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender16" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejISK" TargetControlID="dateKejISK"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                VAP</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejVAP" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejVAP" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 545px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturVAP" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender17" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejVAP" TargetControlID="dateKejVAP"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                HAP</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejHAP" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejHAP" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 545px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturHAP" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender18" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejHAP" TargetControlID="dateKejHAP"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                IADP</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejIADP" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejIADP" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 545px; height: 28px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturIADP" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender19" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejIADP" TargetControlID="dateKejIADP"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                PLEBITIS</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejPlebitis" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejPlebitis" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 545px; height: 23px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturPlebitis" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender20" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejPlebitis" TargetControlID="dateKejPlebitis"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
        <tr>
            <td style="font-weight: bold; width: 139px; height: 29px; background-color: yellow">
                DEKUBITUS</td>
            <td style="width: 183px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="dateKejDekubitus" runat="server" Width="88px"></asp:TextBox>&nbsp;
                <asp:Image ID="ImageKejDekubitus" runat="server" ImageUrl="~/Images/Calendar.png" />
            </td>
            <td style="width: 545px; height: 29px; background-color: #ffffff">
                <asp:TextBox ID="txtKulturDekubitus" runat="server" Height="48px" TextMode="MultiLine"
                    Width="520px"></asp:TextBox></td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender21" runat="server" DaysModeTitleFormat="dd/MM/yyyy"
                Enabled="True" Format="dd/MM/yyyy" PopupButtonID="ImageKejDekubitus" TargetControlID="dateKejDekubitus"
                TodaysDateFormat="dd/MM/yyyy">
            </ajaxToolkit:CalendarExtender>
        </tr>
    </table>
    <br />
    <table border="1" style="width: 1020px">
        <tr>
            <td style="font-weight: bold; width: 140px; height: 30px; background-color: yellow">
                Penggunaan Antibiotika</td>
            <td style="width: 603px; height: 30px">
                <asp:TextBox ID="txtAntibiotika" runat="server" Height="48px" TextMode="MultiLine"
                    Width="736px"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    &nbsp;<br />
        <ajaxToolkit:ToolkitScriptManager CombineScripts="False" EnableScriptGlobalization="True" ID="ScriptManager1" runat="server" ScriptMode="Debug">
    </ajaxToolkit:ToolkitScriptManager>
     <br />
    <div align="center">
        <asp:Button ID="btnEdit"   runat="server" Text="Edit" Height="48px" Width="128px" BackColor="BlueViolet" />  
         <asp:Button ID="BtnSaveInfeksi"   runat="server" Text="Save" Height="48px" Width="128px" BackColor="CornflowerBlue" />
        <asp:Button ID="btnKeluar"   runat="server" Text="Keluar" Height="48px" Width="128px" BackColor="Yellow" />
    </div>
    <br />
    <br />
    <br />
        
</asp:Content>

