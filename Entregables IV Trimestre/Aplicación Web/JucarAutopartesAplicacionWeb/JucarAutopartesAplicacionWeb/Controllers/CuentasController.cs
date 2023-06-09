﻿using JucarAutopartesAplicacionWeb.Data;
using JucarAutopartesAplicacionWeb.Models.Users;
using JucarAutopartesAplicacionWeb.Models.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JucarAutopartesAplicacionWeb.Controllers
{
	public class CuentasController : Controller
	{
		//Inyecciones de dependencia

		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;
		private readonly ApplicationDbContext _context;

		public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_context = context;

		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Registro(string returnurl = null)
		{
			ViewData["ReturnUrl"] = returnurl;
			RegisterViewModel registerViewModel = new RegisterViewModel();
			return View(registerViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Registro(RegisterViewModel registerViewModel, string returnurl = null)
		{
			ViewData["ReturnUrl"] = returnurl;
			returnurl = returnurl ?? Url.Content("~/");
			if (ModelState.IsValid)
			{
				var newUser = new User
				{
					UserName = registerViewModel.Email,
					Email = registerViewModel.Email,
					FirstName = registerViewModel.FirstName,
					SecondName = registerViewModel.SecondName,
					FirstSurname = registerViewModel.FirstSurname,
					SecondSurname = registerViewModel.SecondSurname,
					DocumentType = registerViewModel.DocumentType,
					DocumentNumber = registerViewModel.DocumentNumber,
					Sex = registerViewModel.Sex,
					BirthDate = registerViewModel.BirthDate,
					BirthCity = registerViewModel.BirthCity,
					CityResidence = registerViewModel.CityResidence,
					State = true,
					CreationDate = DateTime.Now,
					ModificationDate = DateTime.Now
				};

				//var userID = newUser.Id;

				var newUserPhone = new UserPhone
				{
					//UserID = userID,
					PhoneType = registerViewModel.PhoneType,
					PhoneNumber = registerViewModel.PhoneNumber,
					CreationDate = DateTime.Now,
					ModificationDate = DateTime.Now
				};

				_context.Add(newUserPhone);
				await _context.SaveChangesAsync();

				var resultado = await _userManager.CreateAsync(newUser, registerViewModel.Password);

				if (resultado.Succeeded)
				{
					await _signInManager.SignInAsync(newUser, isPersistent: false);

					return LocalRedirect(returnurl);
				}
				ValidarErrores(resultado);
			}

			return View(registerViewModel);
		}

		[HttpGet]
		public IActionResult Acceso(string returnurl = null)
		{
			ViewData["ReturnUrl"] = returnurl;
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Acceso(AccesoViewModel accesoViewModel, string returnurl = null)
		{
			ViewData["ReturnUrl"] = returnurl;
			returnurl = returnurl ?? Url.Content("~/");
			if (ModelState.IsValid)
			{
				var resultado = await _signInManager.PasswordSignInAsync(accesoViewModel.Email, accesoViewModel.Password, accesoViewModel.RememberMe, lockoutOnFailure: true);

				if (resultado.Succeeded)
				{
					return LocalRedirect(returnurl);
				}

				else if (resultado.IsLockedOut)
				{
					return View("Bloqueado");
				}

				else
				{
					ModelState.AddModelError(string.Empty, "Acceso inválido.");
					return View(accesoViewModel);
				}
			}
			return View(accesoViewModel);
		}

		/* METODO DE LOGOUT */

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SalirAplicacion()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(HomeController.Index), "Home");
		}

		/* METODO DE OLVIDO PASSWORD */

		[HttpGet]
		public IActionResult OlvidoPassword()
		{
			return View();
		}

		/* MANEJADOR DE ERRORES */

		private void ValidarErrores(IdentityResult result)
		{
			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(String.Empty, error.Description);
			}
		}
	}
}
