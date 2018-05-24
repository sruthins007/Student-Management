<%@ Page Title="" Language="C#" MasterPageFile="~/Student Master.Master" AutoEventWireup="true" CodeBehind="View Grade.aspx.cs" Inherits="Student.View_Grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row mt">
                    <div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i>Add Questions</h4>
                      <%--<form class="form-inline" role="form">--%>
                          <div>
                      <table class="table" align="left">
                      <tr>
                      <td valign="middle">
                       Exam
                       </td>
                       <td valign="middle">
                      <div class="form-group">
                         <asp:DropDownList ID="ddlexam" AppendDataBoundItems="true" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlexam_SelectedIndexChanged"  >
                              <asp:ListItem Value="0">Select</asp:ListItem>          
                     </asp:DropDownList>   
                       </div>
                      </td>
                      </tr>
                          <tr>
                      <td valign="middle">
                       Grade
                       </td>
                       <td valign="middle">
                      <div class="form-group">
                         <asp:TextBox ID="txtgrade" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true"  />   
                       </div>
                      </td>
                                 
                      </tr>
                          </table>
                              &nbsp;
                              </div>
                          </div>
                        </div>
         &nbsp;
         </div>
    
</asp:Content>
