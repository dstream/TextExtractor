using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TikaOnDotNet.TextExtraction;

namespace TextExtractorService.Controllers
{    
    public class ValuesController : ApiController
    {
        // GET api/values
        public TextExtractionResult Get()
        {
            return new TextExtractor().Extract(HttpContext.Current.Server.MapPath("/Storage/sample.rtf"));  
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
