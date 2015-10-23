<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BazaarListInformation.aspx.cs" Inherits="MMSApp.UI.Admin.BazaarListInformation" %>

<asp:Content ID="addBodyContent" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">

    <br />
    <br />
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>BazaarList Information</h3>
            </div>
            <asp:Label ID="message" runat="server"></asp:Label>
            <div class="panel-body">
                <form class="form-horizontal" runat="server">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">Member Name</label>
                        <div class="col-sm-9">
                            <asp:DropDownList ID="memberNameDropDownList" name="memberNameDropDownList" runat="server" class="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="showBazaarListButton" runat="server" type="Button" Text="Show BazaarList" class="btn btn-primary pull-right" OnClick="showBazaarListButton_Click" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    
    
    <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Serial No</th>
                        <th>Bazaar Date</th>
                    </tr>
                </thead>

                <asp:Repeater ID="showBazaarListInformation" runat="server">
                    <ItemTemplate>

                        <tbody>
                            <tr>
                                <td><%# Eval("SerialNo") %></td>
                                <%--<td><%# Eval("MemberName") %></td>
                                <td><%# Eval("MemberEmail") %></td>--%>
                                <td><%# Eval("BazaarDate") %></td>
                            </tr>
                        </tbody>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
        
    </div>
    <div class="col-lg-3"></div>

</asp:Content>

<asp:Content ID="showBodyContent" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">


   

</asp:Content>
