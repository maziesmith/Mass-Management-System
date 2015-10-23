<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddBazaar.aspx.cs" Inherits="MMSApp.UI.Admin.AddBazaar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
      <br/><br/>
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>Add Bazaar</h3>
        </div>
        <asp:Label id="message" runat="server"></asp:Label>
        <div class="panel-body">
            <form id="bazaarForm" class="form-horizontal" runat="server">
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
                    <label class="col-sm-3 control-label">Bazaar Amount</label>
                    <div class="col-sm-9">
                        <input id="bazaarAmountTextBox" name="bazaarAmountTextBox" type="text" class="form-control"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button id="AddBazaarButton" runat="server" type="Button" Text="Add Bazaar" class="btn btn-primary pull-right" OnClick="AddBazaarButton_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>
    <div class="col-lg-3"></div>
    
   
    <script>
        $(document).ready(function () {
            $("#bazaarForm").validate({
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
<asp:Content ID="Content2" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
</asp:Content>
