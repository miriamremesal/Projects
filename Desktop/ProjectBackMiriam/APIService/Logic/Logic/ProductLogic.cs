﻿using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
           
            return productItem.Id;
        }

        public List<ProductItem> GetAllProductsItem()
        {
            return _serviceContext.Set<ProductItem>().ToList();
        }

        public void ModifyProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Remove(productItem);
            _serviceContext.SaveChanges();
        }

    }
}
