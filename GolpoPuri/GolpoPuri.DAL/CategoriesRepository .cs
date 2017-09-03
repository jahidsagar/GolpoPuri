using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.DAL
{
    public class CategoriesRepository:Repository<Categories>, ICatesoriesRepository
    {
        public CategoriesRepository(DbContext context):base(context)
        {

        }
    }
}
