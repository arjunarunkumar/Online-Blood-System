<%@ Page Language="C#" MasterPageFile="~/BBMasterPage.master" AutoEventWireup="true" CodeFile="ExistingDonors.aspx.cs" Inherits="ExistingDonors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <br />
    </div>
    <br />
&nbsp;<asp:Panel ID="Panel1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Styles/prew_img3.jpg" />
    </asp:Panel>
&nbsp;<asp:GridView ID="gvDonors" runat="server">
        <AlternatingRowStyle BackColor="#6699FF" />
        </asp:GridView>
    <br />
</asp:Content>
