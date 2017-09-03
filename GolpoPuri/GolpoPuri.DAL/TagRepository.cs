using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.DAL
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context):base(context)
        {

        }
    }
}
