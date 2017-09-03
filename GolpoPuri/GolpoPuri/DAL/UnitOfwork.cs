using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GolpoPuri.DAL
{
    public class UnitOfwork : IDisposable, IUnitOfwork
    {
        private StoryContext context;

        public IStoryRepository StoryRepository { get; private set; }
        public ICommentRepository CommentRepository { get; private set; }
        public IUsersRepository UsersRepository { get; private set; }
        //add reference here and also add its interface
        private bool disposed = false;

        public UnitOfwork(StoryContext context)
        {
            this.context = context;
            this.StoryRepository = new StoryRepository(context);
            this.CommentRepository = new CommentRepository(context);
            this.UsersRepository = new UsersRepository(context);
            
            
        }

        

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}