using System;
using System.Collections.Generic;
using System.Linq;

namespace FaturaTahsilat.API.DTOs
{
    public class FaturaWithTahsilatDto : FaturaDto
    {
        public IEnumerable<TahsilatDto> Tahsilatlar { get; set; }
    }
}
