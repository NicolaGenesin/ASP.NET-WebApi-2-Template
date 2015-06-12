#region

using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
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
            return Ok(new ContainerImplIdGetOKResponseContent()); // ContainerImplIdGetOKResponseContent is an "api citizen model"
        }

        public IHttpActionResult Delete([FromUri] string containerImplId)
        {
            try
            {
                _containerRepository.Delete(containerImplId);
                return Ok();
            }
            catch (Exception)
            {
                return new ResponseMessageResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, new Exception()));
            }
        }
    }
}