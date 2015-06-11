#region

using Newtonsoft.Json;

#endregion

namespace WebApiApplication.ContainerImpl.Models
{
    public class ContainerImplIdGetOKResponseContent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    } // end class

} // end Models namespace