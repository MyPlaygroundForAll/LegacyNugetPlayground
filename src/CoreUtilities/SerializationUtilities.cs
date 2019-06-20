using Newtonsoft.Json;

namespace CoreUtilities
{
    public static class SerializationUtilities
    {
        /// <summary>
        /// test
        /// </summary>
        /// <typeparam name="TModel">asdgf</typeparam>
        /// <param name="model">ADSAD</param>
        /// <returns></returns>
        public static string Serialize<TModel>(TModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
