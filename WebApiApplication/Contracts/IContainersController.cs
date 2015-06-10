// Template: Controller Interface (ApiControllerInterface.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerControllerContract.Models;

namespace WebApiApplication.ContainerControllerContract
{
    public interface IContainersController
    {

        IHttpActionResult Get([FromUri] decimal? pages = null,[FromUri] string genre = null);

        IHttpActionResult Post(string json,[FromUri] decimal? pages = null);

        IHttpActionResult GetByContainerId([FromUri] string containerId);

        IHttpActionResult Delete([FromUri] string containerId);

    }
}
