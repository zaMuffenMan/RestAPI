using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTfulServices.Controllers
{
    public class CityController : ApiController
    {
        List<string> _test = new List<string>(new string[] { "One", "Two", "Three" });
        public IHttpActionResult Get()
        {
            return Ok(_test);
        }
        public IHttpActionResult Get(int id)
        {
            return Ok(_test[id]);
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] apiResponse jsonbody)
        {
            _test.Add(jsonbody.value);

            return Created(Request.RequestUri, _test);
        }
    }
    public class apiResponse
    {
        public string value { get; set; }
    }
}
