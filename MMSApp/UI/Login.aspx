<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MMSApp.UI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContetPlaceHolder" runat="server">

    <div class="container">
        <div class="row login-panel">
            <div class="col-lg-4"></div>
            <div class="col-lg-4">

                <div class="panel panel-primary" style="background: #23527C; border: 1px solid #114C74;">
                    <div class="panel-heading">
                        <h3 class="panel-title"><b>Login Form</b></h3>
                    </div>

                    <div class="panel-body" style="background: #114C74;">
                        <asp:Label ID="message" runat="server" Style="color: #ffffff;"></asp:Label>
                        <form class="form-horizontal" runat="server" id="loginForm">

                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <div class="input-group">
                                        <div class="input-group-addon" style="background: #23527C; border: 2px solid #00476C; color: #ffffff;"><span class="glyphicon glyphicon-user"></span></div>
                                        <input id="loginUserNameTextBox" name="loginUserNameTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="User Name" />
                                        <%--<input type="text" id="loginUserNameTextBox" name="loginUserNameTextBox" class="form-control"/>--%>
                                    </div>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <div class="input-group">
                                        <div class="input-group-addon" style="background: #23527C; border: 2px solid #00476C; color: #ffffff;"><span class="glyphicon glyphicon-lock"></span></div>
                                        <input id="loginPasswordTextBox" name="loginPasswordTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Password" />
                                        <%--<input type="text" id="loginPasswordTextBox" name="loginPasswordTextBox"/>--%>
                                    </div>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <div class="input-group">
                                        <div class="input-group-addon" style="background: #23527C; border: 2px solid #00476C; color: #ffffff;"><span class="glyphicon glyphicon-th-list"></span></div>
                                        <asp:DropDownList id="loginRoleDropDownList" name="loginRoleDropDownList" runat="server" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Password" />
                                    </div>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <asp:Button ID="LoginButton" runat="server" Text="Login" class="btn btn-primary pull-right" Style="background: #23527C; border: 1px solid #114C74;" OnClick="LoginButton_Click" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                        </form>

                    </div>
                </div>

            </div>
            <div class="col-lg-4"></div>
        </div>
    </div>

    <script>
        $(document).ready(function () {
            $("#loginForm").validate({
                rules: {
                    loginUserNameTextBox: "required",
                    loginPasswordTextBox: "required",
                    loginRoleDropDownList: "required"
                },
                messages: {
                    loginUserNameTextBox: "Enter Your User Name",
                    loginPasswordTextBox: "Enter Your Password",
                    loginRoleDropDownList: "Select Role"
                },
            });
        });
    </script>


</asp:Content>
