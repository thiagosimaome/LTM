﻿using LTM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTM.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "minomo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0", "999999999999")]
        [Required(ErrorMessage ="Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public int clienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}