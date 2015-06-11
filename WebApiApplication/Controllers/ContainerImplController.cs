#region

using System.Web.Http;
using WebApiApplication.ContainerImpl.Models;
using WebApiApplication.Core;

#endregion

namespace WebApiApplication.ContainerImpl
{
    public partial class ContainerImplController : IContainerImplController
    {
        private readonly IContainerRepository _containerRepository;

        public ContainerImplController(IContainerRepository containerRepository)
        {
            _containerRepository = containerRepository; 
        }

        public IHttpActionResult Get([FromUri] decimal? pages = null, [FromUri] string genre = null)
        {
            return Ok(_containerRepository.Get(pages,genre));
        }

        public IHttpActionResult Post(string json, [FromUri] decimal? pages = null)
        {
            return Ok(_containerRepository.Post(json, pages));
        }

        public IHttpActionResult GetByContainerImplId([FromUri] string containerImplId)
        {
            var result = new ContainerImplIdGetOKResponseContent();
            return Ok(result);
        }

        public IHttpActionResult Delete([FromUri] string containerImplId)
        {
            return Ok(_containerRepository.Delete(containerImplId));
        }

    }
}