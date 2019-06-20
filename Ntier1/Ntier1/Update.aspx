<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Ntier1.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <div class="container" style="padding-top:150px">
            <h3> Update Records</h3>
            <div class="col-md-6" style="margin-left:30px;margin-top:15px">

                <div class="form-group">
            <label for="txtName"> Name</label>
            <asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder=" Name"></asp:TextBox>     
        </div>
                <div class="form-group">
            <label for="txtPrice"> D.O.B</label>
            <asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="D.O.B"></asp:TextBox>     
        </div>

                <div class="form-group">
            <label for="txtDsc"> Ni Number</label>
            <asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Ni Number" ></asp:TextBox>     
        </div>
                 <div class="form-group">
            <label for="txtDsc"> Address</label>
            <asp:TextBox ID="TextBox4" class="form-control" runat="server" placeholder="Address" ></asp:TextBox>     
        </div>
                
                <asp:Button ID="Button1" class="btn btn-block btn-success" runat="server" Text="Update" OnClick="Button1_Click"  />
            </div>
        </div>
        
    </form>
</body>
</html>