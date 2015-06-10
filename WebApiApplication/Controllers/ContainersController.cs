// Template: Controller Implementation (ApiControllerImplementation.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerControllerContract.Models;

namespace WebApiApplication.ContainerControllerContract
{
    public partial class ContainersController : IContainersController
    {

				/// <param name="pages">The number of pages to return</param>
		/// <param name="genre">filter the container by genre</param>
        public IHttpActionResult Get([FromUri] decimal? pages = null,[FromUri] string genre = null)
        {
            // TODO: implement Get - route: containers/
			return Ok();
        }

				/// <param name="json"></param>
		/// <param name="pages">The number of pages to return</param>
        public IHttpActionResult Post(string json,[FromUri] decimal? pages = null)
        {
            // TODO: implement Post - route: containers/
			return Ok();
        }

				/// <param name="containerId"></param>
		/// <returns>ContainerIdGetOKResponseContent</returns>
        public IHttpActionResult GetByContainerId([FromUri] string containerId)
        {
            // TODO: implement GetByContainerId - route: containers/{containerId}
			// var result = new ContainerIdGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// This method will *delete* an **individual container** 
		/// </summary>
		/// <param name="containerId"></param>
        public IHttpActionResult Delete([FromUri] string containerId)
        {
            // TODO: implement Delete - route: containers/{containerId}
			return Ok();
        }

    }
}
