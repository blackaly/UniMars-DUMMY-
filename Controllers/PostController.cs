using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using UniMars.Models.DTOs;

namespace UniMars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public  IActionResult CreatePost()
        {

            var user = HttpContext.User.FindFirstValue(claimType: ClaimTypes.Email);

            return Ok(user);
        }
    }
}
