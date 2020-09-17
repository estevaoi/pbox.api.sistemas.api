using System;
using System.ComponentModel.DataAnnotations;

namespace pbox.api.sistemas.Application.Dto
{
    public class SistemaDto
    {
        [Key]
        public Guid SistemaId { get; set; }

        [Required]
        public string Codigo { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime DataHoraAtualizado { get; set; }
    }
}