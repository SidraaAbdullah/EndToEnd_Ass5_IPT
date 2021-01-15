using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using IPT.OnlineShopping.Data.Helpers;
using Newtonsoft.Json;

namespace IPT.OnlineShopping.ClientAndServerSide.Data
{
    public partial class ProductData : System.Web.UI.Page
    {
        static ProductHelper productHelper;
        protected void Page_Load(object sender, EventArgs e)
        {
            productHelper = new ProductHelper();
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]

        public static string AddProduct()
        {
            var productStr = HttpContext.Current.Request["product"];

            var products = JsonConvert.DeserializeObject<ProductModel>(productStr);
            productHelper.Insert(products.Name, products.Price, products.Quantity, products.Brand, products.Description);

            var allRecords = productHelper.GetAllProduct();
            var allRecordsConverter = new List<ProductModel>();
            foreach (var productRecord in allRecords)
            {
                var p = new ProductModel();
                p.Name = productRecord.Name;
                p.Price = productRecord.Price;
                p.Brand = productRecord.Brand;
                p.Description = productRecord.Description;
                p.Quantity = productRecord.Quantity;

                allRecordsConverter.Add(p);
            }
            var allRecordStr = JsonConvert.SerializeObject(allRecordsConverter);
            return allRecordStr;

        }
        public class ProductModel
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Brand { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
        }
    }
}