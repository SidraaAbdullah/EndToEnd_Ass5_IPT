using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.OnlineShopping.Data.Helpers
{
    public class OrderDetailHelper
    {
        public void Insert(string Date, int TotalPrice, int Quantity, int ProductId, int CustomerId)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Date = Date;
            orderDetail.TotalPrice = TotalPrice;
            orderDetail.Quantity = Quantity;
            orderDetail.ProductId = ProductId;
            orderDetail.CustomerId = CustomerId;

            var db = new OnlineShoppingEntities();
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
