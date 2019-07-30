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
    public class GuitarModelConcrete
    {
        public IRepository<GuitarModel> _guitarModelRepository;
        public IUnitOfWork _guitarModelUnitOfWork;
        private DbContext _dbContext;

        public GuitarModelConcrete()
        {
            _dbContext = new Context();
            _guitarModelUnitOfWork = new EFUnitOfWork(_dbContext);
            _guitarModelRepository = _guitarModelUnitOfWork.GetRepository<GuitarModel>();
        }
    }
}
