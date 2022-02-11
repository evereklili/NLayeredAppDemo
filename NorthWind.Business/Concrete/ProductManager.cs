using NorthWind.DataAcces.Concrete;
using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();

        public List<Product> GetAll()
        {
            //bussinness code adding only. burada iş kodu yazılır. Bu kişi datayı çekmeye çalışıyor ama çekebilir mi? çekitiği data onun görmesine izi varmı? birii uygun mu? bri bankacılık uygulamsında bir kredi datasını göreceği zaman mevzuata uygunluğu gibi durumlar kontrol edilir. 

             
            return _productDal.GetAll();
        }
    }
}
