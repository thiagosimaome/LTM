using System.ComponentModel.DataAnnotations.Schema;

namespace LTM.Domain.Entities
{
    public class Produto
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int clienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
