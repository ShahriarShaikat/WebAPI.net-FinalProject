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
    public class authController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(userModel obj) 
        {
            var isUser = authService.UserLogin(obj);
            if (isUser) { return Request.CreateResponse(HttpStatusCode.OK, "Valid user!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "Invalid user!");
        }

        [HttpPost]
        [Route("api/reg/seller")]
        public HttpResponseMessage SignUpSeller(UserSellerModel obj)
        {
            var isUser = authService.SignUpAsSeller(obj);
            if (isUser) { return Request.CreateResponse(HttpStatusCode.OK, "Seller account created!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "Registration failed!");
        }

        [HttpPost]
        [Route("api/reg/buyer")]
        public HttpResponseMessage SignUpBuyer(UserBuyerModel obj)
        {
            var isUser = authService.SignUpAsBuyer(obj);
            if (isUser) { return Request.CreateResponse(HttpStatusCode.OK, "Buyer account created!"); }
            return Request.CreateResponse(HttpStatusCode.OK, "Registration failed!");
        }

    }
}
