using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.API.DTOs
{
    public class TahsilatDto
    {
        public Guid ID { get; set; }
        public decimal TahhutTutari { get; set; }
    }
}
