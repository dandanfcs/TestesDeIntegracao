using System.ComponentModel.DataAnnotations;

namespace TestesDeIntegracao.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}
