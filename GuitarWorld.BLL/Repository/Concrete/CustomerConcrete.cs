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
    public class CustomerConcrete
    {
        public IRepository<Customer> _customerRepository;
        public IUnitOfWork _customerUnitOfWork;
        private DbContext _dbContext;

        public CustomerConcrete()
        {
            _dbContext = new Context();
            _customerUnitOfWork = new EFUnitOfWork(_dbContext);
            _customerRepository = _customerUnitOfWork.GetRepository<Customer>();
        }
    }
}
