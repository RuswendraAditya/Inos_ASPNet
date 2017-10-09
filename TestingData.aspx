<%@ Page Language="VB" MasterPageFile="~/MasterPage4.master" AutoEventWireup="false" CodeFile="TestingData.aspx.vb" Inherits="TestingData" title="Testing..." %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">

        function ActiveTabChanged(sender, e) {
            var CurrentTab = $get('<%= DateTime.Now.ToString("T") %>');
            CurrentTab.innerHTML = sender.get_activeTab().get_headerText();
            Highlight(CurrentTab);
        }

        var HighlightAnimations = {};
        function Highlight(el) {
            if (HighlightAnimations[el.uniqueID] == null) {
                HighlightAnimations[el.uniqueID] = Sys.Extended.UI.Animation.createAnimation({
                    AnimationName: "color",
                    duration: 0.5,
                    property: "style",
                    propertyKey: "backgroundColor",
                    startValue: "#FFFF90",
                    endValue: "#FFFFFF"
                }, el);
            }
            HighlightAnimations[el.uniqueID].stop();
            HighlightAnimations[el.uniqueID].play();
        }

        function ToggleHidden(value) {
            $find('<%= DateTime.Now.ToString("T") %>').get_tabs()[2].set_enabled(value);
        }
    </script>

    <table style="width: 806px">
        <tr>
            <td colspan="4" style="vertical-align: middle; height: 52px; text-align: left">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue"
                    Height="28px" Text="Testing Running Table SIM" Width="377px"></asp:Label></td>
            <td colspan="1" style="vertical-align: middle; height: 52px; text-align: center; width: 253px;">
            </td>
        </tr>
        <tr>
            <td style="width: 1882px; height: 26px;">
                Keuangan</td>
            <td style="width: 95px; height: 26px">
                <asp:Button ID="cmdkeuangan" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px; height: 26px;">
                <asp:LinkButton ID="LinkButton8" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="height: 26px; width: 132px;">
                <asp:Label ID="LblKeuangan" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
            <td rowspan="8" style="vertical-align: top; width: 253px;">
                <asp:TextBox ID="TxtJalur" runat="server" Height="240px" TextMode="MultiLine" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Rekam Medis</td>
            <td style="width: 95px">
                <asp:Button ID="cmdrekammedis" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton1" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblRekamMedis" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Rawat Jalan/Poliklinik</td>
            <td style="width: 95px">
                <asp:Button ID="cmdrawatjalan" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton2" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblRawatJalan" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Rawat Inap/Bangsal</td>
            <td style="width: 95px">
                <asp:Button ID="cmdrawatinap" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton3" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblRawatInap" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Farmasi</td>
            <td style="width: 95px">
                <asp:Button ID="cmdfarmasi" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton4" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblFarmasi" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Laborat</td>
            <td style="width: 95px">
                <asp:Button ID="cmdlaborat" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton5" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblLaborat" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px">
                Radiologi</td>
            <td style="width: 95px">
                <asp:Button ID="cmdradiologi" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px">
                <asp:LinkButton ID="LinkButton6" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px">
                <asp:Label ID="LblRadiologi" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px; height: 27px;">
                Rehab Medik</td>
            <td style="width: 95px; height: 27px;">
                <asp:Button ID="cmdrehabmedik" runat="server" Text="Tes" Width="83px" /></td>
            <td style="width: 71px; height: 27px;">
                <asp:LinkButton ID="LinkButton7" runat="server" Text="Jalur" Width="40px"></asp:LinkButton></td>
            <td style="width: 132px; height: 27px;">
                <asp:Label ID="LblRehabMedik" runat="server" Width="328px" ForeColor="Green"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 1882px; height: 42px;">
            </td>
            <td style="width: 95px; height: 42px">
            </td>
            <td style="width: 71px; height: 42px;">
            </td>
            <td style="height: 42px; width: 132px;">
            </td>
            <td style="height: 42px; width: 253px;">
            </td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="Execute All" Width="117px" />&nbsp;<asp:Button
                    ID="Button2" runat="server" Text="Clear All" Width="117px" /></td>
            <td colspan="1" style="text-align: center; width: 253px;">
            </td>
        </tr>
        <tr>
            <td colspan="4" style="height: 20px; text-align: left">
                </td>
            <td colspan="1" style="height: 20px; text-align: center; width: 253px;">
            </td>
        </tr>
    </table>
        <div >
            &nbsp; &nbsp;
    </div>
    
</asp:Content>

