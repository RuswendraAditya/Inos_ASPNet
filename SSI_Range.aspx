<%@ Page Language="VB" MasterPageFile="~/MasterPageBlank.master" AutoEventWireup="false" CodeFile="SSI_Range.aspx.vb" Inherits="SSI_Range" title="HAIs TRIWULAN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 784px">
        <tr>
            <td style="width: 31px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Icon/excel.png" /></td>
        </tr>
        <tr>
            <td style="width: 31px">
            </td>
            <td colspan="3">
                <asp:Label ID="LblJudul" runat="server" Font-Bold="True" ForeColor="#004000" Text="INDICATE RATE INFEKSI"
                    Width="496px" Font-Size="Medium"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 31px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
            </td>
        </tr>
        <tr>
            <td style="width: 31px">
            </td>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                    CellPadding="4" CssClass="mGrid" ShowFooter="True" Width="645px">
                    <AlternatingRowStyle BackColor="White" CssClass="alt" />
                    <Columns>
                        <asp:TemplateField HeaderText="NO">
                            <ItemTemplate>
                                <asp:Label ID="lblno" runat="server" Text='<%# Bind("no") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SSI">
                            <ItemTemplate>
                                <asp:Label ID="lblSSI" runat="server" Text='<%# Bind("SSI") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="280px" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="%">
                            <ItemTemplate>
                                <asp:Label ID="lblHasil1" runat="server" Text='<%# Bind("HASILBULAN1") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="%">
                            <ItemTemplate>
                                <asp:Label ID="lblHasil2" runat="server" Text='<%# Bind("HASILBULAN2") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="%">
                            <ItemTemplate>
                                <asp:Label ID="lblHasil3" runat="server" Text='<%# Bind("HASILBULAN3") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="TARGET" >
                            <ItemTemplate>
                                <asp:Label ID="lbltarget" runat="server" Text='<%# Bind("target","{0:n}") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="80px" />
                            <ItemStyle HorizontalAlign="Right" />
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
            <td style="width: 31px">
            </td>
            <td style="width: 85px">
            </td>
            <td style="width: 279px">
            </td>
            <td style="width: 224px">
            </td>
        </tr>
    </table>
</asp:Content>

