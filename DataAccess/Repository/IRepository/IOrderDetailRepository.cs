using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> GetAll();
        public OrderDetail? GetById(string id);
        public void Create(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(OrderDetail orderDetail);
    }
}
