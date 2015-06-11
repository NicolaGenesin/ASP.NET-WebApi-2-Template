// Template: Controller Implementation (ApiControllerImplementation.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerImpl.Models;

namespace WebApiApplication.ContainerImpl
{
    public class ContainerImplController : IContainerImplController
    {

        /// <param name="pages">The number of pages to return</param>
        /// <param name="genre">filter the container by genre</param>
        public IHttpActionResult Get([FromUri] decimal? pages = null, [FromUri] string genre = null)
        {
            // TODO: implement Get - route: containerImpl/
            return Ok();
        }

        /// <param name="json"></param>
        /// <param name="pages">The number of pages to return</param>
        public IHttpActionResult Post(string json, [FromUri] decimal? pages = null)
        {
            // TODO: implement Post - route: containerImpl/
            return Ok();
        }

        /// <param name="containerImplId"></param>
        /// <returns>ContainerImplIdGetOKResponseContent</returns>
        public IHttpActionResult GetByContainerImplId([FromUri] string containerImplId)
        {
            // TODO: implement GetByContainerImplId - route: containerImpl/{Id}
            // var result = new ContainerImplIdGetOKResponseContent();
            // return Ok(result);
            return Ok();
        }

        /// <summary>
        /// This method will *delete* an **individual container** 
        /// </summary>
        /// <param name="containerImplId"></param>
        public IHttpActionResult Delete([FromUri] string containerImplId)
        {
            // TODO: implement Delete - route: containerImpl/{Id}
            return Ok();
        }

    }
}
