using System;
using System.Linq;

namespace FaturaTahsilat.API.DTOs
{
    public class FaturaDto
    {
        public Guid AboneId { get; set; }
        public bool FaturaOdendiMi { get; set; }
        public DateTime FaturaDüzenlenmeTarihi { get; set; }
        public DateTime FaturaSonOdemeTarihi { get; set; }
        public string FaturaDonemi { get; set; }
        public decimal FaturaTutari { get; set; }
    }
}
