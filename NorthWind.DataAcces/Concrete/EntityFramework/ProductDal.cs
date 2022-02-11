using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NorthWind.DataAcces.Concrete.EntityFramework
{
    public class ProductDal
    {
        //bu class içinde 
        public List<Product> GetAll()
        {
            using (NorthWindContext context =new NorthWindContext())
            {
                return context.Products.ToList();//code semel
            }
        }
        public Product Get(int id)
        {
            using (NorthWindContext context =new NorthWindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);

            }

        }
        public void Add()
        {


           

            
        }

        public void Add(Product product)
        {
            using (NorthWindContext context =new NorthWindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();//veritabanına kayıt etti. 

            }
        }
        public void Update(Product product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                  

            }

        }
        public void Delete(Product product)
        {

        }

    }
}
//burada veritabanı işlerini yaptık. bunlar dışında başka işler yapılmaz!
//bussinnesse gidip iş kodlarını çağırmka gerekecektir. 