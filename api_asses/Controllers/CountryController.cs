using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using api_asses.Models;

namespace WebApiAss_1.Controllers
{
    public class CountryController : ApiController
    {
        static List<cars> Countrylist = new List<cars>()  
        {
            new cars{id = 1,carsname = "ford"},
              new cars{id = 2,carsname = "Morris Garriage"},
                new cars{id = 3,carsname = "USA"},

        };



        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Countrylist);
            return response;
        }
        
        public IHttpActionResult Post([FromBody] Country c) 
        {
            Countrylist.Add(c);
            return Ok(Countrylist);
        }

        public IHttpActionResult Put(int id, [FromBody] Country c) 
        {
            var Countryval = Countrylist.Find(a => a.id == id);
            if (Countryval != null)
            {
                Countrylist[id - 1] = c;
                return Ok(Countrylist);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Delete(int id)
        {
            var Countryval = Countrylist.Find(a => a.id == id);
            if (Countryval != null)
            {
                Countrylist.RemoveAt(id - 1);
                return Ok(Countrylist);

            }
            else
            {
                return NotFound();
            }

        }
    }
}
