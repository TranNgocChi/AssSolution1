using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        //Using Singleton Design Pattern
        private static OrderDetailDAO instance = new();
        private static readonly object instanceLock = new();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new OrderDetailDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> GetAll()
        {
            List<OrderDetail> listOrderDetail = [];
            try
            {
                using AppDbContext appDbContext = new();
                listOrderDetail = [.. appDbContext.OrderDetails];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrderDetail;
        }

        public OrderDetail? GetById(string id)
        {
            try
            {
                using AppDbContext appDbContext = new();
                var orderDetailFound = appDbContext.OrderDetails.FirstOrDefault(u => u.OrderDetailId.ToString() == id);
                if (orderDetailFound != null)
                {
                    return orderDetailFound;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(OrderDetail orderDetail)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.OrderDetails.Add(orderDetail);
                appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                appDbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(OrderDetail orderDetail)
        {
            try
            {
                using AppDbContext appDbContext = new();

                if (orderDetail != null)
                {
                    appDbContext.OrderDetails.Remove(orderDetail);
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
