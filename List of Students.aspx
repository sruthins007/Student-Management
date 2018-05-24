<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="List of Students.aspx.cs" Inherits="Student.List_of_Students" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt">
                    <div class="col-lg-12">
          			<div class="form-panel">
                          <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1322px">
                              <LocalReport ReportPath="Report3.rdlc">
                                  <DataSources>
                                      <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                  </DataSources>
                              </LocalReport>
                          </rsweb:ReportViewer>
                          <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Student.DataSet3TableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
                          <asp:ScriptManager ID="ScriptManager1" runat="server">
                          </asp:ScriptManager>
                          </div>
                        </div>
        </div>
</asp:Content>
