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
    public class GuitarConcrete
    {
        public IRepository<Guitar> _guitarRepository;
        public IUnitOfWork _guitarUnitOfWork;
        private DbContext _dbContext;

        public GuitarConcrete()
        {
            _dbContext = new Context();
            _guitarUnitOfWork = new EFUnitOfWork(_dbContext);
            _guitarRepository = _guitarUnitOfWork.GetRepository<Guitar>();
        }
    }
}
