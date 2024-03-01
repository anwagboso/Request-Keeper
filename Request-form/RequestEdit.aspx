<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RequestEdit.aspx.cs" Inherits="Request_form.RequestEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style=" margin-top:50px" >  
          Request Edit
  <div class="form-group">
    <label for="txtFirstName">FirstName</label>
   
     <asp:TextBox ID="txtFirstName" class="form-control"  placeholder="Enter firstname" runat="server"></asp:TextBox>
      </div>
  <div class="form-group">
  <label for="txtLastName">LastName</label>
   <asp:TextBox ID="txtLastName" class="form-control"   placeholder="Enter lastname" runat="server"></asp:TextBox>
</div>
 <div class="form-group">
  <label for="txtAddress">Address</label>
  <asp:TextBox ID="txtAddress" class="form-control"   placeholder="Enter Address" runat="server"></asp:TextBox>
</div>
  <div class="form-group">
  <label for="txtPhoneNo">Phone No</label>
   <asp:TextBox ID="txtPhoneNo" class="form-control"   placeholder="Enter lastname" runat="server"></asp:TextBox>
</div>
  <div class="form-group">
    <label for="txtRequestNote">Request Note</label>
     <asp:TextBox ID="txtRequestNote" class="form-control" TextMode="MultiLine"  runat="server"></asp:TextBox>
  </div>
  
 <%-- <button type="submit" class="btn btn-primary">Submit</button>--%>
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Update" OnClick="Button1_Click" />

        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="<< Back " OnClick="Button2_Click" />
</div>
</asp:Content>
