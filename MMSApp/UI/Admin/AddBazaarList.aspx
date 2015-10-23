<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddBazaarList.aspx.cs" Inherits="MMSApp.UI.Admin.AddBazaarList" %>
<asp:Content ID="addBodyContent" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
    <br/><br/>
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>Add BazaarList</h3>
        </div>
        <asp:Label id="message" runat="server"></asp:Label>
        <div class="panel-body">
            <form id="bazaarListForm" class="form-horizontal" runat="server">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Member Name</label>
                    <div class="col-sm-9">
                        <asp:DropDownList id="memberNameDropDownList" name="memberNameDropDownList" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Bazaar Date</label>
                    <div class="col-sm-9">
                        <input id="bazaarDateTextBox" name="bazaarDateTextBox" type="text" class="form-control"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button id="AddBazaarListButton" runat="server" type="Button" Text="Add BazaarList" class="btn btn-primary pull-right" OnClick="AddBazaarListButton_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>
    <div class="col-lg-3"></div>
    
    <script>
        $(document).ready(function() {
            $("#bazaarListForm").validate({
                rules: {
                    memberNameDropDownList: "required",
                    bazaarDateTextBox: "required"
                },
                messages: {
                    memberNameDropDownList: "Select Member Name",
                    bazaarDateTextBox: "Enter the Date"
                }
            });
            $("#bazaarDateTextBox").datepicker();
        });
    </script>

</asp:Content>

<asp:Content ID="showBodyContent" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
</asp:Content>
