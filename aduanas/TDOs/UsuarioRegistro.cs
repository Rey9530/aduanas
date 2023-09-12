using System.ComponentModel.DataAnnotations;

namespace aduanas.TDOs
{
    public class UsuarioRegistro
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string usuario { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
