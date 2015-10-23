<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BazaarInformation.aspx.cs" Inherits="MMSApp.UI.Admin.BazaarInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
    <br />
    <br />
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>Bazaar Information</h3>
            </div>
            
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
                            <asp:Button ID="showBazaarButton" runat="server" type="Button" Text="Show Bazaar" class="btn btn-primary pull-right" OnClick="showBazaarButton_Click" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    
    <span>Total Bazaar = <asp:Label ID="message" runat="server"></asp:Label></span>

    <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Serial No</th>
                        <th>Bazaar Date</th>
                        <th>Bazaar Amount</th>
                    </tr>
                </thead>

                <asp:Repeater ID="showBazaarInformation" runat="server">
                    <ItemTemplate>

                        <tbody>
                            <tr>
                                <td><%# Eval("SerialNo") %></td>
                                <td><%# Eval("BazaarDate") %></td>
                                <td><%# Eval("BazaarAmount") %></td>
                            </tr>
                        </tbody>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
        
    </div>
    <div class="col-lg-3"></div>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
</asp:Content>
