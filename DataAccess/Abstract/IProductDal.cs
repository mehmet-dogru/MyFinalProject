using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        ////default olarak public olur.
        //List<Product> GetAll();
        //void Add(Product product); 
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetAllByCategory(int categoryId);

        List<ProductDetailDto> GetProductDetails();
    }
}
