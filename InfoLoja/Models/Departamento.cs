using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfoLoja.Models
{
    public class Departamento
    {
        [Display(Name = "Código do departamento")]
        public long DepartamentoId { get; set; }

        [Display(Name = "Nome do departamento")]
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}