<%@ Page Title="" Language="C#" MasterPageFile="~/Student Master.Master" AutoEventWireup="true" CodeBehind="Student Exam Registration.aspx.cs" Inherits="Student.Student_Exam_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb">Department HOD Allotment</h4>
                          <div>
                      <table class="table" align="left">    
                           
                          <tr>
                                <td valign="middle">
                       Exam 
                       </td>
                         <td valign="middle">
                      <div class="form-group">
                    <asp:DropDownList ID="ddlexam" AppendDataBoundItems="false" runat="server" CssClass="form-control" AutoPostBack="true">
                              <asp:ListItem Value="0">Select</asp:ListItem>
                     </asp:DropDownList>                            
                          </div>
                             </td></tr>
                          </table>

                              <asp:Button runat="server" ID="btnSave" CssClass="btn btn-theme" 
                            Width="100px" Text="Register" OnClick="btnSave_Click"    />
                              </div></div></div>
</asp:Content>
