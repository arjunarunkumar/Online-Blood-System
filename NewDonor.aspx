<%@ Page Language="C#" MasterPageFile="~/BBMasterPage.master" AutoEventWireup="true" CodeFile="NewDonor.aspx.cs" Inherits="NewDonor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
        <br />
    
        <br />
    
        <asp:Label ID="lblTitle" runat="server" Text="New donor registration"></asp:Label>
        <br />
        <br />
        <table style="width:50%;">
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtboxName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtboxName" ErrorMessage="Cannot be left blank." 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtboxAge" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtboxAge" ErrorMessage="Cannot be left blank." 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSex" runat="server" Text="Sex"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="ctrlDropDownSex" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="ctrlDropDownSex" ErrorMessage="Cannot be left blank." 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtboxAddr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="lblPhNumber" runat="server" Text="Phone Number"></asp:Label>
                </td>
                <td class="style1">
        <asp:TextBox ID="txtboxPhNo" runat="server"></asp:TextBox>
    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBloodGroup" runat="server" Text="BloodGroup"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtboxBloodGrp" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtboxBloodGrp" ErrorMessage="Cannot be left blank." 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    
                    &nbsp;</td>
                <td>
        
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Register" />
        
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BBConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:BBConnectionString.ProviderName %>" 
            SelectCommand="SELECT EMPLOYEE_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NUMBER, HIRE_DATE, JOB_ID, SALARY, COMMISSION_PCT, MANAGER_ID, DEPARTMENT_ID FROM EMPLOYEES">
        </asp:SqlDataSource>
        <br />
    
    
</asp:Content>
