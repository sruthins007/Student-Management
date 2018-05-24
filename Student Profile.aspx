<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Student Profile.aspx.cs" Inherits="Student.Student_Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb">Student Registration</h4>
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
                                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                                    </div>                         
                                </td>  
                                 <td valign="middle">
                                     
                                </td>                         
                             </tr>

                              <tr>
                                <td valign="middle">
                                    Date of Birth
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtdob" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true"  />    
                                    </div>
                                </td>
                                
                                <td valign="middle">
                                    Age
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtage" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>                         
                                </td>                           
                             </tr>
                            


                             <tr>                              
                                <td valign="middle">
                                    Email_id <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true"  />                      
                          <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
              ErrorMessage="enter a email id" ControlToValidate="txtmail"
                  ValidationGroup="vgSubmit" ForeColor="Red"></asp:RequiredFieldValidator>


              <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
              runat="server" ErrorMessage="Please Enter Valid Email ID"
                  ValidationGroup="vgSubmit" ControlToValidate="txtmail"
                  CssClass="requiredFieldValidateStyle"
                  ForeColor="Red"
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> </asp:RegularExpressionValidator>

                       </div>
                      </td>   
                                 <td valign="middle">
                                   Course
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtcourse" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div> 
                                </td>
                                
                                                     
                             </tr>
                            
                          
                                                
        </table>
                          <br />

                          <h4 class="mb">Address</h4>
                      <div>
          			  <table class="table" align="left">
                             <tr>
                                <td valign="middle">
                                    House No.
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txthouse" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                   
                             </tr>


                             <tr>
                                <td valign="middle">
                                    Street
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtstreet" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                                          
                             </tr>


                             <tr>
                                <td valign="middle">
                                    District
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtdistrict" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true"  />    
                                    </div>
                                </td>
                      
                             </tr>

                             <tr>
                                <td valign="middle">
                                    State
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtstate" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true"  />    
                                    </div>
                                </td>
                      
                             </tr>

                             <tr>
                                <td valign="middle">
                                    Pin Code
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtpin" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                      
                             </tr>
                                                   
        </table>

                              
                          <h4 class="mb">Contact Details</h4>
                      <div>
          			  <table class="table" align="left">
                             <tr>
                                <td valign="middle">
                                    Tel:
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtland" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                   
                             </tr>


                             <tr>
                                <td valign="middle">
                                    Mob No:
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtmob1" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                                          
                             </tr>


                             <tr>
                                <td valign="middle">
                                    Mob No 2:
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtmob2" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                      
                             </tr>

                                           
        </table>
<h4 class="mb">Login Details</h4>
                      <div>
          			  <table class="table" align="left">
                             <tr>
                                <td valign="middle">
                                    Username
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtusername" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                   
                             </tr>


                             <tr>
                                <td valign="middle">
                                    Password
                                    <span class="auto-style3">*</span>
                                </td>
                                <td valign="middle">
                                    <div class="form-group">
                                    <asp:TextBox ID="txtpass" runat="server" CssClass="form-control" AutoCompleteType="Disabled" ReadOnly="true" />    
                                    </div>
                                </td>
                                                          
                             </tr>


                           
                                           
        </table>

                         <asp:Button runat="server" ID="btnEdit" CssClass="btn btn-theme" 
                            Width="100px" Text="Edit" OnClick="btnEdit_Click"   />
                          <asp:Button runat="server" ID="btnDelete" CssClass="btn btn-theme" 
                            Width="100px" Text="Delete" OnClick="btnDelete_Click"   />
                          <asp:Button runat="server" ID="btnSave" CssClass="btn btn-theme" 
                            Width="100px" Text="Save" OnClick="btnSave_Click"   />
                      &nbsp;
                              

                          </div>
                        </div>
        </div>
</asp:Content>
