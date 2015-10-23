<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddMeal.aspx.cs" Inherits="MMSApp.UI.Admin.AddMeal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
    
     <br/><br/>
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>Add Meal</h3>
        </div>
        <asp:Label id="message" runat="server"></asp:Label>
        <div class="panel-body">
            <form id="mealForm" class="form-horizontal" runat="server">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Member Name</label>
                    <div class="col-sm-9">
                        <asp:DropDownList id="memberNameDropDownList" name="memberNameDropDownList" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Meal Date</label>
                    <div class="col-sm-9">
                        <input id="mealDateTextBox" name="mealDateTextBox" type="text" class="form-control"/>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-sm-3 control-label">Meal Number</label>
                    <div class="col-sm-9">
                        <input id="mealNumberTextBox" name="mealNumberTextBox" type="text" class="form-control"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button id="AddMealButton" runat="server" type="Button" Text="Add Meal" class="btn btn-primary pull-right" OnClick="AddMealButton_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>
    <div class="col-lg-3"></div>
    
    
    <script>
        $(document).ready(function () {
            $("#mealForm").validate({
                rules: {
                    memberNameDropDownList: "required",
                    bazaarDateTextBox: "required"
                },
                messages: {
                    memberNameDropDownList: "Select Member Name",
                    bazaarDateTextBox: "Enter the Date"
                }
            });
            $("#mealDateTextBox").datepicker();
        });
    </script>
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
</asp:Content>
