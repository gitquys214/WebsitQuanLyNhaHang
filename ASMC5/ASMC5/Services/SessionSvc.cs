using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ASMC5.Services
{
    public static class SessionSvc
    {
        public static void SetobjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetobjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
