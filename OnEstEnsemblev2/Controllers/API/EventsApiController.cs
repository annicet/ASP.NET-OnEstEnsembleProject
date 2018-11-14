using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using OnEstEnsemble.Core.Data.Cross.Services.Logging;
using OnEstEnsemble.Core.Business.Services;
using System.Net.Http;
using System.Net;

namespace OnEstEnsemble.web.Controllers.API
{
    [RoutePrefix("api/Events")]
    public class EventsApiController : ApiController
    {
        ILogWrapper _logger;
        IEventService _eventService;

        public EventsApiController (ILogWrapper logger,IEventService eventService)
        {
            _logger = logger;
            _eventService = eventService;
        }

        [HttpPost]
        [Route("list")]
        public Task<HttpResponseMessage> GetEventsList ()
        {
            HttpResponseMessage reply;

            try
            {
                var list = _eventService.GetList();
                reply = Request.CreateResponse(HttpStatusCode.OK, new { data = list });
            }
            catch (Exception ex)
            {
                reply = this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
                _logger.Error(ex.Message, ex);

            }

            return Task.FromResult(reply);

        }

    }
}
