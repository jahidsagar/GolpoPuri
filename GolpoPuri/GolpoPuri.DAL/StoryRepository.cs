using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.DAL
{
    public class StoryRepository:Repository<Story>, IStoryRepository
    {
        public StoryRepository(DbContext context):base(context)
        {

        }
    }
}
