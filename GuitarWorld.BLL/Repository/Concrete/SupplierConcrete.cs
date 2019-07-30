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
    public class SupplierConcrete
    {
        public IRepository<Supplier> _shipperRepository;
        public IUnitOfWork _shipperUnitOfWork;
        private DbContext _dbContext;

        public SupplierConcrete()
        {
            _dbContext = new Context();
            _shipperUnitOfWork = new EFUnitOfWork(_dbContext);
            _shipperRepository = _shipperUnitOfWork.GetRepository<Supplier>();
        }
    }
}
