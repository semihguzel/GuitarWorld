using GuitarWorld.DAL;
using GuitarWorld.DATA;
using RepositoryPattern.BLL.Repository.Abstract;
using RepositoryPattern.BLL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.BLL.Repository.Concrete
{
    public class OrderConcrete
    {
        public IRepository<Order> _orderRepository;
        public IUnitOfWork _orderUnitOfWork;
        private DbContext _dbContext;

        public OrderConcrete()
        {
            _dbContext = new Context();
            _orderUnitOfWork = new EFUnitOfWork(_dbContext);
            _orderRepository = _orderUnitOfWork.GetRepository<Order>();
        }
    }
}
