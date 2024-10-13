using Domain.Menu;
using MongoDB.Driver;
using Persistence.RepositoryContract;

namespace Persistence.RepositoryImplementation
{
    public class MenuRepository : IMenuRepository
    {
        private readonly IMongoCollection<Menu> _menuCollection;

        public MenuRepository(IMongoCollection<Menu> menuCollection)
        {
            _menuCollection = menuCollection.Database.GetCollection<Menu>("menu"); ;
        }


    }
}
