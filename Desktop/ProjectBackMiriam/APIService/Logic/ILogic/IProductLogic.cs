using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        List<ProductItem> GetAllProductsItem();
        public int InsertProductItem(ProductItem productItem);
        public void ModifyProductItem(ProductItem productItem);
        public void DeleteProductItem(ProductItem productItem);
    }
}