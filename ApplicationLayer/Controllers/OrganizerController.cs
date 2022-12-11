using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    public class OrganizerController : ApiController
    {
        [Route("api/organizer/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserOrganizerDTO user)
        {
            try
            {
                user.UserType = "organizer";
                var data = OrganizerServices.Add(user);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }


        }
    }
}
