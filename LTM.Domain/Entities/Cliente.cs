using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTM.Domain.Entities
{
    public class Cliente
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clienteId { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}
    