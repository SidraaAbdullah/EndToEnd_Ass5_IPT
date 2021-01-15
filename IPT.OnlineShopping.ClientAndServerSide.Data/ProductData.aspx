<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductData.aspx.cs" Inherits="IPT.OnlineShopping.ClientAndServerSide.Data.ProductData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Online Shopping</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>                
                <tr>
                    <td>
                        ProductName:
                    </td>
                    <td>
                        <input type="text" id="productName" />
                    </td>
                </tr>
                <tr>
                    <td>
                        ProductPrice:
                    </td>
                    <td>
                        <input type="number" id="productPrice" />
                    </td>
                </tr>
                <tr>
                    <td>
                        ProductBrand:
                    </td>
                    <td>
                        <input type="text" id="productBrand" />
                    </td>
                </tr>
                <tr>
                    <td>
                        ProductQuantity:
                    </td>
                    <td>
                        <input type="number" id="productQuantity" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Description:
                    </td>
                    <td>
                        <input type="text" id ="description" />
                    </td>
                </tr>
                <tr>
                    <td >
                        <span onclick="addProduct()">Add Customer</span>
                    </td>
                </tr>

            </table>
            <hr />
            <br /><br />
            <table style="width:100%">
              <tr>                 
                 <th>ProductName</th> 
                 <th>Price</th>
                 <th>Brand</th>
                 <th>Quantity</th> 
                 <th>Description</th>              
             </tr>   
             <tr>
               <td id="productName">                 
               </td>
             </tr>
             <tr>
               <td id="price">                
               </td>
             </tr>
             <tr>
               <td id="brand">                 
               </td>
             </tr>
                 <tr>
               <td id="quantity">               
               </td>
             </tr>
             <tr>
               <td id="description">                 
               </td>
             </tr>
           </table>
        </div>
    </form>
    <script>
        function addProduct() {            
            var productName = $("#productName").val();
            var productPrice = $("#productPrice").val();
            var productBrand = $("#productBrand").val();
            var productQuantity = $("#productQuantity").val();
            var description = $("#description").val();

            var product = new Object();            
            product.productName = productName;
            product.productPrice = productPrice;
            product.productBrand = productBrand;
            product.productQuantity = productQuantity;
            product.description = description;

            var productStr = JSON.stringify(product);
            $.ajax({
                type: "GET",
                url: "ProductData.aspx/AddProduct",
                contentType: "application/JSON",
                data:
                {
                    product: productStr,
                },
                success: function (result) {
                    var productData = JSON.parse(result.d);
                    console.log(prouctData);
                    $("#productName").val(productData.productName);
                    $("#price").val(productData.productPrice);
                    $("#brand").val(productData.productBrand);
                    $("#quantity").val(productData.productQuantity);
                    $("#description").val(productData.description);
                }
            });
        }
    </script>
</body>
</html>
