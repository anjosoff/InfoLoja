using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfoLoja.Models
{
    public class Produto
    {
        [Display(Name = "Código do produto")]
        public long? ProdutoId { get; set; }
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }
        [Display(Name = "Código do Fabricante")]
        public long? DepartamentoId { get; set; }

            public Departamento Departamento { get; set; }
          


    }
}