<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="FormSurveilansInfeksiSummary.aspx.vb" Inherits="FormSurveilansInfeksiSummary" title="Summary Surveilans" %>
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
             <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="Summary Surveilans Rumah Sakit"
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
                        <asp:TemplateField HeaderText="Ruang" >
                            <ItemTemplate>
                                <asp:Label ID="lblRuang" runat="server"  Text='<%# Bind("VC_n_ruang") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="90px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Vena Central(N)">
                            <ItemTemplate>
                                <asp:Label ID="lblVenaCentral" runat="server" Text='<%# Bind("vena_sentral_n") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="90px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="IADPP">
                            <ItemTemplate>
                                <asp:Label ID="lblIADP" runat="server" Text='<%# Bind("iadp") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Vena Perifier(N)">
                            <ItemTemplate>
                                <asp:Label ID="lblVenaPerifier" runat="server" Text='<%# Bind("vena_perifier_n") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Plebitis">
                            <ItemTemplate>
                                <asp:Label ID="lblPlebitis" runat="server" Text='<%# Bind("plebitis") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        
                            <asp:TemplateField HeaderText="D-Cateter(N)">
                            <ItemTemplate>
                                <asp:Label ID="lblurine" runat="server"  Text='<%# Bind("urine_n") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              
                            <asp:TemplateField HeaderText="Ca-Uti">
                            <ItemTemplate>
                                <asp:Label ID="lblISK" runat="server"  Text='<%# Bind("ISK") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Tirah Baring(N)" >
                            <ItemTemplate>
                                <asp:Label ID="lblTirah_1" runat="server" Text='<%# Bind("tirah_n") %>'></asp:Label >
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              <asp:TemplateField HeaderText="HAP">
                            <ItemTemplate>
                                <asp:Label ID="lblHAP" runat="server"  Text='<%# Bind("HAP") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              
                             <asp:TemplateField HeaderText="Ventilator(N)">
                            <ItemTemplate>
                                <asp:Label ID="lblVentilator" runat="server" Text='<%# Bind("ventilator_n") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="VAP">
                            <ItemTemplate>
                                <asp:Label ID="lblVAP" runat="server" Text='<%# Bind("VAP") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Tirah Baring(N)" >
                            <ItemTemplate>
                                <asp:Label ID="lblTirah_2" runat="server" Text='<%# Bind("tirah_n") %>'></asp:Label >
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                              <asp:TemplateField HeaderText="Dekubitus">
                            <ItemTemplate>
                                <asp:Label ID="lblHAP" runat="server"  Text='<%# Bind("dekubitus") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="90px" />
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

