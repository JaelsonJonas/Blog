using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public enum StatusPost
    {
        Rascunho,
        Publicado,
        Arquivado
    }
    [Table("Tb_Posts")]
    public class Post
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        public string? Titulo { get; set; }

        public string? Conteudo { get; set; }

        [Display(Name = "Data de Publicação")]
        [DataType(DataType.Date)]
        public DateTime DataPublicacao { get; set; }

        // Relacionamento com Comentarios (um Post pode ter muitos Comentarios)
        public virtual ICollection<Comentario>? Comentarios { get; set; }

    }
}
