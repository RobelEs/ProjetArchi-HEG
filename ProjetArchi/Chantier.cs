using Newtonsoft.Json; 
namespace ProjetArchi
{
    public class ChantierModel
    {
        // Mappe la propriété JSON 'id' à la propriété C# 'Id'
        [JsonProperty("id")]
        public int Id { get; set; }

        // Mappe la propriété JSON 'name' à la propriété C# 'Name'
        [JsonProperty("name")]
        public string Name { get; set; }

        // Mappe la propriété JSON 'address' à la propriété C# 'Address'
        [JsonProperty("address")]
        public string Address { get; set; }

        // Mappe la propriété JSON 'start_date' à la propriété C# 'StartDate'
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        // Mappe la propriété JSON 'end_date' à la propriété C# 'EndDate'
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        // Mappe la propriété JSON 'client_id' à la propriété C# 'ClientId'
        [JsonProperty("client_id")]
        public int ClientId { get; set; }

    }
}