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
    public class GuitarBrandConcrete
    {
        public IRepository<GuitarBrand> _guitarBrandRepository;
        public IUnitOfWork _guitarBrandUnitOfWork;
        private DbContext _dbContext;

        public GuitarBrandConcrete()
        {
            _dbContext = new Context();
            _guitarBrandUnitOfWork = new EFUnitOfWork(_dbContext);
            _guitarBrandRepository = _guitarBrandUnitOfWork.GetRepository<GuitarBrand>();
        }
    }
}
