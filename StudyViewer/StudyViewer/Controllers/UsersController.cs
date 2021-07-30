using Microsoft.AspNetCore.Mvc;
using StudyViewer.Models;
using StudyViewer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyViewer.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsersController: ControllerBase
	{
        private IUserService _userService;

        //Использование di
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
