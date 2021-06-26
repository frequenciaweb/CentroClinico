using System.ComponentModel.DataAnnotations;

namespace CentroClinico.Apresentacao.MVC.Models
{
    public class MVLogin
    {
        [Required(ErrorMessage = "Por favor preencha o nome")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor preencha a senha")]
        [MaxLength(10, ErrorMessage = "A senha deve conter o máximo de 10 caracteres")]
        [MinLength(6, ErrorMessage = "A senha deve conter o minimo de 6 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
