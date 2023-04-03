using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorHoomau.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Column("Valor")]
        [Display(Name ="Valor")]
        public decimal Valor { get; set; }

        [Column("Qtd")]
        [Display(Name ="Quantidade")]
        public int Qtd { get; set; }
    }
}
