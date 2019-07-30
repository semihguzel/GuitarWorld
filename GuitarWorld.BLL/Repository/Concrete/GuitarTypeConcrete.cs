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
    public class GuitarTypeConcrete
    {
        public IRepository<GuitarType> _guitarTypeRepository;
        public IUnitOfWork _guitarTypeUnitOfWork;
        private DbContext _dbContext;

        public GuitarTypeConcrete()
        {
            _dbContext = new Context();
            _guitarTypeUnitOfWork = new EFUnitOfWork(_dbContext);
            _guitarTypeRepository = _guitarTypeUnitOfWork.GetRepository<GuitarType>();
        }
    }
}
