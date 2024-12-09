﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetList()
        {
            return _context.Products.ToList();
        }
        public Product SearchId(int id) 
        {
            foreach (var product in _context.Products)
            {
                if (product.Id == id)
                    return product;
            }
            return new Product();
        }
        public void AddPro(Product product)
        {
            _context.Products.Add(product);
        }
        public void PutVal(int id, Product product)
        {
            Product item=_context.Products.ToList().Find(x => x.Id == id);
            item = product;
        }
        public void DeleteVal(int id)
        {
            foreach (var product in _context.Products)
            {
                if (product.Id == id)
                { _context.Products.Remove(product); return; }
            }
        }
        public void Update(int id, double price)
        {
            foreach (var product in _context.Products)
            {
                if (product.Id == id)
                {
                    product.Price = price;
                    return;
                }
            }
        }
    }
}
