using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.OnlineShopping.Data.Helpers
{
    public class ProductHelper
    {
        public void Insert(string Name, int Price, int Quantity, string Brand, string Description)
        {
            Product product = new Product();
            product.Name = Name;
            product.Price = Price;
            product.Quantity = Quantity;
            product.Brand = Brand;
            product.Description = Description;

            var db = new OnlineShoppingEntities();
            db.Products.Add(product);
            db.SaveChanges();
            db.Dispose();

        }

        public List<Product> GetAllProduct()
        {
            var db = new OnlineShoppingEntities();
            return db.Products.ToList();
        }
    }
}
