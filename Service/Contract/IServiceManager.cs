namespace Service.Contract
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IAccountService AccountService { get; }
        IMenuService MenuService { get; }
        ITileService TileService { get; }
    }
}
