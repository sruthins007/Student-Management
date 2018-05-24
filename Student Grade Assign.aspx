<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Student Grade Assign.aspx.cs" Inherits="Student.Student_Grade_Assign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb">Student - Grade</h4>
                      <div>
                          <table class="table" align="left">
                             <tr>
                                <td valign="middle">
                                     Name / Amission No.
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtname" runat="server" CssClass="form-control" AutoCompleteType="Disabled"  />   
                                                             <asp:HiddenField ID="hdempid" runat="server" /> 
                                    </div>
                                </td>
                                
                                
                                <td valign="middle">
                                    <div class="form-group">
                                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"  />
                                    </div>                         
                                </td>  
                                 <td valign="middle">
                                     
                                </td>                         
                             </tr>

                              <tr>
                                <td valign="middle">
                                   Course
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                     <asp:TextBox ID="txtcourse" runat="server" CssClass="form-control" AutoCompleteType="Disabled"  />        
                                    </div>
                                </td>
                                
                                <td valign="middle">
                                  
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                      
                                    </div>                         
                                </td>                           
                             </tr>
                              <tr>
                                <td valign="middle">
                                    Exam
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:DropDownList ID="ddlexam" AppendDataBoundItems="false" runat="server" CssClass="form-control" AutoPostBack="true">
                              <asp:ListItem Value="0">Select</asp:ListItem>
                     </asp:DropDownList>        
                                    </div>
                                </td>
                                
                                <td valign="middle">
                                    Overall Grade
                                    <span class="auto-style3">*</span>
                                </td>
                               
                                   <td valign="middle">
                                    <div class="form-group">
                                    <asp:DropDownList ID="ddlgrade" AppendDataBoundItems="false" runat="server" CssClass="form-control" AutoPostBack="true">
                              <asp:ListItem Value="0">Select</asp:ListItem>
                     </asp:DropDownList>        
                                    </div>
                                                     
                                </td>                           
                             </tr>

                              </table>
                           <asp:Button runat="server" ID="btnSave" CssClass="btn btn-theme" 
                            Width="100px" Text="Save" OnClick="btnSave_Click"  />
                          &nbsp;
                          </div>
                          </div>
                      </div>
        &nbsp;
        </div>
    
</asp:Content>
