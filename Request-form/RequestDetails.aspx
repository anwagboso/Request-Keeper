<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RequestDetails.aspx.cs" Inherits="Request_form.RequestDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container" style=" margin-top:50px" >    
     <div class="form-group">
       <label for="exampleInputPassword1">Decagon Student Request Details Keeper</label>
       
         <asp:GridView ID="dgDetails" ClientIDMode="Static" runat="server" CssClass="table table-bordered table-striped table-condensed flip-content" OnPreRender="dgDetails_PreRender"  AutoGenerateColumns="False" onrowcommand="dgDetails_RowCommand"  >
             <Columns>
       
      <asp:BoundField DataField="Id" HeaderText="Id"  SortExpression="Id"  />
      <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
      <asp:BoundField DataField="lastName" HeaderText="LastName" SortExpression="lastName" />
      <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" SortExpression="PhoneNo" />
      
      
      
       <asp:TemplateField>
            <HeaderTemplate> Action</HeaderTemplate>
        <ItemTemplate>
            <div class="btn-group btn-group-xs">
         <asp:LinkButton ID="LinkButton1" runat="server" CSSclass="btn btn-primary btn_sizes"  CommandArgument='<%# dgDetails.Rows.Count.ToString() %>' CommandName="UpdateRequest"><i class="fa fa-edit"></i> View Request</asp:LinkButton>
         
        
                </div>
    
         </ItemTemplate>
         </asp:TemplateField>
  </Columns>
</asp:GridView>

      </div>
         
         <asp:Button ID="btnCreateNewRequest" class="btn btn-primary" runat="server" Text="Create New Request" OnClick="btnCreateNewRequest_Click" />
     </div>
</asp:Content>
