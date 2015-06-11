// Template: Controller Interface (ApiControllerInterface.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerImpl.Models;

namespace WebApiApplication.ContainerImpl
{
    public interface IContainerImplController
    {

        IHttpActionResult Get([FromUri] decimal? pages = null,[FromUri] string genre = null);

        IHttpActionResult Post(string json,[FromUri] decimal? pages = null);

        IHttpActionResult GetByContainerImplId([FromUri] string containerImplId);

        IHttpActionResult Delete([FromUri] string containerImplId);

    }
}
