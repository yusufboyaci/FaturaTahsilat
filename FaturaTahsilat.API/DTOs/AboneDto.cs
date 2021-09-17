using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.API.DTOs
{
    public class AboneDto
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public ulong TCNo { get; set; }
        public string AboneNo { get; set; }
    }
}
