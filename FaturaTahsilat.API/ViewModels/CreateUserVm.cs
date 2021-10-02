using FaturaTahsilat.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FaturaTahsilat.API.ViewModels
{
    public class CreateUserVm
    {
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name ="Şifre")]
        public string Sifre { get; set; }
        [Display(Name = "Mail Adresi")]
        public string Mail { get; set; }
        public static implicit operator Kullanici(CreateUserVm createUserVm)
        {
            return new Kullanici
            {
                Email = createUserVm.Mail,
                UserName = createUserVm.KullaniciAdi
            };
        }
    }
}
