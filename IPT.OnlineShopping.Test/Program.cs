using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT.OnlineShopping.Data.Helpers;

namespace IPT.OnlineShopping.Test
{
    class Program
    {
        public static void Main()
        {
            CustomerHelper customerHelper = new CustomerHelper();
            //customerHelper.Insert("Sidra Abdullah", "Sidraabdullah56@gmail.com", "sid12345", "03082608409");
            //customerHelper.Insert("Sarmed Rizv", "Sarmed45@gmail.com", "desh123", "03082608409");
            //customerHelper.Insert("Ayesha Zulfiqar", "aaf.zulfii@gmail.com", "hang345", "03188608409");
            //customerHelper.Insert("Saba Abdullah", "Saba56@gmail.com", "wigwam45", "03082908409");
            // customerHelper.Insert("Iqra Shafqat", "iqrashafaq@gmail.com", "sd12345@", "03152658409");

            ProductHelper productHelper = new ProductHelper();
            // productHelper.Insert("Makeup", 1200, 40, "J.", "Not Retrun and not repalceable");
            // productHelper.Insert("kurta", 2200, 20, "J.", "Repalceable");
            // productHelper.Insert("Trouser", 1000, 10, "J.", "Not Retrun and but Repalceable");
            // productHelper.Insert("Perfumes", 2500, 140, "J.", "Not Retrun and not repalceable");
            // productHelper.Insert("Body spray", 800, 140, "J.", "Not Retrun and not repalceable");
            // productHelper.Insert("Stove", 2200, 9, "Dawlance", "Not Retrun and not Repalceable with one Year wrantee");
            // productHelper.Insert("Sandwich Maker", 3000, 5, "Dawlance", "Not Retrun and not Repalceable with one Year wrantee");

            OrderDetailHelper orderDetailHelper = new OrderDetailHelper();
            orderDetailHelper.Insert("22dec,2020", 2400, 2, 3, 3);
            orderDetailHelper.Insert("23dec,2020", 5000,2,6,4 );
            orderDetailHelper.Insert("31dec,2020", 2200, 1, 4, 5);
        }
    }
}
