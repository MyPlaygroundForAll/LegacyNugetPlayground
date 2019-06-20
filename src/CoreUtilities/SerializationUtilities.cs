using Newtonsoft.Json;

namespace CoreUtilities
{
    public static class SerializationUtilities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Serialize<TModel>(TModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
