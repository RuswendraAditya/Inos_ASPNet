<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" EnableEventValidation = "false" CodeFile="FrmbMitra.aspx.vb" Inherits="FrmbMitra" title="Daftar Mitra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script type="text/javascript">
  function CallPrint(strid)
  {
      var prtContent = document.getElementById(strid);
      var WinPrint = window.open('','','letf=100,top=100,width=1000,height=1000,toolbar=0,scrollbars=1,status=0',resizable=1);
      WinPrint.document.write(prtContent.innerHTML);
      WinPrint.document.close();
      WinPrint.focus();
      WinPrint.print();
      WinPrint.close();

}
  </script>
  

    <table style="width: 800px">
        <tr>
            <td colspan="2" style="width: 4541px; height: 35px">
                </td>
            <td style="width: 13530px; height: 35px">
                &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</td>
            <td style="width: 2776px; height: 35px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="29px" ImageUrl="~/Icon/excel.png" />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageUrl="~/Icon/word.png" />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="29px" ImageUrl="~/Icon/pdf.png" />
                <asp:ImageButton ID="ImageButton6" runat="server" Height="29px" ImageUrl="~/Icon/print.png"
                    OnClientClick="javascript:CallPrint('divPrint')" /></td>
            <td style="width: 365px; height: 35px">
                <asp:ImageButton ID="ImageButton4" runat="server" Height="22px" ImageUrl="~/Icon/close_button_red.png"
                    Width="26px" /></td>
        </tr>
    </table>
   <div id = "divPrint">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Blue" Text="DAFTAR MITRA"
                    Width="601px"></asp:Label><br />
    <asp:SqlDataSource ID="SdsMitra" runat="server"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None"
        BorderWidth="1px" CellPadding="4" CssClass="mGrid"
            PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt">
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:TemplateField HeaderText="Kode" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtkode" runat="server" Text='<%# Bind("vc_kode") %>'
                    Width="200px" Enabled="False"></asp:TextBox>
                </EditItemTemplate>

                <ItemTemplate>
                    <asp:Label ID="lblkode" runat="server" Text='<%# Bind("vc_kode") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="100px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nama Mitra" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtnama" runat="server" Text='<%# Bind("vc_nama_mitra") %>'
                    Width="200px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblNama" runat="server" Text='<%# Bind("vc_nama_mitra") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="200px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Alamat" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtalamat" runat="server" Text='<%# Bind("vc_alamat") %>'
                    Width="300px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblAlamat" runat="server" Text='<%# Bind("vc_alamat") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="300px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Telepon" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtphone" runat="server" Text='<%# Bind("vc_phone") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbldiambiluang" runat="server" Text='<%# Bind("vc_phone") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="100px" />
            </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText="Edit Data">
                    <EditItemTemplate>
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/icon/Update.GIF" />&nbsp;
                        <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Cancel" ImageUrl="~/icon/Cancel.gif" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:ImageButton ID="ImageButton4" runat="server" CommandName="Insert" ImageUrl="~/icon/Insert.gif" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit"
                            ImageUrl="~/icon/Edit.gif" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText="Hapus">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton5" runat="server" OnClientClick="return confirm('Data Mau dihapus?')" CommandName="Delete" CausesValidation="False" 
                         CommandArgument='<%# eval("vc_kode") %>' ImageUrl="~/Icon/Delete.GIF" />
                    </ItemTemplate>
                </asp:TemplateField>

        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" CssClass="pgr" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#147612" Font-Bold="True" ForeColor="#CCCCFF" />
        <AlternatingRowStyle CssClass="alt" />
    </asp:GridView>
   </div> 
</asp:Content>

