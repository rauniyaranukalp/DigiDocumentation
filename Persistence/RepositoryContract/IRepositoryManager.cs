namespace Persistence.RepositoryContract
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        IAccountRepository AccountRepository { get; }
        IMenuRepository MenuRepository { get; }
        ITileRepository TileRepository { get; }
    }
}
