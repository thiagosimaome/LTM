using LTM.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTM.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int clienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "minomo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo SobreNome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo idade")]
        public int Idade { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProductViewModel> Produtos { get; set; }
    }
}