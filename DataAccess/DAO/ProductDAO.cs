using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        //Using Singleton Design Pattern
        private static ProductDAO instance = new();
        private static readonly object instanceLock = new();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new ProductDAO();
                }
                return instance;
            }
        }
        public List<Product> GetAll()
        {
            List<Product> listProduct = [];
            try
            {
                using AppDbContext appDbContext = new();
                listProduct = [.. appDbContext.Products];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProduct;
        }

        public Product? GetById(string id)
        {
            try
            {
                using AppDbContext appDbContext = new();
                var productFound = appDbContext.Products.FirstOrDefault(u => u.ProductId.ToString() == id);
                if (productFound != null)
                {
                    return productFound;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Product product)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.Products.Add(product);
                appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product product)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                appDbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Product product)
        {
            try
            {
                using AppDbContext appDbContext = new();

                if(product != null)
                {
                    appDbContext.Products.Remove(product);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
