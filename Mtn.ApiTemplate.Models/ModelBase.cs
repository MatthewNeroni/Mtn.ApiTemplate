using Newtonsoft.Json;

namespace Mtn.ApiTemplate.Models
{
    public class ModelBase
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}