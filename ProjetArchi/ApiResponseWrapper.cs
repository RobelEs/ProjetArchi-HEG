using Newtonsoft.Json; // Nécessaire pour [JsonProperty]

namespace ProjetArchi
{

    public class ApiResponseWrapper<T>
    {
        [JsonProperty("data")] // Mappe la clé JSON "data" à cette propriété
        public T Data { get; set; }

    }
}