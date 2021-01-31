using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_C.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(0,10, ErrorMessage ="Quantidade deve ser um valor entre 0 e 10.")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        public Categoria categoria { get; set; }
       
    }
}
