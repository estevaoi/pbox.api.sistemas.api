using System;

namespace pbox.api.sistemas.Domain.Entities
{
    public class Sistema : Base
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraAtualizado { get; set; }
    }
}