using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
    public virtual Endereco Endereco { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }
    
}