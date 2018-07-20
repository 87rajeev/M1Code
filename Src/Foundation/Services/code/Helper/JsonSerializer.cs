using M1CP.Foundation.Services.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace M1CP.Foundation.Services.Helper
{
   
    public class JsonSerializer : ISerializer
    {
        private readonly JsonSerializerSettings _settings;

        public JsonSerializer()
        {
            _settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            _settings.Converters.Add(new StringEnumConverter());
        }

        string ISerializer.Serialize<T>(T value)
        {
            if (value != null && _settings != null)
                return JsonConvert.SerializeObject(value, _settings);
            else
                return string.Empty;
        }

        T ISerializer.Deserialize<T>(string value)
        {
            if (value != null && _settings != null)
                return JsonConvert.DeserializeObject<T>(value, _settings);
            else
                return default(T);
        }
    }
}
