using Newtonsoft.Json;

namespace CoreUtilities
{
    public static class SerializationUtilities
    {
        /// <summary>
        /// test 1-2-3
        /// </summary>
        /// <typeparam name="TModel">asg</typeparam>
        /// <param name="model">ADSAD</param>
        /// <returns></returns>
        public static string Serialize<TModel>(TModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
