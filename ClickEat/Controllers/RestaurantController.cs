using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using BLL.Services;
using BLL.DTOs;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClickEat.Controllers
{
    public class RestaurantController : ApiController
    {
        [Route("api/Restaurant")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RestaurantService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Restaurant/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = RestaurantService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Restaurant/add")]
        [HttpPost]
        public HttpResponseMessage Add(RestaurantDTO Restaurant)
        {
            if (ModelState.IsValid)
            {
                var data = RestaurantService.Add(Restaurant);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

        }


    }
}
