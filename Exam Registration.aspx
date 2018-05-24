<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Exam Registration.aspx.cs" Inherits="Student.Exam_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row mt">
                    <div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i>New Exam Registration</h4>
                      <%--<form class="form-inline" role="form">--%>
                          <div>
                      <table class="table" align="left">
                      

                      <tr>
                      <td valign="middle">
                       Exam Type
                       </td>
                       <td valign="middle">
                      <div class="form-group">
                       <asp:TextBox ID="txtexam" runat="server" CssClass="form-control" AutoCompleteType="Disabled" />    
                       </div>
                                 
                      </tr>
 
                         

                          <tr>
                      <td valign="middle">
                       Time
                       </td>
                       <td valign="middle">
                      <div class="form-group">
                          <asp:DropDownList ID="ddlhr" runat="server" CssClass="form-control">
                              <asp:ListItem>select</asp:ListItem>
                              <asp:ListItem>1 Hr</asp:ListItem>
                              <asp:ListItem>2 Hr</asp:ListItem>
                              <asp:ListItem>3 Hr</asp:ListItem>
                          </asp:DropDownList>
                       </div>
                                 
                      </tr>
                           
                          <tr>
                      <td valign="middle">
                       Total Marks
                       </td>
                       <td valign="middle">
                      <div class="form-group">
                       <asp:TextBox ID="txtmark" runat="server" CssClass="form-control" AutoCompleteType="Disabled" onkeypress="return numeric(event);" />    
                       </div>
                                 
                      </tr>
 
                     
                      </table>                

                                      
                           <asp:Button runat="server" ID="btnSave" CssClass="btn btn-theme" 
                            Width="100px" Text="Save" OnClick="btnSave_Click" />
                    </div>
                          </div>
                        </div>

    </div>
</asp:Content>
