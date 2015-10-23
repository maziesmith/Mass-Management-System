<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MMSApp.UI.Admin.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
        

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
    
    
    <div class="container">
        <div class="row register-panel">
            <div class="col-lg-3"></div>
            <div class="col-lg-6">

                <div class="panel panel-primary" style="background: #23527C; border: 1px solid #114C74;">
                    
                    <div class="panel-heading">
                        <h3 class="panel-title"><b>Register Form</b></h3>
                    </div>

                    <div class="panel-body" style="background: #114C74;">
                         <asp:Label ID="message" runat="server" style="color: #ffffff;text-align: center;"></asp:Label>
                        <form class="form-horizontal" runat="server" id="registerForm">

                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgFullNameTextBox" name="rgFullNameTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Full Name" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgUserNameTextBox" name="rgUserNameTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="User Name" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgPasswordTextBox" name="rgPasswordTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Password" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgEmailTextBox" name="rgEmailTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Email" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgPhoneNumberTextBox" name="rgPhoneNumberTextBox" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Contact Number" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <input id="rgCreatedDateTextBox" name="rgCreatedDateTextBox" type="text" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Created Date"/>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <textarea id="rgPresentAddressTextArea" name="rgPresentAddressTextArea" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" rows="3" placeholder="Present Address"></textarea>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <asp:DropDownList id="rgRoleIdDropDownList" name="rgRoleIdDropDownList" runat="server" style="background: #23527C; border: 1px solid #00476C; color: #ffffff;" class="form-control" placeholder="Created Date"></asp:DropDownList>
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-1"></div>
                                <div class="col-sm-10">
                                    <asp:Button ID="RegisterButton" runat="server" Text="Register" style="background: #23527C; border: 1px solid #114C74;" type="submit" class="btn btn-primary pull-right" OnClick="RegisterButton_Click" />
                                </div>
                                <div class="col-sm-1"></div>
                            </div>
                        </form>

                    </div>
                </div>

            </div>
            <div class="col-lg-3"></div>
        </div>
    </div>
    
    
    
    <script>
        $(document).ready(function () {
            $("#rgCreatedDateTextBox").datepicker();
        });
    </script>

    <script>
        $(document).ready(function () {
            $("#registerForm").validate({
                rules: {
                    rgFullNameTextBox: "required",
                    rgUserNameTextBox: "required",
                    rgPasswordTextBox: {
                        required: true,
                        minlength: 5
                    },
                    rgContactNumberTextBox: "required",
                    rgEmailTextBox: {
                        required: true,
                        email: true
                    },
                    rgPhoneNumberTextBox: "required",
                    rgCreatedDateTextBox: "required",
                    rgPresentAddressTextArea: "required",
                    rgRoleIdDropDownList: "required"
                },
                messages: {
                    rgFullNameTextBox: "Enter the Full Name",
                    rgUserNameTextBox: "Enter the User Name",
                    rgPasswordTextBox: {
                        required: "Enter the Password",
                        minlength: "Please enter at least 5 character"
                    },
                    rgContactNumberTextBox: "Enter the Contact Number",
                    rgEmailTextBox: {
                        required: "Enter the Email",
                        email: "Please valid Email"
                    },
                    rgPhoneNumberTextBox: "Enter the Phone Number",
                    rgCreatedDateTextBox: "Enter the Created Date",
                    rgPresentAddressTextArea: "Enter the Present Address",
                    rgRoleIdDropDownList: "Select Role Name"
                },
            });
        });
    </script>

    

</asp:Content>
