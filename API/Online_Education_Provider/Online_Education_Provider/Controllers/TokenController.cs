using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Online_Education_Provider.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Online_Education_Provider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        public readonly OnlineEducationProviderContext _context;
        public TokenController(IConfiguration config, OnlineEducationProviderContext ctx)
        {
            _configuration = config;
            _context = ctx;
        }

        //Login 
        [HttpPost]
       // [Route("Login")]
        public async Task<IActionResult> Post(UserRegistration _userData)
        {
            if (_userData != null && _userData.MailId != null && _userData.Password != null)
            {
                var user = await GetUser(_userData.MailId, _userData.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                         new Claim("UserId", user.UserId.ToString()),
                         new Claim("MailID", user.MailId),
                        new Claim("Password",user.Password)

                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

       /* //Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(UserRegistration _userData)
        {
            var userExists = await _context.UserRegistrations.FindAsync(_userData.UserName);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, "User Already exists");
            else
            {
                await _context.UserRegistrations.AddAsync(_userData);
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status500InternalServerError, "Account created successfully");
            }
    
           // return Ok();
        }
       */

        private async Task<UserRegistration> GetUser(string email, string password)
        {
            return await _context.UserRegistrations.FirstOrDefaultAsync(u => u.MailId == email && u.Password == password);
        }
    }
}
