<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" EnableEventValidation = "false" CodeFile="FrmbTarget.aspx.vb" Inherits="FrmbTarget" title="Surveilans Target" %>
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
   <div id = "divPrint" style="vertical-align: top; text-align: left">
                <br />
    <asp:SqlDataSource ID="SdsData" runat="server"></asp:SqlDataSource>
       <table>
           <tr>
               <td style="width: 103px; height: 36px">
               </td>
               <td style="width: 674px; height: 36px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Blue" Text="MASTER TARGET SURVEILANS"
                    Width="601px"></asp:Label></td>
               <td style="width: 319px; height: 36px">
               </td>
           </tr>
           <tr>
               <td style="width: 103px">
               </td>
               <td style="width: 674px">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None"
        BorderWidth="1px" CellPadding="4" CssClass="mGrid"
            PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt" Width="487px">
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
            
            <asp:TemplateField HeaderText="Nama Survielans" >
                <EditItemTemplate>
                    <asp:TextBox ID="txtnamasurveilans" runat="server" Text='<%# Bind("vc_nama_surveilans") %>'
                    Width="300px" Enabled="False"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblNamasurveilans" runat="server" Text='<%# Bind("vc_nama_surveilans") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="300px" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Target" >
                <EditItemTemplate>
                    <asp:TextBox ID="txttarget" runat="server" Text='<%# Bind("dc_target") %>'
                    Width="100px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbltarget" runat="server" Text='<%# Bind("dc_target") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="100px" />
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

        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" CssClass="pgr" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#147612" Font-Bold="True" ForeColor="#CCCCFF" />
        <AlternatingRowStyle CssClass="alt" />
    </asp:GridView>
               </td>
               <td style="width: 319px">
               </td>
           </tr>
           <tr>
               <td style="width: 103px">
               </td>
               <td style="width: 674px">
               </td>
               <td style="width: 319px">
               </td>
           </tr>
       </table>
       &nbsp;
   </div> 
</asp:Content>

