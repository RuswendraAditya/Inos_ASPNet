<%@ Page Language="VB"   MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="FormMonitoringPlebitis.aspx.vb" Inherits="FormMonitoringPlebitis" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 732px; height: 300px;" border="1" >
     <tr>
            <td style="width: 26px; height: 55px;">
               </td>
            <td colspan="5" style="font-weight: bold; font-size: 11pt; color: blue; height: 55px; width: 312px; text-align: center;">
                FORMULIR MONITORING PELAKSAAAN BUNDLE PENCEGAHAN PLEBITIS</td>
        </tr>
        <tr>
            <td style="width: 26px; height: 20px;">
                Jenis Cateter</td>
            <td style="width: 341px; height: 20px"><asp:CheckBox ID="chkBoxAbocath" runat="server" Text="Abocath" TextAlign="Left" />
                <br />
                <asp:CheckBox ID="chkBoxVenflon" runat="server" Text="Venflon" TextAlign="Left" />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 26px; height: 20px">
                <span lang="IN" style="font-size: 10pt; color: #000000; line-height: 115%; font-family: 'Calibri',sans-serif;
                    mso-fareast-font-family: Calibri; mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: IN;
                    mso-fareast-language: EN-US; mso-bidi-language: AR-SA">Vena</span></td>
            <td style="width: 341px; height: 20px">
                <asp:CheckBox ID="ChkBoxMetacarpal" runat="server" Text="v.metacarpal" TextAlign="Left" /><br />
                <asp:CheckBox ID="ChkBoxSefalika" runat="server" Text="v. sefalika" TextAlign="Left" /><br />
                <asp:CheckBox ID="ChkBoxBasalika" runat="server" Text="v basalika" TextAlign="Left" /><br />
                <asp:CheckBox ID="ChkBoxMedialis" runat="server" Text=" v. antebrakhial medialis" TextAlign="Left" /></td>
        </tr>
        <tr>
            <td style="width: 26px; height: 29px;">
                No Cateter IV</td>
            <td style="width: 341px; height: 29px;">
                &nbsp;<br />
                <asp:CheckBox ID="chkBoxCateter16" runat="server" Text="16" TextAlign="Left" /><br />
                <asp:CheckBox ID="chkBoxCateter18" runat="server" Text="18" TextAlign="Left" /><br />
                <asp:CheckBox ID="chkBoxCateter20" runat="server" Text="20" TextAlign="Left" /><br />
                <asp:CheckBox ID="chkBoxCateter22" runat="server" Text="22" TextAlign="Left" /><br />
                <asp:CheckBox ID="chkBoxCateter24" runat="server" Text="24" TextAlign="Left" /></td>
        </tr>
        <tr>
            <td style="width: 26px; height: 19px;">
            </td>
            <td style="width: 341px; height: 19px;">
            </td>
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
                <asp:TemplateField HeaderText="Pencegahan Plebitis" >  
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
                        <asp:CheckBox ID="chk_tgl_2" runat="server"    Checked='<%# IIf(Eval("vc_tgl_2") Is DBNull.Value, "False", Eval("vc_tgl_2")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
     
                </asp:TemplateField>
                <asp:TemplateField HeaderText="3">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_3" runat="server"  Checked='<%# IIf(Eval("vc_tgl_3") Is DBNull.Value, "False", Eval("vc_tgl_3")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
          
                </asp:TemplateField>
                <asp:TemplateField HeaderText="4">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_4" runat="server"   Checked='<%# IIf(Eval("vc_tgl_4") Is DBNull.Value, "False", Eval("vc_tgl_4")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
        
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="5">  
                  <ItemTemplate>   
                        <asp:CheckBox ID="chk_tgl_5" runat="server"   Checked='<%# IIf(Eval("vc_tgl_5") Is DBNull.Value, "False", Eval("vc_tgl_5")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
       
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="6">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_6" runat="server"   Checked='<%# IIf(Eval("vc_tgl_6") Is DBNull.Value, "False", Eval("vc_tgl_6")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  

                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="7">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_7" runat="server"   Checked='<%# IIf(Eval("vc_tgl_7") Is DBNull.Value, "False", Eval("vc_tgl_7")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="8">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_8" runat="server"   Checked='<%# IIf(Eval("vc_tgl_8") Is DBNull.Value, "False", Eval("vc_tgl_8")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="9">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_9" runat="server"   Checked='<%# IIf(Eval("vc_tgl_9") Is DBNull.Value, "False", Eval("vc_tgl_9")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                 <asp:TemplateField HeaderText="10">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_10" runat="server"   Checked='<%# IIf(Eval("vc_tgl_10") Is DBNull.Value, "False", Eval("vc_tgl_10")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="11">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_11" runat="server"   Checked='<%# IIf(Eval("vc_tgl_11") Is DBNull.Value, "False", Eval("vc_tgl_11")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="12">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_12" runat="server"    Checked='<%# IIf(Eval("vc_tgl_12") Is DBNull.Value, "False", Eval("vc_tgl_12")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="13">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_13" runat="server"  Checked='<%# IIf(Eval("vc_tgl_13") Is DBNull.Value, "False", Eval("vc_tgl_13")) %>' ></asp:CheckBox >  
                    </ItemTemplate>   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="14">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_14" runat="server"   Checked='<%# IIf(Eval("vc_tgl_14") Is DBNull.Value, "False", Eval("vc_tgl_14")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="15">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_15" runat="server"  Checked='<%# IIf(Eval("vc_tgl_15") Is DBNull.Value, "False", Eval("vc_tgl_15")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="16">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_16" runat="server"   Checked='<%# IIf(Eval("vc_tgl_16") Is DBNull.Value, "False", Eval("vc_tgl_16")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="17">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_17" runat="server"   Checked='<%# IIf(Eval("vc_tgl_17") Is DBNull.Value, "False", Eval("vc_tgl_17")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="18">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_18" runat="server"   Checked='<%# IIf(Eval("vc_tgl_18") Is DBNull.Value, "False", Eval("vc_tgl_18")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="19">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_19" runat="server"   Checked='<%# IIf(Eval("vc_tgl_19") Is DBNull.Value, "False", Eval("vc_tgl_19")) %>' ></asp:CheckBox >  
                    </ItemTemplate>      
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="20">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_20" runat="server"   Checked='<%# IIf(Eval("vc_tgl_20") Is DBNull.Value, "False", Eval("vc_tgl_20")) %>' ></asp:CheckBox >  
                    </ItemTemplate>   
                </asp:TemplateField>     
               <asp:TemplateField HeaderText="21">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_21" runat="server"  Checked='<%# IIf(Eval("vc_tgl_21") Is DBNull.Value, "False", Eval("vc_tgl_21")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                 </asp:TemplateField>  
                <asp:TemplateField HeaderText="22">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_22" runat="server"    Checked='<%# IIf(Eval("vc_tgl_22") Is DBNull.Value, "False", Eval("vc_tgl_22")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="23">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_23" runat="server"   Checked='<%# IIf(Eval("vc_tgl_23") Is DBNull.Value, "False", Eval("vc_tgl_23")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="24">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_24" runat="server"   Checked='<%# IIf(Eval("vc_tgl_24") Is DBNull.Value, "False", Eval("vc_tgl_24")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="25">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_25" runat="server"   Checked='<%# IIf(Eval("vc_tgl_25") Is DBNull.Value, "False", Eval("vc_tgl_25")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                      </asp:TemplateField>
                 <asp:TemplateField HeaderText="26">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_26" runat="server"   Checked='<%# IIf(Eval("vc_tgl_26") Is DBNull.Value, "False", Eval("vc_tgl_26")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="27">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_27" runat="server"   Checked='<%# IIf(Eval("vc_tgl_27") Is DBNull.Value, "False", Eval("vc_tgl_27")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="28">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_28" runat="server"   Checked='<%# IIf(Eval("vc_tgl_28") Is DBNull.Value, "False", Eval("vc_tgl_28")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="29">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_29" runat="server"   Checked='<%# IIf(Eval("vc_tgl_29") Is DBNull.Value, "False", Eval("vc_tgl_29")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="30">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_30" runat="server"   Checked='<%# IIf(Eval("vc_tgl_30") Is DBNull.Value, "False", Eval("vc_tgl_30")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                </asp:TemplateField>
                                   <asp:TemplateField HeaderText="31">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_31" runat="server"  Checked='<%# IIf(Eval("vc_tgl_31") Is DBNull.Value, "False", Eval("vc_tgl_31")) %>' ></asp:CheckBox >  
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
                <asp:TemplateField HeaderText="Diagnosa Plebits">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_nama" runat="server" Width="150px"   Text='<%# Eval("vc_nama") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="1">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_1_diag" runat="server"  Checked='<%# IIf(Eval("vc_tgl_1") Is DBNull.Value, "False", Eval("vc_tgl_1")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>  
                <asp:TemplateField HeaderText="2">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_2_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_2") Is DBNull.Value, "False", Eval("vc_tgl_2")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>
                <asp:TemplateField HeaderText="3">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_3_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_3") Is DBNull.Value, "False", Eval("vc_tgl_3")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>
                <asp:TemplateField HeaderText="4">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_4_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_4") Is DBNull.Value, "False", Eval("vc_tgl_4")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                   </asp:TemplateField>    
                <asp:TemplateField HeaderText="5">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_5_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_5") Is DBNull.Value, "False", Eval("vc_tgl_5")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   </asp:TemplateField>
                 <asp:TemplateField HeaderText="6">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_6_diag" runat="server"  Checked='<%# IIf(Eval("vc_tgl_6") Is DBNull.Value, "False", Eval("vc_tgl_6")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  </asp:TemplateField>      
                 <asp:TemplateField HeaderText="7">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_7_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_7") Is DBNull.Value, "False", Eval("vc_tgl_7")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                 
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="8">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_8_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_8") Is DBNull.Value, "False", Eval("vc_tgl_8")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                    
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="9">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_9_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_9") Is DBNull.Value, "False", Eval("vc_tgl_9")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>        
                 <asp:TemplateField HeaderText="10">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_10_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_10") Is DBNull.Value, "False", Eval("vc_tgl_10")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="11">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_11_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_11") Is DBNull.Value, "False", Eval("vc_tgl_11")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
        
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="12">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_12_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_12") Is DBNull.Value, "False", Eval("vc_tgl_12")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="13">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_13_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_13") Is DBNull.Value, "False", Eval("vc_tgl_13")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="14">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_14_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_14") Is DBNull.Value, "False", Eval("vc_tgl_14")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="15">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_15_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_15") Is DBNull.Value, "False", Eval("vc_tgl_15")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="16">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_16_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_16") Is DBNull.Value, "False", Eval("vc_tgl_16")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>      
                 <asp:TemplateField HeaderText="17">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_17_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_17") Is DBNull.Value, "False", Eval("vc_tgl_17")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="18">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_18_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_18") Is DBNull.Value, "False", Eval("vc_tgl_18")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                 
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="19">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_19_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_19") Is DBNull.Value, "False", Eval("vc_tgl_19")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="20">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_20_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_20") Is DBNull.Value, "False", Eval("vc_tgl_20")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   </asp:TemplateField>     
               <asp:TemplateField HeaderText="21">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_21_diag" runat="server"  Checked='<%# IIf(Eval("vc_tgl_21") Is DBNull.Value, "False", Eval("vc_tgl_21")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                 </asp:TemplateField>  
                <asp:TemplateField HeaderText="22">  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_22_diag" runat="server"    Checked='<%# IIf(Eval("vc_tgl_22") Is DBNull.Value, "False", Eval("vc_tgl_22")) %>'  ></asp:CheckBox >  
                    </ItemTemplate>  
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="23">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_23_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_23") Is DBNull.Value, "False", Eval("vc_tgl_23")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                       </asp:TemplateField>
                <asp:TemplateField HeaderText="24">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_24_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_24") Is DBNull.Value, "False", Eval("vc_tgl_24")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                          </asp:TemplateField>    
                <asp:TemplateField HeaderText="25">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_25_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_25") Is DBNull.Value, "False", Eval("vc_tgl_25")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                      </asp:TemplateField>
                 <asp:TemplateField HeaderText="26">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_26_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_26") Is DBNull.Value, "False", Eval("vc_tgl_26")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                        </asp:TemplateField>      
                 <asp:TemplateField HeaderText="27">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_27_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_27") Is DBNull.Value, "False", Eval("vc_tgl_27")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                   
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="28">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_28_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_28") Is DBNull.Value, "False", Eval("vc_tgl_28")) %>' ></asp:CheckBox >  
                    </ItemTemplate>       
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="29">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_29_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_29") Is DBNull.Value, "False", Eval("vc_tgl_29")) %>' ></asp:CheckBox >  
                    </ItemTemplate> 
                </asp:TemplateField>        
                   <asp:TemplateField HeaderText="30">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_30_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_30") Is DBNull.Value, "False", Eval("vc_tgl_30")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
               
                </asp:TemplateField>
                                   <asp:TemplateField HeaderText="31">  
                  <ItemTemplate>  
                        <asp:CheckBox ID="chk_tgl_31_diag" runat="server"   Checked='<%# IIf(Eval("vc_tgl_31") Is DBNull.Value, "False", Eval("vc_tgl_31")) %>' ></asp:CheckBox >  
                    </ItemTemplate>  
                  
                </asp:TemplateField>                                          
            </Columns>  
            <HeaderStyle BackColor="#99CCCC" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#ffffff"/>  
        </asp:GridView>  
             
                <asp:SqlDataSource ID="SdsData2" runat="server"></asp:SqlDataSource>
    <br />
    <br />
    <table style="width: 784px; height: 72px;" border="1" >
        <tr>
            <td style="width: 50px; height: 19px;">
                Kejadian Plebitis</td>
            <td style="width: 341px; height: 19px;"><asp:CheckBox ID="ChkBoxInfeksiplebitisYa" runat="server" Text="Ya" TextAlign="Left" />
                <asp:CheckBox ID="ChkBoxInfeksiplebitisTidak" runat="server" Text="Tidak" TextAlign="Left" /></td>
        </tr>
          <tr>
            <td style="width: 50px; height: 19px;">
              Lokasi</td>
            <td style="width: 341px; height: 19px;">
                &nbsp;<asp:TextBox ID="txtLokasiPleb" runat="server" Height="48px" MaxLength="100" TextMode="MultiLine"
                    Width="488px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 50px; height: 19px;">
             Obat Yang Diberikan</td>
            <td style="width: 341px; height: 19px;">
                &nbsp;<asp:TextBox ID="txtObatPleb" runat="server" Height="48px" MaxLength="200" TextMode="MultiLine"
                    Width="488px"></asp:TextBox></td>
        </tr>
    </table>
                <br /><br />
   <div align="center">
         <asp:Button ID="BtnSaveMonitoringplebitis"   runat="server" Text="Save" Height="48px" Width="128px" BackColor="CornflowerBlue" />
        <asp:Button ID="btnKeluar"   runat="server" Text="Keluar" Height="48px" Width="128px" BackColor="Yellow" />
    </div>
</asp:Content>

