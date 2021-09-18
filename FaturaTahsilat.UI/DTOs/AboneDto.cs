using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.UI.DTOs
{
    public class AboneDto
    {
        public Guid ID { get; set; }
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public ulong TCNo { get; set; }
        public string AboneNo { get; set; }
    }
}
