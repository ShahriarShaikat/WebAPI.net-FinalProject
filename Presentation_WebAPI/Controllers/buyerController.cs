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
    public class buyerController : ApiController
    {

        [HttpGet]
        [Route("api/buyer/all")]
        public HttpResponseMessage BuyerAll()
        {
            var listBuyer = buyerService.AllBuyer();
            return Request.CreateResponse(HttpStatusCode.OK, listBuyer);
        }

        [HttpPost]
        [Route("api/buyer/delete/{id}")]
        public HttpResponseMessage BuyerDelete(int id)
        {
            var isreq = buyerService.DeleteBuyer(id);
            if (isreq) { return Request.CreateResponse(HttpStatusCode.OK, "Buyer account deleted!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "failed to delete!");
        }

        [HttpPost]
        [Route("api/buyer/edit")]
        public HttpResponseMessage BuyerEdit(UserBuyerModel obj)
        {
            var isreq = buyerService.EditBuyer(obj);
            if (isreq) { return Request.CreateResponse(HttpStatusCode.OK, "Data Updated!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "failed to update data!");
        }
    }
}
