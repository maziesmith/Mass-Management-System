<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="MMSApp.UI.Admin.AddMember" %>

<asp:Content ID="addBodyContent" ContentPlaceHolderID="addBodyContentPlaceHolder" runat="server">
    
    <br/><br/>
    
     <div class="col-lg-3"></div>
     <div class="col-lg-6">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title"><span class="glyphicon glyphicon-file"></span>Add Member</h3>
        </div>
        <asp:Label ID="message" runat="server"></asp:Label>
        <div class="panel-body">
            <form class="form-horizontal" runat="server">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Member Name</label>
                    <div class="col-sm-9">
                        <asp:DropDownList id="userMemberDropDownList" name="userMemberDropDownList" runat="server" class="form-control"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button id="AddMemberButton" runat="server" type="Button" Text="Add Member" class="btn btn-primary pull-right" OnClick="AddMemberButton_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>
    <div class="col-lg-3"></div>

</asp:Content>

<asp:Content ID="showBodyContent" ContentPlaceHolderID="showBodyContentPlaceHolder" runat="server">
</asp:Content>