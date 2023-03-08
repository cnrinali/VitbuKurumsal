using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using VitbuWebUIPartnerPanel.Models;

namespace VitbuWebUIPartnerPanel.Controllers
{
    [AllowAnonymous]
    public class AuthorizationController : Controller
    {
        IUserService _userService;
        ILogService _logService;
        ICompanyService _companyService;

        public AuthorizationController(IUserService userService, ILogService logService, ICompanyService companyService)
        {
            _userService = userService;
            _logService = logService;
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Login(loginVM.UserName, loginVM.Password);
                var companyPartner = _companyService.GetList(x => x.Id == user.CompanyId);
                if (user != null && companyPartner[0].CompanyType == "Partner")
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Surname, user.Surname),
                    };

                    var userIdentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    Log log = new Log()
                    {
                        Tarih = DateTime.Now.ToString(),
                        Text = loginVM.UserName + " Login işlemi gerçekleştirdi.",
                        Title = "Sign In Log",
                        Description = "Login Oldu.",
                    };
                    _logService.Create(log);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginVM);
        }

        public async Task<IActionResult> Signout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
