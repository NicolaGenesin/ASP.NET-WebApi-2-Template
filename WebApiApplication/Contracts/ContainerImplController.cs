#region

using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerImpl.Models;

#endregion

// Do not modify this file. This code was generated by RAML Web Api 2 Scaffolder

namespace WebApiApplication.ContainerImpl
{
    [RoutePrefix("containerImpl")]
    public partial class ContainerImplController : ApiController
    {


        /// <param name="pages">The number of pages to return</param>
        /// <param name="genre">filter the container by genre</param>
        [HttpGet]
        [Route("")]
        public virtual IHttpActionResult GetBase([FromUri] decimal? pages = null, [FromUri] string genre = null)
        {
            // Do not modify this code
            return ((IContainerImplController) this).Get(pages, genre);
        }

        /// <param name="json"></param>
        /// <param name="pages">The number of pages to return</param>
        [HttpPost]
        [Route("")]
        public virtual IHttpActionResult PostBase(string json, [FromUri] decimal? pages = null)
        {
            // Do not modify this code
            return ((IContainerImplController) this).Post(json, pages);
        }

        /// <param name="containerImplId"></param>
        /// <returns>ContainerImplIdGetOKResponseContent</returns>
        [ResponseType(typeof (ContainerImplIdGetOKResponseContent))]
        [HttpGet]
        [Route("{Id}")]
        public virtual IHttpActionResult GetByContainerImplIdBase([FromUri] string containerImplId)
        {
            // Do not modify this code
            return ((IContainerImplController) this).GetByContainerImplId(containerImplId);
        }

        /// <summary>
        ///     This method will *delete* an **individual container**
        /// </summary>
        /// <param name="containerImplId"></param>
        [HttpDelete]
        [Route("{Id}")]
        public virtual IHttpActionResult DeleteBase([FromUri] string containerImplId)
        {
            // Do not modify this code
            return ((IContainerImplController) this).Delete(containerImplId);
        }
    }
}