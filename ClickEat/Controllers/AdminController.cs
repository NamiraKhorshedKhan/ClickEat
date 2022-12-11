using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ClickEat.Controllers
{
    //[RoutePrefix("api/category")]
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        [Route("api/admin/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admin/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admin/{id}/tokens")]
        [HttpGet]
        public HttpResponseMessage GetCtBook(int id)
        {
            try
            {
                var data = AdminService.GetTokens(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admin/add")]
        [HttpPost]
        public HttpResponseMessage Add(AdminDTO ct)
        {
            try
            {
                var data = AdminService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}