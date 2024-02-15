using Newtonsoft.Json;

namespace MvcCoches.Models
{
    public class Coche
    {
        [JsonProperty(PropertyName = "id")]
        public String Id { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String VelocidadMaxima { get; set; }
        public Motor Motor { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class Motor
    {
        public String Tipo { get; set; }
        public String Caballos { get; set; }
        public String Cilindrada { get; set; }
        public Boolean Turbo { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
