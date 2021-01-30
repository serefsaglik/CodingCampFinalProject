using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Enities.Concrete;
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

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();

        }
    }
}
