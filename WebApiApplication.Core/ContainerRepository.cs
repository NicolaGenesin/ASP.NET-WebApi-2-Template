#region

using System;
using WebApplication.Model;

#endregion

namespace WebApiApplication.Core
{
    public class ContainerRepository : IContainerRepository
    {

        public RepositoryObject Get(decimal? pages, string genre)
        {
            // search on page by genre
            return new RepositoryObject {Genre = "Dramatic"};
        }

        public void Delete(string containerImplId)
        {
            try
            {
                // delete
            }
            catch (Exception)
            {
                // manage
            }
        }

        public RepositoryObject Post(string json, decimal? pages)
        {
            //create your resource
            return new RepositoryObject { Genre = "Dramatic", Author = "Paul Bailey", Name = "Less french words" };
        }
    }

}