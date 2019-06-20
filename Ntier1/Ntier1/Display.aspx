<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Ntier1.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/> 
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="f1" runat="server"> 

        <div class="container-fluid" style="height:200px;background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);" > 



        </div>
         <!-- second container start-->
        <div class="container-fluid" style="height:50px;padding-top:20px"> 
         <div class="row"> 
             <div class="col-lg-4" style="text-align:right"><a href="insert.aspx"> Create</a> </div>
             <div class="col-lg-8">
                 <div class="col-lg-12">
                      <div class="col-lg-4" style="text-align:right"> Search By Name </div>
                <div class="col-lg-4"> <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox> </div>
                <div class="col-lg-4"> <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Search" OnClick="Button1_Click"  /> </div>
                 </div>

             </div>
               
                    </div>
            </div>
         <!-- second container ends -->

  <!-- 3rd container starts -->
        <div class="container-fluid" style="margin-top:40px;padding-top:20px">
            

            <asp:DataList ID="DataList1" runat="server" style="width:100%">

               
                <ItemTemplate>
                     <div class="row" style="height:200px">
                 <!-- 1st col-lg start -->
                <div class="col-lg-12">
                    <!-- 2nd col-lg start -->
                    <div class="col-lg-3"> </div>
                    <div class="col-lg-6"> 
                          <p>Name : <%#Eval("name") %> </p>
                            
                          <p>D.O.B : <%#Eval("dob") %> </p>
                            
                          <p>Ni-Number: <%#Eval("ninumber") %> </p>
                            
                          <p>Address : <%#Eval("address") %> </p>
                    </div>
                    <div class="col-lg-3"> 
                        <div class="col-lg-6"><a href="Update.aspx?id=<%#Eval("id")%>">Update </a></div>
                         <div class="col-lg-6"><a href="Delete.aspx?id=<%#Eval("id")%>">Delete </a></div>
                    </div>



                    
                     <!-- 1st col-lg ends -->
                    </div>
                <!-- 1st col-lg ends -->
             </div>
          




                </ItemTemplate>





            </asp:DataList>
             </div>
         <!-- 3rd container ends -->

                   
   </form> 
</body>

</html>