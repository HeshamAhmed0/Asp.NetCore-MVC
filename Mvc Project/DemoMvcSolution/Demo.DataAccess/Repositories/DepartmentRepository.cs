using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Data.DbContexts;

namespace Demo.DataAccess.Repositories
{
    public class DepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DepartmentRepository(ApplicationDbContext dbContext)
        {
            // Ask From Clr To Create Object From ApplicationDbContext ويتعمله inject  in _dbcontext
            this._dbContext = dbContext;
        }


        public Department? GetById(int Id)
        {
            var department = _dbContext.Departments.Find(Id);
            return department;
        }
    }
}
