using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModelcs
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Digite o estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Digite a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage ="Digite o sexo")]
        public string Sexo { get; set; }
    }
}
