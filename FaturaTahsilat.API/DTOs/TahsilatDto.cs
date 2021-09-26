using System;
using System.Linq;

namespace FaturaTahsilat.API.DTOs
{
    public class TahsilatDto
    {
        public Guid ID { get; set; }
        public decimal TahhutTutari { get; set; }
    }
}
