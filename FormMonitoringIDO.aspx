<%@ Page Language="VB"   MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="FormMonitoringIDO.aspx.vb" Inherits="FormMonitoringHAP" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="Server" CombineScripts="false"
        EnableScriptGlobalization="true" EnableScriptLocalization="true" ScriptMode="Debug">
    </ajaxToolkit:ToolkitScriptManager>
    <table style="width: 932px; height: 200px;" border="1" >
     <tr>
            <td colspan="12" style="font-weight: bold; font-size: 11pt; color: blue; height: 26px; width: 197px; text-align: center;">
                FORMULIR MONITORING<br />
                PELAKSAAAN BUNDLE PENCEGAHAN IDO</td>
        </tr>
        <tr>
            <td colspan="2" style="height: 16px; font-size: 8pt;">
                Tgl Operasi :&nbsp;
                <asp:TextBox ID="txtTglOperasi" runat="server" Width="56px" Font-Size="8pt"></asp:TextBox></td>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True"
                Format="dd/MM/yyyy" TodaysDateFormat="dd/MM/yyyy" DaysModeTitleFormat="dd/MM/yyyy"
                TargetControlID="txtTglOperasi">
            </ajaxToolkit:CalendarExtender>
            <td colspan="2" style="height: 16px; font-size: 8pt;">
                LamaOperasi Jam/Menit :
                <asp:TextBox ID="TxtLamaOperasiJam" runat="server" Width="16px" MaxLength="2"></asp:TextBox>
                :
                <asp:TextBox ID="TxtLamaOperasiMenit" runat="server" Width="16px" MaxLength="2"></asp:TextBox></td>
                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender3" runat="server"
                TargetControlID="TxtLamaOperasiJam" Mask="99" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError" MaskType="None" />
                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
                TargetControlID="TxtLamaOperasiMenit" Mask="99" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError" MaskType="None" />
           
              <td colspan="5" style="height: 16px; font-size: 8pt;">
                Jenis Operasi :<asp:CheckBox ID="ChkBoxElektif" runat="server" Text="Elektif" TextAlign="Left" />
                <asp:CheckBox ID="ChkBoxCito" runat="server" Text="Cito" TextAlign="Left" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 16px; font-size: 8pt;">
                Kamar Operasi :
                <asp:DropDownList ID="DdRuangOp" runat="server" Font-Size="8pt">
                </asp:DropDownList></td>
            <td colspan="3" style="height: 16px; font-size: 8pt;">
                Prosedur Tindakan :
                <asp:DropDownList ID="DdTindakan" runat="server" Font-Size="8pt" Width="160px">
                </asp:DropDownList></td>
            <td colspan="4" style="height: 16px; font-size: 8pt;">
                ASA Score : &nbsp;&nbsp;<asp:DropDownList ID="DDAsaScore" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp;<br />
                Klasifikasi Operasi:<asp:DropDownList ID="DDKlasifikasiOp" runat="server">
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>BT</asp:ListItem>
                    <asp:ListItem>T</asp:ListItem>
                    <asp:ListItem>K</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td rowspan="2" style="width: 14px; font-size: 8pt; height: 16px;">
                Pre Operasi</td>
            <td style="height: 16px; font-size: 8pt; width: 215px;">
                Suhu Tubuh&nbsp;<asp:DropDownList ID="DDSuhuTubuh" runat="server">
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                </asp:DropDownList>&nbsp;
                <span style="display: inline! important; font-weight: 400; font-size: 16px; float: none;
                    word-spacing: 0px; text-transform: none; color: rgb(34,34,34); text-indent: 0px;
                    font-style: normal; font-family: arial, sans-serif; white-space: normal; letter-spacing: normal;
                    background-color: rgb(255,255,255); text-align: left; font-variant-ligatures: normal;
                    font-variant-caps: normal; orphans: 2; widows: 2; webkit-text-stroke-width: 0px;
                    text-decoration-style: initial; text-decoration-color: initial">°</span><b style="font-size: 16px;
                        word-spacing: 0px; text-transform: none; color: rgb(34,34,34); text-indent: 0px;
                        font-style: normal; font-family: arial, sans-serif; white-space: normal; letter-spacing: normal;
                        background-color: rgb(255,255,255); text-align: left; font-variant-ligatures: normal;
                        font-variant-caps: normal; orphans: 2; widows: 2; webkit-text-stroke-width: 0px;
                        text-decoration-style: initial; text-decoration-color: initial">C</b></td>
            <td style="width: 128px; height: 16px; font-size: 8pt;">
                Albumin <asp:TextBox ID="TxtAlbumin" runat="server" Width="24px"></asp:TextBox>&nbsp; g/dl</td>
            <td style="width: 293px; height: 16px; font-size: 8pt;">
                Gula Darah :
                <asp:TextBox ID="TxtGulaDarah" runat="server" Width="24px"></asp:TextBox>
                Merorok :
                <asp:DropDownList ID="DDMerokok" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 16px; font-size: 8pt;" colspan="4">
                Penyakit Infeksi Lain
                <asp:DropDownList ID="DDPenyInfeksi" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList><br />
                <br />
                Screening MRSA&nbsp;<asp:DropDownList ID="DDScreeningMRSA" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList>&nbsp;<br />
            </td>
        </tr>
        <tr>
            <td style="height: 16px; font-size: 8pt; width: 215px;">
                Pencukuran&nbsp;
                <asp:DropDownList ID="DDPencukuran" runat="server">
                    <asp:ListItem>Clipper</asp:ListItem>
                    <asp:ListItem>Razor</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 128px; height: 16px; font-size: 8pt;">
                Waktu Pencukuran(Jam) &nbsp;<asp:TextBox ID="txtWaktuPencukuran" runat="server" Width="48px"></asp:TextBox>
            </td>
            <td colspan="2" style="height: 16px; font-size: 8pt; width: 261px;">
                Mandi Sebelum Operasi :
                <asp:DropDownList ID="DDMandi" runat="server">
                    <asp:ListItem>Chlorhexidine</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
            <td colspan="3" style="height: 16px; font-size: 8pt;">
                Antibiotik
                Profilaksis&nbsp;
                <asp:DropDownList ID="DDProfilaksis" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td rowspan="2" style="width: 14px; font-size: 8pt; height: 16px;">
                Durante Operasi</td>
            <td style="height: 16px; font-size: 8pt; width: 215px;">
                Sirkulasi Udara
                <asp:TextBox ID="TxtSirkulasi" runat="server" Width="32px"></asp:TextBox></td>
            <td style="width: 128px; height: 16px; font-size: 8pt;">
                Kelembapan Udara(%) &nbsp;<asp:TextBox ID="TxtUdara" runat="server" Width="48px"></asp:TextBox></td>
            <td colspan="2" style="height: 16px; font-size: 8pt; width: 261px;">
                Tekanan Udara
                <asp:TextBox ID="TxtTekanan" runat="server" Width="40px"></asp:TextBox></td>
            <td colspan="2" style="height: 16px; font-size: 8pt; width: 423px;">
                Suhu Ruang &nbsp;<asp:TextBox ID="TxtSuhuRuang" runat="server" Width="24px"></asp:TextBox><span
                    style="font-size: 12pt; color: #222222; font-family: Arial">°</span><b style="font-size: 16px;
                        word-spacing: 0px; text-transform: none; color: rgb(34,34,34); text-indent: 0px;
                        font-style: normal; font-family: arial, sans-serif; white-space: normal; letter-spacing: normal;
                        background-color: rgb(255,255,255); text-align: left; font-variant-ligatures: normal;
                        font-variant-caps: normal; orphans: 2; widows: 2; webkit-text-stroke-width: 0px;
                        text-decoration-style: initial; text-decoration-color: initial">C</b>&nbsp;</td>
            <td colspan="1" style="height: 16px; font-size: 8pt; width: 247px;">
                Drain&nbsp;
                <asp:DropDownList ID="DDDrain" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="height: 16px; font-size: 8pt; width: 215px;">
                Disinfeksi Kulit &nbsp;&nbsp;
                <asp:DropDownList ID="DDDisinfeksi" runat="server">
                    <asp:ListItem>Chlorhexidine-Alcohol</asp:ListItem>
                    <asp:ListItem>Providone-Iodine-Alcohol</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 128px; height: 16px; font-size: 8pt;">
                Implant 
                <asp:DropDownList ID="DDImplant" runat="server">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
            <td colspan="4" style="height: 16px; font-size: 8pt;">
                Jumlah staff dalam kamar operasi 
                <asp:TextBox ID="TxtJumlahStaff" runat="server" Width="32px"></asp:TextBox></td>
            <td colspan="1" style="height: 16px; font-size: 8pt; width: 247px;">
                Indikator Instrumen Steril 
                <asp:DropDownList ID="DDIndikator" runat="server" Font-Size="Smaller">
                    <asp:ListItem>Ya</asp:ListItem>
                    <asp:ListItem>Tidak</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
    </table>
    &nbsp; &nbsp;&nbsp;<br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="1" 
         CssClass="mGrid" Height="30px" ShowFooter="True" Width="150px" Font-Size="8pt" Font-Italic="True" >  
            <Columns>  
                   <asp:TemplateField HeaderText="Monitoring" visible =false >   
                    <ItemTemplate >  
                        <asp:Label ID="lbl_id" runat="server"  Text='<%# Eval("in_monitoring_hdr_id") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
              <asp:TemplateField HeaderText="VC kode" visible =false >  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_kode" runat="server"  Text='<%# Eval("vc_kode") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Post Operasi" >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_nama" runat="server"   Width="150px" Text='<%# Eval("vc_nama") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="1">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_1" runat="server"  Checked='<%# IIf(Eval("vc_tgl_1") Is DBNull.Value, "False", Eval("vc_tgl_1")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
 
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="2">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_2" runat="server"     Checked='<%# IIf(Eval("vc_tgl_2") Is DBNull.Value, "False", Eval("vc_tgl_2")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
     
                </asp:TemplateField>
                <asp:TemplateField HeaderText="3">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_3" runat="server"    Checked='<%# IIf(Eval("vc_tgl_3") Is DBNull.Value, "False", Eval("vc_tgl_3")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
          
                </asp:TemplateField>
                <asp:TemplateField HeaderText="4">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_4" runat="server"    Checked='<%# IIf(Eval("vc_tgl_4") Is DBNull.Value, "False", Eval("vc_tgl_4")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
        
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="5">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_5" runat="server"    Checked='<%# IIf(Eval("vc_tgl_5") Is DBNull.Value, "False", Eval("vc_tgl_5")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
       
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="6">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_6" runat="server"    Checked='<%# IIf(Eval("vc_tgl_6") Is DBNull.Value, "False", Eval("vc_tgl_6")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  

                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="7">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_7" runat="server"    Checked='<%# IIf(Eval("vc_tgl_7") Is DBNull.Value, "False", Eval("vc_tgl_7")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="8">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_8" runat="server"    Checked='<%# IIf(Eval("vc_tgl_8") Is DBNull.Value, "False", Eval("vc_tgl_8")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="9">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_9" runat="server"    Checked='<%# IIf(Eval("vc_tgl_9") Is DBNull.Value, "False", Eval("vc_tgl_9")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                 <asp:TemplateField HeaderText="10">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_10" runat="server"    Checked='<%# IIf(Eval("vc_tgl_10") Is DBNull.Value, "False", Eval("vc_tgl_10")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="11">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_11" runat="server"   Checked='<%# IIf(Eval("vc_tgl_11") Is DBNull.Value, "False", Eval("vc_tgl_11")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="12">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_12" runat="server"     Checked='<%# IIf(Eval("vc_tgl_12") Is DBNull.Value, "False", Eval("vc_tgl_12")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="13">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_13" runat="server"    Checked='<%# IIf(Eval("vc_tgl_13") Is DBNull.Value, "False", Eval("vc_tgl_13")) %>' ></asp:CheckBox >  
                    </ItemTemplate>   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="14">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_14" runat="server"    Checked='<%# IIf(Eval("vc_tgl_14") Is DBNull.Value, "False", Eval("vc_tgl_14")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="15">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_15" runat="server"    Checked='<%# IIf(Eval("vc_tgl_15") Is DBNull.Value, "False", Eval("vc_tgl_15")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="16">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_16" runat="server"    Checked='<%# IIf(Eval("vc_tgl_16") Is DBNull.Value, "False", Eval("vc_tgl_16")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="17">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_17" runat="server"    Checked='<%# IIf(Eval("vc_tgl_17") Is DBNull.Value, "False", Eval("vc_tgl_17")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="18">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_18" runat="server"    Checked='<%# IIf(Eval("vc_tgl_18") Is DBNull.Value, "False", Eval("vc_tgl_18")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="19">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_19" runat="server"    Checked='<%# IIf(Eval("vc_tgl_19") Is DBNull.Value, "False", Eval("vc_tgl_19")) %>' ></asp:CheckBox >  
                    </ItemTemplate>      
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="20">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_20" runat="server"    Checked='<%# IIf(Eval("vc_tgl_20") Is DBNull.Value, "False", Eval("vc_tgl_20")) %>' ></asp:CheckBox >  
                    </ItemTemplate>   
                </asp:TemplateField>     
               <asp:TemplateField HeaderText="21">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_21" runat="server"   Checked='<%# IIf(Eval("vc_tgl_21") Is DBNull.Value, "False", Eval("vc_tgl_21")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                 </asp:TemplateField>  
                <asp:TemplateField HeaderText="22">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_22" runat="server"     Checked='<%# IIf(Eval("vc_tgl_22") Is DBNull.Value, "False", Eval("vc_tgl_22")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="23">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_23" runat="server"    Checked='<%# IIf(Eval("vc_tgl_23") Is DBNull.Value, "False", Eval("vc_tgl_23")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="24">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_24" runat="server"    Checked='<%# IIf(Eval("vc_tgl_24") Is DBNull.Value, "False", Eval("vc_tgl_24")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="25">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_25" runat="server"    Checked='<%# IIf(Eval("vc_tgl_25") Is DBNull.Value, "False", Eval("vc_tgl_25")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                      </asp:TemplateField>
                 <asp:TemplateField HeaderText="26">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_26" runat="server"    Checked='<%# IIf(Eval("vc_tgl_26") Is DBNull.Value, "False", Eval("vc_tgl_26")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="27">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_27" runat="server"    Checked='<%# IIf(Eval("vc_tgl_27") Is DBNull.Value, "False", Eval("vc_tgl_27")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="28">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_28" runat="server"    Checked='<%# IIf(Eval("vc_tgl_28") Is DBNull.Value, "False", Eval("vc_tgl_28")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="29">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_29" runat="server"    Checked='<%# IIf(Eval("vc_tgl_29") Is DBNull.Value, "False", Eval("vc_tgl_29")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="30">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_30" runat="server"    Checked='<%# IIf(Eval("vc_tgl_30") Is DBNull.Value, "False", Eval("vc_tgl_30")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                                   <asp:TemplateField HeaderText="31">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_31" runat="server"    Checked='<%# IIf(Eval("vc_tgl_31") Is DBNull.Value, "False", Eval("vc_tgl_31")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  

                </asp:TemplateField>                                          
            </Columns>  
            <HeaderStyle BackColor="#99CCCC" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#ffffff"/>  
        </asp:GridView>  
        <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="1"    datakeynames="in_monitoring_hdr_id,vc_kode"
         CssClass="mGrid" Height="30px" ShowFooter="True" Width="150px" Font-Size="8pt" Font-Italic="True" >  
            <Columns>   
             <asp:TemplateField HeaderText="Monitoring" visible=false>  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_id_diag" runat="server"   Text='<%# Eval("in_monitoring_hdr_id") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
              <asp:TemplateField HeaderText="VC kode" visible=false>  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_kode_diag" runat="server"  Text='<%# Eval("vc_kode") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Identifikasi IDO">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_nama" runat="server" Width="150px"   Text='<%# Eval("vc_nama") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="1">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_1_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_1") Is DBNull.Value, "False", Eval("vc_tgl_1")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>  
                <asp:TemplateField HeaderText="2">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_2_diag" runat="server"     Checked='<%# IIf(Eval("vc_tgl_2") Is DBNull.Value, "False", Eval("vc_tgl_2")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>
                <asp:TemplateField HeaderText="3">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_3_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_3") Is DBNull.Value, "False", Eval("vc_tgl_3")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>
                <asp:TemplateField HeaderText="4">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_4_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_4") Is DBNull.Value, "False", Eval("vc_tgl_4")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                   </asp:TemplateField>    
                <asp:TemplateField HeaderText="5">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_5_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_5") Is DBNull.Value, "False", Eval("vc_tgl_5")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   </asp:TemplateField>
                 <asp:TemplateField HeaderText="6">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_6_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_6") Is DBNull.Value, "False", Eval("vc_tgl_6")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>      
                 <asp:TemplateField HeaderText="7">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_7_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_7") Is DBNull.Value, "False", Eval("vc_tgl_7")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                 
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="8">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_8_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_8") Is DBNull.Value, "False", Eval("vc_tgl_8")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                    
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="9">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_9_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_9") Is DBNull.Value, "False", Eval("vc_tgl_9")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>        
                 <asp:TemplateField HeaderText="10">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_10_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_10") Is DBNull.Value, "False", Eval("vc_tgl_10")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="11">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_11_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_11") Is DBNull.Value, "False", Eval("vc_tgl_11")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
        
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="12">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_12_diag" runat="server"     Checked='<%# IIf(Eval("vc_tgl_12") Is DBNull.Value, "False", Eval("vc_tgl_12")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="13">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_13_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_13") Is DBNull.Value, "False", Eval("vc_tgl_13")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="14">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_14_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_14") Is DBNull.Value, "False", Eval("vc_tgl_14")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="15">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_15_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_15") Is DBNull.Value, "False", Eval("vc_tgl_15")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="16">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_16_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_16") Is DBNull.Value, "False", Eval("vc_tgl_16")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="17">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_17_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_17") Is DBNull.Value, "False", Eval("vc_tgl_17")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="18">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_18_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_18") Is DBNull.Value, "False", Eval("vc_tgl_18")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                 
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="19">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_19_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_19") Is DBNull.Value, "False", Eval("vc_tgl_19")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="20">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_20_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_20") Is DBNull.Value, "False", Eval("vc_tgl_20")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   </asp:TemplateField>     
               <asp:TemplateField HeaderText="21">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_21_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_21") Is DBNull.Value, "False", Eval("vc_tgl_21")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                 </asp:TemplateField>  
                <asp:TemplateField HeaderText="22">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_22_diag" runat="server"     Checked='<%# IIf(Eval("vc_tgl_22") Is DBNull.Value, "False", Eval("vc_tgl_22")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="23">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_23_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_23") Is DBNull.Value, "False", Eval("vc_tgl_23")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                       </asp:TemplateField>
                <asp:TemplateField HeaderText="24">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_24_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_24") Is DBNull.Value, "False", Eval("vc_tgl_24")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                          </asp:TemplateField>    
                <asp:TemplateField HeaderText="25">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_25_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_25") Is DBNull.Value, "False", Eval("vc_tgl_25")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                      </asp:TemplateField>
                 <asp:TemplateField HeaderText="26">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_26_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_26") Is DBNull.Value, "False", Eval("vc_tgl_26")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                        </asp:TemplateField>      
                 <asp:TemplateField HeaderText="27">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_27_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_27") Is DBNull.Value, "False", Eval("vc_tgl_27")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="28">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_28_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_28") Is DBNull.Value, "False", Eval("vc_tgl_28")) %>' ></asp:CheckBox >  
                    </ItemTemplate>       
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="29">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_29_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_29") Is DBNull.Value, "False", Eval("vc_tgl_29")) %>' ></asp:CheckBox >  
                    </ItemTemplate> 
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="30">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_30_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_30") Is DBNull.Value, "False", Eval("vc_tgl_30")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
               
                </asp:TemplateField>
                                   <asp:TemplateField HeaderText="31">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_31_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_31") Is DBNull.Value, "False", Eval("vc_tgl_31")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>                                          
            </Columns>  
            <HeaderStyle BackColor="#99CCCC" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#ffffff"/>  
        </asp:GridView>  
             
                <asp:SqlDataSource ID="SdsData2" runat="server"></asp:SqlDataSource>
    <br />
    <table style="width: 732px; height: 100px;" border="1" >
                    <tr>
                        <td colspan="2" rowspan="1" style="font-size: 8pt; height: 16px">
                Jenis Lokasi Infeksi</td>
            <td style="font-size: 8pt; width: 128px; height: 16px">
                <asp:CheckBox ID="ChkBoxSuperfisal" runat="server" Text="IDO Superfisal" TextAlign="Left" /></td>
            <td colspan="4" style="font-size: 8pt; height: 16px; width: 181px;">
                &nbsp;<asp:CheckBox ID="ChkBoxFascia" runat="server" Text="IDO Dalam/Fascia" TextAlign="Left" /></td>
            <td colspan="1" style="font-size: 8pt; width: 247px; height: 16px">
                <asp:CheckBox ID="ChkBoxRongga" runat="server" Text="IDO Organ/Rongga" TextAlign="Left" /></td>
                    </tr>
                </table>
                <br /><br />
               <div align="center">
         <asp:Button ID="BtnSaveMonitoringIDO"   runat="server" Text="Save" Height="48px" Width="128px" BackColor="CornflowerBlue" />
        <asp:Button ID="btnKeluar"   runat="server" Text="Keluar" Height="48px" Width="128px" BackColor="Yellow" />
    </div>
</asp:Content>

