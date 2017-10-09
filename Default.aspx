<%@ Page Language="VB" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" title="Login..." %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
    &nbsp;<div id="maincont" style="background-color: white; width: 693px;">
            <!--Begin Middle Top Two Columns Div Element-->
            <!--End Middle Top Two Columns Div Element-->
            <!-- <div style="clear: both;"></div> -->
            <!--Begin Headline News Middle Content-->

            <div class="midcontainer">
                <fieldset style="width: 340px; background-color: white; color: blue;">
                    <div class="container">
                        <table style="width: 100%">
                            <tr>
                                <td colspan="3" style="height: 4px; text-align: center;">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Red"
                                        Text="Masukkan Password Anda" Width="332px" Height="35px"></asp:Label><br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 94px; color: red">
                                    User Name</td>
                                <td style="width: 16px">
                                    :</td>
                                <td style="width: 239px">
                                    <asp:TextBox ID="txtUserName" runat="server" autocomplete="off" Height="22px" MaxLength="15"
                                        Width="148px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RV1" runat="server" ControlToValidate="txtUserName"
                                        ErrorMessage="Masukkan UserName" InitialValue='""' SetFocusOnError="True">*
</asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td style="width: 94px; color: red">
                                    Password</td>
                                <td style="width: 16px">
                                    :</td>
                                <td style="width: 239px">
                                    <asp:TextBox ID="txtPwd" runat="server" autocomplete="off" CssClass="pwd" Height="22px"
                                        MaxLength="15" TextMode="Password" Width="148px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RV2" runat="server" ControlToValidate="txtPwd" ErrorMessage="Masukkan Password"
                                        InitialValue='""' SetFocusOnError="True">*
</asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td style="width: 94px">
                                </td>
                                <td style="width: 16px">
                                </td>
                                <td style="width: 239px">
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
                                        Height="28px" Text="Batal" Width="88px" />
                    <asp:Label ID="lblMsg" runat="server" CssClass="lbl" Font-Bold="True" Font-Size="Large"
                        ForeColor="Red"></asp:Label></td>
                            </tr>
                        </table>
                    </div>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Transparent"
                        Height="1px" ShowMessageBox="True" ShowSummary="False" Width="335px" />
                    <br />
                </fieldset>
                <br />
                <div class="col3" style="width: 254px">
                    &nbsp;<img src="images/hdbullet.gif" /><span class="midtitle">Visi Rumah Sakit</span>&nbsp;<br />
                    <p>
                        <a class="pic_box" href="http://bethesda.or.id" title="Go to our music section now!">
                            <img alt="Go to our music section now!" border="0" src="Images/logo_bethesda.jpg"
                                style="border-top-width: 0px; border-left-width: 0px; background-image: url(Images/logo yakkum.jpg);
                                border-bottom-width: 0px; height: 60px; border-right-width: 0px; weight: 50px" /></a>
                        Menjadi Rumah Sakit pilihan yang bertumbuh dan memuliakan Allah</p>
                    <p>
                        <span class="midtitle"><span style="color: #333333">&nbsp;</span><img src="images/hdbullet.gif" style="font-weight: bold" />Kebijakan mutu Rumah Sakit &nbsp; &nbsp; </span>&nbsp;<br />
                        <a class="pic_box" href="http://bethesda.or.id" title="Go to our music section now!">
                            <img alt="Go to our music section now!" border="0" src="Images/logo_bethesda.jpg"
                                style="border-top-width: 0px; border-left-width: 0px; background-image: url(Images/logo yakkum.jpg);
                                border-bottom-width: 0px; height: 60px; border-right-width: 0px; weight: 50px" /></a>
                        Rumah Sakit Bethesda memberikan layanan yang cepat,tepat,komunikatif dan terpadu
                        sesuai standard mutu sehingga menghasilkan pelanggan yang puas dan setia.</p>
                    <p>
                        Rumah Sakit Bethesda berkomitmen untuk selalu melaksanakan dan meningkatkan keefektifan
                        sistem mutu.</p>
                </div>
                <div class="col3" style="width: 376px">
                    &nbsp;<img src="images/hdbullet.gif" /><span class="midtitle">Misi Rumah Sakit </span><br />
                    <p>
                        <a class="pic_box" href="http://bethesda.or.id" title="Go to our music section now!">
                            <img alt="Go to our music section now!" border="0" src="Images/logo_bethesda.jpg"
                                style="border-top-width: 0px; border-left-width: 0px; border-bottom-width: 0px;
                                height: 60px; border-right-width: 0px; weight: 50px" /></a> 1. Menyelenggarakan
                        pelayanan kesehatan yang holistik, unggul, efisien, efektif dan aman berwawasan
                        lingkungan.</p>
                    <p>
                        2. Menyelenggarakan pelatihan, penelitian dan pengembangan manajemen yang berkesinambungan
                        untuk menghasilkan SDM yang kapabel, berkomitmen, sejahktera dan berjiwa kasih.</p>
                    <p>
                        3.Mewujudkan pelayanan kesehatan yang terjangkau, memuaskan customer dan mampu berkembang
                        dengan baik.</p>
                    <p>
                        4.Menyediakan sarana dan prasarana pelayanan kesehatan dengan mempetimbangkan IPTEK
                        agar pelayanan mampu bersaing di era globalisasi.</p>
                </div>
                <br />
                &nbsp;&nbsp;</div>
                <p>
                    &nbsp;</p>
            <!--End Headline News Middle Content-->
            <!--Begin Middle Bottom Two Columns Div Element-->
            <!--Begin Middle Bottom Two Columns Div Element-->
    </div>
    <div id="rightsidepanel" style="background-color: white">
        <h2>
            <img alt="" src="images/arrow_orange.gif" />
            Poliklinik</h2>
        <ul>
            <li><a href="">Penyakit Dalam (Internes)</a>
            </li>
            <li><a href="">Bedah</a>
            </li>
            <li><a href="">Saraf</a>
            </li>
            <li><a href="">Paru</a> </li>
            <li><a href="">Gigi & Mulut</a>
            </li>
            <li><a href="">Kulit & Kelamin</a>
            </li>
            <li><a href="">Obsgyen</a>
            </li>
            <li><a href="">Woman Klinik</a>
            </li>
        </ul>
    <!--Begin Newsletter Form-->
            <!--End Newsletter Form-->
            <h3>
                <img src="images/arrow_orange.gif" />
                Penunjang</h3>
            <div style="padding-left: 2px; margin-bottom: 10px; padding-top: 6px">
                <img alt="" src="images/arrowred.gif" />
                <a href="">Laboratorium</a><br />
                <img alt="" src="images/arrowred.gif" />
                <a href="">Radiologi</a><br />
                <img alt="" src="images/arrowred.gif" />
                <a href="">Farmasi</a><br />
                <img alt="" src="images/arrowred.gif" />
                <a href="">Rehabilitasi Medik</a><br />
                &nbsp;</div>
            <!--Begin Advertisement-->
            <div class="adspic">
                <img alt="" border="0" src="images/adsheader.gif" />
                <br />
                <a class="pic_box" href="http://www.bethesda.or.id/">
                    <img alt="advertisement" border="0" src="Images/ban3_05new.jpg" weight="143" style="width: 136px; height: 63px" /></a>
                <br />
                <a class="pic_box" href="http://www.yakkum.or.id/">
                    <img alt="advertisement" border="0" src="Images/Yakkum_small.jpg" weight="143" style="width: 141px; height: 64px" /></a>
            </div>
            <!--End Advertisement-->
    </div>
    
    
</asp:Content>

