using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLayer.Application;
using NLayer.Application.Dtos;
using NLayer.Application.Interfaces;

namespace NLayer.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventsService _eventsService;

        public EventsController(IEventsService eventsService)
        {
            _eventsService = eventsService;
        }

        [HttpGet]
        public async Task<List<EventDto>> Get()=>(await _eventsService.GetEvents()).ToList();

        [HttpGet]
        public async Task<EventDto> Get(Guid id) => (await _eventsService.GetEvent(id));


    }
}
