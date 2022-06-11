using FaturaTahsilat.API.ViewModels;
using FaturaTahsilat.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        UserManager<Kullanici> _userManager;
        SignInManager<Kullanici> _signInManager;
        public AuthController(UserManager<Kullanici> userManager, SignInManager<Kullanici> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
       
        [HttpPost("authenticate")]
       public  async Task<IActionResult> Login(string returnUrl,[FromBody] LoginVm loginVm)
        {
            Kullanici kullanici = await _userManager.FindByNameAsync(loginVm.KullaniciAdi);
            if (kullanici !=null)
            {
                var result = await _signInManager.PasswordSignInAsync(kullanici, loginVm.Sifre, true, true);
                if (result.Succeeded)
                {
                    //return Redirect(returnUrl != null ? returnUrl : Url.Action("Index", "Home"));
                    return Redirect(returnUrl != null ? returnUrl : Url.Action("https://localhost:44304/"));
                }
                else
                {
                    ModelState.AddModelError("Parola Hatalı", "Girdiğiniz kullanıcı adı veya parola hatalı, lütfen tekrar deneyiniz.");
                    //return BadRequest(new { message = "Girdiğiniz kullanıcı adı veya parola hatalı, lütfen tekrar deneyiniz." });
                }

            }
            else
            {
                ModelState.AddModelError("Kullanici Bulunamadı", "Girdiğiniz kullanıcı adı veya parola hatalı, lütfen tekrar deneyiniz");
                //return BadRequest(new { message = "Girdiğiniz kullanıcı adı veya parola hatalı, lütfen tekrar deneyiniz." });
            }
            return Ok();
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserVm createUserVm)
        {
            Kullanici kullanici = createUserVm;
            IdentityResult result = await _userManager.CreateAsync(kullanici, createUserVm.Sifre);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                ModelState.AddModelError("Kullanıcı Kayıt Edilemedi", "Girdiğiniz bilgilerle kullanıcı kayıt edilemedi, lütfen tekrar deneyiniz");
            }
            return Ok();
        }
     
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();

        }
    }
}
