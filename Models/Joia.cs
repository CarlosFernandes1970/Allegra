using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allegra.Models
{
    [Table("Joias")]
    public class Joia
    {
        
        
        [Key]
        public int JoiaId { get; set; }

        [Required(ErrorMessage = "O Nome da Jóia deve ser informado!")]
        [Display(Name = "Nome da Jóia")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} de ter no mínimo {1} e no máximo {2} carcteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Descrição Curta da Jóia deve ser informada!")]
        [Display(Name = "Descrição Curta da Jóia")]
        [MinLength(5, ErrorMessage = "O campo Descrição Curta da Jóia deve ter no mínimo {1} caracteres!")]
        [MaxLength(100, ErrorMessage = "O campo Descrição Curta da Jóia deve ter no máximo {1} caracteres!")]
        public string DescricaoCurta { get; set;}

        [Required(ErrorMessage = "A Descrição Detalhada da Jóia deve ser informada!")]
        [Display(Name = "Descrição Detalhada da Jóia")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "O {0} de ter no mínimo {1} e no máximo {2} carcteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço da Jóia deve ser informado!")]
        [Display(Name = "Preço da Jóia")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999999999.99, ErrorMessage = "O preço da Jóia deve ter no máximo {1} e no máximo {2} Reais")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho do arquivo da imagem da Jóia")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} de ter no mínimo {1} e no máximo {2} carcteres")]
        public string ImgURL { get; set; }

        [Display(Name = "Caminho do arquivo miniatura da imagem da Jóia")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} de ter no mínimo {1} e no máximo {2} carcteres")]
        public string? ImgThumnail { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsPreferido { get; set; }
        [Display(Name = "Em estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }


}
