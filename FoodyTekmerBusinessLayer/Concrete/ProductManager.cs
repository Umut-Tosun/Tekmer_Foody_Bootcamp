using FoodTekmerDataAccessLayer.Abstract;
using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerBusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            if(entity.ProductName.Length > 1 && entity.ImageUrl.Length > 1)
            {
                _productDal.Add(entity);
            }
            else
            {
                // - - -- - - - - - -
            }
           
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);  
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public void TUpdate(Product entity)
        {
           _productDal.Update(entity);
        }
    }
}
