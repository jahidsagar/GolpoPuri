using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.DAL
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(DbContext context):base(context)
        {

        }
    }
}
