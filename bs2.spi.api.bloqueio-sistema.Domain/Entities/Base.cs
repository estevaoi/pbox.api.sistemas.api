using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pbox.api.sistemas.Domain.Entities
{
    public class Base
    {
        [Key]
        public Guid SistemaId { get; set; }

        public int Status { get; set; }
        public string Motivo { get; set; }
        public string Usuario { get; set; }
        public DateTime DataHoraCriacao { get; set; }
    }
}