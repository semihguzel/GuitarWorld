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
    public class OrderDetailConcrete
    {
        public IRepository<OrderDetail> _orderDetailRepository;
        public IUnitOfWork _orderDetailUnitOfWork;
        private DbContext _dbContext;

        public OrderDetailConcrete()
        {
            _dbContext = new Context();
            _orderDetailUnitOfWork = new EFUnitOfWork(_dbContext);
            _orderDetailRepository = _orderDetailUnitOfWork.GetRepository<OrderDetail>();
        }
    }
}
