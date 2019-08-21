<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="RoleManage.aspx.cs" Inherits="_3_TIER.RoleManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>
                Enter Role Details
            </th>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtRoleDetails" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="req1" ControlToValidate="txtRoleDetails" runat="server"
                    ErrorMessage="*role detail is required" CssClass="text-danger" display="Dynamic"
                    validationgroup="G1" ></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>
               
                <asp:checkbox ID="chkEnabled" runat="server" CssClass="checkbox-inline" Text="Is Enabled?"/>
                
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" text="Save Role Details " cssclass="btn btn-primary" OnClick="btnSave_Click" />
            </td>
        </tr>
         </tr>
         <tr>
            <td>
                <p class="alert alert-info" id="lblMessage" runat="server"></p>
            </td>
        </tr>

    </table>

    <asp:GridView ID="GridRole" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="table table-risponsive">
        <Columns>
            <asp:BoundField HeaderText="Role Name" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />

    </asp:GridView>
</asp:Content>
