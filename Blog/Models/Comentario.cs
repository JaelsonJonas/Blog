using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Tb_Comentarios")]
    public class Comentario
    {
        [Key]
        [Column("ID")]
        public int ComentarioId { get; set; }

        [Required]
        [Display(Name = "Nome do Autor")]
        public string? AutorNome { get; set; }

        public string? Conteudo { get; set; }

        [Display(Name = "Data de Comentário")]
        [DataType(DataType.Date)]
        public DateTime DataComentario { get; set; }

        // Chave estrangeira para relacionamento muitos-para-um com o Post
        [Column("PostID")]
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
