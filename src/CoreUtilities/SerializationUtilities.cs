using Newtonsoft.Json;

namespace CoreUtilities
{
    public static class SerializationUtilities
    {
        public static string Serialize<TModel>(TModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
