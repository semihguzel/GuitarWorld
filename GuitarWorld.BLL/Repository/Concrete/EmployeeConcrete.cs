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
    public class EmployeeConcrete
    {
        public IRepository<Employee> _employeeRepository;
        public IUnitOfWork _employeeUnitOfWork;
        private DbContext _dbContext;

        public EmployeeConcrete()
        {
            _dbContext = new Context();
            _employeeUnitOfWork = new EFUnitOfWork(_dbContext);
            _employeeRepository = _employeeUnitOfWork.GetRepository<Employee>();
        }
    }
}
