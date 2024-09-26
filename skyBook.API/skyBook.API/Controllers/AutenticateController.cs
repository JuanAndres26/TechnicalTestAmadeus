using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NLog;
using skyBook.Entiti;
using skyBook.Impl;
using skyBook.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using userManagmentService;

namespace skyBook.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutenticateController : ControllerBase
    {
        private readonly IUserAutenticate userAutenticate;
        private readonly NLog.ILogger logger;
        private readonly string secretKey = "qE3fW2gT8J1oK9pZ7sQ4iV6mC5rH3dA9"; // Cambia esto a una clave segura
        public AutenticateController(IUserAutenticate userAutenticate_, NLog.ILogger logger_)
        {
            userAutenticate = userAutenticate_;
            logger = logger_;
        }

        // POST: api/Autenticate/AutenticaterUser
        [Route("AutenticaterUser")]
        [HttpPost]
        public ActionResult<object> AutenticaterUser([FromBody] RequestAutenticate request)
        {
            try
            {
                this.logger.Info($"start query AutenticaterUser in controller");

                dynamic response = userAutenticate.AutenticateUser(request);
                if (Response != null)
                {
                    this.logger.Info($"succesfull query AutenticaterUser");
                    // Generar el token
                    var token = GenerateJwtToken(response);
                    return Ok(new { token });

                }
                else
                {
                    logger.Info("Failed to authenticate user");
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in  controller AutenticaterUser ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }

        }

        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, user.Username), 
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) 
        
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), 
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
