using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using WebEscuelaMVC.Validations;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckNumeroAttribute]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Estado { get; set; }
    }
}
