<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="MemberInformation.aspx.cs" Inherits="MMSApp.UI.Admin.MemberInformation" %>

<asp:Content ID="addBodyContent" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="showBodyContent" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">

    <br />
    <br />
    <div class="col-lg-2"></div>
    <div class="col-lg-8">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <div class="panel-title"><span class="glyphicon glyphicon-list"></span>Member Information</div>
        </div>

        <div class="panel-body">
            <div class="table-responsive">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>Serial No</th>
                            <th>User Name</th>
                            <th>Password</th>
                            <th>Email</th>
                            <th>Phone Number</th>
                            <th>Role Name</th>
                        </tr>
                    </thead>

                    <asp:Repeater ID="showMemberInformation" runat="server">
                        <ItemTemplate>

                            <tbody>
                                <tr>
                                    <td><%# Eval("SerialNo") %></td>
                                    <td><%# Eval("UserName") %></td>
                                    <td><%# Eval("Password") %></td>
                                    <td><%# Eval("Email") %></td>
                                    <td><%# Eval("PhoneNumber") %></td>
                                    <td><%# Eval("RoleName") %></td>
                                </tr>
                            </tbody>

                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </div>
    </div>
    <div class="col-lg-2"></div>
    

</asp:Content>
