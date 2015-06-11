namespace WebApiApplication.Core
{
    public class ContainerRepository : IContainerRepository
    {

        public object Get(decimal? pages, string genre) 
        {
            return new { Username = "my name", Password = "the password" };
        }

        public object Delete(string containerImplId)
        {
            return true;
        }

        public object Post(string json, decimal? pages)
        {
            return new { Username = "my name", Password = "the password" };
        }
    }
}