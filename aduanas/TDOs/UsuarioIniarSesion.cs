using System.ComponentModel.DataAnnotations;

namespace aduanas.TDOs
{
    public class UsuarioIniarSesion
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
