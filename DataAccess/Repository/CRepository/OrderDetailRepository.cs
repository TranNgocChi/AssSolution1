using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CRepository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Create(OrderDetail orderDetail) => OrderDetailDAO.Instance.Create(orderDetail);
        public void Delete(OrderDetail orderDetail) => OrderDetailDAO.Instance.Delete(orderDetail);

        public List<OrderDetail> GetAll() => OrderDetailDAO.Instance.GetAll();

        public OrderDetail? GetById(string id) => OrderDetailDAO.Instance.GetById(id);

        public void Update(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
