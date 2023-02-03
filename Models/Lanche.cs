using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_MVC;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheID { get; set; }

    [Required(ErrorMessage ="O nome do lanche é obrigatório!")]
    [Display(Name ="Nome do lanche")]
    [StringLength(80, MinimumLength = 5, ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string Nome { get; set; }

    [Required(ErrorMessage ="A descrição do lanche deve ser informada")]
    [Display(Name ="Descrição do lanche")]
    [MinLength(10, ErrorMessage ="Descrição deve ter no minimo {1}caracteres")]
    [MaxLength(200, ErrorMessage ="Descrição não pode exceder {1} caracteres")]
    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage ="A descrição do lanche deve ser informada")]
    [Display(Name ="Descrição do lanche")]
    [MinLength(20, ErrorMessage ="Descrição deve ter no minimo {1}caracteres")]
    [MaxLength(200, ErrorMessage ="Descrição não pode exceder {1} caracteres")]
    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage ="Informe o preço do lanche")]
    [Display(Name ="Preço")]
    [Column(TypeName ="decimal(10,2)")]
    [Range(1,999.99, ErrorMessage ="o PREÇO DEVE ESTÁR ENTRE 1 E 999,99")]
    public decimal Preco { get; set; }

    [Display(Name ="Caminho da Imagem")]
    [MaxLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
    public string ImagemUrl { get; set; }

    [Display(Name ="Caminho da Imagem Miniatura")]
    [MaxLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
    public string ImagemThumbnaiUrl { get; set; }

    [Display(Name ="Preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name ="Estoque")]
    public bool EmEstoque { get; set; }

    //Relacionamento entre a classe lanche e a Classe categoria (uma chave estrangeira para o banco)
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
    //Fim do relacionamento entre as classes
}