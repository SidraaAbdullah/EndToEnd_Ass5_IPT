using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.OnlineShopping.Data.Helpers
{
    public class CustomerHelper
    {
        public void Insert(string FullName,string Email, string Password, string PhoneNumber)
        {
            Customer customer = new Customer();
            customer.FullName = FullName;
            customer.Email = Email;
            customer.Password = Password;
            customer.PhoneNumber = PhoneNumber;

            var db = new OnlineShoppingEntities();
            db.Customers.Add(customer);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
