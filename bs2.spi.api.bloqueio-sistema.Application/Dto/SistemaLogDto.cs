using System;

namespace pbox.api.sistemas.Application.Dto
{
    public class SistemaLogDto
    {
        public Guid SistemaId { get; set; }
        public int Status { get; set; }
        public string Motivo { get; set; }
        public string Usuario { get; set; }
        public DateTime DataHoraCriacao { get; set; }
    }
}