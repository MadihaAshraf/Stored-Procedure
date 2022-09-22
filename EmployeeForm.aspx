<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="Stored_Procedure.EmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 675px;
        }
        .auto-style2 {
            width: 292px;
            height: 33px;
        }
        .auto-style3 {
            width: 675px;
            height: 33px;
        }
        .auto-style4 {
            width: 292px;
            height: 25px;
        }
        .auto-style5 {
            width: 675px;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center">Employee Form</h2>

    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Id</td>
            <td class="auto-style1">
                <asp:TextBox ID="TBId" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">First Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="TBFName" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Last Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="TBLName" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Date of Birth</td>
            <td class="auto-style1">
                <asp:TextBox ID="TBDob" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Phone Number</td>
            <td class="auto-style5">
                <asp:TextBox ID="TBPhone" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
        </table>
        </div>

    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 292px">Email</td>
            <td class="auto-style1">
                <asp:TextBox ID="TBEmail" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
    </table>

    <table class="nav-justified">
        <tr>
            <td class="auto-style2">Gender</td>
            <td class="auto-style3">
                <asp:TextBox ID="TBGender" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
    </table>
        <p>
                <asp:Button ID="ButtonInsert1" runat="server" OnClick="Button1_Click" Text="Insert" /> &nbsp;
                <asp:Button ID="ButtonUpdate1" runat="server" OnClick="Button3_Click" Text="Update" /> &nbsp;
                <asp:Button ID="ButtonDelete1" runat="server" OnClick="Button4_Click" Text="Delete" /> &nbsp;
                <asp:Button ID="ButtonSelect1" runat="server" OnClick="Button5_Click" Text="Select" /> &nbsp;
                <asp:Button ID="ButtonClear1" runat="server" Text="Clear" OnClick="ButtonClear_Click" />
            </p>
        <p>
                <asp:Label ID="LInfo" runat="server"></asp:Label>
            </p>
    </form>
</body>
</html>
