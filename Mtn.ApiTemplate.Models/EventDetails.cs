using Mtn.ApiTemplate.Models.Enums;

namespace Mtn.ApiTemplate.Models
{
    public class EventDetails : ModelBase
    {
        public EventDetailType? Type { get; set; }
        public string Message { get; set; }
    }
}