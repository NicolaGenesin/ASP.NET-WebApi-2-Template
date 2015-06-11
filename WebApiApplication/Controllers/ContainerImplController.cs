#region

using System.Web.Http;
using WebApiApplication.ContainerImpl.Models;

#endregion

namespace WebApiApplication.ContainerImpl
{
    public partial class ContainerImplController : IContainerImplController
    {

        public IHttpActionResult Get([FromUri] decimal? pages = null, [FromUri] string genre = null)
        {
            return Ok();
        }

        public IHttpActionResult Post(string json, [FromUri] decimal? pages = null)
        {
            return Ok();
        }

        public IHttpActionResult GetByContainerImplId([FromUri] string containerImplId)
        {
            var result = new ContainerImplIdGetOKResponseContent();
            return Ok(result);
        }

        public IHttpActionResult Delete([FromUri] string containerImplId)
        {
            return Ok();
        }

    }
}