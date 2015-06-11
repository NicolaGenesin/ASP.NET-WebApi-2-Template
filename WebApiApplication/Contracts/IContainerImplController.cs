#region

using System.Web.Http;

#endregion

namespace WebApiApplication.ContainerImpl
{
    public interface IContainerImplController
    {
        IHttpActionResult Get([FromUri] decimal? pages = null, [FromUri] string genre = null);
        IHttpActionResult Post(string json, [FromUri] decimal? pages = null);
        IHttpActionResult GetByContainerImplId([FromUri] string containerImplId);
        IHttpActionResult Delete([FromUri] string containerImplId);
    }
}