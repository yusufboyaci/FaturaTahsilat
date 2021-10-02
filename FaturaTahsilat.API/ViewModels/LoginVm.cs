using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FaturaTahsilat.API.ViewModels
{
    public class LoginVm
    {
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
