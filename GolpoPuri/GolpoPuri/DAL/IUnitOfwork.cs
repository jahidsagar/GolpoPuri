namespace GolpoPuri.DAL
{
    public interface IUnitOfwork
    {
        ICommentRepository CommentRepository { get; }
        IStoryRepository StoryRepository { get; }
        IUsersRepository UsersRepository { get; }
        ICatesoriesRepository CategoryRepository { get; }


        void Dispose();
        void Dispose(bool disposing);
        void Save();
    }
}