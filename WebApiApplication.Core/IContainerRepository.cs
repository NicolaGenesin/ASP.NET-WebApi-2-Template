using System.Security.Cryptography.X509Certificates;

namespace WebApiApplication.Core
{
    public interface IContainerRepository
    {
        object Get(decimal? pages, string genre);
        object Delete(string containerImplId);
        object Post(string json, decimal? pages); 
    }
}