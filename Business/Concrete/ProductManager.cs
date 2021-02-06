using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        
        public ProductManager(IProductDal iProductDal)
        {
            _productDal = iProductDal;
        }

        public IEnumerable<object> GetByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();

        }
    }
}
