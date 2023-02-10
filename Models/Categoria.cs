using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_MVC.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    [StringLength(100, ErrorMessage="O tamanho máximo é de 100 caracteres")]
    [Required(ErrorMessage="Informe o nome da categoria")]
    [Display(Name ="Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage="O tamanho máximo é de 200 caracteres")]
    [Required(ErrorMessage="Informe o descrição da categoria")]
    [Display(Name ="Descrição")]
    public string Descricao { get; set; }

//Relacionamento de um para muitos de Categoria para Lanche
    public List<Lanche> Lanches { get; set; }
}

