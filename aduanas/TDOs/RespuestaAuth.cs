namespace aduanas.TDOs
{
    public class RespuestaAuth
    {
        public string token { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
