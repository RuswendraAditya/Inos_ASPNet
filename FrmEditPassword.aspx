<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FrmEditPassword.aspx.vb" Inherits="FrmEditPassword" title="Edit Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset style="width: 415px; background-color: white">
        <div class="container">
            <table style="width: 100%">
                <tr>
                    <td colspan="3" style="height: 4px">
                        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Red"
                            Text="Ubah Password" Width="329px"></asp:Label><br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 307px; color: red; height: 32px;">
                        Password Lama</td>
                    <td style="width: 16px; height: 32px;">
                        :</td>
                    <td style="width: 304px; height: 32px">
                        <asp:TextBox ID="txtPasswordLama" runat="server" autocomplete="off" Height="22px" MaxLength="15"
                            Width="148px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RV1" runat="server" ControlToValidate="txtPasswordLama"
                            ErrorMessage="Password Lama Harus diisi" InitialValue='""' SetFocusOnError="True">*
</asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 307px; color: red; height: 26px;">
                        Password Baru</td>
                    <td style="width: 16px; height: 26px;">
                        :</td>
                    <td style="width: 304px; height: 26px;">
                        <asp:TextBox ID="TxtPassBaru" runat="server" autocomplete="off" CssClass="pwd" Height="22px"
                            MaxLength="15" TextMode="Password" Width="148px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RV2" runat="server" ControlToValidate="TxtPassBaru" ErrorMessage="Masukkan Password"
                            InitialValue='""' SetFocusOnError="True">*
</asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 307px; color: red">
                        Ulangi Password baru</td>
                    <td style="width: 16px">
                        :</td>
                    <td style="width: 304px">
                        <asp:TextBox ID="TxtUlangiPasswordBaru" runat="server" autocomplete="off" CssClass="pwd" Height="22px"
                            MaxLength="15" TextMode="Password" Width="148px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUlangiPasswordBaru"
                            ErrorMessage="Ulangi Masukkan Password" InitialValue='""' SetFocusOnError="True">*
</asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 307px">
                    </td>
                    <td style="width: 16px">
                    </td>
                    <td style="width: 304px">
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="background-color: lightslategray">
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 5px; background-color: white; text-align: center">
                        <asp:Button ID="btnLogIn" runat="server" BackColor="Aquamarine" CssClass="button"
                            Height="27px" Text="OK" Width="103px" />
                        <asp:Button ID="Button1" runat="server" BackColor="Aquamarine" CssClass="button"
                            Height="28px" Text="Keluar" Width="88px" />
                        <asp:Label ID="lblMsg" runat="server" CssClass="lbl" Font-Bold="True" Font-Size="Large"
                            ForeColor="Red"></asp:Label></td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Transparent"
            Height="1px" ShowMessageBox="True" ShowSummary="False" Width="335px" />
    </fieldset>
</asp:Content>

