using WebApplication.Model;

namespace WebApiApplication.Core
{
    public interface IContainerRepository
    {
        RepositoryObject Get(decimal? pages, string genre);
        void Delete(string containerImplId);
        RepositoryObject Post(string json, decimal? pages);
    }
}