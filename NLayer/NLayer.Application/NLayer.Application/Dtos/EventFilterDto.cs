using System;

namespace NLayer.Application.Dtos
{
    public class EventFilterDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public EventFilterDto()
        {
            
        }
    }
}