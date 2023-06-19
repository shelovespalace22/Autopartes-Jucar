using JucarAutopartesAplicacionWeb.Models.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using JucarAutopartesAplicacionWeb.Models.Users;

namespace JucarAutopartesAplicacionWeb.Controllers
{
    public class CuentasController : Controller
    {

        //    private readonly UserManager<IdentityUser> _userManager;
        //    private readonly SignInManager<IdentityUser> _signInManager;
        //    private readonly IEmailSender _emailSender;


        //    public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
        //    {
        //        this._signInManager = signInManager;
        //        this._userManager = userManager;
        //        _emailSender = emailSender;


        //    }
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }


        //    // ***** METODO DE REGISTRO *****

        //    [HttpGet]
        //    public async Task<IActionResult> Registro(string returnurl = null)
        //    {
        //        ViewData["ReturnUrl"] = returnurl;
        //        UserRegistrationViewModel registroVM = new UserRegistrationViewModel();
        //        return View(registroVM);
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Registro(UserRegistrationViewModel rgViewModel, string returnurl = null)
        //    {
        //        ViewData["ReturnUrl"] = returnurl;
        //        returnurl = returnurl ?? Url.Content("~/");

        //        if (ModelState.IsValid)
        //        {
        //            // Nueva instancia de un Usuario (Arreglar)
        //            var user = new User
        //            {
        //                //UserName = rgViewModel.Email,
        //                //Email = rgViewModel.Email,
        //                //Nombres = rgViewModel.Nombres,
        //                //Apellidos = rgViewModel.Apellidos,
        //                //Pais = rgViewModel.Pais,
        //                //Ciudad = rgViewModel.Ciudad,
        //                //Direccion = rgViewModel.Direccion,
        //                //FechaNacimiento = rgViewModel.FechaNacimiento,
        //                //Estado = true //rgViewModel.Estado
        //            };

        //            // Creación de un usuario en la base de datos (Arreglar)
        //            var resultado = await _userManager.CreateAsync(usuario, rgViewModel.Password);

        //            if (resultado.Succeeded)
        //            {
        //                // Enviar confirmación de Email (Arreglar)
        //                var code = await _userManager.GenerateEmailConfirmationTokenAsync(usuario);
        //                var urlRetorno = Url.Action("ConfirmarEmail", "Cuentas", new { userId = usuario.Id, code = code }, protocol: HttpContext.Request.Scheme);
        //                await _emailSender.SendEmailAsync(rgViewModel.Email, "Confirmar su cuenta - Proyecto Identity", "Por favor confirme su cuenta dando click aquí: <a href=\"" + urlRetorno + "\">enlace</a>");

        //                // Loguear un usuario (Arreglar)
        //                await _signInManager.SignInAsync(usuario, isPersistent: false);

        //                // Redireccionar a página de inicio
        //                return LocalRedirect(returnurl);
        //            }

        //            // Validation failed
        //            ValidarErrores(resultado);
        //        }

        //        return View(rgViewModel);
        //    }

        //    // ***** MANEJADOR DE ERRORES *****
        //    private void ValidarErrores(IdentityResult resultado)
        //    {
        //        foreach (var error in resultado.Errors)
        //        {
        //            ModelState.AddModelError(String.Empty, error.Description);
        //        }
        //    }


        //    // ***** METODO DE LOGUEAR *****

        //    [HttpGet]
        //    public IActionResult Acceso(string returnurl = null)
        //    {
        //        ViewData["ReturnUrl"] = returnurl;
        //        return View();
        //    }



        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Acceso(LogIn accViewModel, string returnurl = null)
        //    {
        //        ViewData["ReturnUrl"] = returnurl;
        //        returnurl = returnurl ?? Url.Content("~/");
        //        if (ModelState.IsValid)
        //        {
        //            var resultado = await _signInManager.PasswordSignInAsync(accViewModel.Email, accViewModel.Password, accViewModel.RememberMe, lockoutOnFailure: true);

        //            if (resultado.Succeeded)
        //            {
        //                //return RedirectToAction("Index", "Home");
        //                return LocalRedirect(returnurl);
        //            }
        //            if (resultado.IsLockedOut)
        //            {
        //                return View("Bloqueado");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError(string.Empty, "Acceso inválido");
        //                return View(accViewModel);
        //            }
        //        }
        //        return View(accViewModel);
        //    }

        //    // ***** METODO PARA SALIR DE LA APP *****

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> SalirAplicacion()
        //    {
        //        await _signInManager.SignOutAsync();
        //        return View(nameof(HomeController.Index), "Home");
        //    }


        //    // ***** METODO OLVIDARPASSWORD *****

        //    [HttpGet]
        //    public IActionResult OlvidoPassword()
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> OlvidoPassword(ForgotPassword opViewModel)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var usuario = await _userManager.FindByEmailAsync(opViewModel.Email);
        //            if (usuario == null)
        //            {
        //                return RedirectToAction("ConfirmacionOlvidoPassword");
        //            }

        //            var codigo = await _userManager.GeneratePasswordResetTokenAsync(usuario);
        //            var urlRetorno = Url.Action("ResetPassword", "Cuentas", new { userId = usuario.Id, code = codigo }, protocol: HttpContext.Request.Scheme);

        //            await _emailSender.SendEmailAsync(opViewModel.Email, "Recuperar contraseña - Proyecto Identity",
        //                "Por favor recupere su contraseña dando click aquí: <a href=\"" + urlRetorno + "\">enlace</a>");

        //            return RedirectToAction("ConfirmacionOlvidoPassword");
        //        }

        //        return View(opViewModel);
        //    }
    }
}
