using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Interfaces.Repository;
using Confitec.TestePratico.Infra.Data.Context;

namespace Confitec.TestePratico.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ConfitecContext dbContext) : base(dbContext)
        {
        }
    }
}
