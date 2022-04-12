using BEL;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation_WebAPI.Controllers
{
    public class sellerController : ApiController
    {
        [HttpPost]
        [Route("api/seller/delete/{id}")]
        public HttpResponseMessage DeleteSeller(int id)
        {
            var isreq = sellerService.DeleteSeller(id);
            if (isreq) { return Request.CreateResponse(HttpStatusCode.OK, "Seller deleted!"); }
            return Request.CreateResponse(HttpStatusCode.OK, " failed!");
        }
        [HttpPost]
        [Route("api/seller/edit")]
        public HttpResponseMessage EditSeller(sellerModel obj)
        {
            var isreq = sellerService.EditSeller(obj);
            if (isreq) { return Request.CreateResponse(HttpStatusCode.OK, "Data updated!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "Update failed!");
        }
    }
}
