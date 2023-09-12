namespace aduanas.TDOs
{
    public class RespuestaHttp<EntidadAsignada>
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public EntidadAsignada data { get; set; }
    }
}
