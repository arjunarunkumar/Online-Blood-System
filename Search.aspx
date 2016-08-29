<%@ Page Language="C#" MasterPageFile="~/BBMasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<asp:Label ID="Label1" runat="server" Text="Select Blood Group" 
        style="text-align: center"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>A+</asp:ListItem>
        <asp:ListItem>A-</asp:ListItem>
        <asp:ListItem>AB+</asp:ListItem>
        <asp:ListItem>AB-</asp:ListItem>
        <asp:ListItem>B+</asp:ListItem>
        <asp:ListItem>B-</asp:ListItem>
        <asp:ListItem>O+</asp:ListItem>
        <asp:ListItem>O-</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblAvailability" runat="server" 
        Text="Availability in Blood Bank: x bottles"></asp:Label>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Display donors with same blood group</asp:LinkButton>
    <br />
    <asp:GridView ID="gvSelectiveDonors" runat="server">
        <AlternatingRowStyle BackColor="#6699FF" />
    </asp:GridView>
    <br />
    <br />
    <asp:Chart ID="Chart1" runat="server">
        <series>
            <asp:Series Name="Series1">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
    <br />
    <br />
</asp:Content>